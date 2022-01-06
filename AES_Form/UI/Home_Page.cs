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
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();
        }

        /*
        #region SHA BUTTON
        private void btn_SHA_Click(object sender, EventArgs e)
        {
            Aes_Form sha_Form = new Aes_Form();
            sha_Form.ShowDialog();
        }
        #endregion
        */

        #region AES BUTTON
        private void btn_Aes_Click(object sender, EventArgs e)
        {
            Aes_Form aes_Form = new Aes_Form();
            aes_Form.ShowDialog();
        }
        #endregion

    }
}
