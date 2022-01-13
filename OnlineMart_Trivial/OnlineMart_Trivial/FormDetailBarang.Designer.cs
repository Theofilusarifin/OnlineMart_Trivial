
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelRating = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxKriteria = new System.Windows.Forms.ComboBox();
            this.textBoxKriteria = new System.Windows.Forms.TextBox();
            this.pictureBoxBarang = new System.Windows.Forms.PictureBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.pictureBoxBintang = new System.Windows.Forms.PictureBox();
            this.textBoxDeskripsiBarang = new System.Windows.Forms.TextBox();
            this.buttonCloseForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBintang)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView.GridColor = System.Drawing.Color.Coral;
            this.dataGridView.Location = new System.Drawing.Point(82, 333);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Montserrat", 12F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Montserrat", 10F);
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView.Size = new System.Drawing.Size(976, 246);
            this.dataGridView.TabIndex = 71;
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRating.Location = new System.Drawing.Point(134, 158);
            this.labelRating.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(66, 44);
            this.labelRating.TabIndex = 73;
            this.labelRating.Text = "5,0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label1.Location = new System.Drawing.Point(78, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 22);
            this.label1.TabIndex = 75;
            this.label1.Text = "Cari Berdasarkan :";
            // 
            // comboBoxKriteria
            // 
            this.comboBoxKriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKriteria.Font = new System.Drawing.Font("Montserrat", 12F);
            this.comboBoxKriteria.FormattingEnabled = true;
            this.comboBoxKriteria.Items.AddRange(new object[] {
            "Id",
            "Rating",
            "Review"});
            this.comboBoxKriteria.Location = new System.Drawing.Point(82, 274);
            this.comboBoxKriteria.Name = "comboBoxKriteria";
            this.comboBoxKriteria.Size = new System.Drawing.Size(248, 30);
            this.comboBoxKriteria.TabIndex = 76;
            // 
            // textBoxKriteria
            // 
            this.textBoxKriteria.BackColor = System.Drawing.Color.White;
            this.textBoxKriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxKriteria.Font = new System.Drawing.Font("Montserrat", 12F);
            this.textBoxKriteria.Location = new System.Drawing.Point(407, 275);
            this.textBoxKriteria.Name = "textBoxKriteria";
            this.textBoxKriteria.Size = new System.Drawing.Size(446, 27);
            this.textBoxKriteria.TabIndex = 74;
            // 
            // pictureBoxBarang
            // 
            this.pictureBoxBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBarang.Location = new System.Drawing.Point(82, 40);
            this.pictureBoxBarang.Name = "pictureBoxBarang";
            this.pictureBoxBarang.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxBarang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBarang.TabIndex = 72;
            this.pictureBoxBarang.TabStop = false;
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
            this.buttonClose.Location = new System.Drawing.Point(1238, 611);
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
            this.buttonSearch.Location = new System.Drawing.Point(930, 272);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(128, 30);
            this.buttonSearch.TabIndex = 77;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            this.buttonSearch.MouseEnter += new System.EventHandler(this.buttonSearch_MouseEnter);
            this.buttonSearch.MouseLeave += new System.EventHandler(this.buttonSearch_MouseLeave);
            // 
            // pictureBoxBintang
            // 
            this.pictureBoxBintang.Image = global::OnlineMart_Trivial.Properties.Resources.Rating_Star;
            this.pictureBoxBintang.Location = new System.Drawing.Point(84, 157);
            this.pictureBoxBintang.Name = "pictureBoxBintang";
            this.pictureBoxBintang.Size = new System.Drawing.Size(45, 42);
            this.pictureBoxBintang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBintang.TabIndex = 79;
            this.pictureBoxBintang.TabStop = false;
            // 
            // textBoxDeskripsiBarang
            // 
            this.textBoxDeskripsiBarang.BackColor = System.Drawing.Color.White;
            this.textBoxDeskripsiBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDeskripsiBarang.Font = new System.Drawing.Font("Montserrat", 12F);
            this.textBoxDeskripsiBarang.Location = new System.Drawing.Point(241, 40);
            this.textBoxDeskripsiBarang.Multiline = true;
            this.textBoxDeskripsiBarang.Name = "textBoxDeskripsiBarang";
            this.textBoxDeskripsiBarang.ReadOnly = true;
            this.textBoxDeskripsiBarang.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDeskripsiBarang.Size = new System.Drawing.Size(817, 100);
            this.textBoxDeskripsiBarang.TabIndex = 81;
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCloseForm.AutoSize = true;
            this.buttonCloseForm.BackColor = System.Drawing.Color.Transparent;
            this.buttonCloseForm.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Button_Leave;
            this.buttonCloseForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCloseForm.FlatAppearance.BorderSize = 0;
            this.buttonCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.buttonCloseForm.ForeColor = System.Drawing.Color.White;
            this.buttonCloseForm.Location = new System.Drawing.Point(930, 598);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Size = new System.Drawing.Size(128, 39);
            this.buttonCloseForm.TabIndex = 82;
            this.buttonCloseForm.Text = "Close";
            this.buttonCloseForm.UseVisualStyleBackColor = false;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            this.buttonCloseForm.MouseEnter += new System.EventHandler(this.buttonCloseForm_MouseEnter);
            this.buttonCloseForm.MouseLeave += new System.EventHandler(this.buttonCloseForm_MouseLeave);
            // 
            // FormDetailBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1139, 667);
            this.Controls.Add(this.buttonCloseForm);
            this.Controls.Add(this.textBoxDeskripsiBarang);
            this.Controls.Add(this.pictureBoxBintang);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxKriteria);
            this.Controls.Add(this.textBoxKriteria);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.pictureBoxBarang);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1139, 667);
            this.Name = "FormDetailBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDetailBarang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDetailBarang_FormClosing);
            this.Load += new System.EventHandler(this.FormDetailBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBintang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.PictureBox pictureBoxBarang;
		private System.Windows.Forms.Label labelRating;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxKriteria;
		private System.Windows.Forms.TextBox textBoxKriteria;
		private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.PictureBox pictureBoxBintang;
        private System.Windows.Forms.TextBox textBoxDeskripsiBarang;
        private System.Windows.Forms.Button buttonCloseForm;
    }
}