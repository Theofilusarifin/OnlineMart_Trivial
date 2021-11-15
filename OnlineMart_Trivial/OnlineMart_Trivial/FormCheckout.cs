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
    public partial class FormCheckout : Form
    {
        List<Metode_pembayaran> metode = new List<Metode_pembayaran>();
        List<Promo> promo = new List<Promo>();
        Pelanggan pelanggan;

        public FormCheckout()
        {
            InitializeComponent();
        }

        private void FormCheckout_Load(object sender, EventArgs e)
        {
            try
            {
                pelanggan = FormUtama.konsumen;

                //memunculkan metde pembayaran yang ada di combobox
                metode = Metode_pembayaran.BacaData("", "");
                comboBoxMetodeBayar.DataSource = metode;
                comboBoxMetodeBayar.DisplayMember = "Nama";
                comboBoxMetodeBayar.DropDownStyle = ComboBoxStyle.DropDownList;

                //memunculkan promo yang ada di combobox
                promo = Promo.BacaData("", "");
                comboBoxMetodeBayar.DataSource = promo;
                comboBoxMetodeBayar.DisplayMember = "Nama";
                comboBoxMetodeBayar.DropDownStyle = ComboBoxStyle.DropDownList;

                //Order.BacaData("id", FormKeranjang.thisOrder.Id.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi error. Pesan kesalahan : " + ex.Message, "Error");
            }
        }
        private void comboBoxMetodeBayar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //ambil metode pembayaran yang dipilih
                Metode_pembayaran metodeDipilih = (Metode_pembayaran)comboBoxMetodeBayar.SelectedItem;

                //ambil data order ini
                Order orderLama = Order.AmbilData(FormKeranjang.thisOrder.Id);

                //ganti metode pembayaran sesuai dengan yang dipilih pelanggan
                orderLama.Metode_pembayaran = metodeDipilih;

                //ganti data lama dengan data baru
                Order.UbahData(orderLama);

                //refresh form
                FormCheckout_Load(sender,e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi error. Pesan kesalahan : " + ex.Message, "Error");
            }
        }
        private void comboBoxPromo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ambil promo yang dipilih
            Promo promoDipilih = (Promo)comboBoxPromo.SelectedItem;

            //ambil data order ini
            Order orderLama = Order.AmbilData(FormKeranjang.thisOrder.Id);

            //ganti promo sesuai dengan yang dipilih pelanggan
            orderLama.Promo = promoDipilih;

            //ganti data lama dengan data baru
            Order.UbahData(orderLama);

            //refresh form
            FormCheckout_Load(sender, e);
        }
        private void buttonBayar_Click(object sender, EventArgs e)
        {

        }
    }
}
