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
    public partial class FormDaftarCabang : Form
    {
        public FormDaftarCabang()
        {
            InitializeComponent();
        }

        public List<Cabang> listCabang = new List<Cabang>();

        private void FormDaftarCabang_Load(object sender, EventArgs e)
        {
            listCabang = Cabang.BacaData("", "");

            if(listCabang.Count > 0)
            {
                dataGridViewCabang.DataSource = listCabang;

                if(!dataGridViewCabang.Columns.Contains("btnUbahGrid"))
                {
                    DataGridViewButtonColumn bcolUbah = new DataGridViewButtonColumn();

                    bcolUbah.HeaderText = "Aksi";
                    bcolUbah.Text = "Ubah";
                    bcolUbah.Name = "btnUbahGrid";
                    bcolUbah.UseColumnTextForButtonValue = true;
                    dataGridViewCabang.Columns.Add(bcolUbah);


                    DataGridViewButtonColumn bcolHapus = new DataGridViewButtonColumn();

                    bcolHapus.HeaderText = "Aksi";
                    bcolHapus.Text = "Hapus";
                    bcolHapus.Name = "btnHapusGrid";
                    bcolHapus.UseColumnTextForButtonValue = true;
                    dataGridViewCabang.Columns.Add(bcolHapus);
                }
            }
            else
            {
                dataGridViewCabang.DataSource = null;
            }
        }
    }
}
