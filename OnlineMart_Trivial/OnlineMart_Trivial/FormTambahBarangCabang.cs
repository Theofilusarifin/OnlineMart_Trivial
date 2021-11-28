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
    public partial class FormTambahBarangCabang : Form
    {
        public FormTambahBarangCabang()
        {
            InitializeComponent();
        }

        List<Barang> listBarang = new List<Barang>();
        List<Cabang> listCabang = new List<Cabang>();

        private void FormTambahBarangCabang_Load(object sender, EventArgs e)
        {
            listBarang = Barang.BacaData("", "");
            comboBoxBarang.DataSource = listBarang;
            comboBoxBarang.DisplayMember = "Nama";
            comboBoxBarang.DropDownStyle = ComboBoxStyle.DropDownList;

            listCabang = Cabang.BacaData("", "");
            comboBoxCabang.DataSource = listBarang;
            comboBoxCabang.DisplayMember = "Nama";
            comboBoxCabang.DropDownStyle = ComboBoxStyle.DropDownList;

            textBoxStok.Focus();
        }
        private void buttonTambah_Click(object sender, EventArgs e)
        {
            Barang barang = (Barang)comboBoxBarang.SelectedItem;

            Cabang cabang = (Cabang)comboBoxCabang.SelectedItem;

            Barang_Cabang bc = new Barang_Cabang(cabang, barang, int.Parse(textBoxStok.Text));

            Barang_Cabang.TambahData(bc);

            MessageBox.Show("Data Barang Cabang berhasil ditambahkan", "Informasi");
        }
    }
}
