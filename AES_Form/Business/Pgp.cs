using Org.BouncyCastle.Bcpg;
using Org.BouncyCastle.Bcpg.OpenPgp;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace CryptDecrypt.Business
{
    /// <summary>
    /// Classe per la gestione della crittografia PGP (Pretty Good Privacy)
    /// Utilizza BouncyCastle per le operazioni di cifratura e decifratura
    /// </summary>
    class Pgp
    {
        #region PGP Key Generation

        /// <summary>
        /// Genera una nuova coppia di chiavi PGP (pubblica e privata)
        /// </summary>
        /// <param name="identity">Identità dell'utente (es. "Nome <email@example.com>")</param>
        /// <param name="password">Password per proteggere la chiave privata</param>
        /// <param name="publicKey">Output: chiave pubblica in formato ASCII armor</param>
        /// <param name="privateKey">Output: chiave privata in formato ASCII armor</param>
        public static void GenerateKeyPair(string identity, string password, out string publicKey, out string privateKey)
        {
            // Genera una coppia di chiavi RSA 2048-bit
            IAsymmetricCipherKeyPairGenerator keyPairGenerator = GeneratorUtilities.GetKeyPairGenerator("RSA");
            keyPairGenerator.Init(new RsaKeyGenerationParameters(BigInteger.ValueOf(0x10001), new SecureRandom(), 2048, 12));
            AsymmetricCipherKeyPair keyPair = keyPairGenerator.GenerateKeyPair();

            // Crea l'anello delle chiavi segrete (private key ring)
            using (MemoryStream privateOut = new MemoryStream())
            {
                PgpSecretKey secretKey = new PgpSecretKey(
                    PgpSignature.DefaultCertification,
                    PublicKeyAlgorithmTag.RsaGeneral,
                    keyPair.Public,
                    keyPair.Private,
                    DateTime.UtcNow,
                    identity,
                    SymmetricKeyAlgorithmTag.Aes256,
                    password.ToCharArray(),
                    null,
                    null,
                    new SecureRandom()
                );

                secretKey.Encode(privateOut);
                privateKey = Convert.ToBase64String(privateOut.ToArray());
            }

            // Estrae la chiave pubblica
            using (MemoryStream publicOut = new MemoryStream())
            {
                PgpSecretKey secretKey = new PgpSecretKey(
                    PgpSignature.DefaultCertification,
                    PublicKeyAlgorithmTag.RsaGeneral,
                    keyPair.Public,
                    keyPair.Private,
                    DateTime.UtcNow,
                    identity,
                    SymmetricKeyAlgorithmTag.Aes256,
                    password.ToCharArray(),
                    null,
                    null,
                    new SecureRandom()
                );

                PgpPublicKey pubKey = secretKey.PublicKey;
                pubKey.Encode(publicOut);
                publicKey = Convert.ToBase64String(publicOut.ToArray());
            }
        }

        #endregion

        #region PGP Encryption

        /// <summary>
        /// Cifra un testo in chiaro usando una chiave pubblica PGP
        /// </summary>
        /// <param name="plainText">Testo da cifrare</param>
        /// <param name="publicKeyString">Chiave pubblica PGP in formato Base64</param>
        /// <returns>Testo cifrato in formato Base64</returns>
        public static string EncryptText(string plainText, string publicKeyString)
        {
            try
            {
                byte[] publicKeyBytes = Convert.FromBase64String(publicKeyString);

                using (MemoryStream publicKeyStream = new MemoryStream(publicKeyBytes))
                using (MemoryStream encryptedOut = new MemoryStream())
                {
                    // Legge la chiave pubblica
                    PgpPublicKey publicKey = ReadPublicKey(publicKeyStream);

                    // Crea lo stream di output per i dati cifrati
                    using (MemoryStream bOut = new MemoryStream())
                    {
                        // Comprime i dati prima della cifratura
                        PgpCompressedDataGenerator comData = new PgpCompressedDataGenerator(CompressionAlgorithmTag.Zip);
                        using (Stream comOut = comData.Open(bOut))
                        {
                            PgpLiteralDataGenerator lData = new PgpLiteralDataGenerator();
                            byte[] bytes = Encoding.UTF8.GetBytes(plainText);

                            using (Stream ldOut = lData.Open(comOut, PgpLiteralData.Binary, PgpLiteralData.Console, bytes.Length, DateTime.UtcNow))
                            {
                                ldOut.Write(bytes, 0, bytes.Length);
                            }
                        }
                        comData.Close();

                        byte[] dataToEncrypt = bOut.ToArray();

                        // Cifra i dati compressi
                        PgpEncryptedDataGenerator encGen = new PgpEncryptedDataGenerator(
                            SymmetricKeyAlgorithmTag.Aes256,
                            true,
                            new SecureRandom()
                        );
                        encGen.AddMethod(publicKey);

                        using (Stream cOut = encGen.Open(encryptedOut, dataToEncrypt.Length))
                        {
                            cOut.Write(dataToEncrypt, 0, dataToEncrypt.Length);
                        }
                    }

                    return Convert.ToBase64String(encryptedOut.ToArray());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante la cifratura PGP: " + ex.Message, ex);
            }
        }

        /// <summary>
        /// Legge una chiave pubblica PGP da uno stream
        /// </summary>
        private static PgpPublicKey ReadPublicKey(Stream inputStream)
        {
            inputStream = PgpUtilities.GetDecoderStream(inputStream);
            PgpPublicKeyRingBundle pgpPub = new PgpPublicKeyRingBundle(inputStream);

            // Cerca la prima chiave adatta per la cifratura
            foreach (PgpPublicKeyRing keyRing in pgpPub.GetKeyRings())
            {
                foreach (PgpPublicKey key in keyRing.GetPublicKeys())
                {
                    if (key.IsEncryptionKey)
                    {
                        return key;
                    }
                }
            }

            throw new ArgumentException("Nessuna chiave di cifratura trovata nella chiave pubblica fornita.");
        }

        #endregion

        #region PGP Decryption

        /// <summary>
        /// Decifra un testo cifrato PGP usando una chiave privata
        /// </summary>
        /// <param name="encryptedText">Testo cifrato in formato Base64</param>
        /// <param name="privateKeyString">Chiave privata PGP in formato Base64</param>
        /// <param name="password">Password per sbloccare la chiave privata</param>
        /// <returns>Testo in chiaro decrittografato</returns>
        public static string DecryptText(string encryptedText, string privateKeyString, string password)
        {
            try
            {
                byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
                byte[] privateKeyBytes = Convert.FromBase64String(privateKeyString);

                using (Stream inputStream = new MemoryStream(encryptedBytes))
                using (Stream keyStream = new MemoryStream(privateKeyBytes))
                {
                    inputStream.Position = 0;
                    keyStream.Position = 0;

                    // Decodifica lo stream cifrato
                    PgpObjectFactory pgpFactory = new PgpObjectFactory(PgpUtilities.GetDecoderStream(inputStream));
                    PgpEncryptedDataList encryptedDataList;

                    PgpObject pgpObject = pgpFactory.NextPgpObject();

                    // Il primo oggetto potrebbe essere un marcatore PGP
                    if (pgpObject is PgpEncryptedDataList)
                    {
                        encryptedDataList = (PgpEncryptedDataList)pgpObject;
                    }
                    else
                    {
                        encryptedDataList = (PgpEncryptedDataList)pgpFactory.NextPgpObject();
                    }

                    // Trova la chiave privata corrispondente
                    PgpPrivateKey privateKey = null;
                    PgpPublicKeyEncryptedData encryptedData = null;

                    foreach (PgpPublicKeyEncryptedData pked in encryptedDataList.GetEncryptedDataObjects())
                    {
                        privateKey = FindSecretKey(keyStream, pked.KeyId, password.ToCharArray());

                        if (privateKey != null)
                        {
                            encryptedData = pked;
                            break;
                        }
                    }

                    if (privateKey == null)
                    {
                        throw new ArgumentException("Chiave privata corrispondente non trovata o password errata.");
                    }

                    // Decifra i dati
                    using (Stream clearStream = encryptedData.GetDataStream(privateKey))
                    {
                        PgpObjectFactory plainFactory = new PgpObjectFactory(clearStream);
                        PgpObject message = plainFactory.NextPgpObject();

                        // Gestisce i dati compressi
                        if (message is PgpCompressedData)
                        {
                            PgpCompressedData compressedData = (PgpCompressedData)message;
                            using (Stream compressedStream = compressedData.GetDataStream())
                            {
                                PgpObjectFactory compressedFactory = new PgpObjectFactory(compressedStream);
                                message = compressedFactory.NextPgpObject();
                            }
                        }

                        // Estrae il testo in chiaro
                        if (message is PgpLiteralData)
                        {
                            PgpLiteralData literalData = (PgpLiteralData)message;
                            using (Stream literalStream = literalData.GetInputStream())
                            using (StreamReader reader = new StreamReader(literalStream, Encoding.UTF8))
                            {
                                return reader.ReadToEnd();
                            }
                        }
                        else if (message is PgpOnePassSignatureList)
                        {
                            throw new PgpException("Il messaggio è firmato, ma questa implementazione non gestisce le firme.");
                        }
                        else
                        {
                            throw new PgpException("Il messaggio non è un semplice dato cifrato.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Errore durante la decifratura PGP: " + ex.Message, ex);
            }
        }

        /// <summary>
        /// Trova e sblocca una chiave privata dall'anello delle chiavi segrete
        /// </summary>
        private static PgpPrivateKey FindSecretKey(Stream keyStream, long keyId, char[] password)
        {
            keyStream.Position = 0;
            PgpSecretKeyRingBundle secretKeyRingBundle = new PgpSecretKeyRingBundle(PgpUtilities.GetDecoderStream(keyStream));
            PgpSecretKey secretKey = secretKeyRingBundle.GetSecretKey(keyId);

            if (secretKey == null)
            {
                return null;
            }

            return secretKey.ExtractPrivateKey(password);
        }

        #endregion
    }
}
