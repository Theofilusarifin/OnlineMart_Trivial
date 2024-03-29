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
// untuk membuat currency symbol
using System.Globalization;

namespace OnlineMart_Trivial
{
    public partial class FormKeranjang : Form
    {
        public static Order thisOrder = new Order();
        public static bool IdGenerated = false;

        public static List<Barang_Order> listBarangOrder = thisOrder.ListBarangOrder;
        Barang_Order barang_order;

        public static float totalHarga;

        public FormKeranjang()
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
            dataGridView.Columns.Add("id", "Id");
            dataGridView.Columns.Add("nama", "Nama Barang");
            dataGridView.Columns.Add("harga", "Harga Barang");
            dataGridView.Columns.Add("kategori_id", "Kategori");
            dataGridView.Columns.Add("jumlah", "Jumlah");
            dataGridView.Columns.Add("subtotal", "SubTotal");

            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 142, 123);
            dataGridView.EnableHeadersVisualStyles = false;

            //Agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridView.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["kategori_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["jumlah"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["subtotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //agar angka rata kanan
            dataGridView.Columns["harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView.Columns["jumlah"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView.Columns["subtotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //agar angka ditampilkan dengan format pemisah ribuan (100 delimiter)
            dataGridView.Columns["harga"].DefaultCellStyle.Format = "#,###";
            dataGridView.Columns["jumlah"].DefaultCellStyle.Format = "#,###";
            dataGridView.Columns["subtotal"].DefaultCellStyle.Format = "#,###";

            // Agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridView.AllowUserToAddRows = false;

            // membuat user dapat mengedit datagrid dengan nama kolom yang sesuai
            foreach (DataGridViewColumn dc in dataGridView.Columns)
            {
                if (dc.Name == "jumlah") dc.ReadOnly = false;
                else dc.ReadOnly = true;
            }
        }

