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
        public List<Barang> listBarang = new List<Barang>();
        
        public FormDaftarBarang()
        {
            InitializeComponent();
        }

        private void FormatDataGrid()
        {
            //Kosongi semua kolom di datagridview
            dataGridView.Columns.Clear();

            //Menambah kolom di datagridview
            dataGridView.Columns.Add("id", "Id");
            dataGridView.Columns.Add("nama", "Nama Barang");
            dataGridView.Columns.Add("harga", "Harga Barang");
            dataGridView.Columns.Add("kategori_id", "Kategori");

            //Agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridView.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["kategori_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            //Kosongi isi datagridview
            dataGridView.Rows.Clear();

            if (listBarang.Count > 0)
            {
                foreach (Barang b in listBarang)
                {
                    dataGridView.Rows.Add(b.Id, b.Nama, b.Harga, b.Kategori.Nama);
                }
            }
            else
            {
                dataGridView.DataSource = null;
            }

            //Tampilkan button Ubah dan Hapus
            if (!dataGridView.Columns.Contains("btnUbahGrid"))
            {
                DataGridViewButtonColumn bcolUbah = new DataGridViewButtonColumn();

                bcolUbah.HeaderText = "Aksi";
                bcolUbah.Text = "Ubah";
                bcolUbah.Name = "btnUbahGrid";
                bcolUbah.UseColumnTextForButtonValue = true;
                dataGridView.Columns.Add(bcolUbah);

                DataGridViewButtonColumn bcolHapus = new DataGridViewButtonColumn();

                bcolHapus.HeaderText = "Aksi";
                bcolHapus.Text = "Hapus";
                bcolHapus.Name = "btnHapusGrid";
                bcolHapus.UseColumnTextForButtonValue = true;
                dataGridView.Columns.Add(bcolHapus);
            }
        }

        private void FormDaftarBarang_Load(object sender, EventArgs e)
        {
            //Panggil Method untuk menambah kolom pada datagridview
            FormatDataGrid();

            //Tampilkan semua data
            listBarang = Barang.BacaData("", "");

            //Tampilkan semua isi list di datagridview (Panggil method TampilDataGridView)
            TampilDataGrid();
        }

        private void textBoxKriteria_TextChanged(object sender, EventArgs e)
        {
            string kriteria = "";
            switch (comboBoxKriteria.Text)
            {
                case "Id":
                    kriteria = "B.id";
                    break;

                case "Nama":
                    kriteria = "B.nama";
                    break;

                case "Harga":
                    kriteria = "B.harga";
                    break;

                case "Kategori":
                    kriteria = "K.nama";
                    break;
            }

            listBarang = Barang.BacaData(kriteria, textBoxKriteria.Text);
            FormatDataGrid();
            TampilDataGrid();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahBarang tambah = new FormTambahBarang();
            tambah.Owner = this;
            tambah.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Menghapus data bila button hapus diklik
            int id = int.Parse(dataGridView.CurrentRow.Cells["Id"].Value.ToString());
            

            //Kalau button hapus diklik
            if (e.ColumnIndex == dataGridView.Columns["btnHapusGrid"].Index && e.RowIndex >= 0)
            {
                string idHapus = dataGridView.CurrentRow.Cells["Id"].Value.ToString();
                string namaHapus = dataGridView.CurrentRow.Cells["Nama"].Value.ToString();

                //User ditanya sesuai dibawah
                DialogResult hasil = MessageBox.Show(this, "Anda yakin akan menghapus Id " + idHapus + " - " + namaHapus + "?",
                                                     "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Kalau User klik yes barang akan dihapus
                if(hasil == DialogResult.Yes)
                {
                    Boolean hapus = Barang.HapusData(id);

                    if (hapus == true)
                    {
                        MessageBox.Show("Penghapusan data berhasil");
                    }
                    else
                    {
                        MessageBox.Show("Penghapusan data gagal");
                    }
                }
                
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void buttonClose_MouseEnter(object sender, EventArgs e)
        {

        }

        private void buttonClose_Leave(object sender, EventArgs e)
        {

        }

        
    }
}
