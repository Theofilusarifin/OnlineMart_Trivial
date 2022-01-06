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
	public partial class FormDetailBarang : Form
	{
		#region Field
		public static Barang barang;
		public static List<Penilaian> listPenilaian = new List<Penilaian>();
        #endregion

        public FormDetailBarang()
		{
			InitializeComponent();
		}

		#region Method
		private void FormatDataGrid()
        {
            //Kosongi semua kolom di datagridview
            dataGridView.Columns.Clear();

            //Menambah kolom di datagridview
            dataGridView.Columns.Add("id", "Id");
            dataGridView.Columns.Add("rating", "Rating Barang");
            dataGridView.Columns.Add("review", "Review Barang");
            dataGridView.Columns.Add("barang_id", "ID Barang");

            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 142, 123);
            dataGridView.EnableHeadersVisualStyles = false;

            //Agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridView.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["rating"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["review"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["barang_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ReadOnly = true;
        }
        private void TampilDataGrid()
        {
            //Kosongi isi datagridview
            dataGridView.Rows.Clear();

            if (listPenilaian.Count > 0)
            {
                foreach (Penilaian p in listPenilaian)
                {
                    //dataGridView.Rows.Add(p.Id, p.Rating, p.Review, p.Barang.Id);
                }
            }
            else
            {
                dataGridView.DataSource = null;
            }
        }
		#endregion

		#region Form Load
		private void FormDetailBarang_Load(object sender, EventArgs e)
		{
            try
            {
                //Default list semua barang di cabang yang pertama
                listPenilaian = Penilaian.BacaData("", "");

                //Panggil Method untuk menambah kolom pada datagridview
                FormatDataGrid();

                //Tampilkan semua isi list di datagridview (Panggil method TampilDataGridView)
                TampilDataGrid();
                double rating = 0;
                for (int i = 0; i <= listPenilaian.Count; i++)
				{
                    Penilaian p = listPenilaian[i];
                    rating += p.Rating;
                    if (i == listPenilaian.Count)
					{
                        rating /= i;
					}
				}
                labelRating.Text = rating.ToString();
                comboBoxKriteria.Text = "Id";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
		#endregion

		#region Button Search
		private void buttonSearch_Click(object sender, EventArgs e)
		{
            string kriteria = "";
            switch (comboBoxKriteria.Text)
            {
                case "id":
                    kriteria = "id";
                    break;
                case "rating":
                    kriteria = "rating";
                    break;
                case "review":
                    kriteria = "review";
                    break;
            }
            listPenilaian = Penilaian.BacaData(kriteria, textBoxKriteria.Text);
            FormatDataGrid();
            TampilDataGrid();
        }
        #endregion
    }
}
