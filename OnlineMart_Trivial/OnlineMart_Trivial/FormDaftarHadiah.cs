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
    public partial class FormDaftarHadiah : Form
    {
        public FormDaftarHadiah()
        {
            InitializeComponent();
        }

        public List<Gift> listGift = new List<Gift>();

        private void FormDaftarGift_Load(object sender, EventArgs e)
        {
            listGift = Gift.BacaData("","");

            if(listGift.Count > 0)
            {
                //kalau ada data maka tampilkan di data grid
                dataGridView.DataSource = listGift;

                if(!dataGridView.Columns.Contains("btnUbahGrid"))
                {
                    DataGridViewButtonColumn bcolUbah = new DataGridViewButtonColumn();

                    bcolUbah.HeaderText = "Aksi";
                    bcolUbah.Text = "Ubah";
                    bcolUbah.Name = "btnUbahGrid";
                    bcolUbah.UseColumnTextForButtonValue = true;
                    dataGridView.Columns.Add(bcolUbah);

                    DataGridViewButtonColumn bcolHapus = new DataGridViewButtonColumn();
                    bcolHapus.HeaderText = "Aksi";
                    bcolHapus.Text = "Hapus";
                    bcolHapus.Name = "btnHapusGrid";
                    bcolHapus.UseColumnTextForButtonValue = true;
                    dataGridView.Columns.Add(bcolHapus);
                }
            }
            else
            {
                dataGridView.DataSource = null;
            }
        }

		private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
