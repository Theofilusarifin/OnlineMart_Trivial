using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OnlineMart_Trivial
{
    public partial class FormCoba : Form
    {
        public FormCoba()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg;*.png)|*.jpg;*.png";

            if(opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);

                string location = @"C:\Users\asus\Documents\GitHub\OnlineMart_Trivial\OnlineMart_Trivial\OnlineMart_Trivial\Resources";

                string fileName = "Tambah Kategori.png";
                string path = Path.Combine(location, fileName);

                pictureBox1.Image = Image.FromFile(path);

                //Image a = pictureBox1.Image;
                //a.Save(path);
                MessageBox.Show(path);
                //MessageBox.Show(op)
            }
        }
    }
}
