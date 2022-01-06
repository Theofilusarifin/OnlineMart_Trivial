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
    public partial class FormNotifikasi : Form
    {
        public FormNotifikasi()
        {
            InitializeComponent();
        }

        List<Notifikasi> listNotifikasi = new List<Notifikasi>();
        List<string> listTipe = new List<string>();

        private string kriteria = "";
        private string nilaiKriteria = "";

        public static int idNotif;

        #region Methods
        private void FormatDataGrid()
        {
            //Kosongi semua kolom di datagridview
            dataGridView.Columns.Clear();

            //Menambah kolom di datagridview
            dataGridView.Columns.Add("iconType", "Gambar"); // nanti ada gambar per tipe notif
            dataGridView.Columns.Add("isi", "");
            dataGridView.Columns.Add("waktu", "Waktu");

            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 142, 123);
            dataGridView.EnableHeadersVisualStyles = false;

            //Agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridView.Columns["iconType"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["isi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["waktu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            //Kosongi isi datagridview
            dataGridView.Rows.Clear();

            if (listNotifikasi.Count > 0)
            {
                foreach (Notifikasi n in listNotifikasi)
                {
                    dataGridView.Rows.Add("gambar sesuai n.Tipe", n.Isi, n.Waktu);
                }
            }
            else
            {
                dataGridView.DataSource = null;
            }

            //Tampilkan button Tolak
            if (!dataGridView.Columns.Contains("btnDetail"))
            {
                DataGridViewButtonColumn bcolDetail = new DataGridViewButtonColumn();

                bcolDetail.HeaderText = "";
                bcolDetail.Text = "Lihat Detail";
                bcolDetail.Name = "btnDetail";
                bcolDetail.UseColumnTextForButtonValue = true;

                dataGridView.Columns.Add(bcolDetail);
            }
        }
        private string ToSentenceCase(string word)
        {
            string str;

            if (word.Length == 0) str = "";
            else if (word.Length == 1) str = char.ToUpper(word[0]).ToString();
            else str = (char.ToUpper(word[0]) + word.Substring(1)).ToString();

            return str;
        }
        #endregion

        private void FormNotifikasi_Load(object sender, EventArgs e)
        {
            try
            {
                FormatDataGrid();

                listNotifikasi = Notifikasi.BacaData(kriteria, nilaiKriteria);

                TampilDataGrid();

                foreach (Notifikasi n in listNotifikasi)
                {
                    listTipe.Add(ToSentenceCase(n.Tipe));
                }
                listTipe.Insert(0, "All");

                comboBoxTipe.DataSource = listTipe;
                comboBoxTipe.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error. Pesan kesalahan : " + ex.Message, "Error");
            }
        }

        private void comboBoxTipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTipe.SelectedItem.ToString() == "All")
                {
                    kriteria = "";
                    nilaiKriteria = "";
                }
                else
                {
                    kriteria = "n.tipe";
                    nilaiKriteria = comboBoxTipe.SelectedItem.ToString();
                }
                FormNotifikasi_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error. Pesan kesalahan : " + ex.Message, "Error");
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dataGridView.Columns["btnDetail"].Index && e.RowIndex >= 0)
                {
                    //idNotif = int.Parse(dataGridView.CurrentRow.DataBoundItem.)
                    //MessageBox.Show("idNotif = " + idNotif);

                    // Open FormDetailNotifikasi
                    FormDetailNotifikasi frm = new FormDetailNotifikasi();
                    frm.Owner = this;
                    frm.Show();
                    this.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ups terjadi kesalahan, Pesan kesalahan : " + ex.Message, "Error");
            }
        }
    }
}
