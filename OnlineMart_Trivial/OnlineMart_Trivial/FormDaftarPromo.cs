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
			}
			else
			{
				dataGridViewPromo.DataSource = null;
			}
		}
	}
}
