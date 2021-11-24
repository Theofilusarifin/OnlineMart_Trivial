using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineMart_LIB;

namespace OnlineMart_Trivial
{
    public partial class FormUbahMetodePembayaran : Form
    {
        public static int IdDipilih;
        public FormUbahMetodePembayaran()
        {
            InitializeComponent();
        }
        Metode_pembayaran m = null;

        private void buttonUbah_Click(object sender, EventArgs e)
		{
            try
            {
                //Ubah menjadi data baru
                m.Nama = textBoxNama.Text;
                Metode_pembayaran.UbahData(m);

                MessageBox.Show("Perubahan berhasil tersimpan!", "Info");

                // Update Data Di Form Daftar
                FormDaftarMetodePembayaran frm = (FormDaftarMetodePembayaran)this.Owner;
                frm.FormDaftarMetodePembayaran_Load_1(sender, e);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Penyimpanan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

		private void FormUbahMetodePembayaran_Load(object sender, EventArgs e)
		{
            //Ambil data yang sesuai id
            m = Metode_pembayaran.AmbilData(IdDipilih);

            //Tampilkan data di text box
            textBoxNama.Text = m.Nama;
        }

        #region DesignButton
        private void buttonUbah_MouseEnter_1(object sender, EventArgs e)
        {
            buttonUbah.BackgroundImage = Properties.Resources.Button_Hover;
        }
        private void buttonUbah_MouseLeave_1(object sender, EventArgs e)
        {
            buttonUbah.BackgroundImage = Properties.Resources.Button_Leave;
        }
        #endregion
    }
}
