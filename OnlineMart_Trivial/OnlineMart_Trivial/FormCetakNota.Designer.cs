
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
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.buttonCetak = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCetakSemua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label1.Location = new System.Drawing.Point(304, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 22);
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
            this.comboBoxKriteria.Location = new System.Drawing.Point(307, 51);
            this.comboBoxKriteria.Name = "comboBoxKriteria";
            this.comboBoxKriteria.Size = new System.Drawing.Size(158, 28);
            this.comboBoxKriteria.TabIndex = 68;
            this.comboBoxKriteria.SelectedIndexChanged += new System.EventHandler(this.comboBoxKriteria_SelectedIndexChanged);
            // 
            // listBoxData
            // 
            this.listBoxData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxData.Font = new System.Drawing.Font("Montserrat", 12F);
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.ItemHeight = 22;
            this.listBoxData.Location = new System.Drawing.Point(308, 113);
            this.listBoxData.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(921, 180);
            this.listBoxData.TabIndex = 71;
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
            this.buttonCetak.Location = new System.Drawing.Point(308, 336);
            this.buttonCetak.Name = "buttonCetak";
            this.buttonCetak.Size = new System.Drawing.Size(128, 39);
            this.buttonCetak.TabIndex = 70;
            this.buttonCetak.Text = "Cetak";
            this.buttonCetak.UseVisualStyleBackColor = false;
            this.buttonCetak.Click += new System.EventHandler(this.buttonCetak_Click);
            this.buttonCetak.MouseEnter += new System.EventHandler(this.buttonCetak_MouseEnter);
            this.buttonCetak.MouseLeave += new System.EventHandler(this.buttonCetak_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 407);
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
            this.buttonCetakSemua.Location = new System.Drawing.Point(1100, 336);
            this.buttonCetakSemua.Name = "buttonCetakSemua";
            this.buttonCetakSemua.Size = new System.Drawing.Size(128, 39);
            this.buttonCetakSemua.TabIndex = 66;
            this.buttonCetakSemua.Text = "Cetak Semua";
            this.buttonCetakSemua.UseVisualStyleBackColor = false;
            this.buttonCetakSemua.Click += new System.EventHandler(this.buttonCetakSemua_Click);
            this.buttonCetakSemua.MouseEnter += new System.EventHandler(this.buttonCetakSemua_MouseEnter);
            this.buttonCetakSemua.MouseLeave += new System.EventHandler(this.buttonCetakSemua_MouseLeave);
            // 
            // FormCetakNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 407);
            this.Controls.Add(this.listBoxData);
            this.Controls.Add(this.buttonCetak);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxKriteria);
            this.Controls.Add(this.buttonCetakSemua);
            this.Margin = new System.Windows.Forms.Padding(2);
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