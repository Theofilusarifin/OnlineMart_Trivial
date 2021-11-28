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
    public partial class FormDaftarBarangCabang : Form
    {
        public FormDaftarBarangCabang()
        {
            InitializeComponent();
        }

        public static List<Barang_Cabang> listBarangCabang = new List<Barang_Cabang>();

        #region Methods
        private void FormatDataGrid()
        {
            //Kosongi semua kolom di datagridview
            dataGridView.Columns.Clear();

            //Menambah kolom di datagridview
            dataGridView.Columns.Add("cabang_id", "Id Cabang");
            dataGridView.Columns.Add("cabang_nama", "Nama Cabang");
            dataGridView.Columns.Add("barang_id", "Id Barang");
            dataGridView.Columns.Add("barang_nama", "Nama Barang");
            dataGridView.Columns.Add("stok", "Stok");

            //Agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridView.Columns["cabang_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["cabang_nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["barang_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["barang_nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["stok"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            //Kosongi isi datagridview
            dataGridView.Rows.Clear();

            if (listBarangCabang.Count > 0)
            {
                foreach (Barang_Cabang bc in listBarangCabang)
                {
                    dataGridView.Rows.Add(bc.Cabang.Id,bc.Cabang.Nama, bc.Barang.Id, bc.Barang.Nama, bc.Stok);
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

        #endregion

        #region FormLoad
        public void FormDaftarBarangCabang_Load(object sender, EventArgs e)
        {
            try
            {
                //Panggil Method untuk menambah kolom pada datagridview
                FormatDataGrid();

                //Tampilkan semua data
                listBarangCabang = Barang_Cabang.BacaData("", "");

                //Tampilkan semua isi list di datagridview (Panggil method TampilDataGridView)
                TampilDataGrid();

                comboBoxKriteria.Text = "Nama Barang";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
        #endregion

        #region Datagridview
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = int.Parse(dataGridView.CurrentRow.Cells["id"].Value.ToString());

                //Kalau button ubah diklik
                if (e.ColumnIndex == dataGridView.Columns["btnUbahGrid"].Index && e.RowIndex >= 0)
                {
                    FormUbahBarangCabang.IdBarangDipilih = id;
                    FormUbahBarangCabang.IdCabangDipilih= id;
                    FormUbahBarangCabang frm = new FormUbahBarangCabang();
                    frm.Owner = this;
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
        #endregion

        #region ButtonSearch
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string kriteria = "";
            switch (comboBoxKriteria.Text)
            {
                case "Nama Cabang":
                    kriteria = "c.nama";
                    break;

                case "Nama Barang":
                    kriteria = "b.nama";
                    break;

                case "Stok":
                    kriteria = "bc.stok";
                    break;
            }

            listBarangCabang = Barang_Cabang.BacaData(kriteria, textBoxKriteria.Text);
            FormatDataGrid();
            TampilDataGrid();
        }
        #endregion

        #region Button
        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahBarangCabang tambah = new FormTambahBarangCabang();
            tambah.Owner = this;
            tambah.Show();
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Desain Button
        private void buttonClose_MouseEnter(object sender, EventArgs e)
        {
            buttonClose.BackgroundImage = Properties.Resources.Button_Hover;
        }
        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.BackgroundImage = Properties.Resources.Button_Leave;
        }
        private void buttonSearch_MouseEnter(object sender, EventArgs e)
        {
            buttonSearch.BackgroundImage = Properties.Resources.Button_Hover;
        }
        private void buttonSearch_MouseLeave(object sender, EventArgs e)
        {
            buttonSearch.BackgroundImage = Properties.Resources.Button_Leave;
        }
        private void buttonTambah_MouseEnter(object sender, EventArgs e)
        {
            buttonTambah.BackgroundImage = Properties.Resources.Button_Hover;
        }
        private void buttonTambah_MouseLeave(object sender, EventArgs e)
        {
            buttonTambah.BackgroundImage = Properties.Resources.Button_Leave;
        }
        #endregion
    }
}
