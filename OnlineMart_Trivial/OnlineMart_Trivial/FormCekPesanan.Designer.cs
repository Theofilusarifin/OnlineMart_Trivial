
namespace OnlineMart_Trivial
{
    partial class FormCekPesanan
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxNomorNota = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelStatusPesanan = new System.Windows.Forms.Label();
            this.listBoxPesan = new System.Windows.Forms.ListBox();
            this.buttonKirim = new System.Windows.Forms.Button();
            this.textBoxPesan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 407);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label1.Location = new System.Drawing.Point(305, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 32;
            this.label1.Text = "Nomor Nota";
            // 
            // comboBoxNomorNota
            // 
            this.comboBoxNomorNota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNomorNota.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNomorNota.FormattingEnabled = true;
            this.comboBoxNomorNota.Items.AddRange(new object[] {
            "Id",
            "Nama Barang",
            "Harga Barang",
            "Kategori"});
            this.comboBoxNomorNota.Location = new System.Drawing.Point(308, 52);
            this.comboBoxNomorNota.Name = "comboBoxNomorNota";
            this.comboBoxNomorNota.Size = new System.Drawing.Size(248, 30);
            this.comboBoxNomorNota.TabIndex = 33;
            this.comboBoxNomorNota.SelectedIndexChanged += new System.EventHandler(this.comboBoxKriteria_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label2.Location = new System.Drawing.Point(644, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 22);
            this.label2.TabIndex = 35;
            this.label2.Text = "Status Pesanan :";
            // 
            // labelStatusPesanan
            // 
            this.labelStatusPesanan.AutoSize = true;
            this.labelStatusPesanan.Font = new System.Drawing.Font("Montserrat", 12F);
            this.labelStatusPesanan.Location = new System.Drawing.Point(796, 55);
            this.labelStatusPesanan.Name = "labelStatusPesanan";
            this.labelStatusPesanan.Size = new System.Drawing.Size(0, 22);
            this.labelStatusPesanan.TabIndex = 36;
            // 
            // listBoxPesan
            // 
            this.listBoxPesan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPesan.Font = new System.Drawing.Font("Montserrat", 12F);
            this.listBoxPesan.FormattingEnabled = true;
            this.listBoxPesan.ItemHeight = 22;
            this.listBoxPesan.Location = new System.Drawing.Point(308, 113);
            this.listBoxPesan.Name = "listBoxPesan";
            this.listBoxPesan.Size = new System.Drawing.Size(919, 158);
            this.listBoxPesan.TabIndex = 37;
            // 
            // buttonKirim
            // 
            this.buttonKirim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonKirim.AutoSize = true;
            this.buttonKirim.BackColor = System.Drawing.Color.Transparent;
            this.buttonKirim.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Button_Leave;
            this.buttonKirim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonKirim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonKirim.FlatAppearance.BorderSize = 0;
            this.buttonKirim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.buttonKirim.ForeColor = System.Drawing.Color.White;
            this.buttonKirim.Location = new System.Drawing.Point(1127, 324);
            this.buttonKirim.Name = "buttonKirim";
            this.buttonKirim.Size = new System.Drawing.Size(100, 27);
            this.buttonKirim.TabIndex = 38;
            this.buttonKirim.Text = "Kirim";
            this.buttonKirim.UseVisualStyleBackColor = false;
            this.buttonKirim.Click += new System.EventHandler(this.buttonKirim_Click);
            // 
            // textBoxPesan
            // 
            this.textBoxPesan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPesan.BackColor = System.Drawing.Color.White;
            this.textBoxPesan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPesan.Font = new System.Drawing.Font("Montserrat", 12F);
            this.textBoxPesan.Location = new System.Drawing.Point(308, 324);
            this.textBoxPesan.Name = "textBoxPesan";
            this.textBoxPesan.Size = new System.Drawing.Size(780, 27);
            this.textBoxPesan.TabIndex = 28;
            // 
            // FormCekPesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 407);
            this.Controls.Add(this.buttonKirim);
            this.Controls.Add(this.listBoxPesan);
            this.Controls.Add(this.labelStatusPesanan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxNomorNota);
            this.Controls.Add(this.textBoxPesan);
            this.Name = "FormCekPesanan";
            this.Text = "FormCekPesanan";
            this.Load += new System.EventHandler(this.FormCekPesanan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxNomorNota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelStatusPesanan;
        private System.Windows.Forms.ListBox listBoxPesan;
        private System.Windows.Forms.Button buttonKirim;
        private System.Windows.Forms.TextBox textBoxPesan;
    }
}