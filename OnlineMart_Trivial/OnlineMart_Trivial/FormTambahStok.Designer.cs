
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxBarang = new System.Windows.Forms.ComboBox();
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
            // 
            // textBoxStok
            // 
            this.textBoxStok.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStok.Font = new System.Drawing.Font("Montserrat", 12F);
            this.textBoxStok.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxStok.Location = new System.Drawing.Point(77, 315);
            this.textBoxStok.Name = "textBoxStok";
            this.textBoxStok.Size = new System.Drawing.Size(339, 20);
            this.textBoxStok.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Montserrat", 12F);
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(49, 360);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(370, 20);
            this.textBox1.TabIndex = 11;
            // 
            // comboBoxBarang
            // 
            this.comboBoxBarang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBarang.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBarang.FormattingEnabled = true;
            this.comboBoxBarang.Location = new System.Drawing.Point(38, 275);
            this.comboBoxBarang.Name = "comboBoxBarang";
            this.comboBoxBarang.Size = new System.Drawing.Size(393, 34);
            this.comboBoxBarang.TabIndex = 10;
            // 
            // FormTambahStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Form_Tambah_Stok;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(467, 548);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxBarang);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxBarang;
    }
}