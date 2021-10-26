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
    public partial class FormDaftarBarang : Form
    {
        public FormDaftarBarang()
        {
            InitializeComponent();
        }

        public List<Barang> listBarang = new List<Barang>();

        private void FormDaftarBarang_Load(object sender, EventArgs e)
        {
            /*listBarang = Barang.BacaData("", "");

            if(listBarang.Count > 0)
            {
                dataGridViewBarang.DataSource = listBarang;

                if(!dataGridViewBarang.Columns.Contains("btnUbahGrid"))
                {
                    DataGridViewButtonColumn bcolUbah = new DataGridViewButtonColumn();

                    bcolUbah.HeaderText = "Aksi";
                    bcolUbah.Text = "Ubah";
                    bcolUbah.Name = "btnUbahGrid";
                    bcolUbah.UseColumnTextForButtonValue = true;
                    dataGridViewBarang.Columns.Add(bcolUbah);


                    DataGridViewButtonColumn bcolHapus = new DataGridViewButtonColumn();

                    bcolHapus.HeaderText = "Aksi";
                    bcolHapus.Text = "Hapus";
                    bcolHapus.Name = "btnHapusGrid";
                    bcolHapus.UseColumnTextForButtonValue = true;
                    dataGridViewBarang.Columns.Add(bcolHapus);
                }
            }
            else
            {
                dataGridViewBarang.DataSource = null;
            }*/
        }
    }
}
