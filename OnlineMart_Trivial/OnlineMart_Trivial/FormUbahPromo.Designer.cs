
namespace OnlineMart_Trivial
{
    partial class FormUbahPromo
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
            this.textBoxPembelanjaanMinimum = new System.Windows.Forms.TextBox();
            this.textBoxDiskonMaksimal = new System.Windows.Forms.TextBox();
            this.textBoxDiskon = new System.Windows.Forms.TextBox();
            this.textBoxTipe = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.buttonUbah = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPembelanjaanMinimum
            // 
            this.textBoxPembelanjaanMinimum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPembelanjaanMinimum.Font = new System.Drawing.Font("Montserrat", 12F);
            this.textBoxPembelanjaanMinimum.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxPembelanjaanMinimum.Location = new System.Drawing.Point(48, 598);
            this.textBoxPembelanjaanMinimum.Name = "textBoxPembelanjaanMinimum";
            this.textBoxPembelanjaanMinimum.Size = new System.Drawing.Size(370, 20);
            this.textBoxPembelanjaanMinimum.TabIndex = 13;
            // 
            // textBoxDiskonMaksimal
            // 
            this.textBoxDiskonMaksimal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDiskonMaksimal.Font = new System.Drawing.Font("Montserrat", 12F);
            this.textBoxDiskonMaksimal.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxDiskonMaksimal.Location = new System.Drawing.Point(48, 516);
            this.textBoxDiskonMaksimal.Name = "textBoxDiskonMaksimal";
            this.textBoxDiskonMaksimal.Size = new System.Drawing.Size(370, 20);
            this.textBoxDiskonMaksimal.TabIndex = 12;
            // 
            // textBoxDiskon
            // 
            this.textBoxDiskon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDiskon.Font = new System.Drawing.Font("Montserrat", 12F);
            this.textBoxDiskon.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxDiskon.Location = new System.Drawing.Point(48, 437);
            this.textBoxDiskon.Name = "textBoxDiskon";
            this.textBoxDiskon.Size = new System.Drawing.Size(370, 20);
            this.textBoxDiskon.TabIndex = 11;
            // 
            // textBoxTipe
            // 
            this.textBoxTipe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTipe.Font = new System.Drawing.Font("Montserrat", 12F);
            this.textBoxTipe.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxTipe.Location = new System.Drawing.Point(48, 272);
            this.textBoxTipe.Name = "textBoxTipe";
            this.textBoxTipe.Size = new System.Drawing.Size(370, 20);
            this.textBoxTipe.TabIndex = 10;
            // 
            // textBoxNama
            // 
            this.textBoxNama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNama.Font = new System.Drawing.Font("Montserrat", 12F);
            this.textBoxNama.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxNama.Location = new System.Drawing.Point(48, 354);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(370, 20);
            this.textBoxNama.TabIndex = 8;
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
            this.buttonUbah.Location = new System.Drawing.Point(38, 685);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(393, 45);
            this.buttonUbah.TabIndex = 9;
            this.buttonUbah.Text = "Ubah";
            this.buttonUbah.UseVisualStyleBackColor = false;
            this.buttonUbah.Click += new System.EventHandler(this.buttonUbah_Click);
            // 
            // FormUbahPromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Ubah_Promo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(467, 781);
            this.Controls.Add(this.textBoxPembelanjaanMinimum);
            this.Controls.Add(this.textBoxDiskonMaksimal);
            this.Controls.Add(this.textBoxDiskon);
            this.Controls.Add(this.textBoxTipe);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.buttonUbah);
            this.DoubleBuffered = true;
            this.Name = "FormUbahPromo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ubah Promo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPembelanjaanMinimum;
        private System.Windows.Forms.TextBox textBoxDiskonMaksimal;
        private System.Windows.Forms.TextBox textBoxDiskon;
        private System.Windows.Forms.TextBox textBoxTipe;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Button buttonUbah;
    }
}