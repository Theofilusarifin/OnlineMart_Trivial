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
    public partial class FormDaftarBarangPelanggan : Form
    {
        public FormDaftarBarangPelanggan()
        {
            InitializeComponent();
        }

        public static List<Barang> listBarang = new List<Barang>();
        public static List<Cabang> listCabang = new List<Cabang>();
        public static List<Barang_Cabang> listBarangCabang = new List<Barang_Cabang>();
        private Cabang cDipilih = Cabang.AmbilPertama();

        #region No Tick Constrols
        //Optimized Controls(No Tick)
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        #endregion

        #region Methods
        private void FormatDataGrid()
        {
            //Kosongi semua kolom di datagridview
            dataGridView.Columns.Clear();

            //Menambah kolom di datagridview
            dataGridView.Columns.Add("id", "Id");
            dataGridView.Columns.Add("nama", "Nama Barang");
            dataGridView.Columns.Add("harga", "Harga Barang");
            dataGridView.Columns.Add("stok", "Stok Barang");
            dataGridView.Columns.Add("kategori_id", "Kategori");

            //Agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridView.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["stok"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["kategori_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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
                    dataGridView.Rows.Add(bc.Barang.Id, bc.Barang.Nama, bc.Barang.Harga, bc.Stok, bc.Barang.Kategori.Nama);
                }
            }
            else
            {
                dataGridView.DataSource = null;
            }

            //Tampilkan button Ubah dan Hapus
            if (!dataGridView.Columns.Contains("btnTambahKeranjang"))
            {
                //Button tambah ke keranjang
                DataGridViewButtonColumn bcolTambahKeranjang = new DataGridViewButtonColumn();

                bcolTambahKeranjang.HeaderText = "Masukkan Ke Keranjang";
                bcolTambahKeranjang.Text = "Masukkan";
                bcolTambahKeranjang.Name = "btnTambahKeranjang";
                bcolTambahKeranjang.UseColumnTextForButtonValue = true;
                dataGridView.Columns.Add(bcolTambahKeranjang);
            }
        }
        #endregion

        #region FormLoad
        private void FormDaftarBarangPelanggan_Load(object sender, EventArgs e)
        {
            try
            {
                //Default list semua barang di cabang yang pertama
                listBarangCabang = Barang_Cabang.BacaData(cDipilih.Id.ToString(), "", "");

                //Panggil Method untuk menambah kolom pada datagridview
                FormatDataGrid();

                //Tampilkan semua data Cabang
                listCabang = Cabang.BacaData("", "");
                comboBoxCabang.DataSource = listCabang;
                comboBoxCabang.DisplayMember = "nama";

                comboBoxCabang.DropDownStyle = ComboBoxStyle.DropDownList;

                //Tampilkan semua isi list di datagridview (Panggil method TampilDataGridView)
                TampilDataGrid();

                comboBoxKriteria.Text = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
        #endregion

        #region ComboBoxCabang
        private void comboBoxCabang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cDipilih = (Cabang)comboBoxCabang.SelectedItem;
            listBarangCabang = Barang_Cabang.BacaData(cDipilih.Id.ToString(), "", "");
            FormatDataGrid();
            TampilDataGrid();
        }
        #endregion

        #region ButtonSearch
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string kriteria = "";
            switch (comboBoxKriteria.Text)
            {
                case "Id":
                    kriteria = "b.id";
                    break;

                case "Nama Barang":
                    kriteria = "b.nama";
                    break;

                case "Harga Barang":
                    kriteria = "b.harga";
                    break;
            }

            listBarangCabang = Barang_Cabang.BacaData(cDipilih.Id.ToString(), kriteria, textBoxKriteria.Text);
            FormatDataGrid();
            TampilDataGrid();
        }
        #endregion

        #region Datagrid
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = int.Parse(dataGridView.CurrentRow.Cells["id"].Value.ToString());

                //Kalau button Tambah ke keranjang diklik
                if (e.ColumnIndex == dataGridView.Columns["btnTambahKeranjang"].Index && e.RowIndex >= 0)
                {
                    Barang b = Barang.AmbilData(id);
                    FormUtama.keranjang.Add(b); //Untuk menambahkan barang ke dalam keranjang
                    MessageBox.Show("Barang berhasil di tambahkan ke dalam keranjang");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
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
        #endregion

        #region Button
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
