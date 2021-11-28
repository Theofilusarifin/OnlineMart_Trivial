
namespace OnlineMart_Trivial
{
    partial class FormTukarHadiah
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
            this.buttonTukar = new System.Windows.Forms.Button();
            this.textBoxBiayaPoin = new System.Windows.Forms.TextBox();
            this.comboBoxHadiah = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonTukar
            // 
            this.buttonTukar.AutoSize = true;
            this.buttonTukar.BackColor = System.Drawing.Color.Transparent;
            this.buttonTukar.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Button_Leave;
            this.buttonTukar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTukar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTukar.FlatAppearance.BorderSize = 0;
            this.buttonTukar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTukar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.buttonTukar.ForeColor = System.Drawing.Color.White;
            this.buttonTukar.Location = new System.Drawing.Point(38, 452);
            this.buttonTukar.Name = "buttonTukar";
            this.buttonTukar.Size = new System.Drawing.Size(393, 45);
            this.buttonTukar.TabIndex = 10;
            this.buttonTukar.Text = "Tukar";
            this.buttonTukar.UseVisualStyleBackColor = false;
            this.buttonTukar.Click += new System.EventHandler(this.buttonTukar_Click);
            this.buttonTukar.MouseEnter += new System.EventHandler(this.buttonTukar_MouseEnter);
            this.buttonTukar.MouseLeave += new System.EventHandler(this.buttonTukar_MouseLeave);
            // 
            // textBoxBiayaPoin
            // 
            this.textBoxBiayaPoin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBiayaPoin.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBiayaPoin.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxBiayaPoin.Location = new System.Drawing.Point(48, 363);
            this.textBoxBiayaPoin.Name = "textBoxBiayaPoin";
            this.textBoxBiayaPoin.Size = new System.Drawing.Size(370, 20);
            this.textBoxBiayaPoin.TabIndex = 9;
            // 
            // comboBoxHadiah
            // 
            this.comboBoxHadiah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHadiah.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxHadiah.FormattingEnabled = true;
            this.comboBoxHadiah.Location = new System.Drawing.Point(38, 274);
            this.comboBoxHadiah.Name = "comboBoxHadiah";
            this.comboBoxHadiah.Size = new System.Drawing.Size(393, 34);
            this.comboBoxHadiah.TabIndex = 11;
            this.comboBoxHadiah.SelectedIndexChanged += new System.EventHandler(this.comboBoxPegawai_SelectedIndexChanged);
            // 
            // FormTukarHadiah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Form_Tukar_Hadiah;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(467, 548);
            this.Controls.Add(this.comboBoxHadiah);
            this.Controls.Add(this.buttonTukar);
            this.Controls.Add(this.textBoxBiayaPoin);
            this.DoubleBuffered = true;
            this.Name = "FormTukarHadiah";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTukarHadiah";
            this.Load += new System.EventHandler(this.FormTukarHadiah_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTukar;
        private System.Windows.Forms.TextBox textBoxBiayaPoin;
        private System.Windows.Forms.ComboBox comboBoxHadiah;
    }
}