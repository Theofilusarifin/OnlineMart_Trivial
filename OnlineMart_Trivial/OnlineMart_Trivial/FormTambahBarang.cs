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
    public partial class FormTambahBarang : Form
    {
        public FormTambahBarang()
        {
            InitializeComponent();
        }

        List<Kategori> listKategori = new List<Kategori>();

        private void FormTambahBarang_Load(object sender, EventArgs e)
        {
            listKategori = Kategori.BacaData("", "");

            comboBoxKategori.DataSource = listKategori;
            comboBoxKategori.DisplayMember = "Nama";

            comboBoxKategori.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                Kategori kategori = (Kategori)comboBoxKategori.SelectedItem;

                Barang barang = new Barang(textBoxNama.Text, int.Parse(textBoxHarga.Text), kategori);

                Barang.TambahData(barang);

                MessageBox.Show("Data Barang berhasil ditambahkan", "Informasi");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Data Barang gagal ditambahkan. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
    }
}
