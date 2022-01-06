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
    public partial class Aes_Form : Form
    {
        #region CONSTUCTOR
        public Aes_Form()
        {
            InitializeComponent();
        }
        #endregion

        #region EVENT
        private void btn_Menu_Click(object sender, EventArgs e)
        {
            Aes_Form.ActiveForm.Close();
        }

        private void btn_CryptAes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_InsertCryptPassword.Text) == false && string.IsNullOrEmpty(txt_InsertCryptPassword.Text) == false)
            {
                Aes aesSha = new Aes();
                string result;

                result = Aes.EncryptText(txt_InsertCryptText.Text, txt_InsertCryptPassword.Text);
                txt_ResultCrypt.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Non hai inserito un campo valido");
            }
        }

        private void btn_DeCryptAes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_InsertDeCryptText.Text) == false && string.IsNullOrEmpty(txt_InsertDeCryptPassword.Text) == false)
            {
                Aes aesSha = new Aes();
                string result;

                result = Aes.DecryptText(txt_InsertDeCryptText.Text, txt_InsertDeCryptPassword.Text);
                txt_ResultDeCrypt.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Non hai inserito un campo valido");
            }
        }

        #endregion

        private void Aes_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
