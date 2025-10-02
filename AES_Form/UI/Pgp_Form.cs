using CryptDecrypt.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptDecrypt.UI
{
    public partial class Pgp_Form : Form
    {
        #region CONSTRUCTOR
        public Pgp_Form()
        {
            InitializeComponent();
        }
        #endregion

        #region EVENT HANDLERS

        /// <summary>
        /// Gestisce il click sul pulsante per generare una nuova coppia di chiavi PGP
        /// </summary>
        private void btn_GenerateKeys_Click(object sender, EventArgs e)
        {
            try
            {
                // Valida i campi di input
                if (string.IsNullOrWhiteSpace(txt_KeyGenIdentity.Text))
                {
                    MessageBox.Show("Inserisci un'identità valida (es. 'Nome <email@example.com>')",
                        "Campo mancante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_KeyGenPassword.Text))
                {
                    MessageBox.Show("Inserisci una password per proteggere la chiave privata",
                        "Campo mancante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Mostra messaggio di attesa (la generazione delle chiavi può richiedere tempo)
                this.Cursor = Cursors.WaitCursor;
                Application.DoEvents();

                string publicKey, privateKey;

                // Genera le chiavi
                Pgp.GenerateKeyPair(txt_KeyGenIdentity.Text, txt_KeyGenPassword.Text,
                    out publicKey, out privateKey);

                // Mostra le chiavi generate
                txt_GeneratedPublicKey.Text = publicKey;
                txt_GeneratedPrivateKey.Text = privateKey;

                this.Cursor = Cursors.Default;

                MessageBox.Show("Chiavi PGP generate con successo!\n\n" +
                    "IMPORTANTE: Salva la chiave privata in un luogo sicuro.\n" +
                    "Non condividere mai la chiave privata con altri.",
                    "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("Errore durante la generazione delle chiavi: " + ex.Message,
                    "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gestisce il click sul pulsante di cifratura PGP
        /// </summary>
        private void btn_CryptPgp_Click(object sender, EventArgs e)
        {
            try
            {
                // Valida i campi di input
                if (string.IsNullOrWhiteSpace(txt_InsertCryptText.Text))
                {
                    MessageBox.Show("Inserisci il testo da cifrare",
                        "Campo mancante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_InsertCryptPublicKey.Text))
                {
                    MessageBox.Show("Inserisci la chiave pubblica PGP",
                        "Campo mancante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Mostra cursore di attesa
                this.Cursor = Cursors.WaitCursor;
                Application.DoEvents();

                // Cifra il testo
                string encryptedText = Pgp.EncryptText(
                    txt_InsertCryptText.Text,
                    txt_InsertCryptPublicKey.Text
                );

                // Mostra il risultato
                txt_ResultCrypt.Text = encryptedText;

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("Errore durante la cifratura: " + ex.Message,
                    "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gestisce il click sul pulsante di decifratura PGP
        /// </summary>
        private void btn_DeCryptPgp_Click(object sender, EventArgs e)
        {
            try
            {
                // Valida i campi di input
                if (string.IsNullOrWhiteSpace(txt_InsertDeCryptText.Text))
                {
                    MessageBox.Show("Inserisci il testo cifrato da decifrare",
                        "Campo mancante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_InsertDeCryptPrivateKey.Text))
                {
                    MessageBox.Show("Inserisci la chiave privata PGP",
                        "Campo mancante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_InsertDeCryptPassword.Text))
                {
                    MessageBox.Show("Inserisci la password della chiave privata",
                        "Campo mancante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Mostra cursore di attesa
                this.Cursor = Cursors.WaitCursor;
                Application.DoEvents();

                // Decifra il testo
                string decryptedText = Pgp.DecryptText(
                    txt_InsertDeCryptText.Text,
                    txt_InsertDeCryptPrivateKey.Text,
                    txt_InsertDeCryptPassword.Text
                );

                // Mostra il risultato
                txt_ResultDeCrypt.Text = decryptedText;

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("Errore durante la decifratura: " + ex.Message +
                    "\n\nVerifica che la chiave privata e la password siano corrette.",
                    "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gestisce il click sul pulsante Menu per chiudere il form
        /// </summary>
        private void btn_Menu_Click(object sender, EventArgs e)
        {
            Pgp_Form.ActiveForm.Close();
        }

        #endregion

        #region FILE ENCRYPTION/DECRYPTION EVENT HANDLERS

        /// <summary>
        /// Gestisce il click sul pulsante per selezionare il file da cifrare
        /// </summary>
        private void btn_BrowseFileEncrypt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Seleziona il file da cifrare";
                openFileDialog.Filter = "Tutti i file (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txt_FileEncryptInput.Text = openFileDialog.FileName;

                    // Suggerisce automaticamente il file di output con estensione .pgp
                    if (string.IsNullOrWhiteSpace(txt_FileEncryptOutput.Text))
                    {
                        txt_FileEncryptOutput.Text = openFileDialog.FileName + ".pgp";
                    }
                }
            }
        }

        /// <summary>
        /// Gestisce il click sul pulsante per selezionare la destinazione del file cifrato
        /// </summary>
        private void btn_BrowseFileEncryptOutput_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Seleziona dove salvare il file cifrato";
                saveFileDialog.Filter = "File PGP (*.pgp)|*.pgp|Tutti i file (*.*)|*.*";
                saveFileDialog.DefaultExt = "pgp";

                // Se c'è un file di input, usa il suo nome come base
                if (!string.IsNullOrWhiteSpace(txt_FileEncryptInput.Text))
                {
                    string inputFileName = Path.GetFileName(txt_FileEncryptInput.Text);
                    saveFileDialog.FileName = inputFileName + ".pgp";
                }

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txt_FileEncryptOutput.Text = saveFileDialog.FileName;
                }
            }
        }

        /// <summary>
        /// Gestisce il click sul pulsante per cifrare un file
        /// </summary>
        private async void btn_EncryptFile_Click(object sender, EventArgs e)
        {
            try
            {
                // Valida i campi di input
                if (string.IsNullOrWhiteSpace(txt_FileEncryptInput.Text))
                {
                    MessageBox.Show("Seleziona il file da cifrare",
                        "Campo mancante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_FileEncryptOutput.Text))
                {
                    MessageBox.Show("Seleziona la destinazione del file cifrato",
                        "Campo mancante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_FileEncryptPublicKey.Text))
                {
                    MessageBox.Show("Inserisci la chiave pubblica PGP",
                        "Campo mancante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!File.Exists(txt_FileEncryptInput.Text))
                {
                    MessageBox.Show("Il file selezionato non esiste",
                        "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ottiene informazioni sul file
                FileInfo fileInfo = new FileInfo(txt_FileEncryptInput.Text);
                long fileSizeKB = fileInfo.Length / 1024;

                // Disabilita i controlli durante la cifratura
                btn_EncryptFile.Enabled = false;
                btn_BrowseFileEncrypt.Enabled = false;
                btn_BrowseFileEncryptOutput.Enabled = false;
                progressBarFileEncrypt.Value = 0;
                lbl_FileEncryptStatus.Text = $"Cifratura in corso... (File: {fileInfo.Name}, Dimensione: {fileSizeKB} KB)";
                Application.DoEvents();

                // Esegue la cifratura in un task asincrono per non bloccare la UI
                await Task.Run(() =>
                {
                    Pgp.EncryptFile(
                        txt_FileEncryptInput.Text,
                        txt_FileEncryptOutput.Text,
                        txt_FileEncryptPublicKey.Text,
                        (progress) =>
                        {
                            // Aggiorna la progress bar (invoca sul thread UI)
                            if (progressBarFileEncrypt.InvokeRequired)
                            {
                                progressBarFileEncrypt.Invoke(new Action(() =>
                                {
                                    progressBarFileEncrypt.Value = progress;
                                    lbl_FileEncryptStatus.Text = $"Cifratura in corso... {progress}%";
                                }));
                            }
                        }
                    );
                });

                // Ripristina i controlli
                btn_EncryptFile.Enabled = true;
                btn_BrowseFileEncrypt.Enabled = true;
                btn_BrowseFileEncryptOutput.Enabled = true;
                lbl_FileEncryptStatus.Text = "Cifratura completata con successo!";
                lbl_FileEncryptStatus.ForeColor = Color.Green;

                MessageBox.Show($"File cifrato con successo!\n\nFile originale: {txt_FileEncryptInput.Text}\nFile cifrato: {txt_FileEncryptOutput.Text}",
                    "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Ripristina i controlli
                btn_EncryptFile.Enabled = true;
                btn_BrowseFileEncrypt.Enabled = true;
                btn_BrowseFileEncryptOutput.Enabled = true;
                progressBarFileEncrypt.Value = 0;
                lbl_FileEncryptStatus.Text = "Errore durante la cifratura";
                lbl_FileEncryptStatus.ForeColor = Color.Red;

                MessageBox.Show("Errore durante la cifratura del file: " + ex.Message,
                    "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gestisce il click sul pulsante per selezionare il file cifrato da decifrare
        /// </summary>
        private void btn_BrowseFileDecrypt_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Seleziona il file cifrato da decifrare";
                openFileDialog.Filter = "File PGP (*.pgp)|*.pgp|Tutti i file (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txt_FileDecryptInput.Text = openFileDialog.FileName;

                    // Suggerisce automaticamente il file di output rimuovendo l'estensione .pgp
                    if (string.IsNullOrWhiteSpace(txt_FileDecryptOutput.Text))
                    {
                        string outputPath = openFileDialog.FileName;
                        if (outputPath.EndsWith(".pgp", StringComparison.OrdinalIgnoreCase))
                        {
                            outputPath = outputPath.Substring(0, outputPath.Length - 4);
                        }
                        else
                        {
                            outputPath += ".decrypted";
                        }
                        txt_FileDecryptOutput.Text = outputPath;
                    }
                }
            }
        }

        /// <summary>
        /// Gestisce il click sul pulsante per selezionare la destinazione del file decifrato
        /// </summary>
        private void btn_BrowseFileDecryptOutput_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Seleziona dove salvare il file decifrato";
                saveFileDialog.Filter = "Tutti i file (*.*)|*.*";

                // Se c'è un file di input con estensione .pgp, suggerisce il nome originale
                if (!string.IsNullOrWhiteSpace(txt_FileDecryptInput.Text))
                {
                    string inputFileName = Path.GetFileName(txt_FileDecryptInput.Text);
                    if (inputFileName.EndsWith(".pgp", StringComparison.OrdinalIgnoreCase))
                    {
                        inputFileName = inputFileName.Substring(0, inputFileName.Length - 4);
                    }
                    saveFileDialog.FileName = inputFileName;
                }

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txt_FileDecryptOutput.Text = saveFileDialog.FileName;
                }
            }
        }

        /// <summary>
        /// Gestisce il click sul pulsante per decifrare un file
        /// </summary>
        private async void btn_DecryptFile_Click(object sender, EventArgs e)
        {
            try
            {
                // Valida i campi di input
                if (string.IsNullOrWhiteSpace(txt_FileDecryptInput.Text))
                {
                    MessageBox.Show("Seleziona il file cifrato da decifrare",
                        "Campo mancante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_FileDecryptOutput.Text))
                {
                    MessageBox.Show("Seleziona la destinazione del file decifrato",
                        "Campo mancante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_FileDecryptPrivateKey.Text))
                {
                    MessageBox.Show("Inserisci la chiave privata PGP",
                        "Campo mancante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_FileDecryptPassword.Text))
                {
                    MessageBox.Show("Inserisci la password della chiave privata",
                        "Campo mancante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!File.Exists(txt_FileDecryptInput.Text))
                {
                    MessageBox.Show("Il file selezionato non esiste",
                        "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ottiene informazioni sul file
                FileInfo fileInfo = new FileInfo(txt_FileDecryptInput.Text);
                long fileSizeKB = fileInfo.Length / 1024;

                // Disabilita i controlli durante la decifratura
                btn_DecryptFile.Enabled = false;
                btn_BrowseFileDecrypt.Enabled = false;
                btn_BrowseFileDecryptOutput.Enabled = false;
                progressBarFileDecrypt.Value = 0;
                label24.Text = $"Decifratura in corso... (File: {fileInfo.Name}, Dimensione: {fileSizeKB} KB)";
                Application.DoEvents();

                string originalFileName = null;

                // Esegue la decifratura in un task asincrono per non bloccare la UI
                await Task.Run(() =>
                {
                    originalFileName = Pgp.DecryptFile(
                        txt_FileDecryptInput.Text,
                        txt_FileDecryptOutput.Text,
                        txt_FileDecryptPrivateKey.Text,
                        txt_FileDecryptPassword.Text,
                        (progress) =>
                        {
                            // Aggiorna la progress bar (invoca sul thread UI)
                            if (progressBarFileDecrypt.InvokeRequired)
                            {
                                progressBarFileDecrypt.Invoke(new Action(() =>
                                {
                                    progressBarFileDecrypt.Value = progress;
                                    label24.Text = $"Decifratura in corso... {progress}%";
                                }));
                            }
                        }
                    );
                });

                // Ripristina i controlli
                btn_DecryptFile.Enabled = true;
                btn_BrowseFileDecrypt.Enabled = true;
                btn_BrowseFileDecryptOutput.Enabled = true;
                label24.Text = "Decifratura completata con successo!";
                label24.ForeColor = Color.Green;

                string successMessage = $"File decifrato con successo!\n\nFile cifrato: {txt_FileDecryptInput.Text}\nFile decifrato: {txt_FileDecryptOutput.Text}";
                if (!string.IsNullOrWhiteSpace(originalFileName))
                {
                    successMessage += $"\n\nNome file originale: {originalFileName}";
                }

                MessageBox.Show(successMessage, "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Ripristina i controlli
                btn_DecryptFile.Enabled = true;
                btn_BrowseFileDecrypt.Enabled = true;
                btn_BrowseFileDecryptOutput.Enabled = true;
                progressBarFileDecrypt.Value = 0;
                label24.Text = "Errore durante la decifratura";
                label24.ForeColor = Color.Red;

                MessageBox.Show("Errore durante la decifratura del file: " + ex.Message +
                    "\n\nVerifica che la chiave privata e la password siano corrette.",
                    "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void label24_Click(object sender, EventArgs e)
        {

        }
    }
}
