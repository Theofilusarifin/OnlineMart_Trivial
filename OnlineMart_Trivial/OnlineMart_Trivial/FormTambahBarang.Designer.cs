﻿
namespace OnlineMart_Trivial
{
    partial class FormTambahBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTambahBarang));
            this.buttonTambah = new System.Windows.Forms.Button();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.comboBoxKategori = new System.Windows.Forms.ComboBox();
            this.pictureBoxBarang = new System.Windows.Forms.PictureBox();
            this.textBoxDeskripsi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTambah
            // 
            this.buttonTambah.AutoSize = true;
            this.buttonTambah.BackColor = System.Drawing.Color.Transparent;
            this.buttonTambah.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTambah.BackgroundImage")));
            this.buttonTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTambah.FlatAppearance.BorderSize = 0;
            this.buttonTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.buttonTambah.ForeColor = System.Drawing.Color.White;
            this.buttonTambah.Location = new System.Drawing.Point(39, 819);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(393, 45);
            this.buttonTambah.TabIndex = 4;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            this.buttonTambah.MouseEnter += new System.EventHandler(this.buttonTambah_MouseEnter);
            this.buttonTambah.MouseLeave += new System.EventHandler(this.buttonTambah_MouseLeave);
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHarga.Font = new System.Drawing.Font("Montserrat", 12F);
            this.textBoxHarga.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxHarga.Location = new System.Drawing.Point(50, 360);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(370, 20);
            this.textBoxHarga.TabIndex = 1;
            // 
            // textBoxNama
            // 
            this.textBoxNama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNama.Font = new System.Drawing.Font("Montserrat", 12F);
            this.textBoxNama.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxNama.Location = new System.Drawing.Point(50, 276);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(370, 20);
            this.textBoxNama.TabIndex = 0;
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKategori.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.Location = new System.Drawing.Point(39, 568);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.Size = new System.Drawing.Size(393, 34);
            this.comboBoxKategori.TabIndex = 3;
            // 
            // pictureBoxBarang
            // 
            this.pictureBoxBarang.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBarang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBarang.Image = global::OnlineMart_Trivial.Properties.Resources.Image_Placeholder;
            this.pictureBoxBarang.Location = new System.Drawing.Point(39, 660);
            this.pictureBoxBarang.Name = "pictureBoxBarang";
            this.pictureBoxBarang.Size = new System.Drawing.Size(115, 119);
            this.pictureBoxBarang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBarang.TabIndex = 4;
            this.pictureBoxBarang.TabStop = false;
            this.pictureBoxBarang.Click += new System.EventHandler(this.pictureBoxBarang_Click);
            // 
            // textBoxDeskripsi
            // 
            this.textBoxDeskripsi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDeskripsi.Font = new System.Drawing.Font("Montserrat", 12F);
            this.textBoxDeskripsi.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxDeskripsi.Location = new System.Drawing.Point(50, 444);
            this.textBoxDeskripsi.Multiline = true;
            this.textBoxDeskripsi.Name = "textBoxDeskripsi";
            this.textBoxDeskripsi.Size = new System.Drawing.Size(370, 59);
            this.textBoxDeskripsi.TabIndex = 2;
            // 
            // FormTambahBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Form_Tambah_Barang2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(467, 913);
            this.Controls.Add(this.pictureBoxBarang);
            this.Controls.Add(this.textBoxDeskripsi);
            this.Controls.Add(this.comboBoxKategori);
            this.Controls.Add(this.textBoxHarga);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.buttonTambah);
            this.DoubleBuffered = true;
            this.Name = "FormTambahBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tambah Barang";
            this.Load += new System.EventHandler(this.FormTambahBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.ComboBox comboBoxKategori;
        private System.Windows.Forms.PictureBox pictureBoxBarang;
        private System.Windows.Forms.TextBox textBoxDeskripsi;
    }
}