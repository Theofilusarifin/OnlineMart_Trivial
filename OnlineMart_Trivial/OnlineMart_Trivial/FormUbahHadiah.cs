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
    public partial class FormUbahHadiah : Form
    {
        public static int IdDipilih;
        public FormUbahHadiah()
        {
            InitializeComponent();
        }

        Gift g = null;

        private void buttonUbah_Click(object sender, EventArgs e)
		{
            try
            {
                //Ubah menjadi data baru
                g.Nama = textBoxNama.Text;
                g.JumlahPoin = int.Parse(textBoxHarga.Text);
                Gift.UbahData(g, FormUtama.koneksi);

                MessageBox.Show("Perubahan berhasil tersimpan!", "Info");

                // Update Data Di Form Daftar
                FormDaftarHadiah frm = (FormDaftarHadiah)this.Owner;
                frm.FormDaftarGift_Load(sender, e);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Penyimpanan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

		private void FormUbahHadiah_Load(object sender, EventArgs e)
		{
            //Ambil data yang sesuai id
            g = Gift.AmbilData(IdDipilih);

            //Tampilkan data di text box
            textBoxNama.Text = g.Nama;
            textBoxHarga.Text = g.JumlahPoin.ToString();
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
