
namespace OnlineMart_Trivial
{
    partial class FormTambahHadiah
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
            this.buttonUbah = new System.Windows.Forms.Button();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.buttonUbah.Location = new System.Drawing.Point(38, 453);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(393, 45);
            this.buttonUbah.TabIndex = 7;
            this.buttonUbah.Text = "Ubah";
            this.buttonUbah.UseVisualStyleBackColor = false;
            this.buttonUbah.Click += new System.EventHandler(this.buttonUbah_Click);
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHarga.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHarga.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxHarga.Location = new System.Drawing.Point(52, 363);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(370, 20);
            this.textBoxHarga.TabIndex = 6;
            this.textBoxHarga.TextChanged += new System.EventHandler(this.textBoxHarga_TextChanged);
            // 
            // textBoxNama
            // 
            this.textBoxNama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNama.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNama.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxNama.Location = new System.Drawing.Point(52, 278);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(370, 20);
            this.textBoxNama.TabIndex = 5;
            this.textBoxNama.TextChanged += new System.EventHandler(this.textBoxNama_TextChanged);
            // 
            // FormTambahHadiah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Tambah_Hadiah;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(467, 548);
            this.Controls.Add(this.buttonUbah);
            this.Controls.Add(this.textBoxHarga);
            this.Controls.Add(this.textBoxNama);
            this.DoubleBuffered = true;
            this.Name = "FormTambahHadiah";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tambah Hadiah";
            this.Load += new System.EventHandler(this.FormTambahHadiah_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUbah;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.TextBox textBoxNama;
    }
}