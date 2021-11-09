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

        public void FormDaftarGift_Load(object sender, EventArgs e)
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
                        Boolean hapus = Gift.HapusData(id);

                        if (hapus == true)
                        {
                            MessageBox.Show("Penghapusan data berhasil");
                            // Refresh Halaman
                            FormDaftarGift_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Penghapusan data gagal");
                        }
                    }
                }
                //Kalau button ubah diklik
                if (e.ColumnIndex == dataGridView.Columns["btnUbahGrid"].Index && e.RowIndex >= 0)
                {
                    FormUbahHadiah.IdDipilih = id;
                    FormUbahHadiah frm = new FormUbahHadiah();
                    frm.Owner = this;
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

		private void buttonTambah_Click(object sender, EventArgs e)
		{
            FormTambahHadiah formTambahHadiah = new FormTambahHadiah();
            formTambahHadiah.Owner = this;
            formTambahHadiah.ShowDialog();
        }

		private void buttonClose_Click(object sender, EventArgs e)
		{
            this.Close();
		}
	}
}
