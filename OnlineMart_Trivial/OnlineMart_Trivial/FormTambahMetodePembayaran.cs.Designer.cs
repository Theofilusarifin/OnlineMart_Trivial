
namespace OnlineMart_Trivial
{
    partial class FormTambahMetodePembayaran
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
			this.buttonTambah = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBoxNama
			// 
			this.textBoxNama.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.textBoxNama.ForeColor = System.Drawing.Color.DimGray;
			this.textBoxNama.Location = new System.Drawing.Point(65, 347);
			this.textBoxNama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxNama.Name = "textBoxNama";
			this.textBoxNama.Size = new System.Drawing.Size(493, 23);
			this.textBoxNama.TabIndex = 2;
			// 
			// buttonTambah
			// 
			this.buttonTambah.AutoSize = true;
			this.buttonTambah.BackColor = System.Drawing.Color.Transparent;
			this.buttonTambah.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Button_Leave;
			this.buttonTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonTambah.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonTambah.FlatAppearance.BorderSize = 0;
			this.buttonTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
			this.buttonTambah.ForeColor = System.Drawing.Color.White;
			this.buttonTambah.Location = new System.Drawing.Point(51, 457);
			this.buttonTambah.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonTambah.Name = "buttonTambah";
			this.buttonTambah.Size = new System.Drawing.Size(524, 55);
			this.buttonTambah.TabIndex = 3;
			this.buttonTambah.Text = "Tambah";
			this.buttonTambah.UseVisualStyleBackColor = false;
			this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
			// 
			// FormTambahMetodePembayaran
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Tambah_Metode_Pembayaran;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(623, 581);
			this.Controls.Add(this.textBoxNama);
			this.Controls.Add(this.buttonTambah);
			this.DoubleBuffered = true;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FormTambahMetodePembayaran";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tambah Metode Pembayaran";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Button buttonTambah;
    }
}