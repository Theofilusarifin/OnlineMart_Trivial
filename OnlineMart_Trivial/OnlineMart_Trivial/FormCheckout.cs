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
        List<Driver> kurir = new List<Driver>();

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

                #region Default value data order
                textBoxId.Text = FormKeranjang.thisOrder.Id.ToString();

                FormKeranjang.thisOrder.Tanggal_waktu = DateTime.Now;

                textBoxOngkosKirim.Text = 10000.ToString();

                FormKeranjang.thisOrder.Cara_bayar = "Transfer";

                FormKeranjang.thisOrder.Status = "Menunggu Pembayaran";

                FormKeranjang.thisOrder.Cabang.Id = 1;

                FormKeranjang.thisOrder.Pelanggan.Id = pelanggan.Id;
                #endregion

                #region combobox
                //memunculkan promo yang ada di combobox
                promo = Promo.BacaData("", "");
                comboBoxMetodeBayar.DataSource = promo;
                comboBoxMetodeBayar.DisplayMember = "Nama";
                comboBoxMetodeBayar.DropDownStyle = ComboBoxStyle.DropDownList;

                //memunculkan metode pembayaran yang ada di combobox
                metode = Metode_pembayaran.BacaData("", "");
                comboBoxMetodeBayar.DataSource = metode;
                comboBoxMetodeBayar.DisplayMember = "Nama";
                comboBoxMetodeBayar.DropDownStyle = ComboBoxStyle.DropDownList;

                //memunculkan kurir yang ada di combobox
                kurir = Driver.BacaData("", "");
                comboBoxMetodeBayar.DataSource = kurir;
                comboBoxMetodeBayar.DisplayMember = "Nama";
                comboBoxMetodeBayar.DropDownStyle = ComboBoxStyle.DropDownList;
                #endregion

                Order.BacaData("id", FormKeranjang.thisOrder.Id.ToString());

                // kalau salah satu dari metode pembayaran dan driver kosong atau keduanya kosong, maka buttonBayar tidak bisa diklik
                if (FormKeranjang.thisOrder.Metode_pembayaran == null || FormKeranjang.thisOrder.Driver == null)
                    buttonBayar.Enabled = false;
                else // kalau keduanya punya data maka button bisa diklik
                    buttonBayar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi error. Pesan kesalahan : " + ex.Message, "Error");
            }
        }

        private void textBoxAlamat_TextChanged(object sender, EventArgs e)
        {
            FormKeranjang.thisOrder.Alamat_tujuan = textBoxAlamat.Text;
        }

        private void comboBoxPromo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //ambil promo yang dipilih
                Promo promoDipilih = (Promo)comboBoxPromo.SelectedItem;

                FormKeranjang.thisOrder.Promo = promoDipilih;

                //refresh form
                FormCheckout_Load(sender, e);
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

                FormKeranjang.thisOrder.Metode_pembayaran = metodeDipilih;

                //refresh form
                FormCheckout_Load(sender,e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi error. Pesan kesalahan : " + ex.Message, "Error");
            }
        }

        private void comboBoxKurir_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //ambil kurir yang dipilih
                Driver kurirDipilih = (Driver)comboBoxKurir.SelectedItem;

                FormKeranjang.thisOrder.Driver = kurirDipilih;

                //refresh form
                FormCheckout_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi error. Pesan kesalahan : " + ex.Message, "Error");
            }
        }

        private void buttonBayar_Click(object sender, EventArgs e)
        {
            try 
            {
                FormKeranjang.thisOrder.Status = "Pesanan Diproses";

                Order.TambahData(FormKeranjang.thisOrder);

                FormKeranjang.thisOrder = null;
                FormUtama.keranjang.Clear();

                MessageBox.Show("Pembayaran berhasil. Pesanan sedang diproses", "Info");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
