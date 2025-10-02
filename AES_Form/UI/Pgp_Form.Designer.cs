
namespace CryptDecrypt.UI
{
    partial class Pgp_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_InsertCryptText = new System.Windows.Forms.TextBox();
            this.txt_InsertCryptPublicKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_CryptPgp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_DeCryptPgp = new System.Windows.Forms.Button();
            this.txt_InsertDeCryptPrivateKey = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_InsertDeCryptText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ResultCrypt = new System.Windows.Forms.TextBox();
            this.txt_ResultDeCrypt = new System.Windows.Forms.TextBox();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_InsertDeCryptPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_GenerateKeys = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_GeneratedPublicKey = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_GeneratedPrivateKey = new System.Windows.Forms.TextBox();
            this.txt_KeyGenIdentity = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_KeyGenPassword = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(48, 235);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text:";
            //
            // txt_InsertCryptText
            //
            this.txt_InsertCryptText.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F);
            this.txt_InsertCryptText.Location = new System.Drawing.Point(115, 232);
            this.txt_InsertCryptText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_InsertCryptText.Multiline = true;
            this.txt_InsertCryptText.Name = "txt_InsertCryptText";
            this.txt_InsertCryptText.Size = new System.Drawing.Size(380, 60);
            this.txt_InsertCryptText.TabIndex = 1;
            //
            // txt_InsertCryptPublicKey
            //
            this.txt_InsertCryptPublicKey.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F);
            this.txt_InsertCryptPublicKey.Location = new System.Drawing.Point(115, 302);
            this.txt_InsertCryptPublicKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_InsertCryptPublicKey.Multiline = true;
            this.txt_InsertCryptPublicKey.Name = "txt_InsertCryptPublicKey";
            this.txt_InsertCryptPublicKey.Size = new System.Drawing.Size(380, 80);
            this.txt_InsertCryptPublicKey.TabIndex = 3;
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(4, 305);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "PublicKey:";
            //
            // btn_CryptPgp
            //
            this.btn_CryptPgp.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.btn_CryptPgp.Location = new System.Drawing.Point(234, 390);
            this.btn_CryptPgp.Name = "btn_CryptPgp";
            this.btn_CryptPgp.Size = new System.Drawing.Size(203, 40);
            this.btn_CryptPgp.TabIndex = 4;
            this.btn_CryptPgp.Text = "Crypt";
            this.btn_CryptPgp.UseVisualStyleBackColor = true;
            this.btn_CryptPgp.Click += new System.EventHandler(this.btn_CryptPgp_Click);
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(32, 443);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Result:";
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(559, 443);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Result:";
            //
            // btn_DeCryptPgp
            //
            this.btn_DeCryptPgp.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.btn_DeCryptPgp.Location = new System.Drawing.Point(761, 390);
            this.btn_DeCryptPgp.Name = "btn_DeCryptPgp";
            this.btn_DeCryptPgp.Size = new System.Drawing.Size(203, 40);
            this.btn_DeCryptPgp.TabIndex = 11;
            this.btn_DeCryptPgp.Text = "DeCrypt";
            this.btn_DeCryptPgp.UseVisualStyleBackColor = true;
            this.btn_DeCryptPgp.Click += new System.EventHandler(this.btn_DeCryptPgp_Click);
            //
            // txt_InsertDeCryptPrivateKey
            //
            this.txt_InsertDeCryptPrivateKey.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F);
            this.txt_InsertDeCryptPrivateKey.Location = new System.Drawing.Point(642, 268);
            this.txt_InsertDeCryptPrivateKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_InsertDeCryptPrivateKey.Multiline = true;
            this.txt_InsertDeCryptPrivateKey.Name = "txt_InsertDeCryptPrivateKey";
            this.txt_InsertDeCryptPrivateKey.Size = new System.Drawing.Size(380, 80);
            this.txt_InsertDeCryptPrivateKey.TabIndex = 10;
            //
            // label7
            //
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(526, 271);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "PrivateKey:";
            //
            // txt_InsertDeCryptText
            //
            this.txt_InsertDeCryptText.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F);
            this.txt_InsertDeCryptText.Location = new System.Drawing.Point(642, 232);
            this.txt_InsertDeCryptText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_InsertDeCryptText.Multiline = true;
            this.txt_InsertDeCryptText.Name = "txt_InsertDeCryptText";
            this.txt_InsertDeCryptText.Size = new System.Drawing.Size(380, 26);
            this.txt_InsertDeCryptText.TabIndex = 8;
            //
            // label8
            //
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(575, 235);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Text:";
            //
            // txt_ResultCrypt
            //
            this.txt_ResultCrypt.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F);
            this.txt_ResultCrypt.Location = new System.Drawing.Point(104, 440);
            this.txt_ResultCrypt.Multiline = true;
            this.txt_ResultCrypt.Name = "txt_ResultCrypt";
            this.txt_ResultCrypt.ReadOnly = true;
            this.txt_ResultCrypt.Size = new System.Drawing.Size(391, 80);
            this.txt_ResultCrypt.TabIndex = 16;
            //
            // txt_ResultDeCrypt
            //
            this.txt_ResultDeCrypt.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F);
            this.txt_ResultDeCrypt.Location = new System.Drawing.Point(631, 440);
            this.txt_ResultDeCrypt.Multiline = true;
            this.txt_ResultDeCrypt.Name = "txt_ResultDeCrypt";
            this.txt_ResultDeCrypt.ReadOnly = true;
            this.txt_ResultDeCrypt.Size = new System.Drawing.Size(391, 80);
            this.txt_ResultDeCrypt.TabIndex = 17;
            //
            // btn_Menu
            //
            this.btn_Menu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Menu.Location = new System.Drawing.Point(942, 530);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(80, 40);
            this.btn_Menu.TabIndex = 18;
            this.btn_Menu.Text = "Menu";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(187, 200);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Crypt Zone";
            //
            // label9
            //
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(757, 200);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 21);
            this.label9.TabIndex = 20;
            this.label9.Text = "DeCrypt Zone";
            //
            // label10
            //
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(11, 170);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1011, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "_______________________________________________________________________________________________";
            //
            // txt_InsertDeCryptPassword
            //
            this.txt_InsertDeCryptPassword.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F);
            this.txt_InsertDeCryptPassword.Location = new System.Drawing.Point(642, 356);
            this.txt_InsertDeCryptPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_InsertDeCryptPassword.Name = "txt_InsertDeCryptPassword";
            this.txt_InsertDeCryptPassword.Size = new System.Drawing.Size(380, 25);
            this.txt_InsertDeCryptPassword.TabIndex = 23;
            this.txt_InsertDeCryptPassword.UseSystemPasswordChar = true;
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(531, 359);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Password:";
            //
            // btn_GenerateKeys
            //
            this.btn_GenerateKeys.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.btn_GenerateKeys.Location = new System.Drawing.Point(234, 72);
            this.btn_GenerateKeys.Name = "btn_GenerateKeys";
            this.btn_GenerateKeys.Size = new System.Drawing.Size(203, 40);
            this.btn_GenerateKeys.TabIndex = 24;
            this.btn_GenerateKeys.Text = "Genera Chiavi";
            this.btn_GenerateKeys.UseVisualStyleBackColor = true;
            this.btn_GenerateKeys.Click += new System.EventHandler(this.btn_GenerateKeys_Click);
            //
            // label11
            //
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(511, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 19);
            this.label11.TabIndex = 25;
            this.label11.Text = "Chiave Pubblica:";
            //
            // txt_GeneratedPublicKey
            //
            this.txt_GeneratedPublicKey.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F);
            this.txt_GeneratedPublicKey.Location = new System.Drawing.Point(515, 42);
            this.txt_GeneratedPublicKey.Multiline = true;
            this.txt_GeneratedPublicKey.Name = "txt_GeneratedPublicKey";
            this.txt_GeneratedPublicKey.ReadOnly = true;
            this.txt_GeneratedPublicKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_GeneratedPublicKey.Size = new System.Drawing.Size(507, 70);
            this.txt_GeneratedPublicKey.TabIndex = 26;
            //
            // label12
            //
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(511, 115);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 19);
            this.label12.TabIndex = 27;
            this.label12.Text = "Chiave Privata:";
            //
            // txt_GeneratedPrivateKey
            //
            this.txt_GeneratedPrivateKey.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F);
            this.txt_GeneratedPrivateKey.Location = new System.Drawing.Point(515, 137);
            this.txt_GeneratedPrivateKey.Multiline = true;
            this.txt_GeneratedPrivateKey.Name = "txt_GeneratedPrivateKey";
            this.txt_GeneratedPrivateKey.ReadOnly = true;
            this.txt_GeneratedPrivateKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_GeneratedPrivateKey.Size = new System.Drawing.Size(507, 54);
            this.txt_GeneratedPrivateKey.TabIndex = 28;
            //
            // txt_KeyGenIdentity
            //
            this.txt_KeyGenIdentity.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F);
            this.txt_KeyGenIdentity.Location = new System.Drawing.Point(115, 20);
            this.txt_KeyGenIdentity.Name = "txt_KeyGenIdentity";
            this.txt_KeyGenIdentity.Size = new System.Drawing.Size(380, 25);
            this.txt_KeyGenIdentity.TabIndex = 30;
            this.txt_KeyGenIdentity.Text = "User <user@example.com>";
            //
            // label13
            //
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(24, 23);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 21);
            this.label13.TabIndex = 29;
            this.label13.Text = "Identity:";
            //
            // txt_KeyGenPassword
            //
            this.txt_KeyGenPassword.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F);
            this.txt_KeyGenPassword.Location = new System.Drawing.Point(115, 51);
            this.txt_KeyGenPassword.Name = "txt_KeyGenPassword";
            this.txt_KeyGenPassword.Size = new System.Drawing.Size(380, 25);
            this.txt_KeyGenPassword.TabIndex = 32;
            this.txt_KeyGenPassword.UseSystemPasswordChar = true;
            //
            // label14
            //
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(4, 54);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 21);
            this.label14.TabIndex = 31;
            this.label14.Text = "Password:";
            //
            // Pgp_Form
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1034, 581);
            this.Controls.Add(this.txt_KeyGenPassword);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_KeyGenIdentity);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_GeneratedPrivateKey);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_GeneratedPublicKey);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_GenerateKeys);
            this.Controls.Add(this.txt_InsertDeCryptPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.txt_ResultDeCrypt);
            this.Controls.Add(this.txt_ResultCrypt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_DeCryptPgp);
            this.Controls.Add(this.txt_InsertDeCryptPrivateKey);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_InsertDeCryptText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_CryptPgp);
            this.Controls.Add(this.txt_InsertCryptPublicKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_InsertCryptText);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1050, 620);
            this.MinimumSize = new System.Drawing.Size(1050, 620);
            this.Name = "Pgp_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crypt / Decrypt PGP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_InsertCryptText;
        private System.Windows.Forms.TextBox txt_InsertCryptPublicKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_CryptPgp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_DeCryptPgp;
        private System.Windows.Forms.TextBox txt_InsertDeCryptPrivateKey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_InsertDeCryptText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ResultCrypt;
        private System.Windows.Forms.TextBox txt_ResultDeCrypt;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_InsertDeCryptPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_GenerateKeys;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_GeneratedPublicKey;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_GeneratedPrivateKey;
        private System.Windows.Forms.TextBox txt_KeyGenIdentity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_KeyGenPassword;
        private System.Windows.Forms.Label label14;
    }
}
