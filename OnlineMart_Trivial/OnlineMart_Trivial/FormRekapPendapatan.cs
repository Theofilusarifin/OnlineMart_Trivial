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
using System.Globalization;

namespace OnlineMart_Trivial
{
    public partial class FormRekapPendapatan : Form
    {
        List<Int32> listTahun = new List<Int32>();
        List<Order> listOrder = new List<Order>();

        string bulan = "";
        string tahun = "";

        double total = 0;

        public FormRekapPendapatan()
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
            dataGridView.Columns.Add("tanggal_waktu", "Tanggal Waktu");
            dataGridView.Columns.Add("komisi", "Komisi");

            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 142, 123);
            dataGridView.EnableHeadersVisualStyles = false;

            //Agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridView.Columns["tanggal_waktu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["komisi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //agar angka rata tengah
            dataGridView.Columns["komisi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //agar angka ditampilkan dengan format pemisah ribuan (100 delimiter)
            dataGridView.Columns["komisi"].DefaultCellStyle.Format = "#,###";

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

                // kalau list order ada isinya
                if (listOrder.Count > 0)
                {
                    // untuk setiap order di list
                    foreach (Order o in listOrder)
                    {
                        if (o.Status == "Order Selesai")
                        {
                            // tunjukkan di datagrid
                            dataGridView.Rows.Add(o.Tanggal_waktu, o.Ongkos_kirim * 0.8);

                            total += o.Ongkos_kirim * 0.8;
                        }
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
        private void FormRekapPendapatan_Load(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTahun.DataSource == null)
                {
                    // memasukkan tahun yang ada di orders ke combobox
                    listTahun = Order.AmbilTahun();
                    comboBoxTahun.DataSource = listTahun;               
                    comboBoxTahun.DropDownStyle = ComboBoxStyle.DropDownList;
                }

                FormatDataGrid();

                listOrder = Order.BacaTanggal(FormUtama.rider, bulan, tahun);

                TampilDataGrid();

                labelTotalPendapatan.Text = total.ToString("C", CultureInfo.CreateSpecificCulture("id"));

                //MessageBox.Show("bulan = " + bulan + ", tahun = " + tahun);
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
            FormRekapPendapatan_Load(sender, e);
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

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
