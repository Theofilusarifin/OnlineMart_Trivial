
namespace OnlineMart_Trivial
{
    partial class FormDaftarPromo
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
			this.dataGridViewPromo = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPromo)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewPromo
			// 
			this.dataGridViewPromo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewPromo.Location = new System.Drawing.Point(175, 121);
			this.dataGridViewPromo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dataGridViewPromo.Name = "dataGridViewPromo";
			this.dataGridViewPromo.RowHeadersWidth = 51;
			this.dataGridViewPromo.Size = new System.Drawing.Size(719, 314);
			this.dataGridViewPromo.TabIndex = 19;
			// 
			// FormDaftarPromo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.dataGridViewPromo);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FormDaftarPromo";
			this.Text = "FormDaftarPromo";
			this.Load += new System.EventHandler(this.FormDaftarPromo_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPromo)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPromo;
    }
}