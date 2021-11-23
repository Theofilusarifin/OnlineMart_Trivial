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
    public partial class FormDaftarOrder : Form
    {
        public List<Order> listOrder = new List<Order>();
        public FormDaftarOrder()
        {
            InitializeComponent();
        }

        #region Methods
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
        }
        #endregion

        #region FormLoad
        private void FormDaftarOrder_Load(object sender, EventArgs e)
		{
            try
            {
                //Panggil Method untuk menambah kolom pada datagridview
                FormatDataGrid();

                //Tampilkan semua data
                listOrder = Order.BacaData("", "");

                //Tampilkan semua isi list di datagridview (Panggil method TampilDataGridView)
                TampilDataGrid();

                comboBoxKriteria.Text = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
		}
        #endregion

        #region Textbox
        private void textBoxKriteria_TextChanged(object sender, EventArgs e)
        {
            string kriteria = "";
            switch (comboBoxKriteria.Text)
            {
                case "Id":
                    kriteria = "id";
                    break;

                case "Tanggal":
                    kriteria = "tanggal_waktu";
                    break;

                case "Alamat":
                    kriteria = "alamat_tujuan";
                    break;

                case "Ongkos Kirim":
                    kriteria = "ongkos_kirim";
                    break;

                case "Total Bayar":
                    kriteria = "total_bayar";
                    break;

                case "Cara Bayar":
                    kriteria = "cara_bayar";
                    break;

                case "Status":
                    kriteria = "status";
                    break;
            }

            listOrder = Order.BacaData(kriteria, textBoxKriteria.Text);
            FormatDataGrid();
            TampilDataGrid();
        }
        #endregion

        #region Desain Button
        private void buttonClose_MouseEnter(object sender, EventArgs e)
        {
            buttonClose.BackgroundImage = Properties.Resources.Button_Hover;
        }
        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.BackgroundImage = Properties.Resources.Button_Leave;
        }
        #endregion

        #region Button
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
		#endregion

		private void buttonCetak_Click(object sender, EventArgs e)
		{
			try
			{
                Order.CetakDaftarOrder("", "", "daftarnota.txt", FormUtama.koneksi);
                MessageBox.Show("Nota berhasil di cetak");
			}
            catch (Exception ex)
			{
                MessageBox.Show("Terjadi Error. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

		private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void comboBoxKriteria_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
