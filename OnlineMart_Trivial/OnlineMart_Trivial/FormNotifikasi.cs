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
using System.IO;

namespace OnlineMart_Trivial
{
    public partial class FormNotifikasi : Form
    {
        public FormNotifikasi()
        {
            InitializeComponent();
        }

        List<Notifikasi> listNotifikasi = new List<Notifikasi>();

        private string kriteria = "";
        private string nilaiKriteria = "";

        public static int idNotif;

        #region Methods
        private void FormatDataGrid()
        {
            //Kosongi semua kolom di datagridview
            dataGridView.Columns.Clear();

            //Menambah kolom di datagridview

            DataGridViewImageColumn dgvimgcol = new DataGridViewImageColumn();
            dgvimgcol.HeaderText = "Icon Notif";
            dgvimgcol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView.Columns.Add(dgvimgcol);
            dataGridView.RowTemplate.Height = 80;

            dataGridView.Columns.Add("isi", "");
            dataGridView.Columns.Add("waktu", "Waktu");

            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 142, 123);
            dataGridView.EnableHeadersVisualStyles = false;

            //Agar lebar kolom dapat menyesuaikan panjang / isi data
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
                    //MessageBox.Show("Role user : " + n.Role_user + ", role : " + FormUtama.role + ", n.Pelanggan.Id : " + n.Pelanggan.Id + ", " +
                    //                "FormUtama.konsumen.Id : " + FormUtama.konsumen.Id + ", FormUtama.rider.Id : " + FormUtama.rider.Id + ", " +
                    //                "FormUtama.pegawai.Id : " + FormUtama.pegawai.Id + "FormUtama.penjual.Id : " + FormUtama.penjual.Id);


                    string path = "";
                    PictureBox image = new PictureBox();
                    switch (n.Tipe)
                    {
                        case "order":
                            path = Path.Combine(FormUtama.location + "\\notif\\", "receipt.png");
                            image.Image = Image.FromFile(path);
                            break;
                        case "chat":
                            path = Path.Combine(FormUtama.location + "\\notif\\", "bubble-chat.png");
                            image.Image = Image.FromFile(path);
                            break;
                    }

                    MemoryStream mmst = new MemoryStream();
                    image.Image.Save(mmst, image.Image.RawFormat);
                    byte[] img = mmst.ToArray();

                    if (n.Role_user == "konsumen" && FormUtama.role == "konsumen" && n.Pelanggan.Id == FormUtama.konsumen.Id)
                    {
                        dataGridView.Rows.Add(img, n.Isi, n.Waktu);
                    }
                    else if (n.Role_user == "driver" && FormUtama.role == "rider" && n.Driver.Id == FormUtama.rider.Id)
                    {
                        dataGridView.Rows.Add(img, n.Isi, n.Waktu);
                    }
                    else if (n.Role_user == "pegawai" && FormUtama.role == "pegawai" && n.Pegawai.Id == FormUtama.pegawai.Id)
                    {
                        dataGridView.Rows.Add(img, n.Isi, n.Waktu);
                    }
                    else if (n.Role_user == "penjual" && FormUtama.role == "penjual" && n.Penjual.Id == FormUtama.penjual.Id)
                    {
                        dataGridView.Rows.Add(img, n.Isi, n.Waktu);
                    }
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
                List<string> listTipe = new List<string>();

                listNotifikasi = Notifikasi.BacaData(kriteria, nilaiKriteria);

                listTipe = Notifikasi.AmbilTipe();
                listTipe.Insert(0, "All");

                comboBoxTipe.DataSource = listTipe;
                comboBoxTipe.DropDownStyle = ComboBoxStyle.DropDownList;

                FormatDataGrid();
                TampilDataGrid();
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
                    // ambil index row noti dari datagrid
                    int index = dataGridView.CurrentRow.Index;
                    //MessageBox.Show("index : " + index);

                    // ambil data notif
                    Notifikasi notifikasi = listNotifikasi[index];
                    idNotif = notifikasi.Id;
                    //MessageBox.Show("idNotif : " + idNotif);

                    switch (notifikasi.Tipe)
                    {
                        case "order":
                            switch (FormUtama.role)
                            {
                                case "konsumen":
                                    
                                    break;
                                case "rider":
                                    FormUtama.frmUtama.openChildForm(new FormDaftarPengiriman());
                                    break;
                                case "pegawai":

                                    break;
                                case "penjual":

                                    break;
                            }
                            break;

                        case "chat":
                            switch (FormUtama.role)
                            {
                                case "konsumen":
                                    FormUtama.frmUtama.openChildForm(new FormCekPesanan());
                                    break;
                                case "rider":
                                    FormUtama.frmUtama.openChildForm(new FormChatPelanggan());
                                    break;
                                case "pegawai":

                                    break;
                                case "penjual":

                                    break;
                            }
                            break;
                    }

                    //// Open FormDetailNotifikasi
                    //FormDetailNotifikasi frm = new FormDetailNotifikasi();
                    //frm.Owner = this;
                    //frm.Show();
                    //this.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ups terjadi kesalahan, Pesan kesalahan : " + ex.Message, "Error");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Desain Button
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
