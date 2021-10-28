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
        public FormUbahBarang()
        {
            InitializeComponent();
        }

        List<Kategori> listKategori = new List<Kategori>();

        private void FormUbahBarang_Load(object sender, EventArgs e)
        {
            listKategori = Kategori.BacaData("", "");

            comboBoxKategori.DataSource = listKategori;
            comboBoxKategori.DisplayMember = "Nama";

            comboBoxKategori.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {

        }
    }
}
