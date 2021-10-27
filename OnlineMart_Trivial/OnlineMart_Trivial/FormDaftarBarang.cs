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
            listBarang = Barang.BacaData("", "");

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
            }
        }

        private void dataGridViewBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridViewBarang.CurrentRow.Cells["IdBarang"].Value.ToString();

            if(e.ColumnIndex == dataGridViewBarang.Columns["btnHapusGrid"].Index && e.RowIndex >= 0)
            {
                string idHapus = dataGridViewBarang.CurrentRow.Cells["IdBarang"].Value.ToString();
                string namaHapus = dataGridViewBarang.CurrentRow.Cells["Nama"].Value.ToString();

                DialogResult hasil = MessageBox.Show(this, "Anda yakin akan menghapus " + idHapus + "-" + namaHapus + "?",
                                                     "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(hasil == DialogResult.Yes)
                {
                    Boolean hapus = Kategori.HapusData(id);

                    if(hapus == true)
                    {
                        MessageBox.Show("Penghapusan data berhasil");

                        // FormDaftarBarang_Load()
                    }
                    else
                    {
                        MessageBox.Show("Penghapusan data gagal");
                    }
                }
            }
        }
    }
}
