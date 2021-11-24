
namespace OnlineMart_Trivial
{
    partial class FormRekapPenjualanOmaSaldo
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelTotalPemasukan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTahun = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxbulan = new System.Windows.Forms.ComboBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.AutoSize = true;
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Button_Leave;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(893, 52);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(128, 30);
            this.buttonSearch.TabIndex = 50;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            this.buttonSearch.MouseEnter += new System.EventHandler(this.buttonSearch_MouseEnter);
            this.buttonSearch.MouseLeave += new System.EventHandler(this.buttonSearch_MouseLeave);
            // 
            // labelTotalPemasukan
            // 
            this.labelTotalPemasukan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalPemasukan.AutoSize = true;
            this.labelTotalPemasukan.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPemasukan.Location = new System.Drawing.Point(1229, 55);
            this.labelTotalPemasukan.Name = "labelTotalPemasukan";
            this.labelTotalPemasukan.Size = new System.Drawing.Size(0, 22);
            this.labelTotalPemasukan.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label4.Location = new System.Drawing.Point(1229, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 22);
            this.label4.TabIndex = 48;
            this.label4.Text = "Total Pemasukan :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label2.Location = new System.Drawing.Point(589, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 46;
            this.label2.Text = "Tahun :";
            // 
            // comboBoxTahun
            // 
            this.comboBoxTahun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTahun.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTahun.FormattingEnabled = true;
            this.comboBoxTahun.Location = new System.Drawing.Point(592, 52);
            this.comboBoxTahun.Name = "comboBoxTahun";
            this.comboBoxTahun.Size = new System.Drawing.Size(248, 30);
            this.comboBoxTahun.TabIndex = 47;
            this.comboBoxTahun.SelectedIndexChanged += new System.EventHandler(this.comboBoxTahun_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 407);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label1.Location = new System.Drawing.Point(305, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 43;
            this.label1.Text = "Bulan :";
            // 
            // comboBoxbulan
            // 
            this.comboBoxbulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxbulan.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxbulan.FormattingEnabled = true;
            this.comboBoxbulan.Items.AddRange(new object[] {
            "",
            "Januari",
            "Februari",
            "Maret",
            "April",
            "Mei",
            "Juni",
            "Juli",
            "Agustus",
            "September",
            "Oktober",
            "November",
            "Desember"});
            this.comboBoxbulan.Location = new System.Drawing.Point(308, 52);
            this.comboBoxbulan.Name = "comboBoxbulan";
            this.comboBoxbulan.Size = new System.Drawing.Size(248, 30);
            this.comboBoxbulan.TabIndex = 44;
            this.comboBoxbulan.SelectedIndexChanged += new System.EventHandler(this.comboBoxbulan_SelectedIndexChanged);
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
            this.buttonClose.Location = new System.Drawing.Point(1279, 336);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(128, 39);
            this.buttonClose.TabIndex = 42;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            this.buttonClose.MouseEnter += new System.EventHandler(this.buttonClose_MouseEnter);
            this.buttonClose.MouseLeave += new System.EventHandler(this.buttonClose_MouseLeave);
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.Location = new System.Drawing.Point(308, 112);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(1099, 201);
            this.dataGridView.TabIndex = 41;
            // 
            // FormRekapPenjualanOmaSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1458, 407);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelTotalPemasukan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTahun);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxbulan);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormRekapPenjualanOmaSaldo";
            this.Text = "Rekap Penjualan";
            this.Load += new System.EventHandler(this.FormRekapPenjualanOmaSaldo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelTotalPemasukan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTahun;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxbulan;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}