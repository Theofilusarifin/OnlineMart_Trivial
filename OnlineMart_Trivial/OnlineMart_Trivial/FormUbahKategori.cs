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
    public partial class FormUbahKategori : Form
    {
        public static int IdDipilih;

        public FormUbahKategori()
        {
            InitializeComponent();
        }

        Kategori k = null;

        private void FormUbahKategori_Load(object sender, EventArgs e)
        {
            //Ambil data yang sesuai id
            k = Kategori.AmbilData(IdDipilih);

            //Tampilkan data di text box
            textBoxNama.Text = k.Nama;
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                //Ubah menjadi data baru
                k.Nama = textBoxNama.Text;
                Kategori.UbahData(k);

                MessageBox.Show("Perubahan berhasil tersimpan!", "Info");

                // Update Data Di Form Daftar
                FormDaftarKategori frm = (FormDaftarKategori)this.Owner;
                frm.FormDaftarKategori_Load(sender, e);

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Penyimpanan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        #region DesignButton
        private void buttonUbah_MouseEnter(object sender, EventArgs e)
        {
            buttonUbah.BackgroundImage = Properties.Resources.Button_Hover;
        }
        private void buttonUbah_MouseLeave(object sender, EventArgs e)
        {
            buttonUbah.BackgroundImage = Properties.Resources.Button_Leave;
        }
        #endregion
    }
}
