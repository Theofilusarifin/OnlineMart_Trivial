namespace OnlineMart_Trivial
{
    partial class FormRiwayatIsiSaldo
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
            this.dataGridViewRiwayat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.comboBoxKriteria = new System.Windows.Forms.ComboBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxKriteria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRiwayat)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRiwayat
            // 
            this.dataGridViewRiwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRiwayat.Location = new System.Drawing.Point(70, 120);
            this.dataGridViewRiwayat.Name = "dataGridViewRiwayat";
            this.dataGridViewRiwayat.Size = new System.Drawing.Size(478, 244);
            this.dataGridViewRiwayat.TabIndex = 0;
            this.dataGridViewRiwayat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRiwayat_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cari Berdasarkan :";
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
            this.buttonTambah.Location = new System.Drawing.Point(17, 399);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(142, 39);
            this.buttonTambah.TabIndex = 7;
            this.buttonTambah.Text = "Tambah Data";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // comboBoxKriteria
            // 
            this.comboBoxKriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxKriteria.FormattingEnabled = true;
            this.comboBoxKriteria.Items.AddRange(new object[] {
            "Id",
            "Nama Cabang",
            "Alamat",
            "Pegawai"});
            this.comboBoxKriteria.Location = new System.Drawing.Point(27, 54);
            this.comboBoxKriteria.Name = "comboBoxKriteria";
            this.comboBoxKriteria.Size = new System.Drawing.Size(248, 28);
            this.comboBoxKriteria.TabIndex = 10;
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
            this.buttonClose.Location = new System.Drawing.Point(629, 399);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(128, 39);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxKriteria
            // 
            this.textBoxKriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxKriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKriteria.Location = new System.Drawing.Point(321, 55);
            this.textBoxKriteria.Name = "textBoxKriteria";
            this.textBoxKriteria.Size = new System.Drawing.Size(446, 26);
            this.textBoxKriteria.TabIndex = 6;
            this.textBoxKriteria.TextChanged += new System.EventHandler(this.textBoxKriteria_TextChanged);
            // 
            // FormRiwayatIsiSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.comboBoxKriteria);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxKriteria);
            this.Controls.Add(this.dataGridViewRiwayat);
            this.Name = "FormRiwayatIsiSaldo";
            this.Text = "FormRiwayatIsiSaldo";
            this.Load += new System.EventHandler(this.FormRiwayatIsiSaldo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRiwayat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRiwayat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.ComboBox comboBoxKriteria;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxKriteria;
    }
}