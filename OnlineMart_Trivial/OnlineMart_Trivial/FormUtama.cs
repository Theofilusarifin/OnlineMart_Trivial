using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Tambahkan using reference
using OnlineMart_LIB;

namespace OnlineMart_Trivial
{
    public partial class FormUtama : Form
    {
        public static string role;

        public FormUtama()
        {
            InitializeComponent();
        }

        #region No Tick Constrols
        //Optimized Controls (No Tick)
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;

                return cp;
            }
        }
        #endregion

        private void FormUtama_Load(object sender, EventArgs e)
        {
            //Ubah form ini (FormUtama) menjadi fullscreen (maximized)
            this.WindowState = FormWindowState.Maximized;

            //Ubah FormUtama menjadi MdiParent (MdiContainer)
            this.IsMdiContainer = true;

            try
            {
                //Ambil nilai di db setting
                Koneksi koneksi = new Koneksi();
                //MessageBox.Show("Koneksi Berhasil");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi Gagal. Pesan Kesalahan : " + ex.Message);
            }
        }

        #region OpenFormAuth
        int opening = 0;
        private void timerOpening_Tick(object sender, EventArgs e)
        {
            opening++;
            if (opening == 1)
            {
                FormAuth frm = new FormAuth(); //Create Object FormDaftarKategori
                frm.MdiParent = this; //Set form utama menjadi parent dari objek form yang dibuat
                frm.Show(); //Tampilkan form
                // Method ShowDialog() tidak bisa digunakan jika menerapkan MdiParent, bisanya Method Show();
                timerOpening.Stop();
            }
        }
        #endregion
    }
}
