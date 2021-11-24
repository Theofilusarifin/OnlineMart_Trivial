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
	public partial class FormHistoryTransaksi : Form
	{
        public static int orderID; //Agar dapat dipanggil di form cek pesanan
		public FormHistoryTransaksi()
		{
			InitializeComponent();
		}
		public static List<Order> listOrder = new List<Order>(); //deklarasi list order

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

        #region Method
        private void FormatDataGrid()
        {
            //Kosongi semua kolom di datagridview
            dataGridView.Columns.Clear();

            //Menambah kolom di datagridview
            dataGridView.Columns.Add("id", "Id");
            dataGridView.Columns.Add("tanggal_waktu", "Tanggal");
            dataGridView.Columns.Add("alamat_tujuan", "Alamat");
            dataGridView.Columns.Add("ongkos_kirim", "Ongkos Kirim");
            dataGridView.Columns.Add("total_bayar", "Total Bayar");
            dataGridView.Columns.Add("cara_bayar", "Cara Bayar");
            dataGridView.Columns.Add("status", "Status");
            dataGridView.Columns.Add("cabang_id", "Nama Cabang");
            dataGridView.Columns.Add("driver_id", "Nama Driver");
            dataGridView.Columns.Add("promo_id", "Id Promo");
            dataGridView.Columns.Add("gift_redeem_id", "Id Hadiah");

            //Agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridView.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["tanggal_waktu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["alamat_tujuan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["ongkos_kirim"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["total_bayar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["cara_bayar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["cabang_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["driver_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["promo_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["gift_redeem_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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
                    dataGridView.Rows.Add(o.Id, o.Tanggal_waktu, o.Alamat_tujuan, o.Ongkos_kirim, o.Total_bayar, o.Cara_bayar, o.Status, o.Cabang.Nama, o.Driver.Nama, o.Promo.Id, o.Gift_redeem.Id);
                }
            }
            else
            {
                dataGridView.DataSource = null;
            }
            //Tampilkan button dan Hapus
            if (!dataGridView.Columns.Contains("btnCekPesanan"))
            {
                DataGridViewButtonColumn bcolCekPesanan = new DataGridViewButtonColumn();

                bcolCekPesanan.HeaderText = "Aksi";
                bcolCekPesanan.Text = "Cek Pesanan";
                bcolCekPesanan.Name = "btnCekPesanan";
                bcolCekPesanan.UseColumnTextForButtonValue = true;

                dataGridView.Columns.Add(bcolCekPesanan);
            }
        }
        #endregion

        private void FormHistoryTransaksi_Load(object sender, EventArgs e)
		{
			try
			{
                //Panggil Method untuk menambah kolom pada datagridview
                FormatDataGrid();

                //Tampilkan semua data
                listOrder = Order.BacaData("pelanggan_id", FormUtama.konsumen.Id.ToString());

                //Tampilkan semua isi list di datagridview (Panggil method TampilDataGridView)
                TampilDataGrid();
            }
			catch (Exception ex)
			{
                MessageBox.Show("Terjadi Error. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

		private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
                int id = int.Parse(dataGridView.CurrentRow.Cells["Id"].Value.ToString()); //Untuk mengambil ID dari button yang di klik
                if (e.ColumnIndex == dataGridView.Columns["btnCekPesanan"].Index && e.RowIndex >= 0) //Untuk mengecek apakah yang ditekan adalah button cek pesanan
                {
                    //Hubungkan form cek pesanan di sini
                }
            }
            catch (Exception ex)
			{
                MessageBox.Show("Terjadi Error. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
        #region DesainButton
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
