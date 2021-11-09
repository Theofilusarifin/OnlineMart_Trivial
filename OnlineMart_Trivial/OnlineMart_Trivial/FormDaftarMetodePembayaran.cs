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
    public partial class FormDaftarMetodePembayaran : Form
    {
        public List<Metode_pembayarans> listMetode = new List<Metode_pembayarans>();
        public FormDaftarMetodePembayaran()
        {
            InitializeComponent();
        }
        private void FormatDataGrid()
        {
            //Kosongi semua kolom di datagridview
            dataGridView.Columns.Clear();

            //Menambah kolom di datagridview
            dataGridView.Columns.Add("id", "Id");
            dataGridView.Columns.Add("nama", "Nama Metode");

            //Agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridView.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ReadOnly = true;
        }
        private void TampilDataGrid()
        {
            //Kosongi isi datagridview
            dataGridView.Rows.Clear();

            if (listMetode.Count > 0)
            {
                foreach (Metode_pembayarans m in listMetode)
                {
                    dataGridView.Rows.Add(m.Id, m.Name);
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
                bcolUbah.FlatStyle = FlatStyle.Flat;
                bcolUbah.DefaultCellStyle.Font = new Font("Montserrat", 9, FontStyle.Bold);
                bcolUbah.DefaultCellStyle.ForeColor = Color.White;
                bcolUbah.DefaultCellStyle.BackColor = Color.FromArgb(227, 65, 35);
                dataGridView.Columns.Add(bcolUbah);

                DataGridViewButtonColumn bcolHapus = new DataGridViewButtonColumn();

                bcolHapus.HeaderText = "Aksi";
                bcolHapus.Text = "Hapus";
                bcolHapus.Name = "btnHapusGrid";
                bcolHapus.UseColumnTextForButtonValue = true;
                bcolHapus.FlatStyle = FlatStyle.Flat;
                bcolHapus.DefaultCellStyle.Font = new Font("Montserrat", 9, FontStyle.Bold);
                bcolHapus.DefaultCellStyle.ForeColor = Color.White;
                bcolHapus.DefaultCellStyle.BackColor = Color.FromArgb(227, 65, 35);

                dataGridView.Columns.Add(bcolHapus);

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

                dataGridView.Columns.Add(bcolTambahKeranjang);
            }
        }
        private void FormDaftarMetodePembayaran_Load(object sender, EventArgs e)
		{
            //Panggil Method untuk menambah kolom pada datagridview
            FormatDataGrid();

            //Tampilkan semua data
            listMetode = Metode_pembayarans.BacaData("", "");

            //Tampilkan semua isi list di datagridview (Panggil method TampilDataGridView)
            TampilDataGrid();
        }
	}
}
