using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineMart_Trivial
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
            //Background Transparant
            //pictureBoxLogo.Parent = pictureBoxBackground;
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            //Ubah form ini (FormUtama) menjadi fullscreen (maximized)
            //this.WindowState = FormWindowState.Maximized;

            //Ubah FormUtama menjadi MdiParent (MdiContainer)
            this.IsMdiContainer = true;

            try
            {
                //Ambil nilai di db setting
                //Koneksi koneksi = new Koneksi(db.Default.DbServer, db.Default.DbName, db.Default.DbUsername, db.Default.DbPassword);
                //MessageBox.Show("Koneksi Berhasil");
            }
            catch (Exception ex)
            {
               //MessageBox.Show("Koneksi Gagal. Pesan Kesalahan : " + ex.Message);
            }
        }
    }
}
