
namespace OnlineMart_Trivial
{
    partial class FormAuth
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
            this.pictureBoxRider = new System.Windows.Forms.PictureBox();
            this.pictureBoxPegawai = new System.Windows.Forms.PictureBox();
            this.pictureBoxPenjual = new System.Windows.Forms.PictureBox();
            this.pictureBoxKonsumen = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPegawai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPenjual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKonsumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxRider
            // 
            this.pictureBoxRider.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRider.Location = new System.Drawing.Point(483, 400);
            this.pictureBoxRider.Name = "pictureBoxRider";
            this.pictureBoxRider.Size = new System.Drawing.Size(247, 377);
            this.pictureBoxRider.TabIndex = 19;
            this.pictureBoxRider.TabStop = false;
            this.pictureBoxRider.Click += new System.EventHandler(this.pictureBoxRider_Click);
            // 
            // pictureBoxPegawai
            // 
            this.pictureBoxPegawai.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPegawai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPegawai.Location = new System.Drawing.Point(847, 400);
            this.pictureBoxPegawai.Name = "pictureBoxPegawai";
            this.pictureBoxPegawai.Size = new System.Drawing.Size(247, 377);
            this.pictureBoxPegawai.TabIndex = 20;
            this.pictureBoxPegawai.TabStop = false;
            this.pictureBoxPegawai.Click += new System.EventHandler(this.pictureBoxPegawai_Click);
            // 
            // pictureBoxPenjual
            // 
            this.pictureBoxPenjual.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPenjual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPenjual.Location = new System.Drawing.Point(1215, 400);
            this.pictureBoxPenjual.Name = "pictureBoxPenjual";
            this.pictureBoxPenjual.Size = new System.Drawing.Size(247, 377);
            this.pictureBoxPenjual.TabIndex = 21;
            this.pictureBoxPenjual.TabStop = false;
            this.pictureBoxPenjual.Click += new System.EventHandler(this.pictureBoxPenjual_Click);
            // 
            // pictureBoxKonsumen
            // 
            this.pictureBoxKonsumen.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxKonsumen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxKonsumen.Location = new System.Drawing.Point(96, 400);
            this.pictureBoxKonsumen.Name = "pictureBoxKonsumen";
            this.pictureBoxKonsumen.Size = new System.Drawing.Size(247, 377);
            this.pictureBoxKonsumen.TabIndex = 22;
            this.pictureBoxKonsumen.TabStop = false;
            this.pictureBoxKonsumen.Click += new System.EventHandler(this.pictureBoxKonsumen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::OnlineMart_Trivial.Properties.Resources.Background_Auth3;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1556, 884);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // FormAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Background_Auth3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1556, 884);
            this.Controls.Add(this.pictureBoxKonsumen);
            this.Controls.Add(this.pictureBoxPenjual);
            this.Controls.Add(this.pictureBoxPegawai);
            this.Controls.Add(this.pictureBoxRider);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAuth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAuth";
            this.Load += new System.EventHandler(this.FormAuth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPegawai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPenjual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKonsumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxRider;
        private System.Windows.Forms.PictureBox pictureBoxPegawai;
        private System.Windows.Forms.PictureBox pictureBoxPenjual;
        private System.Windows.Forms.PictureBox pictureBoxKonsumen;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}