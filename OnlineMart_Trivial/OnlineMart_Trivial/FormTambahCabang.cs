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
    public partial class FormTambahCabang : Form
    {
        public FormTambahCabang()
        {
            InitializeComponent();
        }

        List<Pegawai> listPegawai = new List<Pegawai>();

        private void FormTambahCabang_Load(object sender, EventArgs e)
        {
            listPegawai = Pegawai.BacaData("", "");

            comboBoxPegawai.DataSource = listPegawai;
            comboBoxPegawai.DisplayMember = "nama";

            comboBoxPegawai.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                Pegawai pegawai = (Pegawai)comboBoxPegawai.SelectedItem;

                Cabang cabang = new Cabang(textBoxNama.Text, textBoxAlamat.Text, pegawai);

                Cabang.TambahData(cabang);

                MessageBox.Show("Data Barang berhasil ditambahkan", "Informasi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Barang gagal ditambahkan. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
    }
}
