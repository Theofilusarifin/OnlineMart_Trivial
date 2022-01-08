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

        List<Order> listOrder = new List<Order>();

        Order o = null;

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
            dataGridView.Columns.Add("nama_pelanggan", "Nama Pelanggan");
            dataGridView.Columns.Add("tanggal_waktu", "Tanggal");
            dataGridView.Columns.Add("alamat_tujuan", "Alamat");
            dataGridView.Columns.Add("ongkos_kirim", "Ongkos Kirim");
            dataGridView.Columns.Add("komisi", "Komisi");

            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 142, 123);
            dataGridView.EnableHeadersVisualStyles = false;

            //Agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridView.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["nama_pelanggan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["tanggal_waktu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["alamat_tujuan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["ongkos_kirim"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["komisi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

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
                    dataGridView.Rows.Add(o.Id, o.Pelanggan.Nama, o.Tanggal_waktu, o.Alamat_tujuan, o.Ongkos_kirim, Math.Round(o.Ongkos_kirim * 0.8, 2));
                }
            }
            else
            {
                dataGridView.DataSource = null;
            }

            //Tampilkan button Tolak
            if (!dataGridView.Columns.Contains("btnTolak"))
            {
                DataGridViewButtonColumn bcolTolak = new DataGridViewButtonColumn();

                bcolTolak.HeaderText = "Aksi";
                bcolTolak.Text = "Tolak";
                bcolTolak.Name = "btnTolak";
                bcolTolak.UseColumnTextForButtonValue = true;

                dataGridView.Columns.Add(bcolTolak);
            }

            //Tampilkan button Selesai dikirim
            if (!dataGridView.Columns.Contains("btnSelesaiDikirim"))
            {
                DataGridViewButtonColumn bcolSelesaiDikirim = new DataGridViewButtonColumn();

                bcolSelesaiDikirim.HeaderText = "Aksi";
                bcolSelesaiDikirim.Text = "Selesai Dikirim";
                bcolSelesaiDikirim.Name = "btnSelesaiDikirim";
                bcolSelesaiDikirim.UseColumnTextForButtonValue = true;

                dataGridView.Columns.Add(bcolSelesaiDikirim);
            }
        }

        private string ToSentenceCase(string word)
        {
            string str;

            if (word.Length == 0) str = "";
            else if (word.Length == 1) str = char.ToUpper(word[0]).ToString();
            else str = (char.ToUpper(word[0]) + word.Substring(1)).ToString();

            return str;
        }
        #endregion

        #region FormLoad
        private void FormDaftarPengiriman_Load(object sender, EventArgs e)
        {
            try
            {
                //Panggil Method untuk menambah kolom pada datagridview
                FormatDataGrid();

                //Tampilkan semua data
                listOrder = Order.BacaData("Pesanan Diproses", "o.driver_id", FormUtama.rider.Id.ToString());

                //Tampilkan semua isi list di datagridview (Panggil method TampilDataGridView)
                TampilDataGrid();

                comboBoxKriteria.Text = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error. Pesan kesalahan : " + ex.Message, "Error");
            }

        }
        #endregion

        #region DataGrid
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Menghapus data bila button hapus diklik
                long id = long.Parse(dataGridView.CurrentRow.Cells["id"].Value.ToString());
                string nama = dataGridView.CurrentRow.Cells["nama_pelanggan"].Value.ToString();

                //Kalau button tolak diklik
                if (e.ColumnIndex == dataGridView.Columns["btnTolak"].Index && e.RowIndex >= 0)
                {
                    DialogResult hasil = MessageBox.Show(this, "Apakah anda yakin akan menolak pesanan ini?",
                                                         "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //Kalau User klik yes
                    if (hasil == DialogResult.Yes)
                    {
                        o = Order.AmbilData(id);

                        o.Status = "Cancelled";

                        Order.UbahData(o);

                        //buat notifikasi
                        Notifikasi notifikasi = new Notifikasi("Order Cancelled", "order", "konsumen", DateTime.Now, o.Pelanggan, o.Driver, null, null);
                        Notifikasi.TambahData(notifikasi);

                        FormDaftarPengiriman_Load(sender, e);
                    }
                }

                //Kalau button selesai dikirim diklik
                if (e.ColumnIndex == dataGridView.Columns["btnSelesaiDikirim"].Index && e.RowIndex >= 0)
                {
                    DialogResult hasil = MessageBox.Show(this, "Apakah pesanan dengan ID (" + id + ") atas nama " + ToSentenceCase(nama) + " sudah selesai anda kirim?",
                                                         "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //Kalau User klik yes
                    if (hasil == DialogResult.Yes)
                    {
                        o = Order.AmbilData(id);

                        o.Status = "Order Selesai";

                        Order.UbahData(o);
                        FormDaftarPengiriman_Load(sender, e);

                        MessageBox.Show("Terima kasih telah mengirim order ini. Selamat melakukan aktifitas kembali");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Order gagal di update, Pesan kesalahan: " + ex.Message, "Error");
            }
        }
        #endregion

        #region ButtonSearch
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string kriteria = "";
            switch (comboBoxKriteria.Text)
            {
                case "Id":
                    kriteria = "o.id";
                    break;

                case "Tanggal":
                    kriteria = "o.tanggal_waktu";
                    break;

                case "Alamat":
                    kriteria = "o.alamat_tujuan";
                    break;

                case "Ongkos Kirim":
                    kriteria = "o.ongkos_kirim";
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
        private void buttonSearch_MouseEnter(object sender, EventArgs e)
        {
            buttonSearch.BackgroundImage = Properties.Resources.Button_Hover;
        }
        private void buttonSearch_MouseLeave(object sender, EventArgs e)
        {
            buttonSearch.BackgroundImage = Properties.Resources.Button_Leave;
        }
        #endregion

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
