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
    public partial class FormDaftarMetodePembayaran : Form
    {
        public List<Metode_pembayaran> listMetode = new List<Metode_pembayaran>();
        public FormDaftarMetodePembayaran()
        {
            InitializeComponent();
        }
        private void FormatDataGrid()
        {
            //Kosongi semua kolom di datagridview
            dataGridView.Columns.Clear();

            //Menambah kolom di datagridview
            dataGridView.Columns.Add("id", "Id");
            dataGridView.Columns.Add("nama", "Nama Metode");

            //Agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridView.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ReadOnly = true;
        }
        private void TampilDataGrid()
        {
            //Kosongi isi datagridview
            dataGridView.Rows.Clear();

            if (listMetode.Count > 0)
            {
                foreach (Metode_pembayaran m in listMetode)
                {
                    dataGridView.Rows.Add(m.Id, m.Nama);
                }
            }
            else
            {
                dataGridView.DataSource = null;
            }

            //Tampilkan button Ubah dan Hapus
            if (!dataGridView.Columns.Contains("btnUbahGrid"))
            {
                DataGridViewButtonColumn bcolUbah = new DataGridViewButtonColumn();

                bcolUbah.HeaderText = "Aksi";
                bcolUbah.Text = "Ubah";
                bcolUbah.Name = "btnUbahGrid";
                bcolUbah.UseColumnTextForButtonValue = true;
                bcolUbah.FlatStyle = FlatStyle.Flat;
                dataGridView.Columns.Add(bcolUbah);

                DataGridViewButtonColumn bcolHapus = new DataGridViewButtonColumn();

                bcolHapus.HeaderText = "Aksi";
                bcolHapus.Text = "Hapus";
                bcolHapus.Name = "btnHapusGrid";
                bcolHapus.UseColumnTextForButtonValue = true;
                bcolHapus.FlatStyle = FlatStyle.Flat;

                dataGridView.Columns.Add(bcolHapus);
            }
        }

		public void FormDaftarMetodePembayaran_Load_1(object sender, EventArgs e)
		{
            //Panggil Method untuk menambah kolom pada datagridview
            FormatDataGrid();

            //Tampilkan semua data
            listMetode = Metode_pembayaran.BacaData("", "");

            //Tampilkan semua isi list di datagridview (Panggil method TampilDataGridView)
            TampilDataGrid();

            comboBoxKriteria.Text = "Id";
        }

		private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
                //Menghapus data bila button hapus diklik
                int id = int.Parse(dataGridView.CurrentRow.Cells["Id"].Value.ToString());


                //Kalau button hapus diklik
                if (e.ColumnIndex == dataGridView.Columns["btnHapusGrid"].Index && e.RowIndex >= 0)
                {
                    string idHapus = dataGridView.CurrentRow.Cells["Id"].Value.ToString();
                    string namaHapus = dataGridView.CurrentRow.Cells["Nama"].Value.ToString();

                    //User ditanya sesuai dibawah
                    DialogResult hasil = MessageBox.Show(this, "Anda yakin akan menghapus Id " + idHapus + " - " + namaHapus + "?",
                                                         "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //Kalau User klik yes barang akan dihapus
                    if (hasil == DialogResult.Yes)
                    {
                        Boolean hapus = Metode_pembayaran.HapusData(id);

                        if (hapus == true)
                        {
                            MessageBox.Show("Penghapusan data berhasil");
                            // Refresh Halaman
                            FormDaftarMetodePembayaran_Load_1(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Penghapusan data gagal");
                        }
                    }
                }
                //Kalau button ubah diklik
                if (e.ColumnIndex == dataGridView.Columns["btnUbahGrid"].Index && e.RowIndex >= 0)
                {
                    FormUbahMetodePembayaran.IdDipilih = id;
                    FormUbahMetodePembayaran frm = new FormUbahMetodePembayaran();
                    frm.Owner = this;
                    frm.Show();
                }
            }
            catch (Exception ex)
			{
                MessageBox.Show(ex.Message);
			}
		}

		private void buttonTambah_Click(object sender, EventArgs e)
		{
            FormTambahMetodePembayaran formTambahMetodePembayaran = new FormTambahMetodePembayaran();
            formTambahMetodePembayaran.Owner = this;
            formTambahMetodePembayaran.ShowDialog();
		}

		private void textBoxKriteria_TextChanged(object sender, EventArgs e)
		{
            string kriteria = "";
            switch (comboBoxKriteria.Text)
            {
                case "ID":
                    kriteria = "id";
                    break;

                case "Nama":
                    kriteria = "nama";
                    break;
            }

            listMetode = Metode_pembayaran.BacaData(kriteria, textBoxKriteria.Text);
            FormatDataGrid();
            TampilDataGrid();
        }

		private void buttonClose_Click(object sender, EventArgs e)
		{
            this.Close();
		}
	}
}
