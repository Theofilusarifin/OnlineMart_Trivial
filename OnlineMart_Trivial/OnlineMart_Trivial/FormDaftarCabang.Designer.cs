
namespace OnlineMart_Trivial
{
    partial class FormDaftarCabang
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
            this.dataGridViewCabang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCabang)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCabang
            // 
            this.dataGridViewCabang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCabang.Location = new System.Drawing.Point(131, 98);
            this.dataGridViewCabang.Name = "dataGridViewCabang";
            this.dataGridViewCabang.Size = new System.Drawing.Size(539, 255);
            this.dataGridViewCabang.TabIndex = 19;
            this.dataGridViewCabang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCabang_CellContentClick);
            // 
            // FormDaftarCabang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewCabang);
            this.Name = "FormDaftarCabang";
            this.Text = "FormDaftarCabang";
            this.Load += new System.EventHandler(this.FormDaftarCabang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCabang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCabang;
    }
}