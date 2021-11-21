
namespace OnlineMart_Trivial
{
	partial class FormCetakNota
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
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxKriteria = new System.Windows.Forms.ComboBox();
			this.buttonCetak = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.buttonCetakSemua = new System.Windows.Forms.Button();
			this.listBoxData = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label1.Location = new System.Drawing.Point(440, 26);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(194, 25);
			this.label1.TabIndex = 67;
			this.label1.Text = "Cari Berdasarkan ID:";
			// 
			// comboBoxKriteria
			// 
			this.comboBoxKriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxKriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxKriteria.FormattingEnabled = true;
			this.comboBoxKriteria.Items.AddRange(new object[] {
            "Id",
            "Tanggal",
            "Alamat",
            "Ongkos Kirim",
            "Total Bayar",
            "Cara Bayar",
            "Status"});
			this.comboBoxKriteria.Location = new System.Drawing.Point(444, 63);
			this.comboBoxKriteria.Margin = new System.Windows.Forms.Padding(4);
			this.comboBoxKriteria.Name = "comboBoxKriteria";
			this.comboBoxKriteria.Size = new System.Drawing.Size(210, 33);
			this.comboBoxKriteria.TabIndex = 68;
			this.comboBoxKriteria.SelectedIndexChanged += new System.EventHandler(this.comboBoxKriteria_SelectedIndexChanged);
			// 
			// buttonCetak
			// 
			this.buttonCetak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCetak.AutoSize = true;
			this.buttonCetak.BackColor = System.Drawing.Color.Transparent;
			this.buttonCetak.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Button_Leave;
			this.buttonCetak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonCetak.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonCetak.FlatAppearance.BorderSize = 0;
			this.buttonCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
			this.buttonCetak.ForeColor = System.Drawing.Color.White;
			this.buttonCetak.Location = new System.Drawing.Point(445, 414);
			this.buttonCetak.Margin = new System.Windows.Forms.Padding(4);
			this.buttonCetak.Name = "buttonCetak";
			this.buttonCetak.Size = new System.Drawing.Size(171, 48);
			this.buttonCetak.TabIndex = 70;
			this.buttonCetak.Text = "Cetak!";
			this.buttonCetak.UseVisualStyleBackColor = false;
			this.buttonCetak.Click += new System.EventHandler(this.buttonCetak_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(371, 501);
			this.pictureBox1.TabIndex = 69;
			this.pictureBox1.TabStop = false;
			// 
			// buttonCetakSemua
			// 
			this.buttonCetakSemua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCetakSemua.AutoSize = true;
			this.buttonCetakSemua.BackColor = System.Drawing.Color.Transparent;
			this.buttonCetakSemua.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Button_Leave;
			this.buttonCetakSemua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonCetakSemua.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonCetakSemua.FlatAppearance.BorderSize = 0;
			this.buttonCetakSemua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCetakSemua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
			this.buttonCetakSemua.ForeColor = System.Drawing.Color.White;
			this.buttonCetakSemua.Location = new System.Drawing.Point(1260, 414);
			this.buttonCetakSemua.Margin = new System.Windows.Forms.Padding(4);
			this.buttonCetakSemua.Name = "buttonCetakSemua";
			this.buttonCetakSemua.Size = new System.Drawing.Size(171, 48);
			this.buttonCetakSemua.TabIndex = 66;
			this.buttonCetakSemua.Text = "Cetak Semua";
			this.buttonCetakSemua.UseVisualStyleBackColor = false;
			this.buttonCetakSemua.Click += new System.EventHandler(this.buttonCetakSemua_Click);
			// 
			// listBoxData
			// 
			this.listBoxData.FormattingEnabled = true;
			this.listBoxData.ItemHeight = 16;
			this.listBoxData.Location = new System.Drawing.Point(446, 168);
			this.listBoxData.Name = "listBoxData";
			this.listBoxData.Size = new System.Drawing.Size(985, 196);
			this.listBoxData.TabIndex = 71;
			// 
			// FormCetakNota
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1465, 501);
			this.Controls.Add(this.listBoxData);
			this.Controls.Add(this.buttonCetak);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBoxKriteria);
			this.Controls.Add(this.buttonCetakSemua);
			this.Name = "FormCetakNota";
			this.Text = "FormCetakNota";
			this.Load += new System.EventHandler(this.FormCetakNota_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonCetak;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxKriteria;
		private System.Windows.Forms.Button buttonCetakSemua;
		private System.Windows.Forms.ListBox listBoxData;
	}
}