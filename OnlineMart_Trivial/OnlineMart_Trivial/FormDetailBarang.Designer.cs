﻿
namespace OnlineMart_Trivial
{
	partial class FormDetailBarang
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.labelRating = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxKriteria = new System.Windows.Forms.ComboBox();
			this.textBoxKriteria = new System.Windows.Forms.TextBox();
			this.pictureBoxBarang = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.buttonClose = new System.Windows.Forms.Button();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarang)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView
			// 
			this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView.DefaultCellStyle = dataGridViewCellStyle10;
			this.dataGridView.GridColor = System.Drawing.Color.Coral;
			this.dataGridView.Location = new System.Drawing.Point(334, 144);
			this.dataGridView.Name = "dataGridView";
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
			this.dataGridView.RowHeadersWidth = 51;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle12;
			this.dataGridView.Size = new System.Drawing.Size(942, 201);
			this.dataGridView.TabIndex = 71;
			// 
			// labelRating
			// 
			this.labelRating.AutoSize = true;
			this.labelRating.Font = new System.Drawing.Font("Montserrat", 14F);
			this.labelRating.Location = new System.Drawing.Point(677, 37);
			this.labelRating.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelRating.Name = "labelRating";
			this.labelRating.Size = new System.Drawing.Size(118, 26);
			this.labelRating.TabIndex = 73;
			this.labelRating.Text = "Montserrat";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.label1.Location = new System.Drawing.Point(344, 82);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(140, 20);
			this.label1.TabIndex = 75;
			this.label1.Text = "Cari Berdasarkan :";
			// 
			// comboBoxKriteria
			// 
			this.comboBoxKriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxKriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.comboBoxKriteria.FormattingEnabled = true;
			this.comboBoxKriteria.Items.AddRange(new object[] {
            "id",
            "rating",
            "review"});
			this.comboBoxKriteria.Location = new System.Drawing.Point(347, 112);
			this.comboBoxKriteria.Name = "comboBoxKriteria";
			this.comboBoxKriteria.Size = new System.Drawing.Size(248, 28);
			this.comboBoxKriteria.TabIndex = 76;
			// 
			// textBoxKriteria
			// 
			this.textBoxKriteria.BackColor = System.Drawing.Color.White;
			this.textBoxKriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxKriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.textBoxKriteria.Location = new System.Drawing.Point(641, 113);
			this.textBoxKriteria.Name = "textBoxKriteria";
			this.textBoxKriteria.Size = new System.Drawing.Size(446, 26);
			this.textBoxKriteria.TabIndex = 74;
			// 
			// pictureBoxBarang
			// 
			this.pictureBoxBarang.Image = global::OnlineMart_Trivial.Properties.Resources.Rating_Star;
			this.pictureBoxBarang.Location = new System.Drawing.Point(547, 11);
			this.pictureBoxBarang.Name = "pictureBoxBarang";
			this.pictureBoxBarang.Size = new System.Drawing.Size(96, 67);
			this.pictureBoxBarang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxBarang.TabIndex = 72;
			this.pictureBoxBarang.TabStop = false;
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
			this.buttonClose.Location = new System.Drawing.Point(1379, 351);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(128, 39);
			this.buttonClose.TabIndex = 66;
			this.buttonClose.Text = "Close";
			this.buttonClose.UseVisualStyleBackColor = false;
			// 
			// buttonSearch
			// 
			this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSearch.AutoSize = true;
			this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
			this.buttonSearch.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Button_Leave;
			this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonSearch.FlatAppearance.BorderSize = 0;
			this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
			this.buttonSearch.ForeColor = System.Drawing.Color.White;
			this.buttonSearch.Location = new System.Drawing.Point(1131, 108);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(128, 30);
			this.buttonSearch.TabIndex = 77;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.UseVisualStyleBackColor = false;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.AutoSize = true;
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Button_Leave;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(1131, 356);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 39);
			this.button1.TabIndex = 78;
			this.button1.Text = "Close";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// FormDetailBarang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1280, 407);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBoxKriteria);
			this.Controls.Add(this.textBoxKriteria);
			this.Controls.Add(this.labelRating);
			this.Controls.Add(this.pictureBoxBarang);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.buttonClose);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "FormDetailBarang";
			this.Text = "FormDetailBarang";
			this.Load += new System.EventHandler(this.FormDetailBarang_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarang)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.PictureBox pictureBoxBarang;
		private System.Windows.Forms.Label labelRating;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxKriteria;
		private System.Windows.Forms.TextBox textBoxKriteria;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.Button button1;
	}
}