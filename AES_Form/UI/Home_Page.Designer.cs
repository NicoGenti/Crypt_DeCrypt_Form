
namespace CryptDecrypt.UI
{
    partial class Home_Page
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
            this.btn_MD5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Aes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Crypt && DeCrypt";
            // 
            // btn_MD5
            // 
            this.btn_MD5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MD5.Enabled = false;
            this.btn_MD5.Location = new System.Drawing.Point(104, 269);
            this.btn_MD5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_MD5.MaximumSize = new System.Drawing.Size(365, 55);
            this.btn_MD5.MinimumSize = new System.Drawing.Size(365, 55);
            this.btn_MD5.Name = "btn_MD5";
            this.btn_MD5.Size = new System.Drawing.Size(365, 55);
            this.btn_MD5.TabIndex = 2;
            this.btn_MD5.Text = "MD5...Coming Soon";
            this.btn_MD5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(104, 375);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.MaximumSize = new System.Drawing.Size(365, 55);
            this.button1.MinimumSize = new System.Drawing.Size(365, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(365, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "More...Coming Soon";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_Aes
            // 
            this.btn_Aes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Aes.Location = new System.Drawing.Point(104, 164);
            this.btn_Aes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Aes.MaximumSize = new System.Drawing.Size(365, 55);
            this.btn_Aes.MinimumSize = new System.Drawing.Size(365, 55);
            this.btn_Aes.Name = "btn_Aes";
            this.btn_Aes.Size = new System.Drawing.Size(365, 55);
            this.btn_Aes.TabIndex = 4;
            this.btn_Aes.Text = "AES";
            this.btn_Aes.UseVisualStyleBackColor = true;
            this.btn_Aes.Click += new System.EventHandler(this.btn_Aes_Click);
            // 
            // Home_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 481);
            this.Controls.Add(this.btn_Aes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_MD5);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(585, 520);
            this.Name = "Home_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Crypt/DeCrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SHA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_MD5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Aes;
    }
}