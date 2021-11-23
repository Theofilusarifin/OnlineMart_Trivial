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
            // Kosongi semua kolom di datagridview
            dataGridView.Columns.Clear();

            // Menambah kolom di datagridview
            dataGridView.Columns.Add("pelanggan_id", "Nama Pelanggan");
            dataGridView.Columns.Add("alamat_tujuan", "Alamat");
            dataGridView.Columns.Add("ongkos_kirim", "Ongkos Kirim");
            dataGridView.Columns.Add("komisi", "Komisi");

            // Agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridView.Columns["pelanggan_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["alamat_tujuan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["ongkos_kirim"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["komisi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //agar angka rata kanan
            dataGridView.Columns["ongkos_kirim"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView.Columns["komisi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //agar angka ditampilkan dengan format pemisah ribuan (100 delimiter)
            dataGridView.Columns["ongkos_kirim"].DefaultCellStyle.Format = "#,###";
            dataGridView.Columns["komisi"].DefaultCellStyle.Format = "#,###";

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
                    dataGridView.Rows.Add(o.Pelanggan.Nama, o.Alamat_tujuan, o.Ongkos_kirim, o.Ongkos_kirim * 0.8);
                }
            }
            else
            {
                dataGridView.DataSource = null;
            }
        }
        #endregion

        private void FormDaftarPengiriman_Load(object sender, EventArgs e)
        {
            try
            {
                //Panggil Method untuk menambah kolom pada datagridview
                FormatDataGrid();

                //Tampilkan semua data
                listOrder = Order.BacaData("driver_id", FormUtama.rider.Id.ToString(), FormUtama.koneksi);

                //Tampilkan semua isi list di datagridview (Panggil method TampilDataGridView)
                TampilDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
            
        }
    }
}
