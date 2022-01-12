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
	public partial class FormAccPenjual : Form
	{
		public FormAccPenjual()
		{
			InitializeComponent();
		}
        public static List<Penjual> listPenjual = new List<Penjual>();

        #region Methods
        private void FormatDataGrid()
        {
            //Kosongi semua kolom di datagridview
            dataGridView.Columns.Clear();

            //Menambah kolom di datagridview
            dataGridView.Columns.Add("id", "Id");
            dataGridView.Columns.Add("username", "username Penjual");
            dataGridView.Columns.Add("nama", "Nama Penjual");
            dataGridView.Columns.Add("email", "Email Penjual");
            dataGridView.Columns.Add("status", "Status Penjual");
            dataGridView.Columns.Add("telepon", "Telepon Penjual");

            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 142, 123);
            dataGridView.EnableHeadersVisualStyles = false;

            //Agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridView.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["username"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["telepon"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            //Kosongi isi datagridview
            dataGridView.Rows.Clear();

            if (listPenjual.Count > 0)
            {
                foreach (Penjual p in listPenjual)
                {
                    dataGridView.Rows.Add(p.Id, p.Username, p.Nama, p.Email, p.Status, p.Telpon);
                }
            }
            else
            {
                dataGridView.DataSource = null;
            }

            //Tampilkan button Ubah dan Hapus
            if (!dataGridView.Columns.Contains("btnAcc"))
            {
                DataGridViewButtonColumn bcolAcc = new DataGridViewButtonColumn();

                bcolAcc.HeaderText = "Aksi";
                bcolAcc.Text = "Konfirmasi";
                bcolAcc.Name = "btnAcc";
                bcolAcc.UseColumnTextForButtonValue = true;
                dataGridView.Columns.Add(bcolAcc);
            }
            
        }
		#endregion

		#region Form Load
		private void FormAccPenjual_Load(object sender, EventArgs e)
		{
            try
            {
                //Default list semua barang di cabang yang pertama
                listPenjual = Penjual.BacaData("status", "Not Ready");

                //Panggil Method untuk menambah kolom pada datagridview
                FormatDataGrid();
                TampilDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
		#endregion

		#region Button Close
		private void buttonClose_Click(object sender, EventArgs e)
		{
            this.Close();
		}
		#endregion

		#region Datagrid
		private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
            try
            {
                int id = int.Parse(dataGridView.CurrentRow.Cells["id"].Value.ToString());
                Penjual p = Penjual.AmbilData(id);
                //Kalau button Tambah ke keranjang diklik
                if (e.ColumnIndex == dataGridView.Columns["btnAcc"].Index && e.RowIndex >= 0)
                {
                    p.Status = "OK";
                    if (Penjual.UbahData(p))
					{
                        MessageBox.Show("Penjual berhasil di konfirmasi! Status telah diubah");
                        FormAccPenjual_Load(sender, e);
                    }
                    else
					{
                        MessageBox.Show("Gagal untuk mengkonfirmasi penjual");
                        FormAccPenjual_Load(sender, e);
					}
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
        #endregion

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
