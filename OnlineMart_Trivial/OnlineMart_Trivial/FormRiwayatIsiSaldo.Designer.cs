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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRiwayat)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRiwayat
            // 
            this.dataGridViewRiwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRiwayat.Location = new System.Drawing.Point(54, 50);
            this.dataGridViewRiwayat.Name = "dataGridViewRiwayat";
            this.dataGridViewRiwayat.Size = new System.Drawing.Size(478, 244);
            this.dataGridViewRiwayat.TabIndex = 0;
            this.dataGridViewRiwayat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRiwayat_CellContentClick);
            // 
            // FormRiwayatIsiSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewRiwayat);
            this.Name = "FormRiwayatIsiSaldo";
            this.Text = "FormRiwayatIsiSaldo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRiwayat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRiwayat;
    }
}