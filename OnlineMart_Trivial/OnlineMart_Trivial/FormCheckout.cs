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
    public partial class FormCheckout : Form
    {
        List<Metode_pembayaran> metode = new List<Metode_pembayaran>();
        List<Promo> promo = new List<Promo>();
        Pelanggan pelanggan;

        public FormCheckout()
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
            dataGridView.Columns.Add("alamat_tujuan", "Alamat Tujuan");
            dataGridView.Columns.Add("ongkos_kirim", "Ongkos Kirim");
            dataGridView.Columns.Add("total_bayar", "Total Bayar");
            dataGridView.Columns.Add("cara_bayar", "Cara Bayar");
            dataGridView.Columns.Add("status", "Status"); // 'Menunggu Pembayaran' pertama kali masuk, waktu tombol bayar di datagrid ditekan ganti jadi 'Pesanan Diproses' 
            dataGridView.Columns.Add("cabang_id", "Cabang");
            dataGridView.Columns.Add("pelanggan_id", "Pelanggan");
            dataGridView.Columns.Add("promo_id", "Promo"); // tampilkan sesuai yang BARUSAN DIPILIH pelanggan
            dataGridView.Columns.Add("metode_pembayaran", "Metode Pembayaran");

            //Agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridView.Columns["tanggal_waktu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["alamat_tujuan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["ongkos_kirim"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["total_bayar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["cara_bayar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["cabang_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["pelanggan_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["promo_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["metode_pembayaran"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //agar angka rata kanan
            dataGridView.Columns["ongkos_kirim"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView.Columns["total_bayar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //agar angka ditampilkan dengan format pemisah ribuan (100 delimiter)
            dataGridView.Columns["ongkos_kirim"].DefaultCellStyle.Format = "#,###";
            dataGridView.Columns["total_bayar"].DefaultCellStyle.Format = "#,###";

            // Agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            //Kosongi isi datagridview
            dataGridView.Rows.Clear();

            if (FormKeranjang.thisOrder.ListBarangOrder.Count > 0)
            {
                dataGridView.Rows.Add(DateTime.Now.ToString(), FormKeranjang.thisOrder.Alamat_tujuan, 10000, FormKeranjang.thisOrder.Total_bayar, 
                                      "cara bayar", "Menunggu Pembayaran", FormKeranjang.thisOrder.Cabang.Nama, pelanggan.Nama, 
                                      FormKeranjang.thisOrder.Promo, metode);
            }
            else
            {
                dataGridView.DataSource = null;
            }

            //Tampilkan button dan Hapus
            if (!dataGridView.Columns.Contains("btnBayar"))
            {
                DataGridViewButtonColumn bcolBayar = new DataGridViewButtonColumn();

                bcolBayar.HeaderText = "Aksi";
                bcolBayar.Text = "Hapus";
                bcolBayar.Name = "btnBayar";
                bcolBayar.UseColumnTextForButtonValue = true;
                bcolBayar.FlatStyle = FlatStyle.Flat;

                dataGridView.Columns.Add(bcolBayar);
            }
        }
        #endregion

        private void FormCheckout_Load(object sender, EventArgs e)
        {
            pelanggan = FormUtama.konsumen;

            //memunculkan metde pembayaran yang ada di combobox
            metode = Metode_pembayaran.BacaData("", "");
            comboBoxMetodeBayar.DataSource = metode;
            comboBoxMetodeBayar.DisplayMember = "Nama";
            comboBoxMetodeBayar.DropDownStyle = ComboBoxStyle.DropDownList;

            //memunculkan promo yang ada di combobox
            promo = Promo.BacaData("", "");
            comboBoxMetodeBayar.DataSource = promo;
            comboBoxMetodeBayar.DisplayMember = "Nama";
            comboBoxMetodeBayar.DropDownStyle = ComboBoxStyle.DropDownList;

            FormatDataGrid();

            Order.BacaData("id", FormKeranjang.thisOrder.Id.ToString());

            TampilDataGrid();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Kalau button bayar di datagrid diklik
                if (e.ColumnIndex == dataGridView.Columns["btnBayar"].Index && e.RowIndex >= 0)
                {
                    //ambil data order ini
                    Order orderLama = Order.AmbilData(FormKeranjang.thisOrder.Id);

                    //ganti metode pembayaran sesuai dengan yang dipilih pelanggan
                    orderLama.Status = "Pesanan Diproses";

                    //ganti data lama dengan data baru
                    Order.UbahData(orderLama);

                    MessageBox.Show("Pembayaran berhasil. Pesanan Diproses", "Info");
                    FormCheckout_Load(sender, e);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Pembayaran gagal. Pesan kesalahan : " + ex.Message, "Error");
            }
        }
        private void comboBoxMetodeBayar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //ambil metode pembayaran yang dipilih
                Metode_pembayaran metodeDipilih = (Metode_pembayaran)comboBoxMetodeBayar.SelectedItem;

                //ambil data order ini
                Order orderLama = Order.AmbilData(FormKeranjang.thisOrder.Id);

                //ganti metode pembayaran sesuai dengan yang dipilih pelanggan
                orderLama.Metode_pembayaran = metodeDipilih;

                //ganti data lama dengan data baru
                Order.UbahData(orderLama);

                //refresh form
                FormCheckout_Load(sender,e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi error. Pesan kesalahan : " + ex.Message, "Error");
            }
        }

        private void comboBoxPromo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ambil promo yang dipilih
            Promo promoDipilih = (Promo)comboBoxPromo.SelectedItem;

            //ambil data order ini
            Order orderLama = Order.AmbilData(FormKeranjang.thisOrder.Id);

            //ganti promo sesuai dengan yang dipilih pelanggan
            orderLama.Promo = promoDipilih;

            //ganti data lama dengan data baru
            Order.UbahData(orderLama);

            //refresh form
            FormCheckout_Load(sender, e);
        }
    }
}
