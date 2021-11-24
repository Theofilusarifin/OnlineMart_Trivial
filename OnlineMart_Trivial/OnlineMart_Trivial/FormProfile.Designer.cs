
namespace OnlineMart_Trivial
{
    partial class FormProfile
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
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxNomorTelepon = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Montserrat", 12F);
            this.textBoxUsername.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxUsername.Location = new System.Drawing.Point(50, 328);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(339, 20);
            this.textBoxUsername.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("Montserrat", 12F);
            this.textBoxEmail.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxEmail.Location = new System.Drawing.Point(50, 486);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(338, 20);
            this.textBoxEmail.TabIndex = 10;
            // 
            // textBoxNomorTelepon
            // 
            this.textBoxNomorTelepon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNomorTelepon.Font = new System.Drawing.Font("Montserrat", 12F);
            this.textBoxNomorTelepon.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxNomorTelepon.Location = new System.Drawing.Point(50, 407);
            this.textBoxNomorTelepon.Name = "textBoxNomorTelepon";
            this.textBoxNomorTelepon.Size = new System.Drawing.Size(338, 20);
            this.textBoxNomorTelepon.TabIndex = 9;
            // 
            // textBoxNama
            // 
            this.textBoxNama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNama.Font = new System.Drawing.Font("Montserrat", 12F);
            this.textBoxNama.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxNama.Location = new System.Drawing.Point(50, 251);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(339, 20);
            this.textBoxNama.TabIndex = 7;
            // 
            // buttonEdit
            // 
            this.buttonEdit.AutoSize = true;
            this.buttonEdit.BackColor = System.Drawing.Color.Transparent;
            this.buttonEdit.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Button_Leave;
            this.buttonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(33, 569);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(373, 41);
            this.buttonEdit.TabIndex = 11;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            this.buttonEdit.MouseEnter += new System.EventHandler(this.buttonEdit_MouseEnter);
            this.buttonEdit.MouseLeave += new System.EventHandler(this.buttonEdit_MouseLeave);
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Edit_Profile;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 661);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxNomorTelepon);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.buttonEdit);
            this.DoubleBuffered = true;
            this.Name = "FormProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProfil";
            this.Load += new System.EventHandler(this.FormProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxNomorTelepon;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Button buttonEdit;
    }
}