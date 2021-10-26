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
    public partial class FormDaftarPromo : Form
    {
        public List<Promo> listPromo = new List<Promo>();
        public FormDaftarPromo()
        {
            InitializeComponent();
        }

		private void FormDaftarPromo_Load(object sender, EventArgs e)
		{
			listPromo = Promo.BacaData("", "");

			if (listPromo.Count > 0)
			{
				dataGridViewPromo.DataSource = listPromo; //menampilkan data

				if (!dataGridViewPromo.Columns.Contains("buttonUbah"))
				{
					DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
					bcol.HeaderText = "Aksi";
					bcol.Text = "Ubah";
					bcol.Name = "btnUbahGrid";
					bcol.UseColumnTextForButtonValue = true;
					dataGridViewPromo.Columns.Add(bcol);

					DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
					bcol2.HeaderText = "Aksi";
					bcol2.Text = "Hapus";
					bcol2.Name = "btnHapusGrid";
					bcol2.UseColumnTextForButtonValue = true;
					dataGridViewPromo.Columns.Add(bcol2);
				}
			}
			else
			{
				dataGridViewPromo.DataSource = null;
			}
		}
	}
}
