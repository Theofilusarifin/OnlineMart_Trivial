
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
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.textBoxOngkosKirim = new System.Windows.Forms.TextBox();
            this.textBoxTotalBayar = new System.Windows.Forms.TextBox();
            this.comboBoxPromo = new System.Windows.Forms.ComboBox();
            this.comboBoxMetodeBayar = new System.Windows.Forms.ComboBox();
            this.comboBoxKurir = new System.Windows.Forms.ComboBox();
            this.buttonBayar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.Color.White;
            this.textBoxId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxId.Enabled = false;
            this.textBoxId.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxId.Location = new System.Drawing.Point(49, 280);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(370, 20);
            this.textBoxId.TabIndex = 2;
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAlamat.Font = new System.Drawing.Font("Montserrat", 12F);
            this.textBoxAlamat.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxAlamat.Location = new System.Drawing.Point(49, 366);
            this.textBoxAlamat.Multiline = true;
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(370, 59);
            this.textBoxAlamat.TabIndex = 3;
            // 
            // textBoxOngkosKirim
            // 
            this.textBoxOngkosKirim.BackColor = System.Drawing.Color.White;
            this.textBoxOngkosKirim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOngkosKirim.Enabled = false;
            this.textBoxOngkosKirim.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOngkosKirim.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxOngkosKirim.Location = new System.Drawing.Point(49, 493);
            this.textBoxOngkosKirim.Name = "textBoxOngkosKirim";
            this.textBoxOngkosKirim.Size = new System.Drawing.Size(370, 20);
            this.textBoxOngkosKirim.TabIndex = 4;
            // 
            // textBoxTotalBayar
            // 
            this.textBoxTotalBayar.BackColor = System.Drawing.Color.White;
            this.textBoxTotalBayar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalBayar.Enabled = false;
            this.textBoxTotalBayar.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalBayar.ForeColor = System.Drawing.Color.Transparent;
            this.textBoxTotalBayar.Location = new System.Drawing.Point(49, 574);
            this.textBoxTotalBayar.Name = "textBoxTotalBayar";
            this.textBoxTotalBayar.Size = new System.Drawing.Size(370, 20);
            this.textBoxTotalBayar.TabIndex = 5;
            // 
            // comboBoxPromo
            // 
            this.comboBoxPromo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPromo.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPromo.FormattingEnabled = true;
            this.comboBoxPromo.Location = new System.Drawing.Point(39, 656);
            this.comboBoxPromo.Name = "comboBoxPromo";
            this.comboBoxPromo.Size = new System.Drawing.Size(393, 34);
            this.comboBoxPromo.TabIndex = 6;
            // 
            // comboBoxMetodeBayar
            // 
            this.comboBoxMetodeBayar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMetodeBayar.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMetodeBayar.FormattingEnabled = true;
            this.comboBoxMetodeBayar.Location = new System.Drawing.Point(39, 745);
            this.comboBoxMetodeBayar.Name = "comboBoxMetodeBayar";
            this.comboBoxMetodeBayar.Size = new System.Drawing.Size(393, 34);
            this.comboBoxMetodeBayar.TabIndex = 7;
            // 
            // comboBoxKurir
            // 
            this.comboBoxKurir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKurir.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxKurir.FormattingEnabled = true;
            this.comboBoxKurir.Location = new System.Drawing.Point(39, 834);
            this.comboBoxKurir.Name = "comboBoxKurir";
            this.comboBoxKurir.Size = new System.Drawing.Size(393, 34);
            this.comboBoxKurir.TabIndex = 8;
            // 
            // buttonBayar
            // 
            this.buttonBayar.AutoSize = true;
            this.buttonBayar.BackColor = System.Drawing.Color.Transparent;
            this.buttonBayar.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Button_Leave;
            this.buttonBayar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBayar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBayar.FlatAppearance.BorderSize = 0;
            this.buttonBayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.buttonBayar.ForeColor = System.Drawing.Color.White;
            this.buttonBayar.Location = new System.Drawing.Point(39, 918);
            this.buttonBayar.Name = "buttonBayar";
            this.buttonBayar.Size = new System.Drawing.Size(393, 45);
            this.buttonBayar.TabIndex = 9;
            this.buttonBayar.Text = "Bayar";
            this.buttonBayar.UseVisualStyleBackColor = false;
            this.buttonBayar.Click += new System.EventHandler(this.buttonBayar_Click);
            // 
            // FormCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Checkout_Belanja;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(467, 1018);
            this.Controls.Add(this.buttonBayar);
            this.Controls.Add(this.comboBoxKurir);
            this.Controls.Add(this.comboBoxMetodeBayar);
            this.Controls.Add(this.comboBoxPromo);
            this.Controls.Add(this.textBoxTotalBayar);
            this.Controls.Add(this.textBoxOngkosKirim);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxAlamat);
            this.DoubleBuffered = true;
            this.Name = "FormCheckout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCheckout";
            this.Load += new System.EventHandler(this.FormCheckout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.TextBox textBoxOngkosKirim;
        private System.Windows.Forms.TextBox textBoxTotalBayar;
        private System.Windows.Forms.ComboBox comboBoxPromo;
        private System.Windows.Forms.ComboBox comboBoxMetodeBayar;
        private System.Windows.Forms.ComboBox comboBoxKurir;
        private System.Windows.Forms.Button buttonBayar;
    }
}