        private void TampilDataGrid()
        {
            try
            {
                //Kosongi isi datagridview
                dataGridView.Rows.Clear();

                listBarangOrder.Clear();
                // dimasukkin ke barang_order supaya bisa hitung subtotal sama jumlah barang
                #region Keranjang to Barang_Order
                bool helper;

                // kalau keranjang ada isinya
                if (FormUtama.keranjang.Count > 0)
                {
                    // untuk setiap barang di keranjang
                    foreach (Barang b in FormUtama.keranjang)
                    {
                        // anggap barang dengan id yang sama tidak akan ketemu dahulu
                        helper = false;

                        // kalau list barang order ada isinya
                        if (listBarangOrder.Count > 0)
                        {
                            // untuk setiap barang order di list barang order
                            foreach (Barang_Order bo in listBarangOrder)
                            {
                                // kalau id barang di keranjang sama dengan id barang order di list barang order
                                if (b.Id == bo.Barang.Id)
                                {
                                    // ketemu barang dengan id yang sama 
                                    helper = true;

                                    // jumlah dan harga ditambah
                                    bo.Jumlah += 1;
                                    bo.Harga += b.Harga;

                                    // kalau ketemu langsung lanjut ke barang selanjutnya
                                    break;
                                }
                            }
                            // kalau tidak ada id yang sama
                            if (helper == false)
                            {
                                barang_order = new Barang_Order(b, thisOrder, 1, b.Harga);
                                listBarangOrder.Add(barang_order);
                            }
                        }
                        // kalau list barang order kosong
                        else
                        {
                            barang_order = new Barang_Order(b, thisOrder, 1, b.Harga);
                            listBarangOrder.Add(barang_order);
                        }
                    }
                }
                #endregion

                // kalau barang order ada isinya
                if (listBarangOrder.Count > 0)
                {
                    // untuk setiap barang di list barang order
                    foreach (Barang_Order bo in listBarangOrder)
                    {
                        // tunjukkan di datagrid dengan tipe Barang_Order
                        dataGridView.Rows.Add(bo.Barang.Id, bo.Barang.Nama, bo.Barang.Harga, bo.Barang.Kategori.Nama, bo.Jumlah, bo.Harga /*subtotal*/);
                    }
                }
                else
                {
                    dataGridView.DataSource = null;
                }

                //Tampilkan button dan Hapus
                if (!dataGridView.Columns.Contains("btnHapus"))
                {
                    DataGridViewButtonColumn bcolHapus = new DataGridViewButtonColumn();

                    bcolHapus.HeaderText = "Aksi";
                    bcolHapus.Text = "Hapus";
                    bcolHapus.Name = "btnHapus";
                    bcolHapus.UseColumnTextForButtonValue = true;

                    dataGridView.Columns.Add(bcolHapus);
                }

                if (!dataGridView.Columns.Contains("btn+"))
                {
                    DataGridViewButtonColumn bcolTambah = new DataGridViewButtonColumn();

                    bcolTambah.HeaderText = "";
                    bcolTambah.Text = "+";
                    bcolTambah.Name = "btn+";
                    bcolTambah.UseColumnTextForButtonValue = true;

                    int colJumlah = dataGridView.Columns.IndexOf(dataGridView.Columns["jumlah"]);

                    dataGridView.Columns.Insert(colJumlah + 1, bcolTambah);
                }

                if (!dataGridView.Columns.Contains("btn-"))
                {
                    DataGridViewButtonColumn bcolKurang = new DataGridViewButtonColumn();

                    bcolKurang.HeaderText = "";
                    bcolKurang.Text = "-";
                    bcolKurang.Name = "btn-";
                    bcolKurang.UseColumnTextForButtonValue = true;

                    int colJumlah = dataGridView.Columns.IndexOf(dataGridView.Columns["jumlah"]);

                    dataGridView.Columns.Insert(colJumlah, bcolKurang);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region FormLoad
        public void FormKeranjang_Load(object sender, EventArgs e)
		{
            try
            {
                //generate id order yyyyMMddxxxx (yyyy-MM-dd-xxxx) detail ada di class order
                if (thisOrder.Id == 0 && !IdGenerated)
                {
                    thisOrder.Id = long.Parse(Order.GenerateIdOrder());

                    // Set IdGenerated ke true agar tidak generate id baru
                    IdGenerated = true;
                }

                if (FormUtama.pilihVendor == "cabang") labelNamaVendor.Text = FormUtama.cDipilih.Nama;
                else if (FormUtama.pilihVendor == "penjual") labelNamaVendor.Text = FormUtama.pDipilih.Nama;

                //Panggil Method untuk menambah kolom pada datagridview
                FormatDataGrid();

                //Tampilkan semua isi list di datagridview (Panggil method TampilDataGridView)
                TampilDataGrid();

                #region TotalHarga
                totalHarga = 0;

                foreach (Barang_Order bo in listBarangOrder)
                {
                    totalHarga += bo.Harga;
                }

                labelTotalHarga.Text = totalHarga.ToString("C", CultureInfo.CreateSpecificCulture("id"));
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region FormClosing
        private void FormKeranjang_FormClosing(object sender, FormClosingEventArgs e)
        {
            listBarangOrder.Clear();
        }
        #endregion

        #region Datagrid
        private void dataGridViewKeranjang_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
                int id = int.Parse(dataGridView.CurrentRow.Cells["id"].Value.ToString());

                #region buttonHapus
                //Kalau button hapus diklik
                if (e.ColumnIndex == dataGridView.Columns["btnHapus"].Index && e.RowIndex >= 0)
                {
                    string idHapus = dataGridView.CurrentRow.Cells["id"].Value.ToString();
                    string namaHapus = dataGridView.CurrentRow.Cells["nama"].Value.ToString();

                    //User ditanya sesuai dibawah
                    DialogResult hasil = MessageBox.Show(this, "Anda yakin akan menghapus Id " + idHapus + " - " + namaHapus + " dari keranjang?",
                                                         "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //Kalau User klik yes barang akan dihapus
                    if (hasil == DialogResult.Yes)
                    {
                        FormUtama.keranjang.RemoveAll(barang => barang.Id == id);

                        MessageBox.Show("Barang berhasil di hapus");
                        // refresh halaman
                        FormKeranjang_Load(sender, e);
                    }
                }
                #endregion

                #region button +
                //Kalau button + diklik
                if (e.ColumnIndex == dataGridView.Columns["btn+"].Index && e.RowIndex >= 0)
                {
                    Barang b = Barang.AmbilData(id);
                    FormUtama.keranjang.Add(b); //Untuk menambahkan barang ke dalam keranjang
                    FormKeranjang_Load(sender, e);
                }
                #endregion

                #region button -
                //Kalau button - diklik
                if (e.ColumnIndex == dataGridView.Columns["btn-"].Index && e.RowIndex >= 0)
                {
                    Barang b = Barang.AmbilData(id);
                    for (int i = 0; i < FormUtama.keranjang.Count; i++)
                    {
                        if (FormUtama.keranjang[i].Id == b.Id && FormUtama.keranjang[i].Nama == b.Nama)
                        {
                            FormUtama.keranjang.RemoveAt(i);

                            if (FormUtama.keranjang.Count == 0)
                            {
                                FormUtama.pilihVendor = "";
                                FormUtama.cDipilih = null;
                                FormUtama.pDipilih = null;
                            }

                            break;
                        }
                    }
                    FormKeranjang_Load(sender, e);
                }
                #endregion
            }
            catch (Exception ex)
			{
                MessageBox.Show(ex.Message);
			}
		}

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = int.Parse(dataGridView.CurrentRow.Cells["id"].Value.ToString());

                int jumlahAwal = 0;
                // untuk setiap barang order di list
                foreach (Barang_Order bo in listBarangOrder)
                {
                    if (bo.Barang.Id == id)
                    {
                        // masukkan jumlah awal
                        jumlahAwal = bo.Jumlah;
                        //MessageBox.Show("jumlah awal: " + bo.Jumlah.ToString());
                    }
                }

                // ambil jumlah dari data grid
                int jumlah = int.Parse(dataGridView.CurrentRow.Cells["jumlah"].Value.ToString());
                // masukkan jumlah akhir
                int jumlahAkhir = jumlah;
                //MessageBox.Show("jumlah akhir: " + jumlah.ToString());

                // hitung perubahan
                int perubahan = jumlahAkhir - jumlahAwal;
                //MessageBox.Show("perubahan: " + perubahan.ToString());

                // kalau negatif
                if (perubahan < 0)
                {
                    for (int i = 0; i < Math.Abs(perubahan); i++)
                    {
                        Barang b = Barang.AmbilData(id);
                        for (int j = 0; j < FormUtama.keranjang.Count; j++)
                        {
                            if (FormUtama.keranjang[j].Id == b.Id && FormUtama.keranjang[j].Nama == b.Nama)
                            {
                                FormUtama.keranjang.RemoveAt(j);
                                break;
                            }
                        }
                    }
                }
                // kalau positif
                else if (perubahan > 0)
                {
                    for (int i = 0; i < perubahan; i++)
                    {
                        Barang b = Barang.AmbilData(id);
                        FormUtama.keranjang.Add(b);
                    }
                }

                FormKeranjang_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Button
        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            // Set Default Gift Redeem Id 1
            thisOrder.Gift_redeem = new Gift_Redeem(1);

            //foreach (Barang_Order bo in listBarangOrder)
            //{
            //    thisOrder.Total_bayar += bo.Harga;
            //}

            thisOrder.Total_bayar = totalHarga;

            foreach (Barang_Order bo in listBarangOrder)
            {
                bo.Order.Total_bayar = thisOrder.Total_bayar;
                bo.Order.Gift_redeem = thisOrder.Gift_redeem;
            }

            MessageBox.Show("Checkout Berhasil! Silakan buka Form Checkout untuk melakukan pembayaran");
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region DesainButton
        private void buttonCheckout_MouseEnter(object sender, EventArgs e)
        {
            buttonCheckout.BackgroundImage = Properties.Resources.Button_Hover;
        }
        private void buttonCheckout_MouseLeave(object sender, EventArgs e)
        {
            buttonCheckout.BackgroundImage = Properties.Resources.Button_Leave;
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

    }
}
