
namespace OnlineMart_Trivial
{
    partial class FormKeranjang
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
            this.dataGridViewKeranjang = new System.Windows.Forms.DataGridView();
            this.buttonCheckout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeranjang)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKeranjang
            // 
            this.dataGridViewKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKeranjang.Location = new System.Drawing.Point(64, 70);
            this.dataGridViewKeranjang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewKeranjang.Name = "dataGridViewKeranjang";
            this.dataGridViewKeranjang.RowHeadersWidth = 51;
            this.dataGridViewKeranjang.RowTemplate.Height = 24;
            this.dataGridViewKeranjang.Size = new System.Drawing.Size(440, 244);
            this.dataGridViewKeranjang.TabIndex = 0;
            this.dataGridViewKeranjang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKeranjang_CellContentClick);
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.Location = new System.Drawing.Point(417, 330);
            this.buttonCheckout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(131, 26);
            this.buttonCheckout.TabIndex = 1;
            this.buttonCheckout.Text = "Proceed to checkout";
            this.buttonCheckout.UseVisualStyleBackColor = true;
            this.buttonCheckout.Click += new System.EventHandler(this.buttonCheckout_Click);
            // 
            // FormKeranjang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.buttonCheckout);
            this.Controls.Add(this.dataGridViewKeranjang);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormKeranjang";
            this.Text = "FormKeranjang";
            this.Load += new System.EventHandler(this.FormKeranjang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeranjang)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewKeranjang;
		private System.Windows.Forms.Button buttonCheckout;
	}
}