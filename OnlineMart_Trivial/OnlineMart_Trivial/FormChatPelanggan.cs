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
    public partial class FormChatPelanggan : Form
    {
        public FormChatPelanggan()
        {
            InitializeComponent();
        }

        List<Order> listOrder = new List<Order>();
        List<Chat> listChat = new List<Chat>();

        List<string> listStatus = new List<string>();

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

        #region Methods
        private void TampilkanPesan()
        {
            try
            {
                // Bersihkan list box sebelum menambah data baru
                listBoxPesan.Items.Clear();

                // Define isi chat
                listChat = Chat.BacaData("order_id", comboBoxNomorNota.Text);

                // Ambil id order yang sedang dipilih
                Order o = (Order)comboBoxNomorNota.SelectedItem;
                labelStatusPesanan.Text = o.Status.ToString();

                // Tampilkan pesan
                foreach (Chat c in listChat)
                {
                    if (c.Role_pengirim == "driver")
                    {
                        listBoxPesan.Items.Add("Me : " + c.Isi);
                    }
                    else
                    {
                        listBoxPesan.Items.Add("Konsumen : " + c.Isi);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi error. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }

        }
        #endregion

        #region FormLoad
        private void FormChatPelanggan_Load(object sender, EventArgs e)
        {
            try
            {
                //listStatus = Order.AmbilStatus();
                //listStatus.Insert(0, "");

                //comboBoxStatus.DataSource = listStatus;
                //comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;

                //listOrder = Order.BacaData(comboBoxStatus.SelectedItem.ToString(), "o.driver_id", FormUtama.rider.Id.ToString());

                listOrder = Order.BacaData("o.driver_id", FormUtama.rider.Id.ToString());

                comboBoxNomorNota.DataSource = listOrder;
                comboBoxNomorNota.DisplayMember = "Id";

                comboBoxNomorNota.DropDownStyle = ComboBoxStyle.DropDownList;

                TampilkanPesan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi error. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
        #endregion

        #region ComboBox
        private void comboBoxNomorNota_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Tampilkan Pesan berdasarkan order id yang dipilih
            TampilkanPesan();
        }
        #endregion

        #region Button
        private void buttonKirim_Click(object sender, EventArgs e)
        {
            try
            {
                // Ambil id order yang sedang dipilih
                Order o = (Order)comboBoxNomorNota.SelectedItem;

                // Buat Chat baru
                Chat chat = new Chat(textBoxPesan.Text, DateTime.Now, "driver", "konsumen", o, o.Driver, o.Pelanggan);

                // Tambahkan Chat Baru
                Chat.TambahData(chat);

                // Tampilkan pesan sementara ke ListBox
                listBoxPesan.Items.Add("Me : " + chat.Isi);

                // buat notifikasi
                Notifikasi notifikasi = new Notifikasi(chat.Isi, "chat", "konsumen", DateTime.Now, o.Pelanggan, o.Driver, null, null);
                Notifikasi.TambahData(notifikasi);

                // Bersihkan Text Box
                textBoxPesan.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Mengirim Pesan. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
        #endregion

        #region DesainButton
        private void buttonKirim_MouseEnter(object sender, EventArgs e)
        {
            buttonKirim.BackgroundImage = Properties.Resources.Button_Hover;
        }
        private void buttonKirim_MouseLeave(object sender, EventArgs e)
        {
            buttonKirim.BackgroundImage = Properties.Resources.Button_Leave;
        }
        #endregion
        
    }
}
