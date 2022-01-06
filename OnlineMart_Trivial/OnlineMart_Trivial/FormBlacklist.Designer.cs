
namespace OnlineMart_Trivial
{
	partial class FormBlacklist
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
			this.textBoxNama = new System.Windows.Forms.TextBox();
			this.textBoxJenis = new System.Windows.Forms.TextBox();
			this.textBoxAlasan = new System.Windows.Forms.TextBox();
			this.buttonTambah = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBoxNama
			// 
			this.textBoxNama.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxNama.Font = new System.Drawing.Font("Montserrat", 12F);
			this.textBoxNama.ForeColor = System.Drawing.Color.DimGray;
			this.textBoxNama.Location = new System.Drawing.Point(47, 256);
			this.textBoxNama.Name = "textBoxNama";
			this.textBoxNama.Size = new System.Drawing.Size(370, 20);
			this.textBoxNama.TabIndex = 1;
			// 
			// textBoxJenis
			// 
			this.textBoxJenis.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxJenis.Font = new System.Drawing.Font("Montserrat", 12F);
			this.textBoxJenis.ForeColor = System.Drawing.Color.DimGray;
			this.textBoxJenis.Location = new System.Drawing.Point(47, 330);
			this.textBoxJenis.Name = "textBoxJenis";
			this.textBoxJenis.Size = new System.Drawing.Size(370, 20);
			this.textBoxJenis.TabIndex = 2;
			// 
			// textBoxAlasan
			// 
			this.textBoxAlasan.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxAlasan.Font = new System.Drawing.Font("Montserrat", 12F);
			this.textBoxAlasan.ForeColor = System.Drawing.Color.DimGray;
			this.textBoxAlasan.Location = new System.Drawing.Point(47, 404);
			this.textBoxAlasan.Name = "textBoxAlasan";
			this.textBoxAlasan.Size = new System.Drawing.Size(370, 20);
			this.textBoxAlasan.TabIndex = 3;
			// 
			// buttonTambah
			// 
			this.buttonTambah.AutoSize = true;
			this.buttonTambah.BackColor = System.Drawing.Color.Transparent;
			this.buttonTambah.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Button_Leave;
			this.buttonTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonTambah.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonTambah.FlatAppearance.BorderSize = 0;
			this.buttonTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
			this.buttonTambah.ForeColor = System.Drawing.Color.White;
			this.buttonTambah.Location = new System.Drawing.Point(37, 465);
			this.buttonTambah.Name = "buttonTambah";
			this.buttonTambah.Size = new System.Drawing.Size(393, 45);
			this.buttonTambah.TabIndex = 4;
			this.buttonTambah.Text = "Blacklist";
			this.buttonTambah.UseVisualStyleBackColor = false;
			this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
			// 
			// FormBlacklist
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Form_Blacklist;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(467, 554);
			this.Controls.Add(this.buttonTambah);
			this.Controls.Add(this.textBoxAlasan);
			this.Controls.Add(this.textBoxJenis);
			this.Controls.Add(this.textBoxNama);
			this.DoubleBuffered = true;
			this.Name = "FormBlacklist";
			this.Text = "FormBlacklist";
			this.Load += new System.EventHandler(this.FormBlacklist_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxNama;
		private System.Windows.Forms.TextBox textBoxJenis;
		private System.Windows.Forms.TextBox textBoxAlasan;
		private System.Windows.Forms.Button buttonTambah;
	}
}