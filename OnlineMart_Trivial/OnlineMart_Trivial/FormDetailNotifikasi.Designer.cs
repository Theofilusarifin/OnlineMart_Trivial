
namespace OnlineMart_Trivial
{
    partial class FormDetailNotifikasi
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(137, 70);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(487, 303);
            this.listBox.TabIndex = 0;
            // 
            // FormDetailNotifikasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox);
            this.Name = "FormDetailNotifikasi";
            this.Text = "FormDetailNotifikasi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDetailNotifikasi_FormClosing);
            this.Load += new System.EventHandler(this.FormDetailNotifikasi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
    }
}