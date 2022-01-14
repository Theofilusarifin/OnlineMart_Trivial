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

        List<Cabang> listCabang = new List<Cabang>();
        List<Order> bulanOrder = new List<Order>();
        List<Int32> listTahun = new List<Int32>();

        Cabang cabang = null;
        string bulan = "";
        string tahun = "";

        public FormRekapPenjualanBarang()
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
            dataGridView.Columns.Add("vendor", "Vendor"); //dari order
            dataGridView.Columns.Add("tanggal_waktu", "Tanggal Waktu"); // dari order
            dataGridView.Columns.Add("barang", "Nama Barang"); // dari barang
            dataGridView.Columns.Add("harga", "Harga"); // dari barang
            dataGridView.Columns.Add("jumlah", "Jumlah"); // dari barang_order
            dataGridView.Columns.Add("subtotal", "SubTotal"); // dari barang_order

            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 142, 123);
            dataGridView.EnableHeadersVisualStyles = false;

            //Agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridView.Columns["vendor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["tanggal_waktu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["barang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["jumlah"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["subtotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //agar angka rata tengah
            dataGridView.Columns["harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["jumlah"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["subtotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

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
                        if (bo.Order.Cabang != null)
                        {
                            dataGridView.Rows.Add(bo.Order.Cabang.Nama, bo.Order.Tanggal_waktu, bo.Barang.Nama, bo.Barang.Harga, bo.Jumlah, bo.Harga);
                        }
                        else
                        {
                            dataGridView.Rows.Add(bo.Order.Penjual.Nama, bo.Order.Tanggal_waktu, bo.Barang.Nama, bo.Barang.Harga, bo.Jumlah, bo.Harga);
                        }
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

        #region FormLoad
        private void FormRekapPenjualanBarang_Load(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxCabang.DataSource == null)
                {
                    listCabang = Cabang.BacaData("", "");
                    comboBoxCabang.DataSource = listCabang;
                    comboBoxCabang.DisplayMember = "Nama";
                    comboBoxCabang.DropDownStyle = ComboBoxStyle.DropDownList;
                }

                if (comboBoxTahun.DataSource == null)
                {
                    listTahun = Order.AmbilTahun();
                    comboBoxTahun.DataSource = listTahun;
                    comboBoxTahun.DropDownStyle = ComboBoxStyle.DropDownList;
                }

                FormatDataGrid();

                listPenjualanBarang = Barang_Order.BacaSemuaData();

                TampilDataGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Terjai error. Pesan kesalahan : " + ex.Message, "Error");
            }
        }
        #endregion

        #region ComboBox
        private void comboBoxCabang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cabang = (Cabang)comboBoxCabang.SelectedItem;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjdi error. Pesan kesalahan : " + ex.Message, "Error");
            }
        }

        private void comboBoxBulan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBulan.SelectedItem)
                {
                    case "":
                        bulan = "";
                        break;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjdi error. Pesan kesalahan : " + ex.Message, "Error");
            }
        }
        private void comboBoxTahun_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tahun = comboBoxTahun.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjdi error. Pesan kesalahan : " + ex.Message, "Error");
            }
        }
        #endregion

        #region Buttons
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FormatDataGrid();

            listPenjualanBarang = Barang_Order.BacaPenjualanBarang(cabang, bulan, tahun);

            TampilDataGrid();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region DesainButton
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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
