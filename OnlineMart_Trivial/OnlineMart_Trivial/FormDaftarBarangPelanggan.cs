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
    public partial class FormDaftarBarangPelanggan : Form
    {
        public FormDaftarBarangPelanggan()
        {
            InitializeComponent();
        }

        public static List<Barang> listBarang = new List<Barang>();
        public static List<Cabang> listCabang = new List<Cabang>();
        public static List<Barang_Cabang> listBarangCabang = new List<Barang_Cabang>();
        public static List<Barang_Penjual> listBarangPenjual = new List<Barang_Penjual>();
        public static Cabang cDipilih = Cabang.AmbilPertama();


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
            try
            {

                //Kosongi isi datagridview
                dataGridView.Rows.Clear();

                if (listBarangCabang.Count > 0)
                {
                    foreach (Barang_Cabang bc in listBarangCabang)
                    {
                        string path = Path.Combine(FormUtama.location + "\\barang\\", bc.Barang.Path_gambar);
                        //MessageBox.Show(path);
                        PictureBox image = new PictureBox();
                        image.Image = Image.FromFile(path);

                        MemoryStream mmst = new MemoryStream();
                        image.Image.Save(mmst, image.Image.RawFormat);
                        byte[] img = mmst.ToArray();

                        dataGridView.Rows.Add(bc.Barang.Id, bc.Barang.Nama, img, bc.Barang.Harga, bc.Stok, bc.Barang.Kategori.Nama);
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
                    bcolLihatDetail.Text = "Lihat detail";
                    bcolLihatDetail.Name = "btnLihatDetailBarang";
                    bcolLihatDetail.UseColumnTextForButtonValue = true;
                    bcolLihatDetail.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                    dataGridView.Columns.Add(bcolLihatDetail);
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show("Harap Ubah Varibel Path pada Form Utama menjadi Path Resource Online Mart pada komputer lokal anda", "Informasi");
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
                comboBoxVendor.DataSource = listCabang;
                comboBoxVendor.DisplayMember = "nama";

                comboBoxVendor.DropDownStyle = ComboBoxStyle.DropDownList;

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
            cDipilih = (Cabang)comboBoxVendor.SelectedItem;
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
                Barang b = Barang.AmbilData(id);
                //Kalau button Tambah ke keranjang diklik
                if (e.ColumnIndex == dataGridView.Columns["btnTambahKeranjang"].Index && e.RowIndex >= 0)
                {
                    if (FormUtama.keranjang.Count == 0)
                    {
                        FormUtama.cDipilih = cDipilih;
                    }
                    if (cDipilih.Nama == FormUtama.cDipilih.Nama)
                    {
                        FormUtama.keranjang.Add(b); //Untuk menambahkan barang ke dalam keranjang
                        MessageBox.Show("Barang berhasil di tambahkan ke dalam keranjang");
                    }
                    else
                    {
                        MessageBox.Show("Hanya bisa menambahkan barang dari satu cabang sama yang telah dipilih.");
                    }
                }
                if (e.ColumnIndex == dataGridView.Columns["btnLihatDetailBarang"].Index && e.RowIndex >= 0)
				{
                    FormDetailBarang.barang = b;
                    FormDetailBarang formDetailBarang = new FormDetailBarang();
                    formDetailBarang.Owner = this;
                    formDetailBarang.ShowDialog();
                    this.Hide();
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
