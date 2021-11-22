
namespace OnlineMart_Trivial
{
    partial class FormRekapPenjualanBarang
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.comboBoxCabang = new System.Windows.Forms.ComboBox();
            this.comboBoxBulan = new System.Windows.Forms.ComboBox();
            this.comboBoxTahun = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(76, 141);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(551, 150);
            this.dataGridView.TabIndex = 0;
            // 
            // comboBoxCabang
            // 
            this.comboBoxCabang.FormattingEnabled = true;
            this.comboBoxCabang.Location = new System.Drawing.Point(76, 50);
            this.comboBoxCabang.Name = "comboBoxCabang";
            this.comboBoxCabang.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCabang.TabIndex = 1;
            this.comboBoxCabang.SelectedIndexChanged += new System.EventHandler(this.comboBoxCabang_SelectedIndexChanged);
            // 
            // comboBoxBulan
            // 
            this.comboBoxBulan.FormattingEnabled = true;
            this.comboBoxBulan.Items.AddRange(new object[] {
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
            this.comboBoxBulan.Location = new System.Drawing.Point(298, 50);
            this.comboBoxBulan.Name = "comboBoxBulan";
            this.comboBoxBulan.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBulan.TabIndex = 2;
            this.comboBoxBulan.SelectedIndexChanged += new System.EventHandler(this.comboBoxBulan_SelectedIndexChanged);
            // 
            // comboBoxTahun
            // 
            this.comboBoxTahun.FormattingEnabled = true;
            this.comboBoxTahun.Location = new System.Drawing.Point(525, 50);
            this.comboBoxTahun.Name = "comboBoxTahun";
            this.comboBoxTahun.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTahun.TabIndex = 3;
            this.comboBoxTahun.SelectedIndexChanged += new System.EventHandler(this.comboBoxTahun_SelectedIndexChanged);
            // 
            // FormRekapPenjualanBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxTahun);
            this.Controls.Add(this.comboBoxBulan);
            this.Controls.Add(this.comboBoxCabang);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormRekapPenjualanBarang";
            this.Text = "FormRekapPenjualanBarang";
            this.Load += new System.EventHandler(this.FormRekapPenjualanBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox comboBoxCabang;
        private System.Windows.Forms.ComboBox comboBoxBulan;
        private System.Windows.Forms.ComboBox comboBoxTahun;
    }
}