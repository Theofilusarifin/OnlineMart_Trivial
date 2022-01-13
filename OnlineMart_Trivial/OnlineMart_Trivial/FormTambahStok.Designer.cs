
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
            this.buttonTambah = new System.Windows.Forms.Button();
            this.textBoxStok = new System.Windows.Forms.TextBox();
            this.textBoxBarang = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.buttonTambah.Location = new System.Drawing.Point(38, 451);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(393, 45);
            this.buttonTambah.TabIndex = 7;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            this.buttonTambah.MouseEnter += new System.EventHandler(this.buttonTambah_MouseEnter);
            this.buttonTambah.MouseLeave += new System.EventHandler(this.buttonTambah_MouseLeave);
            // 
            // textBoxStok
            // 
            this.textBoxStok.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStok.Font = new System.Drawing.Font("Montserrat", 12F);
            this.textBoxStok.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxStok.Location = new System.Drawing.Point(51, 361);
            this.textBoxStok.Name = "textBoxStok";
            this.textBoxStok.Size = new System.Drawing.Size(362, 20);
            this.textBoxStok.TabIndex = 9;
            // 
            // textBoxBarang
            // 
            this.textBoxBarang.BackColor = System.Drawing.Color.White;
            this.textBoxBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBarang.Font = new System.Drawing.Font("Montserrat", 12F);
            this.textBoxBarang.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxBarang.Location = new System.Drawing.Point(51, 277);
            this.textBoxBarang.Name = "textBoxBarang";
            this.textBoxBarang.ReadOnly = true;
            this.textBoxBarang.Size = new System.Drawing.Size(362, 20);
            this.textBoxBarang.TabIndex = 10;
            // 
            // FormTambahStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Form_Tambah_Stok1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(467, 548);
            this.Controls.Add(this.textBoxBarang);
            this.Controls.Add(this.textBoxStok);
            this.Controls.Add(this.buttonTambah);
            this.DoubleBuffered = true;
            this.Name = "FormTambahStok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTambahStok";
            this.Load += new System.EventHandler(this.FormTambahStok_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonTambah;
		private System.Windows.Forms.TextBox textBoxStok;
        public System.Windows.Forms.TextBox textBoxBarang;
    }
}