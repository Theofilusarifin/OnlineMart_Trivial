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
    public partial class FormRiwayatIsiSaldo : Form
    {
        public FormRiwayatIsiSaldo()
        {
            InitializeComponent();
        }
        public List<Riwayat_isi_saldo> listRiwayat = new List<Riwayat_isi_saldo>();

        private void dataGridViewRiwayat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Kosongi semua kolom di datagridview
            dataGridViewRiwayat.Columns.Clear();

            //Menambah kolom di datagridview
            dataGridViewRiwayat.Columns.Add("id", "Id");
            dataGridViewRiwayat.Columns.Add("waktu", "Waktu");
            dataGridViewRiwayat.Columns.Add("isiSaldo", "Isi Saldo");
            dataGridViewRiwayat.Columns.Add("pelanggan_id", "Pelanggan");

            //Agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridViewRiwayat.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewRiwayat.Columns["waktu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewRiwayat.Columns["isiSaldo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewRiwayat.Columns["pelanggan_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridViewRiwayat.AllowUserToAddRows = false;
            dataGridViewRiwayat.ReadOnly = true;
        }
    }
}
