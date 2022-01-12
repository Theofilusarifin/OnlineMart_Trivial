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
    public partial class FormUbahBarang : Form
    {
		#region Field
		public static int IdDipilih;
        Barang b = null;
		#endregion

		public FormUbahBarang()
        {
            InitializeComponent();
        }

		#region Form Load
		private void FormUbahBarang_Load(object sender, EventArgs e)
        {
            // Masukkan kategori ke textbox
            List<Kategori> listKategori = Kategori.BacaData("", "", FormUtama.koneksi);

            comboBoxKategori.DataSource = listKategori;
            comboBoxKategori.DisplayMember = "Nama";

            comboBoxKategori.DropDownStyle = ComboBoxStyle.DropDownList;

            //Ambil data yang sesuai id
            b = Barang.AmbilData(IdDipilih);

            //Tampilkan data di text box
            textBoxNama.Text = b.Nama;
            textBoxHarga.Text = b.Harga.ToString();
            comboBoxKategori.Text = b.Kategori.Nama;
        }
		#endregion

		#region Button Ubah
		private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                Kategori kDipilih = (Kategori)comboBoxKategori.SelectedItem;
                
                //Ubah menjadi data baru
                b.Nama = textBoxNama.Text;
                b.Harga = int.Parse(textBoxHarga.Text);
                b.Kategori = kDipilih;
                Barang.UbahData(b, FormUtama.koneksi);

                MessageBox.Show("Perubahan berhasil tersimpan!", "Info");

                // Update Data Di Form Daftar
                FormDaftarBarang frm = (FormDaftarBarang)this.Owner;
                frm.FormDaftarBarang_Load(sender, e);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Penyimpanan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
        #endregion

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
