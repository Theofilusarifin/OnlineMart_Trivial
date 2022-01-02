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
    public partial class FormRekapPenjualanOmaSaldo : Form
    {
        List<Int32> tahunRiwayatIsiSaldo = new List<Int32>();
        List<Riwayat_isi_saldo> listRiwayatIsiSaldo = new List<Riwayat_isi_saldo>();

        public FormRekapPenjualanOmaSaldo()
        {
            InitializeComponent();
        }

        string bulan = "";
        string tahun = "";

        double total = 0;

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
            dataGridView.Columns.Add("tanggal_waktu", "Tanggal Waktu");
            dataGridView.Columns.Add("pemasukan", "Pemasukkan");

            //Agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridView.Columns["tanggal_waktu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["pemasukan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //agar angka rata tengah
            dataGridView.Columns["pemasukan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //agar angka ditampilkan dengan format pemisah ribuan (100 delimiter)
            dataGridView.Columns["pemasukan"].DefaultCellStyle.Format = "#,###";

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

                total = 0;

                // kalau barang order ada isinya
                if (listRiwayatIsiSaldo.Count > 0)
                {
                    // untuk setiap barang di list barang order
                    foreach (Riwayat_isi_saldo ris in listRiwayatIsiSaldo)
                    {
                        // tunjukkan di datagrid dengan tipe Barang_Order
                        dataGridView.Rows.Add(ris.Waktu, ris.IsiSaldo);

                        total += ris.IsiSaldo;
                    }
                }
                else
                {
                    dataGridView.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region FormLoad
        private void FormRekapPenjualanOmaSaldo_Load(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTahun.DataSource == null)
                {
                    // memasukkan tahun yang ada di orders ke combobox
                    tahunRiwayatIsiSaldo = Riwayat_isi_saldo.AmbilTahun();
                    comboBoxTahun.DataSource = tahunRiwayatIsiSaldo;
                    comboBoxTahun.DropDownStyle = ComboBoxStyle.DropDownList;
                }

                FormatDataGrid();

                listRiwayatIsiSaldo = Riwayat_isi_saldo.BacaTanggal(bulan, tahun);

                TampilDataGrid();

                labelTotalPemasukan.Text = "Rp" + total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi error. Pesan kesalahan : " + ex.Message, "Error");
            }
        }
        #endregion

        #region Buttons
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FormRekapPenjualanOmaSaldo_Load(sender, e);

        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region ComboBox
        private void comboBoxbulan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // mengubah bulan yang dipilih menjadi angka, tapi tipe tetap string
                switch (comboBoxbulan.SelectedItem)
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
                MessageBox.Show("Terjadi error. Pesan kesalahan : " + ex.Message, "Error");
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
                MessageBox.Show("Terjadi error. Pesan kesalahan : " + ex.Message, "Error");
            }
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
    }
}
