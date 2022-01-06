
namespace CryptDecrypt.UI
{
    partial class Aes_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aes_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_InsertCryptText = new System.Windows.Forms.TextBox();
            this.txt_InsertCryptPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_CryptAes = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_DeCryptAes = new System.Windows.Forms.Button();
            this.txt_InsertDeCryptPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_InsertDeCryptText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.img_Instruction = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ResultCrypt = new System.Windows.Forms.TextBox();
            this.txt_ResultDeCrypt = new System.Windows.Forms.TextBox();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_Instruction)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(416, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text:";
            // 
            // txt_InsertCryptText
            // 
            this.txt_InsertCryptText.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F);
            this.txt_InsertCryptText.Location = new System.Drawing.Point(483, 70);
            this.txt_InsertCryptText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_InsertCryptText.Name = "txt_InsertCryptText";
            this.txt_InsertCryptText.Size = new System.Drawing.Size(469, 28);
            this.txt_InsertCryptText.TabIndex = 1;
            // 
            // txt_InsertCryptPassword
            // 
            this.txt_InsertCryptPassword.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F);
            this.txt_InsertCryptPassword.Location = new System.Drawing.Point(483, 108);
            this.txt_InsertCryptPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_InsertCryptPassword.Name = "txt_InsertCryptPassword";
            this.txt_InsertCryptPassword.Size = new System.Drawing.Size(469, 28);
            this.txt_InsertCryptPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(372, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // btn_CryptAes
            // 
            this.btn_CryptAes.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.btn_CryptAes.Location = new System.Drawing.Point(602, 144);
            this.btn_CryptAes.Name = "btn_CryptAes";
            this.btn_CryptAes.Size = new System.Drawing.Size(203, 51);
            this.btn_CryptAes.TabIndex = 4;
            this.btn_CryptAes.Text = "Crypt";
            this.btn_CryptAes.UseVisualStyleBackColor = true;
            this.btn_CryptAes.Click += new System.EventHandler(this.btn_CryptAes_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(497, 221);
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
            this.label5.Location = new System.Drawing.Point(497, 525);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Result:";
            // 
            // btn_DeCryptAes
            // 
            this.btn_DeCryptAes.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.btn_DeCryptAes.Location = new System.Drawing.Point(602, 442);
            this.btn_DeCryptAes.Name = "btn_DeCryptAes";
            this.btn_DeCryptAes.Size = new System.Drawing.Size(203, 51);
            this.btn_DeCryptAes.TabIndex = 11;
            this.btn_DeCryptAes.Text = "DeCrypt";
            this.btn_DeCryptAes.UseVisualStyleBackColor = true;
            this.btn_DeCryptAes.Click += new System.EventHandler(this.btn_DeCryptAes_Click);
            // 
            // txt_InsertDeCryptPassword
            // 
            this.txt_InsertDeCryptPassword.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F);
            this.txt_InsertDeCryptPassword.Location = new System.Drawing.Point(483, 404);
            this.txt_InsertDeCryptPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_InsertDeCryptPassword.Name = "txt_InsertDeCryptPassword";
            this.txt_InsertDeCryptPassword.Size = new System.Drawing.Size(469, 28);
            this.txt_InsertDeCryptPassword.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(372, 407);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Password:";
            // 
            // txt_InsertDeCryptText
            // 
            this.txt_InsertDeCryptText.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F);
            this.txt_InsertDeCryptText.Location = new System.Drawing.Point(483, 363);
            this.txt_InsertDeCryptText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_InsertDeCryptText.Name = "txt_InsertDeCryptText";
            this.txt_InsertDeCryptText.Size = new System.Drawing.Size(469, 28);
            this.txt_InsertDeCryptText.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(416, 366);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Text:";
            // 
            // img_Instruction
            // 
            this.img_Instruction.Image = ((System.Drawing.Image)(resources.GetObject("img_Instruction.Image")));
            this.img_Instruction.Location = new System.Drawing.Point(12, 77);
            this.img_Instruction.Name = "img_Instruction";
            this.img_Instruction.Size = new System.Drawing.Size(353, 469);
            this.img_Instruction.TabIndex = 22;
            this.img_Instruction.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(134, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Instruction:";
            // 
            // txt_ResultCrypt
            // 
            this.txt_ResultCrypt.Location = new System.Drawing.Point(569, 218);
            this.txt_ResultCrypt.Name = "txt_ResultCrypt";
            this.txt_ResultCrypt.Size = new System.Drawing.Size(275, 28);
            this.txt_ResultCrypt.TabIndex = 16;
            // 
            // txt_ResultDeCrypt
            // 
            this.txt_ResultDeCrypt.Location = new System.Drawing.Point(569, 522);
            this.txt_ResultDeCrypt.Name = "txt_ResultDeCrypt";
            this.txt_ResultDeCrypt.Size = new System.Drawing.Size(275, 28);
            this.txt_ResultDeCrypt.TabIndex = 17;
            // 
            // btn_Menu
            // 
            this.btn_Menu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Menu.Location = new System.Drawing.Point(872, 509);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(80, 52);
            this.btn_Menu.TabIndex = 18;
            this.btn_Menu.Text = "Menu";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(655, 38);
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
            this.label9.Location = new System.Drawing.Point(655, 317);
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
            this.label10.Location = new System.Drawing.Point(379, 279);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(602, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "__________________________________________________________________________";
            // 
            // Aes_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(994, 591);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.txt_ResultDeCrypt);
            this.Controls.Add(this.txt_ResultCrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.img_Instruction);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_DeCryptAes);
            this.Controls.Add(this.txt_InsertDeCryptPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_InsertDeCryptText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_CryptAes);
            this.Controls.Add(this.txt_InsertCryptPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_InsertCryptText);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1010, 630);
            this.MinimumSize = new System.Drawing.Size(1010, 630);
            this.Name = "Aes_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crypt / Decrypt AES";
            this.Load += new System.EventHandler(this.Aes_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_Instruction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_InsertCryptText;
        private System.Windows.Forms.TextBox txt_InsertCryptPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_CryptAes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_DeCryptAes;
        private System.Windows.Forms.TextBox txt_InsertDeCryptPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_InsertDeCryptText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox img_Instruction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ResultCrypt;
        private System.Windows.Forms.TextBox txt_ResultDeCrypt;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}