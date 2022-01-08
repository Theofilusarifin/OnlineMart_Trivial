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
	public partial class FormDaftarPenjual : Form
	{
		#region Public Variable
		public static List<Penjual> listPenjual = new List<Penjual>();
        public static Penjual penjual;
		#endregion

		public FormDaftarPenjual()
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

		#region Method
		private void FormatDataGrid()
        {
            //Kosongi semua kolom di datagridview
            dataGridView.Columns.Clear();

            //Menambah kolom di datagridview
            dataGridView.Columns.Add("id", "Id");
            dataGridView.Columns.Add("username", "Username Penjual");
            dataGridView.Columns.Add("nama", "Nama Penjual");
            dataGridView.Columns.Add("email", "Email Penjual");
            dataGridView.Columns.Add("status", "Status Penjual");
            dataGridView.Columns.Add("telpon", "Telpon Penjual");


            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 142, 123);
            dataGridView.EnableHeadersVisualStyles = false;

            //Agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridView.Columns["username"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["telpon"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

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
                    if (p.Blacklist != null)
					{
                        DataGridViewButtonColumn bcolRemove = new DataGridViewButtonColumn();

                        bcolRemove.HeaderText = "Aksi";
                        bcolRemove.Text = "Remove Blacklist";
                        bcolRemove.Name = "btnRemoveBlacklist";
                        bcolRemove.UseColumnTextForButtonValue = true;
                        dataGridView.Columns.Add(bcolRemove);
                    }
                }
            }
            else
            {
                dataGridView.DataSource = null;
            }

            //Tampilkan button Ubah dan Hapus
            //if (!dataGridView.Columns.Contains("btnRemoveBlacklist"))
            //{
            //    DataGridViewButtonColumn bcolRemove = new DataGridViewButtonColumn();

            //    bcolRemove.HeaderText = "Aksi";
            //    bcolRemove.Text = "Remove Blacklist";
            //    bcolRemove.Name = "btnRemoveBlacklist";
            //    bcolRemove.UseColumnTextForButtonValue = true;
            //    dataGridView.Columns.Add(bcolRemove);

            //}
            if (!dataGridView.Columns.Contains("btnBlacklist"))
            {
                //Button tambah ke keranjang
                DataGridViewButtonColumn bcolBlacklist = new DataGridViewButtonColumn();

                bcolBlacklist.HeaderText = "Blacklist";
                bcolBlacklist.Text = "Blacklist toko";
                bcolBlacklist.Name = "btnBlacklist";
                bcolBlacklist.UseColumnTextForButtonValue = true;
                dataGridView.Columns.Add(bcolBlacklist);
            }
        }
        #endregion

        #region Form Load
        public void FormDaftarPenjual_Load(object sender, EventArgs e)
		{
            try
            {
                //Panggil Method untuk menambah kolom pada datagridview
                FormatDataGrid();

                //Tampilkan semua data
                listPenjual = Penjual.BacaData("", "");

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

		#region Button Close
		private void buttonClose_Click(object sender, EventArgs e)
		{
            this.Close();
		}
		#endregion

		#region Button Search
		private void buttonSearch_Click(object sender, EventArgs e)
		{
            string kriteria = "";
            switch (comboBoxKriteria.Text)
			{
                case "Id":
                    kriteria = "p.id";
                    break;
                case "Username":
                    kriteria = "p.username";
                    break;
                case "Nama":
                    kriteria = "p.nama";
                    break;
                case "Email":
                    kriteria = "p.email";
                    break;
                case "Status":
                    kriteria = "p.status";
                    break;
                case "Telpon":
                    kriteria = "p.telpon";
                    break;
            }
            listPenjual = Penjual.BacaData(kriteria, textBoxKriteria.Text);
            FormatDataGrid();
            TampilDataGrid();
        }
		#endregion

		#region Datagrid
		private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
            try
            {
                int id = int.Parse(dataGridView.CurrentRow.Cells["id"].Value.ToString());
                Penjual p = Penjual.AmbilData(id);
                if (e.ColumnIndex == dataGridView.Columns["btnBlacklist"].Index && e.RowIndex >= 0)
                {
                    penjual = p;
                    FormBlacklist formBlacklist = new FormBlacklist();
                    formBlacklist.Owner = this;
                    formBlacklist.ShowDialog();
                    this.Hide();
                }
                if (e.ColumnIndex == dataGridView.Columns["btnRemoveBlacklist"].Index && e.RowIndex >= 0)
                {
                    Blacklist b = null;
                    Penjual.UbahData(p, b);
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
        #endregion
    }
}
