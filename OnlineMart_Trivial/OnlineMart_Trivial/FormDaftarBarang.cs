﻿using System;
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
    public partial class FormDaftarBarang : Form
    {
        public static List<Barang> listBarang = new List<Barang>();
        
        public FormDaftarBarang()
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

            DataGridViewImageColumn dgvimgcol = new DataGridViewImageColumn();
            dgvimgcol.HeaderText = "Gambar Barang";
            dgvimgcol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView.Columns.Add(dgvimgcol);
            dataGridView.RowTemplate.Height = 110;

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
            try
            { 
                //Kosongi isi datagridview
                dataGridView.Rows.Clear();

                if (listBarang.Count > 0)
                {
                    foreach (Barang b in listBarang)
                    {
                        string path = Path.Combine(FormUtama.location + "\\barang\\", b.Path_gambar);
                        //MessageBox.Show(path);
                        PictureBox image = new PictureBox();
                        image.Image = Image.FromFile(path);

                        MemoryStream mmst = new MemoryStream();
                        image.Image.Save(mmst, image.Image.RawFormat);
                        byte[] img = mmst.ToArray();

                        dataGridView.Rows.Add(b.Id, b.Nama, img, b.Harga, b.Kategori.Nama);
                    }
                }
                else
                {
                    dataGridView.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                MessageBox.Show("Harap Ubah Varibel Path pada Form Utama menjadi Path Resource Online Mart pada komputer lokal anda", "Informasi");
            }

            //Tampilkan button Ubah dan Hapus
            if (!dataGridView.Columns.Contains("btnUbahGrid"))
            {
                DataGridViewButtonColumn bcolUbah = new DataGridViewButtonColumn();

                bcolUbah.HeaderText = "Aksi";
                bcolUbah.Text = "Ubah";
                bcolUbah.Name = "btnUbahGrid";
                bcolUbah.UseColumnTextForButtonValue = true;
                bcolUbah.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                dataGridView.Columns.Add(bcolUbah);

                DataGridViewButtonColumn bcolHapus = new DataGridViewButtonColumn();

                bcolHapus.HeaderText = "Aksi";
                bcolHapus.Text = "Hapus";
                bcolHapus.Name = "btnHapusGrid";
                bcolHapus.UseColumnTextForButtonValue = true;
                bcolHapus.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                dataGridView.Columns.Add(bcolHapus);
            }
        }
        #endregion

        #region FormLoad
        public void FormDaftarBarang_Load(object sender, EventArgs e)
        {
            try
            {
                //Panggil Method untuk menambah kolom pada datagridview
                FormatDataGrid();

                //Tampilkan semua data
                listBarang = Barang.BacaData("", "");

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

            listBarang = Barang.BacaData(kriteria, textBoxKriteria.Text);
            FormatDataGrid();
            TampilDataGrid();
        }
        #endregion

        #region DataGrid
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Menghapus data bila button hapus diklik
                int id = int.Parse(dataGridView.CurrentRow.Cells["id"].Value.ToString());

                //Kalau button hapus diklik
                if (e.ColumnIndex == dataGridView.Columns["btnHapusGrid"].Index && e.RowIndex >= 0)
                {
                    string idHapus = dataGridView.CurrentRow.Cells["id"].Value.ToString();
                    string namaHapus = dataGridView.CurrentRow.Cells["nama"].Value.ToString();

                    //User ditanya sesuai dibawah
                    DialogResult hasil = MessageBox.Show(this, "Anda yakin akan menghapus Id " + idHapus + " - " + namaHapus + "?",
                                                         "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //Kalau User klik yes barang akan dihapus
                    if (hasil == DialogResult.Yes)
                    {
                        Boolean hapus = Barang.HapusData(id);

                        if (hapus == true)
                        {
                            MessageBox.Show("Penghapusan data berhasil");
                            // Refresh Halaman
                            FormDaftarBarang_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Penghapusan data gagal");
                        }
                    }
                }
                //Kalau button ubah diklik
                if (e.ColumnIndex == dataGridView.Columns["btnUbahGrid"].Index && e.RowIndex >= 0)
                {
                    FormUbahBarang.IdDipilih = id;
                    FormUbahBarang frm = new FormUbahBarang();
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

        #region Desain Button
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            buttonTambah.BackgroundImage = Properties.Resources.Button_Hover;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            buttonTambah.BackgroundImage = Properties.Resources.Button_Leave;
        }
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
        #endregion
    }
}
