
namespace OnlineMart_Trivial
{
    partial class FormDaftarOrder
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
			this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewOrder
			// 
			this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewOrder.Location = new System.Drawing.Point(175, 121);
			this.dataGridViewOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dataGridViewOrder.Name = "dataGridViewOrder";
			this.dataGridViewOrder.RowHeadersWidth = 51;
			this.dataGridViewOrder.Size = new System.Drawing.Size(719, 314);
			this.dataGridViewOrder.TabIndex = 19;
			// 
			// FormDaftarOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.dataGridViewOrder);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FormDaftarOrder";
			this.Text = "FormDaftarOrder";
			this.Load += new System.EventHandler(this.FormDaftarOrder_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrder;
    }
}