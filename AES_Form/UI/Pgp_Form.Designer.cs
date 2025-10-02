
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
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_FileEncryptInput = new System.Windows.Forms.TextBox();
            this.btn_BrowseFileEncrypt = new System.Windows.Forms.Button();
            this.txt_FileEncryptOutput = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_BrowseFileEncryptOutput = new System.Windows.Forms.Button();
            this.txt_FileEncryptPublicKey = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_EncryptFile = new System.Windows.Forms.Button();
            this.progressBarFileEncrypt = new System.Windows.Forms.ProgressBar();
            this.lbl_FileEncryptStatus = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_FileDecryptInput = new System.Windows.Forms.TextBox();
            this.btn_BrowseFileDecrypt = new System.Windows.Forms.Button();
            this.txt_FileDecryptOutput = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btn_BrowseFileDecryptOutput = new System.Windows.Forms.Button();
            this.txt_FileDecryptPrivateKey = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_FileDecryptPassword = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.btn_DecryptFile = new System.Windows.Forms.Button();
            this.progressBarFileDecrypt = new System.Windows.Forms.ProgressBar();
            this.label24 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(48, 250);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text:";
            // 
            // txt_InsertCryptText
            // 
            this.txt_InsertCryptText.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F);
            this.txt_InsertCryptText.Location = new System.Drawing.Point(115, 247);
            this.txt_InsertCryptText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_InsertCryptText.Multiline = true;
            this.txt_InsertCryptText.Name = "txt_InsertCryptText";
            this.txt_InsertCryptText.Size = new System.Drawing.Size(380, 60);
            this.txt_InsertCryptText.TabIndex = 1;
            // 
            // txt_InsertCryptPublicKey
            // 
            this.txt_InsertCryptPublicKey.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F);
            this.txt_InsertCryptPublicKey.Location = new System.Drawing.Point(115, 317);
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
            this.label2.Location = new System.Drawing.Point(4, 320);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "PublicKey:";
            // 
            // btn_CryptPgp
            // 
            this.btn_CryptPgp.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.btn_CryptPgp.Location = new System.Drawing.Point(234, 405);
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
            this.label4.Location = new System.Drawing.Point(32, 458);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Result:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(560, 458);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 27);
            this.label5.TabIndex = 13;
            this.label5.Text = "Result:";
            // 
            // btn_DeCryptPgp
            // 
            this.btn_DeCryptPgp.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.btn_DeCryptPgp.Location = new System.Drawing.Point(761, 405);
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
            this.txt_InsertDeCryptPrivateKey.Location = new System.Drawing.Point(642, 283);
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
            this.label7.Location = new System.Drawing.Point(527, 286);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 27);
            this.label7.TabIndex = 9;
            this.label7.Text = "PrivateKey:";
            // 
            // txt_InsertDeCryptText
            // 
            this.txt_InsertDeCryptText.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F);
            this.txt_InsertDeCryptText.Location = new System.Drawing.Point(642, 247);
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
            this.label8.Location = new System.Drawing.Point(576, 250);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 27);
            this.label8.TabIndex = 7;
            this.label8.Text = "Text:";
            // 
            // txt_ResultCrypt
            // 
            this.txt_ResultCrypt.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F);
            this.txt_ResultCrypt.Location = new System.Drawing.Point(104, 455);
            this.txt_ResultCrypt.Multiline = true;
            this.txt_ResultCrypt.Name = "txt_ResultCrypt";
            this.txt_ResultCrypt.ReadOnly = true;
            this.txt_ResultCrypt.Size = new System.Drawing.Size(391, 80);
            this.txt_ResultCrypt.TabIndex = 16;
            // 
            // txt_ResultDeCrypt
            // 
            this.txt_ResultDeCrypt.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F);
            this.txt_ResultDeCrypt.Location = new System.Drawing.Point(631, 455);
            this.txt_ResultDeCrypt.Multiline = true;
            this.txt_ResultDeCrypt.Name = "txt_ResultDeCrypt";
            this.txt_ResultDeCrypt.ReadOnly = true;
            this.txt_ResultDeCrypt.Size = new System.Drawing.Size(391, 80);
            this.txt_ResultDeCrypt.TabIndex = 17;
            // 
            // btn_Menu
            // 
            this.btn_Menu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Menu.Location = new System.Drawing.Point(935, 857);
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
            this.label6.Location = new System.Drawing.Point(188, 215);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 27);
            this.label6.TabIndex = 19;
            this.label6.Text = "Crypt Zone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(757, 215);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 27);
            this.label9.TabIndex = 20;
            this.label9.Text = "DeCrypt Zone";
            // 
            // txt_InsertDeCryptPassword
            // 
            this.txt_InsertDeCryptPassword.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F);
            this.txt_InsertDeCryptPassword.Location = new System.Drawing.Point(642, 371);
            this.txt_InsertDeCryptPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_InsertDeCryptPassword.Name = "txt_InsertDeCryptPassword";
            this.txt_InsertDeCryptPassword.Size = new System.Drawing.Size(380, 29);
            this.txt_InsertDeCryptPassword.TabIndex = 23;
            this.txt_InsertDeCryptPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(532, 374);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 27);
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
            this.label11.Location = new System.Drawing.Point(512, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 23);
            this.label11.TabIndex = 25;
            this.label11.Text = "Chiave Pubblica:";
            // 
            // txt_GeneratedPublicKey
            // 
            this.txt_GeneratedPublicKey.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F);
            this.txt_GeneratedPublicKey.Location = new System.Drawing.Point(515, 51);
            this.txt_GeneratedPublicKey.Multiline = true;
            this.txt_GeneratedPublicKey.Name = "txt_GeneratedPublicKey";
            this.txt_GeneratedPublicKey.ReadOnly = true;
            this.txt_GeneratedPublicKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_GeneratedPublicKey.Size = new System.Drawing.Size(507, 45);
            this.txt_GeneratedPublicKey.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(512, 112);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 23);
            this.label12.TabIndex = 27;
            this.label12.Text = "Chiave Privata:";
            // 
            // txt_GeneratedPrivateKey
            // 
            this.txt_GeneratedPrivateKey.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F);
            this.txt_GeneratedPrivateKey.Location = new System.Drawing.Point(515, 148);
            this.txt_GeneratedPrivateKey.Multiline = true;
            this.txt_GeneratedPrivateKey.Name = "txt_GeneratedPrivateKey";
            this.txt_GeneratedPrivateKey.ReadOnly = true;
            this.txt_GeneratedPrivateKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_GeneratedPrivateKey.Size = new System.Drawing.Size(507, 40);
            this.txt_GeneratedPrivateKey.TabIndex = 28;
            // 
            // txt_KeyGenIdentity
            // 
            this.txt_KeyGenIdentity.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F);
            this.txt_KeyGenIdentity.Location = new System.Drawing.Point(115, 20);
            this.txt_KeyGenIdentity.Name = "txt_KeyGenIdentity";
            this.txt_KeyGenIdentity.Size = new System.Drawing.Size(380, 29);
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
            this.label13.Size = new System.Drawing.Size(92, 27);
            this.label13.TabIndex = 29;
            this.label13.Text = "Identity:";
            // 
            // txt_KeyGenPassword
            // 
            this.txt_KeyGenPassword.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F);
            this.txt_KeyGenPassword.Location = new System.Drawing.Point(115, 51);
            this.txt_KeyGenPassword.Name = "txt_KeyGenPassword";
            this.txt_KeyGenPassword.Size = new System.Drawing.Size(380, 29);
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
            this.label14.Size = new System.Drawing.Size(111, 27);
            this.label14.TabIndex = 31;
            this.label14.Text = "Password:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(141, 583);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(225, 27);
            this.label15.TabIndex = 33;
            this.label15.Text = "Crypt File (PGP) Zone";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(21, 616);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 23);
            this.label16.TabIndex = 34;
            this.label16.Text = "File Input:";
            // 
            // txt_FileEncryptInput
            // 
            this.txt_FileEncryptInput.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F);
            this.txt_FileEncryptInput.Location = new System.Drawing.Point(115, 613);
            this.txt_FileEncryptInput.Name = "txt_FileEncryptInput";
            this.txt_FileEncryptInput.ReadOnly = true;
            this.txt_FileEncryptInput.Size = new System.Drawing.Size(299, 27);
            this.txt_FileEncryptInput.TabIndex = 35;
            // 
            // btn_BrowseFileEncrypt
            // 
            this.btn_BrowseFileEncrypt.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F);
            this.btn_BrowseFileEncrypt.Location = new System.Drawing.Point(421, 611);
            this.btn_BrowseFileEncrypt.Name = "btn_BrowseFileEncrypt";
            this.btn_BrowseFileEncrypt.Size = new System.Drawing.Size(70, 25);
            this.btn_BrowseFileEncrypt.TabIndex = 36;
            this.btn_BrowseFileEncrypt.Text = "Sfoglia...";
            this.btn_BrowseFileEncrypt.UseVisualStyleBackColor = true;
            this.btn_BrowseFileEncrypt.Click += new System.EventHandler(this.btn_BrowseFileEncrypt_Click);
            // 
            // txt_FileEncryptOutput
            // 
            this.txt_FileEncryptOutput.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F);
            this.txt_FileEncryptOutput.Location = new System.Drawing.Point(115, 642);
            this.txt_FileEncryptOutput.Name = "txt_FileEncryptOutput";
            this.txt_FileEncryptOutput.ReadOnly = true;
            this.txt_FileEncryptOutput.Size = new System.Drawing.Size(299, 27);
            this.txt_FileEncryptOutput.TabIndex = 38;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(8, 645);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(111, 23);
            this.label17.TabIndex = 37;
            this.label17.Text = "File Output:";
            // 
            // btn_BrowseFileEncryptOutput
            // 
            this.btn_BrowseFileEncryptOutput.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F);
            this.btn_BrowseFileEncryptOutput.Location = new System.Drawing.Point(421, 640);
            this.btn_BrowseFileEncryptOutput.Name = "btn_BrowseFileEncryptOutput";
            this.btn_BrowseFileEncryptOutput.Size = new System.Drawing.Size(70, 25);
            this.btn_BrowseFileEncryptOutput.TabIndex = 39;
            this.btn_BrowseFileEncryptOutput.Text = "Sfoglia...";
            this.btn_BrowseFileEncryptOutput.UseVisualStyleBackColor = true;
            this.btn_BrowseFileEncryptOutput.Click += new System.EventHandler(this.btn_BrowseFileEncryptOutput_Click);
            // 
            // txt_FileEncryptPublicKey
            // 
            this.txt_FileEncryptPublicKey.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F);
            this.txt_FileEncryptPublicKey.Location = new System.Drawing.Point(115, 675);
            this.txt_FileEncryptPublicKey.Multiline = true;
            this.txt_FileEncryptPublicKey.Name = "txt_FileEncryptPublicKey";
            this.txt_FileEncryptPublicKey.Size = new System.Drawing.Size(376, 60);
            this.txt_FileEncryptPublicKey.TabIndex = 41;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(12, 674);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(103, 23);
            this.label18.TabIndex = 40;
            this.label18.Text = "Public Key:";
            // 
            // btn_EncryptFile
            // 
            this.btn_EncryptFile.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Bold);
            this.btn_EncryptFile.Location = new System.Drawing.Point(189, 737);
            this.btn_EncryptFile.Name = "btn_EncryptFile";
            this.btn_EncryptFile.Size = new System.Drawing.Size(150, 35);
            this.btn_EncryptFile.TabIndex = 42;
            this.btn_EncryptFile.Text = "Cifra File";
            this.btn_EncryptFile.UseVisualStyleBackColor = true;
            this.btn_EncryptFile.Click += new System.EventHandler(this.btn_EncryptFile_Click);
            // 
            // progressBarFileEncrypt
            // 
            this.progressBarFileEncrypt.Location = new System.Drawing.Point(115, 778);
            this.progressBarFileEncrypt.Name = "progressBarFileEncrypt";
            this.progressBarFileEncrypt.Size = new System.Drawing.Size(376, 23);
            this.progressBarFileEncrypt.TabIndex = 43;
            // 
            // lbl_FileEncryptStatus
            // 
            this.lbl_FileEncryptStatus.AutoSize = true;
            this.lbl_FileEncryptStatus.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F);
            this.lbl_FileEncryptStatus.Location = new System.Drawing.Point(100, 804);
            this.lbl_FileEncryptStatus.Name = "lbl_FileEncryptStatus";
            this.lbl_FileEncryptStatus.Size = new System.Drawing.Size(0, 20);
            this.lbl_FileEncryptStatus.TabIndex = 44;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(696, 583);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(253, 27);
            this.label19.TabIndex = 45;
            this.label19.Text = "DeCrypt File (PGP) Zone";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(545, 616);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 23);
            this.label20.TabIndex = 46;
            this.label20.Text = "File Input:";
            // 
            // txt_FileDecryptInput
            // 
            this.txt_FileDecryptInput.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F);
            this.txt_FileDecryptInput.Location = new System.Drawing.Point(642, 613);
            this.txt_FileDecryptInput.Name = "txt_FileDecryptInput";
            this.txt_FileDecryptInput.ReadOnly = true;
            this.txt_FileDecryptInput.Size = new System.Drawing.Size(296, 27);
            this.txt_FileDecryptInput.TabIndex = 47;
            // 
            // btn_BrowseFileDecrypt
            // 
            this.btn_BrowseFileDecrypt.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F);
            this.btn_BrowseFileDecrypt.Location = new System.Drawing.Point(945, 611);
            this.btn_BrowseFileDecrypt.Name = "btn_BrowseFileDecrypt";
            this.btn_BrowseFileDecrypt.Size = new System.Drawing.Size(70, 25);
            this.btn_BrowseFileDecrypt.TabIndex = 48;
            this.btn_BrowseFileDecrypt.Text = "Sfoglia...";
            this.btn_BrowseFileDecrypt.UseVisualStyleBackColor = true;
            this.btn_BrowseFileDecrypt.Click += new System.EventHandler(this.btn_BrowseFileDecrypt_Click);
            // 
            // txt_FileDecryptOutput
            // 
            this.txt_FileDecryptOutput.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F);
            this.txt_FileDecryptOutput.Location = new System.Drawing.Point(642, 642);
            this.txt_FileDecryptOutput.Name = "txt_FileDecryptOutput";
            this.txt_FileDecryptOutput.ReadOnly = true;
            this.txt_FileDecryptOutput.Size = new System.Drawing.Size(296, 27);
            this.txt_FileDecryptOutput.TabIndex = 50;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(532, 645);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(111, 23);
            this.label21.TabIndex = 49;
            this.label21.Text = "File Output:";
            // 
            // btn_BrowseFileDecryptOutput
            // 
            this.btn_BrowseFileDecryptOutput.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F);
            this.btn_BrowseFileDecryptOutput.Location = new System.Drawing.Point(945, 640);
            this.btn_BrowseFileDecryptOutput.Name = "btn_BrowseFileDecryptOutput";
            this.btn_BrowseFileDecryptOutput.Size = new System.Drawing.Size(70, 25);
            this.btn_BrowseFileDecryptOutput.TabIndex = 51;
            this.btn_BrowseFileDecryptOutput.Text = "Sfoglia...";
            this.btn_BrowseFileDecryptOutput.UseVisualStyleBackColor = true;
            this.btn_BrowseFileDecryptOutput.Click += new System.EventHandler(this.btn_BrowseFileDecryptOutput_Click);
            // 
            // txt_FileDecryptPrivateKey
            // 
            this.txt_FileDecryptPrivateKey.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F);
            this.txt_FileDecryptPrivateKey.Location = new System.Drawing.Point(640, 671);
            this.txt_FileDecryptPrivateKey.Multiline = true;
            this.txt_FileDecryptPrivateKey.Name = "txt_FileDecryptPrivateKey";
            this.txt_FileDecryptPrivateKey.Size = new System.Drawing.Size(375, 60);
            this.txt_FileDecryptPrivateKey.TabIndex = 53;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(532, 674);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(109, 23);
            this.label22.TabIndex = 52;
            this.label22.Text = "Private Key:";
            // 
            // txt_FileDecryptPassword
            // 
            this.txt_FileDecryptPassword.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F);
            this.txt_FileDecryptPassword.Location = new System.Drawing.Point(642, 737);
            this.txt_FileDecryptPassword.Name = "txt_FileDecryptPassword";
            this.txt_FileDecryptPassword.Size = new System.Drawing.Size(373, 27);
            this.txt_FileDecryptPassword.TabIndex = 55;
            this.txt_FileDecryptPassword.UseSystemPasswordChar = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Bold);
            this.label23.Location = new System.Drawing.Point(541, 740);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(94, 23);
            this.label23.TabIndex = 54;
            this.label23.Text = "Password:";
            // 
            // btn_DecryptFile
            // 
            this.btn_DecryptFile.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10F, System.Drawing.FontStyle.Bold);
            this.btn_DecryptFile.Location = new System.Drawing.Point(737, 766);
            this.btn_DecryptFile.Name = "btn_DecryptFile";
            this.btn_DecryptFile.Size = new System.Drawing.Size(150, 35);
            this.btn_DecryptFile.TabIndex = 56;
            this.btn_DecryptFile.Text = "Decifra File";
            this.btn_DecryptFile.UseVisualStyleBackColor = true;
            this.btn_DecryptFile.Click += new System.EventHandler(this.btn_DecryptFile_Click);
            // 
            // progressBarFileDecrypt
            // 
            this.progressBarFileDecrypt.Location = new System.Drawing.Point(642, 807);
            this.progressBarFileDecrypt.Name = "progressBarFileDecrypt";
            this.progressBarFileDecrypt.Size = new System.Drawing.Size(373, 23);
            this.progressBarFileDecrypt.TabIndex = 57;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.label24.Location = new System.Drawing.Point(13, 538);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(962, 27);
            this.label24.TabIndex = 58;
            this.label24.Text = "_________________________________________________________________________________" +
    "______________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(13, 188);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(962, 27);
            this.label10.TabIndex = 59;
            this.label10.Text = "_________________________________________________________________________________" +
    "______________";
            // 
            // Pgp_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1042, 909);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.progressBarFileDecrypt);
            this.Controls.Add(this.btn_DecryptFile);
            this.Controls.Add(this.txt_FileDecryptPassword);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txt_FileDecryptPrivateKey);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.btn_BrowseFileDecryptOutput);
            this.Controls.Add(this.txt_FileDecryptOutput);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btn_BrowseFileDecrypt);
            this.Controls.Add(this.txt_FileDecryptInput);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lbl_FileEncryptStatus);
            this.Controls.Add(this.progressBarFileEncrypt);
            this.Controls.Add(this.btn_EncryptFile);
            this.Controls.Add(this.txt_FileEncryptPublicKey);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btn_BrowseFileEncryptOutput);
            this.Controls.Add(this.txt_FileEncryptOutput);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btn_BrowseFileEncrypt);
            this.Controls.Add(this.txt_FileEncryptInput);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
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
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_FileEncryptInput;
        private System.Windows.Forms.Button btn_BrowseFileEncrypt;
        private System.Windows.Forms.TextBox txt_FileEncryptOutput;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_BrowseFileEncryptOutput;
        private System.Windows.Forms.TextBox txt_FileEncryptPublicKey;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btn_EncryptFile;
        private System.Windows.Forms.ProgressBar progressBarFileEncrypt;
        private System.Windows.Forms.Label lbl_FileEncryptStatus;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_FileDecryptInput;
        private System.Windows.Forms.Button btn_BrowseFileDecrypt;
        private System.Windows.Forms.TextBox txt_FileDecryptOutput;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btn_BrowseFileDecryptOutput;
        private System.Windows.Forms.TextBox txt_FileDecryptPrivateKey;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txt_FileDecryptPassword;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btn_DecryptFile;
        private System.Windows.Forms.ProgressBar progressBarFileDecrypt;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label10;
    }
}
