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
    public partial class FormDaftarPengiriman : Form
    {
        public FormDaftarPengiriman()
        {
            InitializeComponent();
        }

        public List<Order> listOrder = new List<Order>();

        #region Methods
        private void FormatDataGrid()
        {
            //Kosongi semua kolom di datagridview
            dataGridView.Columns.Clear();

            //Menambah kolom di datagridview
            dataGridView.Columns.Add("tanggal_waktu", "tanggal waktu");
            dataGridView.Columns.Add("alamat_tujuan", "alamat tujuan");
            dataGridView.Columns.Add("ongkos_kirim", "ongkos kirim");
            dataGridView.Columns.Add("total_bayar", "total bayar");
            dataGridView.Columns.Add("cara_bayar", "cara bayar");
            dataGridView.Columns.Add("cabang_id", "Cabang");
            dataGridView.Columns.Add("pelanggan_id", "Pelanggan");
            dataGridView.Columns.Add("promo_id", "Promo");
            dataGridView.Columns.Add("status", "Status");
            dataGridView.Columns.Add("metode_pembayaran", "Metode Pembayaran");

            //Agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridView.Columns["tanggal_waktu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["alamat_tujuan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["ongkos_kirim"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["total_bayar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["cara_bayar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["cabang_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["pelanggan_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["promo_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["metode_pembayaran"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            //Kosongi isi datagridview
            dataGridView.Rows.Clear();

            if (listOrder.Count > 0)
            {
                foreach (Order o in listOrder)
                {
                    dataGridView.Rows.Add(o.Tanggal_waktu, o.Alamat_tujuan, o.Ongkos_kirim, o.Total_bayar, o.Cara_bayar, o.Cabang.Nama,
                        o.Pelanggan.Nama, o.Promo.Nama, o.Status, o.Metode_pembayaran);
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
            }
        }
        #endregion

        private void FormDaftarPengiriman_Load(object sender, EventArgs e)
        {
            // Panggil Method untuk menambah kolom pada datagridview
            FormatDataGrid();

            // Tampilkan semua data
            listOrder = Order.BacaData("driver_id", FormUtama.rider.Id.ToString());

            //Tampilkan semua isi list di datagridview (Panggil method TampilDataGridView)
            TampilDataGrid();
        }
    }
}
