
namespace OnlineMart_Trivial
{
	partial class FormTambahBarangPenjual
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
			this.comboBoxKategori = new System.Windows.Forms.ComboBox();
			this.textBoxHarga = new System.Windows.Forms.TextBox();
			this.textBoxNama = new System.Windows.Forms.TextBox();
			this.buttonTambah = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// comboBoxKategori
			// 
			this.comboBoxKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxKategori.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxKategori.FormattingEnabled = true;
			this.comboBoxKategori.Location = new System.Drawing.Point(39, 443);
			this.comboBoxKategori.Name = "comboBoxKategori";
			this.comboBoxKategori.Size = new System.Drawing.Size(393, 34);
			this.comboBoxKategori.TabIndex = 6;
			// 
			// textBoxHarga
			// 
			this.textBoxHarga.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxHarga.Font = new System.Drawing.Font("Montserrat", 12F);
			this.textBoxHarga.ForeColor = System.Drawing.Color.DimGray;
			this.textBoxHarga.Location = new System.Drawing.Point(50, 362);
			this.textBoxHarga.Name = "textBoxHarga";
			this.textBoxHarga.Size = new System.Drawing.Size(370, 20);
			this.textBoxHarga.TabIndex = 5;
			// 
			// textBoxNama
			// 
			this.textBoxNama.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxNama.Font = new System.Drawing.Font("Montserrat", 12F);
			this.textBoxNama.ForeColor = System.Drawing.Color.DimGray;
			this.textBoxNama.Location = new System.Drawing.Point(50, 278);
			this.textBoxNama.Name = "textBoxNama";
			this.textBoxNama.Size = new System.Drawing.Size(370, 20);
			this.textBoxNama.TabIndex = 4;
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
			this.buttonTambah.Location = new System.Drawing.Point(39, 535);
			this.buttonTambah.Name = "buttonTambah";
			this.buttonTambah.Size = new System.Drawing.Size(393, 45);
			this.buttonTambah.TabIndex = 7;
			this.buttonTambah.Text = "Tambah";
			this.buttonTambah.UseVisualStyleBackColor = false;
			this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
			// 
			// FormTambahBarangPenjual
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Tambah_barang;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(467, 634);
			this.Controls.Add(this.comboBoxKategori);
			this.Controls.Add(this.textBoxHarga);
			this.Controls.Add(this.textBoxNama);
			this.Controls.Add(this.buttonTambah);
			this.DoubleBuffered = true;
			this.Name = "FormTambahBarangPenjual";
			this.Text = "FormTambahBarangPenjual";
			this.Load += new System.EventHandler(this.FormTambahBarangPenjual_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxKategori;
		private System.Windows.Forms.TextBox textBoxHarga;
		private System.Windows.Forms.TextBox textBoxNama;
		private System.Windows.Forms.Button buttonTambah;
	}
}