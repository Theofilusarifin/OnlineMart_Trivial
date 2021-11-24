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
    public partial class FormCekPesanan : Form
    {
        public FormCekPesanan()
        {
            InitializeComponent();
        }

        List<Order> listOrder = new List<Order>();
        List<Chat> listChat = new List<Chat>();

        #region Methodss
        private void TampilkanPesan()
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
                if (c.Role_pengirim == "konsumen") 
                {
                    listBoxPesan.Items.Add("Me : " + c.Isi);
                }
                else
                {
                    listBoxPesan.Items.Add("Driver : " + c.Isi);
                }
            }
        }
        #endregion

        #region FormLoad
        private void FormCekPesanan_Load(object sender, EventArgs e)
        {
            listOrder = Order.BacaData("o.pelanggan_id", FormUtama.konsumen.Id.ToString());

            comboBoxNomorNota.DataSource = listOrder;
            comboBoxNomorNota.DisplayMember = "Id";

            comboBoxNomorNota.DropDownStyle = ComboBoxStyle.DropDownList;

            TampilkanPesan();
        }
        #endregion

        #region ComboBox
        private void comboBoxKriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Tampilkan Pesan berdasarkan order id yang dipilih
            TampilkanPesan();
        }
        #endregion

        #region Button
        private void buttonKirim_Click(object sender, EventArgs e)
        {
            // Ambil id order yang sedang dipilih
            Order o = (Order)comboBoxNomorNota.SelectedItem;

            // Buat Chat baru
            Chat chat = new Chat(textBoxPesan.Text, DateTime.Now, "Konsumen", o, o.Driver, o.Pelanggan);

            // Tambahkan Chat Baru
            Chat.TambahData(chat);

            // Tampilkan pesan sementara ke ListBox
            listBoxPesan.Items.Add("Me : " + chat.Isi);

            // Bersihkan Text Box
            textBoxPesan.Clear();
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
