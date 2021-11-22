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
    public partial class FormRekapPenjualanBarang : Form
    {
        List<Barang_Order> listPenjualanBarang = new List<Barang_Order>();

        List<Cabang> idCabang = new List<Cabang>();
        List<Order> bulanOrder = new List<Order>();
        List<Order> tahunOrder = new List<Order>();

        string cabang_id = "";
        string bulan = "";
        string tahun = "";

        public FormRekapPenjualanBarang()
        {
            InitializeComponent();
        }

        #region Methods
        private void FormatDataGrid()
        {
            //Kosongi semua kolom di datagridview
            dataGridView.Columns.Clear();

            //Menambah kolom di datagridview
            dataGridView.Columns.Add("cabang", "Cabang"); //dari order
            dataGridView.Columns.Add("tanggal_waktu", "Tanggal Waktu"); // dari order
            dataGridView.Columns.Add("barang", "Nama Barang"); // dari barang
            dataGridView.Columns.Add("harga", "Harga"); // dari barang
            dataGridView.Columns.Add("jumlah", "Jumlah"); // dari barang_order
            dataGridView.Columns.Add("subtotal", "SubTotal"); // dari barang_order

            //Agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridView.Columns["cabang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["tanggal_waktu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["barang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["jumlah"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["subtotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //agar angka rata kanan
            dataGridView.Columns["harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView.Columns["jumlah"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView.Columns["subtotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //agar angka ditampilkan dengan format pemisah ribuan (100 delimiter)
            dataGridView.Columns["harga"].DefaultCellStyle.Format = "#,###";
            dataGridView.Columns["subtotal"].DefaultCellStyle.Format = "#,###";

            // Agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            try
            {
                dataGridView.Rows.Clear();

                if (listPenjualanBarang.Count > 0)
                {
                    foreach (Barang_Order bo in listPenjualanBarang)
                    {
                        dataGridView.Rows.Add(bo.Order.Cabang.Nama, bo.Order.Tanggal_waktu, bo.Barang.Nama, bo.Barang.Harga, bo.Jumlah, bo.Harga);
                    }
                }
                else dataGridView.DataSource = null;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Terjdi error. Pesan kesalahan : " + ex.Message, "Error");
            }
        }
        #endregion

        private void FormRekapPenjualanBarang_Load(object sender, EventArgs e)
        {
            try
            {
                #region combobox
                idCabang = Cabang.BacaData("", "", FormUtama.koneksi);
                comboBoxCabang.DataSource = idCabang;
                comboBoxCabang.DisplayMember = "Id";
                comboBoxCabang.DropDownStyle = ComboBoxStyle.DropDownList;

                tahunOrder = Order.AmbilTahun(FormUtama.koneksi);
                comboBoxTahun.DataSource = idCabang;
                comboBoxTahun.DisplayMember = "Tanggal_waktu";
                comboBoxTahun.DropDownStyle = ComboBoxStyle.DropDownList;
                #endregion

                FormatDataGrid();

                listPenjualanBarang = Barang_Order.BacaPenjualanBarang(cabang_id, bulan, tahun, FormUtama.koneksi);

                TampilDataGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Terjai error. Pesan kesalahan : " + ex.Message, "Error");
            }
        }

        private void comboBoxCabang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cabang_id = comboBoxCabang.SelectedItem.ToString();

                FormRekapPenjualanBarang_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Terjdi error. Pesan kesalahan : " + ex.Message, "Error");
            }
        }

        private void comboBoxBulan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                #region switch case
                switch (comboBoxBulan.SelectedItem)
                {
                    case "Januari":
                        bulan = "1";
                        break;
                    case "Februari":
                        bulan = "2";
                        break;
                    case "Maret":
                        bulan = "3";
                        break;
                    case "April":
                        bulan = "4";
                        break;
                    case "Mei":
                        bulan = "5";
                        break;
                    case "Juni":
                        bulan = "6";
                        break;
                    case "Juli":
                        bulan = "7";
                        break;
                    case "Agustus":
                        bulan = "8";
                        break;
                    case "September":
                        bulan = "9";
                        break;
                    case "Oktober":
                        bulan = "10";
                        break;
                    case "November":
                        bulan = "11";
                        break;
                    case "Desember":
                        bulan = "12";
                        break;
                }
                #endregion

                FormRekapPenjualanBarang_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Terjdi error. Pesan kesalahan : " + ex.Message, "Error");
            }
        }

        private void comboBoxTahun_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tahun = comboBoxTahun.SelectedItem.ToString();

                FormRekapPenjualanBarang_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Terjdi error. Pesan kesalahan : " + ex.Message, "Error");
            }
        }
    }
}
