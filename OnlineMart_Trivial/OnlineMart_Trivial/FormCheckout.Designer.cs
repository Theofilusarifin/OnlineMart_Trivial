
namespace OnlineMart_Trivial
{
    partial class FormCheckout
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
            this.buttonKeranjang = new System.Windows.Forms.Button();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.comboBoxMetodeBayar = new System.Windows.Forms.ComboBox();
            this.comboBoxPromo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.Location = new System.Drawing.Point(37, 113);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(740, 201);
            this.dataGridView.TabIndex = 29;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // buttonKeranjang
            // 
            this.buttonKeranjang.Location = new System.Drawing.Point(37, 352);
            this.buttonKeranjang.Name = "buttonKeranjang";
            this.buttonKeranjang.Size = new System.Drawing.Size(124, 23);
            this.buttonKeranjang.TabIndex = 31;
            this.buttonKeranjang.Text = "kembali ke keranjang";
            this.buttonKeranjang.UseVisualStyleBackColor = true;
            this.buttonKeranjang.Click += new System.EventHandler(this.buttonKeranjang_Click);
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Location = new System.Drawing.Point(37, 49);
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(100, 20);
            this.textBoxAlamat.TabIndex = 32;
            // 
            // comboBoxMetodeBayar
            // 
            this.comboBoxMetodeBayar.FormattingEnabled = true;
            this.comboBoxMetodeBayar.Location = new System.Drawing.Point(423, 49);
            this.comboBoxMetodeBayar.Name = "comboBoxMetodeBayar";
            this.comboBoxMetodeBayar.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMetodeBayar.TabIndex = 33;
            this.comboBoxMetodeBayar.SelectedIndexChanged += new System.EventHandler(this.comboBoxMetodeBayar_SelectedIndexChanged);
            // 
            // comboBoxPromo
            // 
            this.comboBoxPromo.FormattingEnabled = true;
            this.comboBoxPromo.Location = new System.Drawing.Point(581, 49);
            this.comboBoxPromo.Name = "comboBoxPromo";
            this.comboBoxPromo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPromo.TabIndex = 34;
            this.comboBoxPromo.SelectedIndexChanged += new System.EventHandler(this.comboBoxPromo_SelectedIndexChanged);
            // 
            // FormCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxPromo);
            this.Controls.Add(this.comboBoxMetodeBayar);
            this.Controls.Add(this.textBoxAlamat);
            this.Controls.Add(this.buttonKeranjang);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormCheckout";
            this.Text = "FormCheckout";
            this.Load += new System.EventHandler(this.FormCheckout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonKeranjang;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.ComboBox comboBoxMetodeBayar;
        private System.Windows.Forms.ComboBox comboBoxPromo;
    }
}