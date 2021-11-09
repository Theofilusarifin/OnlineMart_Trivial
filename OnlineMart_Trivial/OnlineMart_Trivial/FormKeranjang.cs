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
    public partial class FormKeranjang : Form
    {
        public FormKeranjang()
        {
            InitializeComponent();
        }
        private void FormatDataGrid()
        {
            //Kosongi semua kolom di datagridview
            dataGridViewKeranjang.Columns.Clear();

            //Menambah kolom di datagridview
            dataGridViewKeranjang.Columns.Add("id", "Id");
            dataGridViewKeranjang.Columns.Add("nama", "Nama Barang");
            dataGridViewKeranjang.Columns.Add("harga", "Harga Barang");
            dataGridViewKeranjang.Columns.Add("kategori_id", "Kategori");

            //Agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridViewKeranjang.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewKeranjang.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewKeranjang.Columns["harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewKeranjang.Columns["kategori_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridViewKeranjang.AllowUserToAddRows = false;
            dataGridViewKeranjang.ReadOnly = true;
        }
        private void TampilDataGrid()
        {
            //Kosongi isi datagridview
            dataGridViewKeranjang.Rows.Clear();

            if (FormUtama.keranjang.Count > 0)
            {
                foreach (Barang b in FormUtama.keranjang)
                {
                    dataGridViewKeranjang.Rows.Add(b.Id, b.Nama, b.Harga, b.Kategori.Nama);
                }
            }
            else
            {
                dataGridViewKeranjang.DataSource = null;
            }

            //Tampilkan button Ubah dan Hapus
            if (!dataGridViewKeranjang.Columns.Contains("btnHapusGrid"))
            {
                DataGridViewButtonColumn bcolHapus = new DataGridViewButtonColumn();

                bcolHapus.HeaderText = "Aksi";
                bcolHapus.Text = "Hapus";
                bcolHapus.Name = "btnHapusGrid";
                bcolHapus.UseColumnTextForButtonValue = true;
                bcolHapus.FlatStyle = FlatStyle.Flat;
                bcolHapus.DefaultCellStyle.Font = new Font("Montserrat", 9, FontStyle.Bold);
                bcolHapus.DefaultCellStyle.ForeColor = Color.White;
                bcolHapus.DefaultCellStyle.BackColor = Color.FromArgb(227, 65, 35);

                dataGridViewKeranjang.Columns.Add(bcolHapus);
            }
        }
        private void FormKeranjang_Load(object sender, EventArgs e)
		{
            //Panggil Method untuk menambah kolom pada datagridview
            FormatDataGrid();

            //Tampilkan semua isi list di datagridview (Panggil method TampilDataGridView)
            TampilDataGrid();
		}

		private void dataGridViewKeranjang_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
                //Menghapus data bila button hapus diklik
                int id = int.Parse(dataGridViewKeranjang.CurrentRow.Cells["Id"].Value.ToString());
                //Kalau button hapus diklik
                if (e.ColumnIndex == dataGridViewKeranjang.Columns["btnHapusGrid"].Index && e.RowIndex >= 0)
                {
                    string idHapus = dataGridViewKeranjang.CurrentRow.Cells["Id"].Value.ToString();
                    string namaHapus = dataGridViewKeranjang.CurrentRow.Cells["Nama"].Value.ToString();

                    //User ditanya sesuai dibawah
                    DialogResult hasil = MessageBox.Show(this, "Anda yakin akan menghapus Id " + idHapus + " - " + namaHapus + "?",
                                                         "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //Kalau User klik yes barang akan dihapus
                    if (hasil == DialogResult.Yes)
                    {
                        for (int i = 0; i < FormUtama.keranjang.Count; i++)
						{
                            Barang b = FormUtama.keranjang.ElementAt(i);
                            if (b.Id == id)
							{
                                FormUtama.keranjang.RemoveAt(i);
                            }
                        }
                        MessageBox.Show("Barang berhasil di hapus");
                        FormKeranjang_Load(sender, e);
                    }
					else
					{
                        MessageBox.Show("Penghapusan digagalkan");
					}
                }
            }
			catch (Exception ex)
			{
                MessageBox.Show(ex.Message);
			}
		}
	}
}
