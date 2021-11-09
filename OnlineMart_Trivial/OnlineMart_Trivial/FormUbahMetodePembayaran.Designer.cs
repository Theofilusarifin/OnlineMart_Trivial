
namespace OnlineMart_Trivial
{
    partial class FormUbahMetodePembayaran
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
			this.textBoxNama = new System.Windows.Forms.TextBox();
			this.buttonUbah = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBoxNama
			// 
			this.textBoxNama.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.textBoxNama.ForeColor = System.Drawing.Color.DimGray;
			this.textBoxNama.Location = new System.Drawing.Point(67, 348);
			this.textBoxNama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxNama.Name = "textBoxNama";
			this.textBoxNama.Size = new System.Drawing.Size(493, 23);
			this.textBoxNama.TabIndex = 4;
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
			this.buttonUbah.Location = new System.Drawing.Point(52, 458);
			this.buttonUbah.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonUbah.Name = "buttonUbah";
			this.buttonUbah.Size = new System.Drawing.Size(524, 55);
			this.buttonUbah.TabIndex = 5;
			this.buttonUbah.Text = "Ubah";
			this.buttonUbah.UseVisualStyleBackColor = false;
			this.buttonUbah.Click += new System.EventHandler(this.buttonUbah_Click);
			// 
			// FormUbahMetodePembayaran
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Ubah_Metode_Pembayaran;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(623, 581);
			this.Controls.Add(this.textBoxNama);
			this.Controls.Add(this.buttonUbah);
			this.DoubleBuffered = true;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FormUbahMetodePembayaran";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ubah Metode Pembayaran";
			this.Load += new System.EventHandler(this.FormUbahMetodePembayaran_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Button buttonUbah;
    }
}