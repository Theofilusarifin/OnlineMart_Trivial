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
        public static Order thisOrder;

        public FormKeranjang()
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
            dataGridView.Columns.Add("nama", "Nama Barang");
            dataGridView.Columns.Add("harga", "Harga Barang");
            dataGridView.Columns.Add("kategori_id", "Kategori");

            //Agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridView.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["kategori_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // Agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            //Kosongi isi datagridview
            dataGridView.Rows.Clear();

            if (FormUtama.keranjang.Count > 0)
            {
                foreach (Barang b in FormUtama.keranjang)
                {
                    dataGridView.Rows.Add(b.Id, b.Nama, b.Harga, b.Kategori.Nama);
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
                bcolHapus.FlatStyle = FlatStyle.Flat;
                bcolHapus.DefaultCellStyle.Font = new Font("Montserrat", 9, FontStyle.Bold);
                bcolHapus.DefaultCellStyle.ForeColor = Color.White;
                bcolHapus.DefaultCellStyle.BackColor = Color.FromArgb(227, 65, 35);

                dataGridView.Columns.Add(bcolHapus);
            }
        }
        #endregion

        #region FormLoad
        private void FormKeranjang_Load(object sender, EventArgs e)
		{
            try
            {
                //generate id order yyyyMMddxxxx (yyyy-MM-dd-xxxx) detail ada di class order
                thisOrder.Id = int.Parse(Order.GenerateIdOrder());

                //Panggil Method untuk menambah kolom pada datagridview
                FormatDataGrid();

                //Tampilkan semua isi list di datagridview (Panggil method TampilDataGridView)
                TampilDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Datagrid
        private void dataGridViewKeranjang_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                        MessageBox.Show("Penghapusan gagal");
					}
                }
            }
			catch (Exception ex)
			{
                MessageBox.Show(ex.Message);
			}
		}

        #endregion

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            FormCheckout checkout = new FormCheckout();
            checkout.Owner = this;
            checkout.Show();

            this.Close();
        }
    }
}
