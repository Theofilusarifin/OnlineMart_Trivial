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

		private void buttonUbah_Click(object sender, EventArgs e)
		{
            try
            {
                Gift g = Gift.AmbilData(IdDipilih, FormUtama.koneksi);

                //Ubah menjadi data baru
                g.Nama = textBoxNama.Text;
                g.JumlahPoin = int.Parse(textBoxHarga.Text);
                Gift.UbahData(g);

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
            Gift g = Gift.AmbilData(IdDipilih, FormUtama.koneksi);

            //Tampilkan data di text box
            textBoxNama.Text = g.Nama;
            textBoxHarga.Text = g.JumlahPoin.ToString();
        }
	}
}
