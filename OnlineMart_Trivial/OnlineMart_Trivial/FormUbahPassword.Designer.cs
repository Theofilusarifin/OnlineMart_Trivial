
namespace OnlineMart_Trivial
{
    partial class FormUbahPassword
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
            this.textBoxPassBaruConfirm = new System.Windows.Forms.TextBox();
            this.textBoxPassBaru = new System.Windows.Forms.TextBox();
            this.textBoxPassLama = new System.Windows.Forms.TextBox();
            this.buttonUbah = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPassBaruConfirm
            // 
            this.textBoxPassBaruConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassBaruConfirm.Font = new System.Drawing.Font("Montserrat", 12F);
            this.textBoxPassBaruConfirm.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxPassBaruConfirm.Location = new System.Drawing.Point(49, 442);
            this.textBoxPassBaruConfirm.Name = "textBoxPassBaruConfirm";
            this.textBoxPassBaruConfirm.Size = new System.Drawing.Size(370, 20);
            this.textBoxPassBaruConfirm.TabIndex = 17;
            // 
            // textBoxPassBaru
            // 
            this.textBoxPassBaru.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassBaru.Font = new System.Drawing.Font("Montserrat", 12F);
            this.textBoxPassBaru.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxPassBaru.Location = new System.Drawing.Point(49, 358);
            this.textBoxPassBaru.Name = "textBoxPassBaru";
            this.textBoxPassBaru.Size = new System.Drawing.Size(370, 20);
            this.textBoxPassBaru.TabIndex = 16;
            // 
            // textBoxPassLama
            // 
            this.textBoxPassLama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassLama.Font = new System.Drawing.Font("Montserrat", 12F);
            this.textBoxPassLama.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxPassLama.Location = new System.Drawing.Point(49, 276);
            this.textBoxPassLama.Name = "textBoxPassLama";
            this.textBoxPassLama.Size = new System.Drawing.Size(370, 20);
            this.textBoxPassLama.TabIndex = 15;
            // 
            // buttonUbah
            // 
            this.buttonUbah.AutoSize = true;
            this.buttonUbah.BackColor = System.Drawing.Color.Transparent;
            this.buttonUbah.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Button_Leave;
            this.buttonUbah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUbah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUbah.FlatAppearance.BorderSize = 0;
            this.buttonUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUbah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.buttonUbah.ForeColor = System.Drawing.Color.White;
            this.buttonUbah.Location = new System.Drawing.Point(38, 530);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(393, 45);
            this.buttonUbah.TabIndex = 14;
            this.buttonUbah.Text = "Ubah";
            this.buttonUbah.UseVisualStyleBackColor = false;
            this.buttonUbah.Click += new System.EventHandler(this.buttonUbah_Click);
            this.buttonUbah.MouseEnter += new System.EventHandler(this.buttonUbah_MouseEnter);
            this.buttonUbah.MouseLeave += new System.EventHandler(this.buttonUbah_MouseLeave);
            // 
            // FormUbahPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Ubah_Password;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(467, 626);
            this.Controls.Add(this.textBoxPassBaruConfirm);
            this.Controls.Add(this.textBoxPassBaru);
            this.Controls.Add(this.textBoxPassLama);
            this.Controls.Add(this.buttonUbah);
            this.DoubleBuffered = true;
            this.Name = "FormUbahPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUbahPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPassBaruConfirm;
        private System.Windows.Forms.TextBox textBoxPassBaru;
        private System.Windows.Forms.TextBox textBoxPassLama;
        private System.Windows.Forms.Button buttonUbah;
    }
}