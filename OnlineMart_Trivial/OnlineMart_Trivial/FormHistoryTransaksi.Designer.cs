﻿
namespace OnlineMart_Trivial
{
	partial class FormHistoryTransaksi
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.buttonTambah = new System.Windows.Forms.Button();
			this.buttonClose = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(371, 501);
			this.pictureBox1.TabIndex = 37;
			this.pictureBox1.TabStop = false;
			// 
			// buttonTambah
			// 
			this.buttonTambah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonTambah.AutoSize = true;
			this.buttonTambah.BackColor = System.Drawing.Color.Transparent;
			this.buttonTambah.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Button_Leave;
			this.buttonTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonTambah.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonTambah.FlatAppearance.BorderSize = 0;
			this.buttonTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
			this.buttonTambah.ForeColor = System.Drawing.Color.White;
			this.buttonTambah.Location = new System.Drawing.Point(444, 415);
			this.buttonTambah.Margin = new System.Windows.Forms.Padding(4);
			this.buttonTambah.Name = "buttonTambah";
			this.buttonTambah.Size = new System.Drawing.Size(189, 48);
			this.buttonTambah.TabIndex = 35;
			this.buttonTambah.Text = "Tambah Data";
			this.buttonTambah.UseVisualStyleBackColor = false;
			// 
			// buttonClose
			// 
			this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonClose.AutoSize = true;
			this.buttonClose.BackColor = System.Drawing.Color.Transparent;
			this.buttonClose.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Button_Leave;
			this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonClose.FlatAppearance.BorderSize = 0;
			this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
			this.buttonClose.ForeColor = System.Drawing.Color.White;
			this.buttonClose.Location = new System.Drawing.Point(1260, 415);
			this.buttonClose.Margin = new System.Windows.Forms.Padding(4);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(171, 48);
			this.buttonClose.TabIndex = 36;
			this.buttonClose.Text = "Close";
			this.buttonClose.UseVisualStyleBackColor = false;
			// 
			// dataGridView
			// 
			this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.GridColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView.Location = new System.Drawing.Point(444, 139);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 51;
			this.dataGridView.Size = new System.Drawing.Size(987, 247);
			this.dataGridView.TabIndex = 34;
			this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
			// 
			// FormHistoryTransaksi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1465, 501);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.buttonTambah);
			this.Controls.Add(this.buttonClose);
			this.Controls.Add(this.dataGridView);
			this.Name = "FormHistoryTransaksi";
			this.Text = "FormHistoryTransaksi";
			this.Load += new System.EventHandler(this.FormHistoryTransaksi_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonTambah;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.DataGridView dataGridView;
	}
}