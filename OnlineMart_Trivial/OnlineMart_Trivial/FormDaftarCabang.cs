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

        private void FormatDataGrid()
        {
            //Kosongi semua kolom di datagridview
            dataGridView.Columns.Clear();

            //Menambah kolom di datagridview
            dataGridView.Columns.Add("id", "Id");
            dataGridView.Columns.Add("nama", "Nama Cabang");
            dataGridView.Columns.Add("alamat", "Alamat");
            dataGridView.Columns.Add("pegawai_id", "Pegawai");

            //Agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridView.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["alamat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["pegawai_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            //Kosongi isi datagridview
            dataGridView.Rows.Clear();

            if (listCabang.Count > 0)
            {
                foreach (Cabang c in listCabang)
                {
                    dataGridView.Rows.Add(c.Id, c.Nama, c.Alamat, c.Pegawai.Nama);
                }
            }
            else
            {
                dataGridView.DataSource = null;
            }
        }

        private void FormDaftarCabang_Load(object sender, EventArgs e)
        {
            // Panggil Method untuk menambah kolom pada datagridview
            FormatDataGrid();

            // Tampilkan semua data
            listCabang = Cabang.BacaData("", "");

            //Tampilkan semua isi list di datagridview (Panggil method TampilDataGridView)
            TampilDataGrid();
        }
    }
}
