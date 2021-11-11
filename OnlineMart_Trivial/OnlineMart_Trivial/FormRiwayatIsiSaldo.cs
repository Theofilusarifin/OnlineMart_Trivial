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
    public partial class FormRiwayatIsiSaldo : Form
    {
        public FormRiwayatIsiSaldo()
        {
            InitializeComponent();
        }
        public List<Riwayat_isi_saldo> listRiwayat = new List<Riwayat_isi_saldo>();

        #region Methods

        private void FormatDataGrid()
        {
            //Kosongi semua kolom di datagridview
            dataGridViewRiwayat.Columns.Clear();

            //Menambah kolom di datagridview
            dataGridViewRiwayat.Columns.Add("id", "Id");
            dataGridViewRiwayat.Columns.Add("waktu", "Waktu");
            dataGridViewRiwayat.Columns.Add("isiSaldo", "Isi Saldo");
            dataGridViewRiwayat.Columns.Add("pelanggan_id", "Pelanggan");

            //Agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridViewRiwayat.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewRiwayat.Columns["waktu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewRiwayat.Columns["isiSaldo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewRiwayat.Columns["pelanggan_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridViewRiwayat.AllowUserToAddRows = false;
            dataGridViewRiwayat.ReadOnly = true;
        }
        private void TampilDataGrid()
        {
            //Kosongi isi datagridview
            dataGridViewRiwayat.Rows.Clear();

            if (listRiwayat.Count > 0)
            {
                foreach (Riwayat_isi_saldo r in listRiwayat)
                {
                    dataGridViewRiwayat.Rows.Add(r.Id, r.Waktu, r.IsiSaldo, r.Pelanggan.Id);
                }
            }
            else
            {
                dataGridViewRiwayat.DataSource = null;
            }

            //Tampilkan button Ubah dan Hapus
            if (!dataGridViewRiwayat.Columns.Contains("btnUbahGrid"))
            {
                DataGridViewButtonColumn bcolUbah = new DataGridViewButtonColumn();

                bcolUbah.HeaderText = "Aksi";
                bcolUbah.Text = "Ubah";
                bcolUbah.Name = "btnUbahGrid";
                bcolUbah.UseColumnTextForButtonValue = true;
                bcolUbah.FlatStyle = FlatStyle.Flat;
                dataGridViewRiwayat.Columns.Add(bcolUbah);

                DataGridViewButtonColumn bcolHapus = new DataGridViewButtonColumn();

                bcolHapus.HeaderText = "Aksi";
                bcolHapus.Text = "Hapus";
                bcolHapus.Name = "btnHapusGrid";
                bcolHapus.UseColumnTextForButtonValue = true;
                bcolHapus.FlatStyle = FlatStyle.Flat;

                dataGridViewRiwayat.Columns.Add(bcolHapus);

                //Button tambah ke keranjang
                DataGridViewButtonColumn bcolTambahKeranjang = new DataGridViewButtonColumn();

                bcolTambahKeranjang.HeaderText = "Aksi";
                bcolTambahKeranjang.Text = "Tambahkan ke keranjang";
                bcolTambahKeranjang.Name = "btnTambahKeranjang";
                bcolTambahKeranjang.UseColumnTextForButtonValue = true;
                bcolTambahKeranjang.FlatStyle = FlatStyle.Flat;
                bcolTambahKeranjang.DefaultCellStyle.Font = new Font("Montserrat", 9, FontStyle.Bold);
                bcolTambahKeranjang.DefaultCellStyle.ForeColor = Color.White;
                bcolTambahKeranjang.DefaultCellStyle.BackColor = Color.FromArgb(227, 65, 35);

                dataGridViewRiwayat.Columns.Add(bcolTambahKeranjang);
            }
            #endregion
        }

        private void FormRiwayatIsiSaldo_Load(object sender, EventArgs e)
        {
            // Panggil Method untuk menambah kolom pada datagridview
            FormatDataGrid();

            // Tampilkan semua data
            listRiwayat = Riwayat_isi_saldo.BacaData("", "");

            //Tampilkan semua isi list di datagridview (Panggil method TampilDataGridView)
            TampilDataGrid();

            comboBoxKriteria.Text = "Id";
        }

        #region Textbox
        private void textBoxKriteria_TextChanged(object sender, EventArgs e)
        {
            string kriteria = "";
            switch (comboBoxKriteria.Text)
            {
                case "Id":
                    kriteria = "R.id";
                    break;

                case "Waktu":
                    kriteria = "R.waktu";
                    break;

                case "Isi Saldo":
                    kriteria = "R.isiSaldo";
                    break;

                case "Pelanggan":
                    kriteria = "P.nama";
                    break;
            }

            listRiwayat = Riwayat_isi_saldo.BacaData(kriteria, textBoxKriteria.Text);
            FormatDataGrid();
            TampilDataGrid();
            #endregion
        }

        #region DataGrid
        private void dataGridViewRiwayat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                //Menghapus data bila button hapus diklik
                int id = int.Parse(dataGridViewRiwayat.CurrentRow.Cells["Id"].Value.ToString());


                //Kalau button hapus diklik
                if (e.ColumnIndex == dataGridViewRiwayat.Columns["btnHapusGrid"].Index && e.RowIndex >= 0)
                {
                    string idHapus = dataGridViewRiwayat.CurrentRow.Cells["Id"].Value.ToString();
                    string namaHapus = dataGridViewRiwayat.CurrentRow.Cells["Nama"].Value.ToString();

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
                           FormRiwayatIsiSaldo_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Penghapusan data gagal");
                        }
                    }

                }
                //Kalau button ubah diklik
                if (e.ColumnIndex == dataGridViewRiwayat.Columns["btnUbahGrid"].Index && e.RowIndex >= 0)
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

        #region Button
        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormRiwayatIsiSaldo tambah = new FormRiwayatIsiSaldo();
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
