
namespace OnlineMart_Trivial
{
    partial class FormUbahCabang
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
            this.buttonUbah = new System.Windows.Forms.Button();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.comboBoxPegawai = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
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
            this.buttonUbah.Location = new System.Drawing.Point(39, 581);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(393, 45);
            this.buttonUbah.TabIndex = 3;
            this.buttonUbah.Text = "Ubah";
            this.buttonUbah.UseVisualStyleBackColor = false;
            this.buttonUbah.Click += new System.EventHandler(this.buttonUbah_Click);
            this.buttonUbah.MouseEnter += new System.EventHandler(this.buttonUbah_MouseEnter);
            this.buttonUbah.MouseLeave += new System.EventHandler(this.buttonUbah_MouseLeave);
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAlamat.Font = new System.Drawing.Font("Montserrat", 12F);
            this.textBoxAlamat.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxAlamat.Location = new System.Drawing.Point(50, 368);
            this.textBoxAlamat.Multiline = true;
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(370, 59);
            this.textBoxAlamat.TabIndex = 1;
            // 
            // textBoxNama
            // 
            this.textBoxNama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNama.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNama.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxNama.Location = new System.Drawing.Point(51, 283);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(370, 20);
            this.textBoxNama.TabIndex = 0;
            // 
            // comboBoxPegawai
            // 
            this.comboBoxPegawai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPegawai.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPegawai.FormattingEnabled = true;
            this.comboBoxPegawai.Location = new System.Drawing.Point(39, 487);
            this.comboBoxPegawai.Name = "comboBoxPegawai";
            this.comboBoxPegawai.Size = new System.Drawing.Size(393, 34);
            this.comboBoxPegawai.TabIndex = 2;
            // 
            // FormUbahCabang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Ubah_Cabang1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(467, 680);
            this.Controls.Add(this.comboBoxPegawai);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.textBoxAlamat);
            this.Controls.Add(this.buttonUbah);
            this.DoubleBuffered = true;
            this.Name = "FormUbahCabang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ubah Cabang";
            this.Load += new System.EventHandler(this.FormUbahCabang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUbah;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.ComboBox comboBoxPegawai;
    }
}