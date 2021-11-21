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

        private void TampilkanPesan()
        {
            // Bersihkan list box sebelum menambah data baru
            listBoxPesan.Items.Clear();

            // Define isi chat
            listChat = Chat.BacaData("id", long.Parse(comboBoxNomorNota.Text), FormUtama.koneksi);
            
            // Tampilkan pesan
            foreach (Chat c in listChat)
            {
                if (c.Role_pengirim == "Pelanggan") 
                {
                    listBoxPesan.Items.Add("Me : " + c.Isi);
                }
                else if (c.Role_pengirim == "Driver")
                {
                    listBoxPesan.Items.Add("Driver : " + c.Isi);
                }
            }
        }

        private void FormCekPesanan_Load(object sender, EventArgs e)
        {
            listOrder = Order.BacaData("", "");

            comboBoxNomorNota.DataSource = listOrder;
            comboBoxNomorNota.DisplayMember = "Id";

            comboBoxNomorNota.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBoxKriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Tampilkan Pesan berdasarkan order id yang dipilih
            TampilkanPesan();
        }

        private void buttonKirim_Click(object sender, EventArgs e)
        {
            // Ambil id order yang sedang dipilih
            Order o = Order.AmbilData(long.Parse(comboBoxNomorNota.Text));

            // Buat Chat baru
            Chat chat = new Chat(textBoxPesan.Text, DateTime.Now, "Pelanggan", o, o.Driver, o.Pelanggan);

            // Refresh ListBox
            TampilkanPesan();

            // Bersihkan Text Box
            textBoxPesan.Clear();
        }
    }
}
