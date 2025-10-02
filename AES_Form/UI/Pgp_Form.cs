using CryptDecrypt.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
