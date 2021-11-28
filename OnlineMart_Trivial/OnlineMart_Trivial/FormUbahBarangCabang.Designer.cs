
namespace OnlineMart_Trivial
{
    partial class FormUbahBarangCabang
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
            this.textBoxStok = new System.Windows.Forms.TextBox();
            this.buttonUbah = new System.Windows.Forms.Button();
            this.textBoxBarang = new System.Windows.Forms.TextBox();
            this.textBoxCabang = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxStok
            // 
            this.textBoxStok.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStok.Font = new System.Drawing.Font("Montserrat", 12F);
            this.textBoxStok.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxStok.Location = new System.Drawing.Point(50, 448);
            this.textBoxStok.Name = "textBoxStok";
            this.textBoxStok.Size = new System.Drawing.Size(370, 20);
            this.textBoxStok.TabIndex = 10;
            // 
            // buttonUbah
            // 
            this.buttonUbah.AutoSize = true;
            this.buttonUbah.BackColor = System.Drawing.Color.Transparent;
            this.buttonUbah.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Button_Leave;
            this.buttonUbah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUbah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUbah.FlatAppearance.BorderSize = 0;
            this.buttonUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUbah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.buttonUbah.ForeColor = System.Drawing.Color.White;
            this.buttonUbah.Location = new System.Drawing.Point(39, 537);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(393, 45);
            this.buttonUbah.TabIndex = 9;
            this.buttonUbah.Text = "Ubah";
            this.buttonUbah.UseVisualStyleBackColor = false;
            this.buttonUbah.Click += new System.EventHandler(this.buttonUbah_Click);
            this.buttonUbah.MouseEnter += new System.EventHandler(this.buttonUbah_MouseEnter);
            this.buttonUbah.MouseLeave += new System.EventHandler(this.buttonUbah_MouseLeave);
            // 
            // textBoxBarang
            // 
            this.textBoxBarang.BackColor = System.Drawing.Color.White;
            this.textBoxBarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBarang.Font = new System.Drawing.Font("Montserrat", 12F);
            this.textBoxBarang.ForeColor = System.Drawing.Color.Black;
            this.textBoxBarang.Location = new System.Drawing.Point(50, 280);
            this.textBoxBarang.Name = "textBoxBarang";
            this.textBoxBarang.Size = new System.Drawing.Size(370, 20);
            this.textBoxBarang.TabIndex = 11;
            // 
            // textBoxCabang
            // 
            this.textBoxCabang.BackColor = System.Drawing.Color.White;
            this.textBoxCabang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCabang.Font = new System.Drawing.Font("Montserrat", 12F);
            this.textBoxCabang.ForeColor = System.Drawing.Color.Black;
            this.textBoxCabang.Location = new System.Drawing.Point(50, 364);
            this.textBoxCabang.Name = "textBoxCabang";
            this.textBoxCabang.Size = new System.Drawing.Size(370, 20);
            this.textBoxCabang.TabIndex = 12;
            // 
            // FormUbahBarangCabang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Ubah_Barang_Cabang1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(467, 634);
            this.Controls.Add(this.textBoxCabang);
            this.Controls.Add(this.textBoxBarang);
            this.Controls.Add(this.textBoxStok);
            this.Controls.Add(this.buttonUbah);
            this.DoubleBuffered = true;
            this.Name = "FormUbahBarangCabang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUbahBarangCabang";
            this.Load += new System.EventHandler(this.FormUbahBarangCabang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStok;
        private System.Windows.Forms.Button buttonUbah;
        private System.Windows.Forms.TextBox textBoxBarang;
        private System.Windows.Forms.TextBox textBoxCabang;
    }
}