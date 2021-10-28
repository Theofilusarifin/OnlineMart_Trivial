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

        List<Kategori> listKategori = new List<Kategori>();

        private void FormTambahCabang_Load(object sender, EventArgs e)
        {
            listKategori = Kategori.BacaData("", "");

            comboBoxPegawai.DataSource = listKategori;
            comboBoxPegawai.DisplayMember = "Nama";

            comboBoxPegawai.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {

        }
    }
}
