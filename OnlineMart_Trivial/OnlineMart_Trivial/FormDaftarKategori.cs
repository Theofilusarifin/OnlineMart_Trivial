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
    public partial class FormDaftarKategori : Form
    {
        public FormDaftarKategori()
        {
            InitializeComponent();
        }

        public List<Kategori> listKategori = new List<Kategori>();
        private void FormDaftarKategori_Load(object sender, EventArgs e)
        {
            listKategori = Kategori.BacaData("", "");

            if(listKategori.Count > 0)
            {
                dataGridViewKategori.DataSource = listKategori;

                if(!dataGridViewKategori.Columns.Contains("btnUbahGrid"))
                {
                    DataGridViewButtonColumn bcolUbah = new DataGridViewButtonColumn();

                    bcolUbah.HeaderText = "Aksi";
                    bcolUbah.Text = "Ubah";
                    bcolUbah.Name = "btnUbahGrid";
                    bcolUbah.UseColumnTextForButtonValue = true;
                    dataGridViewKategori.Columns.Add(bcolUbah);

                    DataGridViewButtonColumn bcolHapus = new DataGridViewButtonColumn();
                    bcolHapus.HeaderText = "Aksi";
                    bcolHapus.Text = "Hapus";
                    bcolHapus.Name = "btnHapusGrid";
                    bcolHapus.UseColumnTextForButtonValue = true;
                    dataGridViewKategori.Columns.Add(bcolHapus);
                }
            }
            else
            {
                dataGridViewKategori = null;
            }
        }
    }
}
