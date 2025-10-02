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
        #region Helper Methods

        /// <summary>
        /// Converte una chiave (ASCII armor o Base64) in uno stream utilizzabile da BouncyCastle
        /// </summary>
        /// <param name="keyString">Chiave in formato ASCII armor o Base64</param>
        /// <returns>Stream della chiave decodificato</returns>
        private static Stream GetKeyStream(string keyString)
        {
            if (string.IsNullOrWhiteSpace(keyString))
                throw new ArgumentNullException(nameof(keyString), "La chiave non può essere vuota.");

            // Se la chiave è in formato ASCII armor (contiene header PGP)
            if (keyString.Contains("-----BEGIN PGP"))
            {
                // BouncyCastle può decodificare direttamente ASCII armor
                byte[] keyBytes = Encoding.UTF8.GetBytes(keyString);
                return new MemoryStream(keyBytes);
            }
            else
            {
                // Altrimenti assume che sia Base64 puro
                string cleanBase64 = keyString.Replace("\r", "").Replace("\n", "").Replace(" ", "");
                byte[] keyBytes = Convert.FromBase64String(cleanBase64);
                return new MemoryStream(keyBytes);
            }
        }

        #endregion

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
                using (Stream publicKeyStream = GetKeyStream(publicKeyString))
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

                using (Stream inputStream = new MemoryStream(encryptedBytes))
                using (Stream keyStream = GetKeyStream(privateKeyString))
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

        #region PGP File Encryption

        /// <summary>
        /// Cifra un file usando una chiave pubblica PGP
        /// </summary>
        /// <param name="inputFilePath">Percorso del file da cifrare</param>
        /// <param name="outputFilePath">Percorso dove salvare il file cifrato</param>
        /// <param name="publicKeyString">Chiave pubblica PGP in formato Base64</param>
        /// <param name="progress">Action opzionale per segnalare il progresso (percentuale 0-100)</param>
        public static void EncryptFile(string inputFilePath, string outputFilePath, string publicKeyString, Action<int> progress = null)
        {
            // Validazione dei parametri
            if (string.IsNullOrWhiteSpace(inputFilePath))
                throw new ArgumentNullException(nameof(inputFilePath), "Il percorso del file di input non può essere vuoto.");

            if (string.IsNullOrWhiteSpace(outputFilePath))
                throw new ArgumentNullException(nameof(outputFilePath), "Il percorso del file di output non può essere vuoto.");

            if (string.IsNullOrWhiteSpace(publicKeyString))
                throw new ArgumentNullException(nameof(publicKeyString), "La chiave pubblica non può essere vuota.");

            if (!File.Exists(inputFilePath))
                throw new FileNotFoundException("Il file da cifrare non esiste.", inputFilePath);

            try
            {
                FileInfo fileInfo = new FileInfo(inputFilePath);
                long fileSize = fileInfo.Length;
                long bytesProcessed = 0;

                using (Stream publicKeyStream = GetKeyStream(publicKeyString))
                using (FileStream outputStream = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
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

                            // Usa il nome del file originale e la data di modifica
                            using (Stream ldOut = lData.Open(comOut, PgpLiteralData.Binary, fileInfo.Name, fileInfo.Length, fileInfo.LastWriteTime))
                            using (FileStream inputStream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
                            {
                                // Legge e scrive in blocchi per gestire file grandi in modo efficiente
                                byte[] buffer = new byte[65536]; // Buffer di 64KB
                                int bytesRead;

                                while ((bytesRead = inputStream.Read(buffer, 0, buffer.Length)) > 0)
                                {
                                    ldOut.Write(buffer, 0, bytesRead);
                                    bytesProcessed += bytesRead;

                                    // Segnala il progresso (se fornito)
                                    if (progress != null && fileSize > 0)
                                    {
                                        int progressPercent = (int)((bytesProcessed * 100) / fileSize);
                                        progress(progressPercent);
                                    }
                                }
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

                        using (Stream cOut = encGen.Open(outputStream, dataToEncrypt.Length))
                        {
                            cOut.Write(dataToEncrypt, 0, dataToEncrypt.Length);
                        }
                    }
                }

                // Segnala completamento (100%)
                progress?.Invoke(100);
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new UnauthorizedAccessException("Accesso negato al file. Verifica i permessi.", ex);
            }
            catch (IOException ex)
            {
                throw new IOException("Errore di I/O durante la cifratura del file: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                // Rimuove il file di output parziale in caso di errore
                if (File.Exists(outputFilePath))
                {
                    try { File.Delete(outputFilePath); } catch { /* Ignora errori durante la pulizia */ }
                }

                throw new Exception("Errore durante la cifratura del file PGP: " + ex.Message, ex);
            }
        }

        #endregion

        #region PGP File Decryption

        /// <summary>
        /// Decifra un file cifrato PGP usando una chiave privata
        /// </summary>
        /// <param name="inputFilePath">Percorso del file cifrato</param>
        /// <param name="outputFilePath">Percorso dove salvare il file decifrato</param>
        /// <param name="privateKeyString">Chiave privata PGP in formato Base64</param>
        /// <param name="password">Password per sbloccare la chiave privata</param>
        /// <param name="progress">Action opzionale per segnalare il progresso (percentuale 0-100)</param>
        /// <returns>Nome del file originale estratto dai metadati PGP</returns>
        public static string DecryptFile(string inputFilePath, string outputFilePath, string privateKeyString, string password, Action<int> progress = null)
        {
            // Validazione dei parametri
            if (string.IsNullOrWhiteSpace(inputFilePath))
                throw new ArgumentNullException(nameof(inputFilePath), "Il percorso del file di input non può essere vuoto.");

            if (string.IsNullOrWhiteSpace(outputFilePath))
                throw new ArgumentNullException(nameof(outputFilePath), "Il percorso del file di output non può essere vuoto.");

            if (string.IsNullOrWhiteSpace(privateKeyString))
                throw new ArgumentNullException(nameof(privateKeyString), "La chiave privata non può essere vuota.");

            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentNullException(nameof(password), "La password non può essere vuota.");

            if (!File.Exists(inputFilePath))
                throw new FileNotFoundException("Il file cifrato non esiste.", inputFilePath);

            string originalFileName = null;

            try
            {
                FileInfo fileInfo = new FileInfo(inputFilePath);
                long fileSize = fileInfo.Length;

                progress?.Invoke(10); // Inizio decifratura

                using (FileStream inputStream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
                using (Stream keyStream = GetKeyStream(privateKeyString))
                {
                    // Decodifica lo stream cifrato
                    PgpObjectFactory pgpFactory = new PgpObjectFactory(PgpUtilities.GetDecoderStream(inputStream));
                    PgpEncryptedDataList encryptedDataList;

                    progress?.Invoke(20); // Stream decodificato

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

                    progress?.Invoke(30); // Dati cifrati trovati

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

                    progress?.Invoke(50); // Chiave privata trovata

                    // Decifra i dati
                    using (Stream clearStream = encryptedData.GetDataStream(privateKey))
                    {
                        PgpObjectFactory plainFactory = new PgpObjectFactory(clearStream);
                        PgpObject message = plainFactory.NextPgpObject();

                        progress?.Invoke(60); // Decifratura in corso

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

                        progress?.Invoke(70); // Decompressione completata

                        // Estrae il file
                        if (message is PgpLiteralData)
                        {
                            PgpLiteralData literalData = (PgpLiteralData)message;
                            originalFileName = literalData.FileName;

                            using (Stream literalStream = literalData.GetInputStream())
                            using (FileStream outputStream = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
                            {
                                // Copia i dati in blocchi per gestire file grandi in modo efficiente
                                byte[] buffer = new byte[65536]; // Buffer di 64KB
                                int bytesRead;
                                long bytesProcessed = 0;

                                while ((bytesRead = literalStream.Read(buffer, 0, buffer.Length)) > 0)
                                {
                                    outputStream.Write(buffer, 0, bytesRead);
                                    bytesProcessed += bytesRead;

                                    // Segnala il progresso (70-100%)
                                    if (progress != null)
                                    {
                                        int progressPercent = 70 + (int)((bytesProcessed * 30) / Math.Max(fileSize, 1));
                                        progress(Math.Min(progressPercent, 99));
                                    }
                                }
                            }

                            progress?.Invoke(100); // Completato
                        }
                        else if (message is PgpOnePassSignatureList)
                        {
                            throw new PgpException("Il file è firmato, ma questa implementazione non gestisce le firme.");
                        }
                        else
                        {
                            throw new PgpException("Il file non è un semplice dato cifrato.");
                        }
                    }
                }

                return originalFileName ?? Path.GetFileName(inputFilePath);
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new UnauthorizedAccessException("Accesso negato al file. Verifica i permessi.", ex);
            }
            catch (IOException ex)
            {
                throw new IOException("Errore di I/O durante la decifratura del file: " + ex.Message, ex);
            }
            catch (Exception ex)
            {
                // Rimuove il file di output parziale in caso di errore
                if (File.Exists(outputFilePath))
                {
                    try { File.Delete(outputFilePath); } catch { /* Ignora errori durante la pulizia */ }
                }

                throw new Exception("Errore durante la decifratura del file PGP: " + ex.Message, ex);
            }
        }

        #endregion
    }
}
