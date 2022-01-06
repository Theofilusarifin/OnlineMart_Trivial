
namespace OnlineMart_Trivial
{
	partial class FormTambahStok
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
			this.textBoxStok = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBoxNama
			// 
			this.textBoxNama.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxNama.Font = new System.Drawing.Font("Montserrat", 12F);
			this.textBoxNama.ForeColor = System.Drawing.Color.DimGray;
			this.textBoxNama.Location = new System.Drawing.Point(48, 250);
			this.textBoxNama.Name = "textBoxNama";
			this.textBoxNama.Size = new System.Drawing.Size(339, 20);
			this.textBoxNama.TabIndex = 8;
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
			this.buttonTambah.Location = new System.Drawing.Point(32, 398);
			this.buttonTambah.Name = "buttonTambah";
			this.buttonTambah.Size = new System.Drawing.Size(393, 45);
			this.buttonTambah.TabIndex = 7;
			this.buttonTambah.Text = "Tambah";
			this.buttonTambah.UseVisualStyleBackColor = false;
			this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
			// 
			// textBoxStok
			// 
			this.textBoxStok.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxStok.Font = new System.Drawing.Font("Montserrat", 12F);
			this.textBoxStok.ForeColor = System.Drawing.Color.DimGray;
			this.textBoxStok.Location = new System.Drawing.Point(48, 324);
			this.textBoxStok.Name = "textBoxStok";
			this.textBoxStok.Size = new System.Drawing.Size(339, 20);
			this.textBoxStok.TabIndex = 9;
			// 
			// FormTambahStok
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Form_Tambah_Stok_Penjual;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(437, 464);
			this.Controls.Add(this.textBoxStok);
			this.Controls.Add(this.textBoxNama);
			this.Controls.Add(this.buttonTambah);
			this.DoubleBuffered = true;
			this.Name = "FormTambahStok";
			this.Text = "FormTambahStok";
			this.Load += new System.EventHandler(this.FormTambahStok_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxNama;
		private System.Windows.Forms.Button buttonTambah;
		private System.Windows.Forms.TextBox textBoxStok;
	}
}