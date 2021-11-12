
namespace OnlineMart_Trivial
{
    partial class FormIsiSaldo
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
            this.comboBoxMetodePembayaran = new System.Windows.Forms.ComboBox();
            this.textBoxSaldo = new System.Windows.Forms.TextBox();
            this.buttonBeli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxMetodePembayaran
            // 
            this.comboBoxMetodePembayaran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMetodePembayaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMetodePembayaran.FormattingEnabled = true;
            this.comboBoxMetodePembayaran.Location = new System.Drawing.Point(37, 380);
            this.comboBoxMetodePembayaran.Name = "comboBoxMetodePembayaran";
            this.comboBoxMetodePembayaran.Size = new System.Drawing.Size(393, 32);
            this.comboBoxMetodePembayaran.TabIndex = 5;
            // 
            // textBoxSaldo
            // 
            this.textBoxSaldo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSaldo.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxSaldo.Location = new System.Drawing.Point(50, 291);
            this.textBoxSaldo.Name = "textBoxSaldo";
            this.textBoxSaldo.Size = new System.Drawing.Size(370, 19);
            this.textBoxSaldo.TabIndex = 4;
            // 
            // buttonBeli
            // 
            this.buttonBeli.AutoSize = true;
            this.buttonBeli.BackColor = System.Drawing.Color.Transparent;
            this.buttonBeli.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Button_Leave;
            this.buttonBeli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBeli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBeli.FlatAppearance.BorderSize = 0;
            this.buttonBeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.buttonBeli.ForeColor = System.Drawing.Color.White;
            this.buttonBeli.Location = new System.Drawing.Point(37, 470);
            this.buttonBeli.Name = "buttonBeli";
            this.buttonBeli.Size = new System.Drawing.Size(393, 45);
            this.buttonBeli.TabIndex = 6;
            this.buttonBeli.Text = "Beli";
            this.buttonBeli.UseVisualStyleBackColor = false;
            this.buttonBeli.Click += new System.EventHandler(this.buttonBeli_Click);
            // 
            // FormIsiSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Form_Isi_Saldo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(467, 570);
            this.Controls.Add(this.comboBoxMetodePembayaran);
            this.Controls.Add(this.textBoxSaldo);
            this.Controls.Add(this.buttonBeli);
            this.DoubleBuffered = true;
            this.Name = "FormIsiSaldo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Isi Saldo";
            this.Load += new System.EventHandler(this.FormIsiSaldo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMetodePembayaran;
        private System.Windows.Forms.TextBox textBoxSaldo;
        private System.Windows.Forms.Button buttonBeli;
    }
}