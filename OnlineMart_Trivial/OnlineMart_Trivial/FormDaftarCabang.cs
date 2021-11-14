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
    public partial class FormDaftarCabang : Form
    {
        public FormDaftarCabang()
        {
            InitializeComponent();
        }

        public List<Cabang> listCabang = new List<Cabang>();

        #region Methods
        private void FormatDataGrid()
        {
            //Kosongi semua kolom di datagridview
            dataGridView.Columns.Clear();

            //Menambah kolom di datagridview
            dataGridView.Columns.Add("id", "Id");
            dataGridView.Columns.Add("nama", "Nama Cabang");
            dataGridView.Columns.Add("alamat", "Alamat");
            dataGridView.Columns.Add("pegawai_id", "Pegawai");

            //Agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridView.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["alamat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["pegawai_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            //Kosongi isi datagridview
            dataGridView.Rows.Clear();

            if (listCabang.Count > 0)
            {
                foreach (Cabang c in listCabang)
                {
                    dataGridView.Rows.Add(c.Id, c.Nama, c.Alamat, c.Pegawai.Nama);
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
        public void FormDaftarCabang_Load(object sender, EventArgs e)
        {
            try
            {
                // Panggil Method untuk menambah kolom pada datagridview
                FormatDataGrid();

                // Tampilkan semua data
                listCabang = Cabang.BacaData("", "");

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

        #region Textbox
        private void textBoxKriteria_TextChanged(object sender, EventArgs e)
        {
            string kriteria = "";
            switch (comboBoxKriteria.Text)
            {
                case "Id":
                    kriteria = "id";
                    break;

                case "Nama Cabang":
                    kriteria = "nama";
                    break;

                case "Alamat":
                    kriteria = "alamat";
                    break;
            }

            listCabang = Cabang.BacaData(kriteria, textBoxKriteria.Text);
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
                        Boolean hapus = Cabang.HapusData(id);

                        if (hapus == true)
                        {
                            MessageBox.Show("Penghapusan data berhasil");
                            // Refresh Halaman
                            FormDaftarCabang_Load(sender, e);
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
                    FormUbahCabang.IdDipilih = id;
                    FormUbahCabang frm = new FormUbahCabang();
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
        private void buttonTambah_MouseEnter(object sender, EventArgs e)
        {
            buttonTambah.BackgroundImage = Properties.Resources.Button_Hover;
        }

        private void buttonTambah_MouseLeave(object sender, EventArgs e)
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
        #endregion

        #region Button
        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahCabang tambah = new FormTambahCabang();
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
