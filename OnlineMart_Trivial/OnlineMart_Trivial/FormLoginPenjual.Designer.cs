
namespace OnlineMart_Trivial
{
    partial class FormLoginPenjual
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
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelRegistrasi = new System.Windows.Forms.Label();
            this.pictureBoxMata = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMata)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxPassword.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxPassword.Location = new System.Drawing.Point(51, 393);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '⚉';
            this.textBoxPassword.Size = new System.Drawing.Size(290, 17);
            this.textBoxPassword.TabIndex = 4;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Montserrat", 12F);
            this.textBoxUsername.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxUsername.Location = new System.Drawing.Point(51, 308);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(339, 20);
            this.textBoxUsername.TabIndex = 3;
            // 
            // buttonLogin
            // 
            this.buttonLogin.AutoSize = true;
            this.buttonLogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Button_Leave;
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(39, 462);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(366, 41);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            this.buttonLogin.MouseEnter += new System.EventHandler(this.buttonLogin_MouseEnter);
            this.buttonLogin.MouseLeave += new System.EventHandler(this.buttonLogin_MouseLeave);
            // 
            // labelRegistrasi
            // 
            this.labelRegistrasi.AutoSize = true;
            this.labelRegistrasi.BackColor = System.Drawing.Color.White;
            this.labelRegistrasi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRegistrasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRegistrasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelRegistrasi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(65)))), ((int)(((byte)(36)))));
            this.labelRegistrasi.Location = new System.Drawing.Point(235, 527);
            this.labelRegistrasi.Name = "labelRegistrasi";
            this.labelRegistrasi.Size = new System.Drawing.Size(141, 16);
            this.labelRegistrasi.TabIndex = 6;
            this.labelRegistrasi.Text = "&Lakukan Registrasi";
            this.labelRegistrasi.Click += new System.EventHandler(this.labelRegistrasi_Click);
            // 
            // pictureBoxMata
            // 
            this.pictureBoxMata.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMata.Image = global::OnlineMart_Trivial.Properties.Resources.Closed_Eye;
            this.pictureBoxMata.Location = new System.Drawing.Point(351, 390);
            this.pictureBoxMata.Name = "pictureBoxMata";
            this.pictureBoxMata.Size = new System.Drawing.Size(35, 27);
            this.pictureBoxMata.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMata.TabIndex = 8;
            this.pictureBoxMata.TabStop = false;
            this.pictureBoxMata.Click += new System.EventHandler(this.pictureBoxMata_Click);
            // 
            // FormLoginPenjual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Login_Penjual;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 599);
            this.Controls.Add(this.pictureBoxMata);
            this.Controls.Add(this.labelRegistrasi);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.buttonLogin);
            this.DoubleBuffered = true;
            this.Name = "FormLoginPenjual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Penjual";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLoginPenjual_FormClosing);
            this.Load += new System.EventHandler(this.FormLoginPenjual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelRegistrasi;
        private System.Windows.Forms.PictureBox pictureBoxMata;
    }
}