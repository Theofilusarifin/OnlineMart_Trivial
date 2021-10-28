
namespace OnlineMart_Trivial
{
    partial class FormRegisterRider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegisterRider));
            this.labelRegistrasi = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxNomorTelepon = new System.Windows.Forms.TextBox();
            this.textBoxKonfirmasiPassword = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelRegistrasi
            // 
            this.labelRegistrasi.AutoSize = true;
            this.labelRegistrasi.BackColor = System.Drawing.Color.White;
            this.labelRegistrasi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRegistrasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRegistrasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelRegistrasi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(65)))), ((int)(((byte)(36)))));
            this.labelRegistrasi.Location = new System.Drawing.Point(231, 782);
            this.labelRegistrasi.Name = "labelRegistrasi";
            this.labelRegistrasi.Size = new System.Drawing.Size(153, 16);
            this.labelRegistrasi.TabIndex = 12;
            this.labelRegistrasi.Text = "&Silahkan Login Disini";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Montserrat", 9.5F, System.Drawing.FontStyle.Bold);
            this.textBoxEmail.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxEmail.Location = new System.Drawing.Point(48, 522);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(338, 16);
            this.textBoxEmail.TabIndex = 21;
            // 
            // textBoxNomorTelepon
            // 
            this.textBoxNomorTelepon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNomorTelepon.Font = new System.Drawing.Font("Montserrat", 9.5F, System.Drawing.FontStyle.Bold);
            this.textBoxNomorTelepon.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxNomorTelepon.Location = new System.Drawing.Point(46, 448);
            this.textBoxNomorTelepon.Name = "textBoxNomorTelepon";
            this.textBoxNomorTelepon.Size = new System.Drawing.Size(338, 16);
            this.textBoxNomorTelepon.TabIndex = 20;
            // 
            // textBoxKonfirmasiPassword
            // 
            this.textBoxKonfirmasiPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKonfirmasiPassword.Font = new System.Drawing.Font("Montserrat", 9.5F, System.Drawing.FontStyle.Bold);
            this.textBoxKonfirmasiPassword.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxKonfirmasiPassword.Location = new System.Drawing.Point(46, 670);
            this.textBoxKonfirmasiPassword.Name = "textBoxKonfirmasiPassword";
            this.textBoxKonfirmasiPassword.PasswordChar = '⚉';
            this.textBoxKonfirmasiPassword.Size = new System.Drawing.Size(338, 16);
            this.textBoxKonfirmasiPassword.TabIndex = 19;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Montserrat", 9.5F, System.Drawing.FontStyle.Bold);
            this.textBoxPassword.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxPassword.Location = new System.Drawing.Point(48, 596);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '⚉';
            this.textBoxPassword.Size = new System.Drawing.Size(338, 16);
            this.textBoxPassword.TabIndex = 18;
            // 
            // textBoxNama
            // 
            this.textBoxNama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNama.Font = new System.Drawing.Font("Montserrat", 9.5F, System.Drawing.FontStyle.Bold);
            this.textBoxNama.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxNama.Location = new System.Drawing.Point(47, 297);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(339, 16);
            this.textBoxNama.TabIndex = 17;
            // 
            // buttonRegister
            // 
            this.buttonRegister.AutoSize = true;
            this.buttonRegister.BackColor = System.Drawing.Color.Transparent;
            this.buttonRegister.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Button_Leave;
            this.buttonRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.buttonRegister.ForeColor = System.Drawing.Color.White;
            this.buttonRegister.Location = new System.Drawing.Point(33, 728);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(373, 41);
            this.buttonRegister.TabIndex = 16;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonLogin_Click);
            this.buttonRegister.MouseEnter += new System.EventHandler(this.buttonRegister_MouseEnter);
            this.buttonRegister.MouseLeave += new System.EventHandler(this.buttonRegister_MouseLeave);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Montserrat", 9.5F, System.Drawing.FontStyle.Bold);
            this.textBoxUsername.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxUsername.Location = new System.Drawing.Point(46, 372);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(339, 16);
            this.textBoxUsername.TabIndex = 22;
            // 
            // FormRegisterRider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Form_Regis_Rider1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 845);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxNomorTelepon);
            this.Controls.Add(this.textBoxKonfirmasiPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.labelRegistrasi);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 884);
            this.Name = "FormRegisterRider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrasi Rider";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRegisterRider_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRegistrasi;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxNomorTelepon;
        private System.Windows.Forms.TextBox textBoxKonfirmasiPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxUsername;
    }
}