
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNamaCabang = new System.Windows.Forms.Label();
            this.buttonCheckout = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelTotalHarga = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label1.Location = new System.Drawing.Point(304, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 22);
            this.label1.TabIndex = 45;
            this.label1.Text = "Cabang Dipilih :";
            // 
            // labelNamaCabang
            // 
            this.labelNamaCabang.AutoSize = true;
            this.labelNamaCabang.Font = new System.Drawing.Font("Montserrat", 12F);
            this.labelNamaCabang.Location = new System.Drawing.Point(445, 25);
            this.labelNamaCabang.Name = "labelNamaCabang";
            this.labelNamaCabang.Size = new System.Drawing.Size(0, 22);
            this.labelNamaCabang.TabIndex = 46;
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCheckout.AutoSize = true;
            this.buttonCheckout.BackColor = System.Drawing.Color.Transparent;
            this.buttonCheckout.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Button_Leave;
            this.buttonCheckout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCheckout.FlatAppearance.BorderSize = 0;
            this.buttonCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.buttonCheckout.ForeColor = System.Drawing.Color.White;
            this.buttonCheckout.Location = new System.Drawing.Point(308, 355);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(128, 39);
            this.buttonCheckout.TabIndex = 44;
            this.buttonCheckout.Text = "Checkout";
            this.buttonCheckout.UseVisualStyleBackColor = false;
            this.buttonCheckout.Click += new System.EventHandler(this.buttonCheckout_Click);
            this.buttonCheckout.MouseEnter += new System.EventHandler(this.buttonCheckout_MouseEnter);
            this.buttonCheckout.MouseLeave += new System.EventHandler(this.buttonCheckout_MouseLeave);
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
            this.buttonClose.Location = new System.Drawing.Point(1101, 355);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(128, 39);
            this.buttonClose.TabIndex = 43;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            this.buttonClose.MouseEnter += new System.EventHandler(this.buttonClose_MouseEnter);
            this.buttonClose.MouseLeave += new System.EventHandler(this.buttonClose_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 419);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.GridColor = System.Drawing.Color.Coral;
            this.dataGridView.Location = new System.Drawing.Point(308, 65);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat", 8F);
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.Size = new System.Drawing.Size(921, 267);
            this.dataGridView.TabIndex = 47;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKeranjang_CellContentClick);
            this.dataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellEndEdit);
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            // 
            // labelTotalHarga
            // 
            this.labelTotalHarga.AutoSize = true;
            this.labelTotalHarga.Font = new System.Drawing.Font("Montserrat", 12F);
            this.labelTotalHarga.Location = new System.Drawing.Point(968, 25);
            this.labelTotalHarga.Name = "labelTotalHarga";
            this.labelTotalHarga.Size = new System.Drawing.Size(0, 22);
            this.labelTotalHarga.TabIndex = 50;
            this.labelTotalHarga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label4.Location = new System.Drawing.Point(854, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 22);
            this.label4.TabIndex = 49;
            this.label4.Text = "Total Harga :";
            // 
            // FormKeranjang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 419);
            this.Controls.Add(this.labelTotalHarga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.labelNamaCabang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCheckout);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormKeranjang";
            this.Text = "FormKeranjang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormKeranjang_FormClosing);
            this.Load += new System.EventHandler(this.FormKeranjang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonCheckout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNamaCabang;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelTotalHarga;
        private System.Windows.Forms.Label label4;
    }
}