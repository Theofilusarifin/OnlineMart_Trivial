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

namespace OnlineMart_Trivial
{
    public partial class FormRekapPendapatan : Form
    {
        Order tahunOrder;
        List<Order> listOrder = new List<Order>();

        string bulan = "";
        string tahun = "";

        double total;

        public FormRekapPendapatan()
        {
            InitializeComponent();
        }

        #region Methods
        private void FormatDataGrid()
        {
            //Kosongi semua kolom di datagridview
            dataGridView.Columns.Clear();

            //Menambah kolom di datagridview
            dataGridView.Columns.Add("tanggal_waktu", "Tanggal Waktu");
            dataGridView.Columns.Add("komisi", "Komisi");

            //Agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridView.Columns["tanggal_waktu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["komisi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //agar angka rata kanan
            dataGridView.Columns["komisi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

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

                // kalau barang order ada isinya
                if (listOrder.Count > 0)
                {
                    // untuk setiap barang di list barang order
                    foreach (Order o in listOrder)
                    {
                        // tunjukkan di datagrid dengan tipe Barang_Order
                        dataGridView.Rows.Add(o.Tanggal_waktu, o.Ongkos_kirim * 0.8);

                        total += o.Ongkos_kirim * 0.8;
                    }
                }
                else
                {
                    dataGridView.DataSource = null;
                }

                //Tampilkan button dan Hapus
                if (!dataGridView.Columns.Contains("btnHapusGrid"))
                {
                    DataGridViewButtonColumn bcolHapus = new DataGridViewButtonColumn();

                    bcolHapus.HeaderText = "Aksi";
                    bcolHapus.Text = "Hapus";
                    bcolHapus.Name = "btnHapusGrid";
                    bcolHapus.UseColumnTextForButtonValue = true;

                    dataGridView.Columns.Add(bcolHapus);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void FormRekapPendapatan_Load(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTahun.DataSource == null)
                {
                    // memasukkan tahun yang ada di orders ke combobox
                    tahunOrder = Order.AmbilTahun(FormUtama.koneksi);
                    comboBoxTahun.DataSource = tahunOrder;
                    comboBoxTahun.DisplayMember = "Tanggal_waktu";
                    comboBoxTahun.DropDownStyle = ComboBoxStyle.DropDownList;
                }

                FormatDataGrid();

                listOrder = Order.BacaTanggal(FormUtama.rider.Id, bulan, tahun, FormUtama.koneksi);

                TampilDataGrid();

                labelTotalPendapatan.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi error. Pesan kesalahan : " + ex.Message, "Error");
            }
        }

        private void comboBoxbulan_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                #region switch case
                // mengubah bulan yang dipilih menjadi angka, tapi tipe tetap string
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

                FormRekapPendapatan_Load(sender, e);
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

                FormRekapPendapatan_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Terjadi error. Pesan kesalahan : " + ex.Message, "Error");
            }
        }
    }
}
