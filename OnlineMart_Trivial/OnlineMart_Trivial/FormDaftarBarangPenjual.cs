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
	public partial class FormDaftarBarangPenjual : Form
	{

		public static List<Barang> listBarangPenjual = new List<Barang>();
        public static Barang barang;

		public FormDaftarBarangPenjual()
        {
			InitializeComponent();
		}

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
            dataGridView.Columns.Add("kategori_id", "Kategori");

            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 142, 123);
            dataGridView.EnableHeadersVisualStyles = false;

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

            if (listBarangPenjual.Count > 0)
            {
                foreach (Barang b in listBarangPenjual)
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
            if (!dataGridView.Columns.Contains("btnLihatDetailBarang"))
            {
                //Button tambah ke keranjang
                DataGridViewButtonColumn bcolLihatDetail = new DataGridViewButtonColumn();

                bcolLihatDetail.HeaderText = "Detail barang";
                bcolLihatDetail.Text = "Lihat detail!";
                bcolLihatDetail.Name = "btnLihatDetailBarang";
                bcolLihatDetail.UseColumnTextForButtonValue = true;
                dataGridView.Columns.Add(bcolLihatDetail);
            }
        }
		#endregion

		#region Form Load
		public void FormDaftarBarangPenjual_Load(object sender, EventArgs e)
		{
            try
            {
                //Panggil Method untuk menambah kolom pada datagridview
                FormatDataGrid();

                //Tampilkan semua data
                listBarangPenjual = Barang.BacaData("", "");

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

		#region Button Search
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

            listBarangPenjual = Barang.BacaData(kriteria, textBoxKriteria.Text);
            FormatDataGrid();
            TampilDataGrid();
        }
		#endregion

		#region Button Tambah
		private void buttonTambah_Click(object sender, EventArgs e)
		{
            FormTambahBarangPenjual formTambahBarangPenjual = new FormTambahBarangPenjual();
            formTambahBarangPenjual.Owner = this;
            formTambahBarangPenjual.ShowDialog();
		}
		#endregion

		#region Button Close
		private void buttonClose_Click(object sender, EventArgs e)
		{
            this.Close();
		}
		#endregion

		#region Datagrid
		private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
            try
            {
                int id = int.Parse(dataGridView.CurrentRow.Cells["id"].Value.ToString());
                Barang b = Barang.AmbilData(id);
                if (e.ColumnIndex == dataGridView.Columns["btnLihatDetailBarang"].Index && e.RowIndex >= 0)
                {
                    FormDetailBarang.barang = b;
                    FormDetailBarang formDetailBarang = new FormDetailBarang();
                    formDetailBarang.Owner = this;
                    formDetailBarang.ShowDialog();
                    this.Hide();
                }
                if (e.ColumnIndex == dataGridView.Columns["btnUbahGrid"].Index && e.RowIndex >= 0)
                {
                    barang = b;
                    FormTambahStok formTambahStok = new FormTambahStok();
                    formTambahStok.Owner = this;
                    formTambahStok.ShowDialog();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
        #endregion

        private void comboBoxKriteria_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

        #region Desain Button
        private void buttonClose_MouseEnter(object sender, EventArgs e)
        {
            buttonClose.BackgroundImage = Properties.Resources.Button_Hover;
        }
        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.BackgroundImage = Properties.Resources.Button_Leave;
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
