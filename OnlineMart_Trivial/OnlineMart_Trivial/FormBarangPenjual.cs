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
using System.IO;

namespace OnlineMart_Trivial
{
	public partial class FormBarangPenjual : Form
	{
		public FormBarangPenjual()
		{
			InitializeComponent();
		}

        public static List<Penjual> listPenjual = new List<Penjual>();
        public static List<Barang_Penjual> listBarangPenjual = new List<Barang_Penjual>();
        public static Penjual pDipilih = Penjual.AmbilPertama();

        public static Barang barang;
        Penjual penjual;

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

            DataGridViewImageColumn dgvimgcol = new DataGridViewImageColumn();
            dgvimgcol.HeaderText = "Gambar Barang";
            dgvimgcol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView.Columns.Add(dgvimgcol);
            dataGridView.RowTemplate.Height = 110;

            dataGridView.Columns.Add("harga", "Harga Barang");
            dataGridView.Columns.Add("stok", "Stok Barang");
            dataGridView.Columns.Add("kategori_id", "Kategori");

            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 142, 123);
            dataGridView.EnableHeadersVisualStyles = false;

            //Agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridView.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["stok"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
                foreach (Barang_Penjual bp in listBarangPenjual)
                {
                    string path = Path.Combine(FormUtama.location + "\\barang\\", bp.Barang.Path_gambar);
                    //MessageBox.Show(path);
                    PictureBox image = new PictureBox();
                    image.Image = Image.FromFile(path);

                    MemoryStream mmst = new MemoryStream();
                    image.Image.Save(mmst, image.Image.RawFormat);
                    byte[] img = mmst.ToArray();

                    dataGridView.Rows.Add(bp.Barang.Id, bp.Barang.Nama, img, bp.Barang.Harga, bp.Stok, bp.Barang.Kategori.Nama);
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

                bcolTambahKeranjang.HeaderText = "Add to cart";
                bcolTambahKeranjang.Text = "Masukkan";
                bcolTambahKeranjang.Name = "btnTambahKeranjang";
                bcolTambahKeranjang.UseColumnTextForButtonValue = true;
                bcolTambahKeranjang.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dataGridView.Columns.Add(bcolTambahKeranjang);
            }

            if (!dataGridView.Columns.Contains("btnLihatDetailBarang"))
            {
                //Button tambah ke keranjang
                DataGridViewButtonColumn bcolLihatDetail = new DataGridViewButtonColumn();

                bcolLihatDetail.HeaderText = "Detail barang";
                bcolLihatDetail.Text = "Lihat detail!";
                bcolLihatDetail.Name = "btnLihatDetailBarang";
                bcolLihatDetail.UseColumnTextForButtonValue = true;
                bcolLihatDetail.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dataGridView.Columns.Add(bcolLihatDetail);
            }
        }
        #endregion

        #region Button Search
        private void buttonSearch_Click_1(object sender, EventArgs e)
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

            listBarangPenjual = Barang_Penjual.BacaData(kriteria, textBoxKriteria.Text, pDipilih);

            FormatDataGrid();
            TampilDataGrid();
        }
		#endregion

        #region Form Load
		private void FormBarangPenjual_Load(object sender, EventArgs e)
		{
            try
            {
                //Panggil Method untuk menambah kolom pada datagridview
                FormatDataGrid();

                //Tampilkan semua data
                listBarangPenjual = Barang_Penjual.BacaData("", "", pDipilih);

                //Tampilkan semua isi list di datagridview (Panggil method TampilDataGridView)
                TampilDataGrid();

                listPenjual = Penjual.BacaData("", "");
                comboBoxKriteria.Text = "Id";
                comboBoxPenjual.DataSource = listPenjual;
                comboBoxPenjual.DisplayMember = "nama";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error. Pesan kesalahan : " + ex.Message, "Error");
            }
        }
		#endregion

        #region Button Close
		private void buttonClose_Click_1(object sender, EventArgs e)
		{
            this.Close();
        }
		#endregion

        #region Datagrid
		private void dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{
            try
            {
                int id = int.Parse(dataGridView.CurrentRow.Cells["id"].Value.ToString());
                Barang b = Barang.AmbilData(id);
                if (e.ColumnIndex == dataGridView.Columns["btnLihatDetailBarang"].Index && e.RowIndex >= 0)
                {
                    FormDetailBarang.barangDipilih = b;
                    FormDetailBarang formDetailBarang = new FormDetailBarang();
                    formDetailBarang.Owner = this;
                    formDetailBarang.ShowDialog();
                    this.Hide();
                }
                if (e.ColumnIndex == dataGridView.Columns["btnTambahKeranjang"].Index && e.RowIndex >= 0)
                {
                    if (FormUtama.keranjang.Count == 0)
                    {
                        FormUtama.pDipilih = pDipilih;
                    }
                    if (penjual.Id == FormUtama.pDipilih.Id)
                    {
                        FormUtama.keranjang.Add(b); //Untuk menambahkan barang ke dalam keranjang
                        MessageBox.Show("Barang berhasil di tambahkan ke dalam keranjang");

                        if (FormUtama.pilihVendor == "")
                        {
                            FormUtama.pilihVendor = "penjual";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hanya bisa menambahkan barang dari satu Penjual sama yang telah dipilih.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
		#endregion

		#region Combo box Penjual
		private void comboBoxPenjual_SelectedIndexChanged(object sender, EventArgs e)
		{
            penjual = (Penjual)comboBoxPenjual.SelectedItem;
            listBarangPenjual = Barang_Penjual.BacaData("", "", pDipilih);

            FormatDataGrid();
            TampilDataGrid();
        }
        #endregion;

    }
}
