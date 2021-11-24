﻿using System;
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

        public FormCheckout()
        {
            InitializeComponent();
        }

        private void CheckButtonStatus()
        {
            // kalau salah satu dari metode pembayaran dan driver kosong atau keduanya kosong, maka buttonBayar tidak bisa diklik
            if (!(FormKeranjang.thisOrder.Metode_pembayaran == null) && !(FormKeranjang.thisOrder.Driver == null)) buttonBayar.Enabled = true;
            // kalau keduanya punya data maka button bisa diklik
            else buttonBayar.Enabled = false;
        }

        #region FormLoad
        private void FormCheckout_Load(object sender, EventArgs e)
        {
            try
            {
                if (FormKeranjang.thisOrder.Id == 0)
                {
                    MessageBox.Show("Lakukan Checkout Keranjang Terlebih Dahulu!");
                    this.Close();
                }
                else
                {
                    #region Default value data order
                    textBoxId.Text = FormKeranjang.thisOrder.Id.ToString();
                    textBoxTotalBayar.Text = FormKeranjang.thisOrder.Total_bayar.ToString();
                    textBoxOngkosKirim.Text = 10000.ToString();

                    FormKeranjang.thisOrder.Cabang = Cabang.AmbilData(1, FormUtama.koneksi);
                    FormKeranjang.thisOrder.Pelanggan = FormUtama.konsumen;
                    #endregion

                    #region combobox
                    //memunculkan promo yang ada di combobox
                    promo = Promo.BacaData("", "");
                    comboBoxPromo.DataSource = promo;
                    comboBoxPromo.DisplayMember = "Nama";
                    comboBoxPromo.DropDownStyle = ComboBoxStyle.DropDownList;

                    //memunculkan metode pembayaran yang ada di combobox
                    metode = Metode_pembayaran.BacaData("", "");
                    comboBoxMetodeBayar.DataSource = metode;
                    comboBoxMetodeBayar.DisplayMember = "Nama";
                    comboBoxMetodeBayar.DropDownStyle = ComboBoxStyle.DropDownList;

                    //memunculkan kurir yang ada di combobox
                    kurir = Driver.BacaData("", "");
                    comboBoxKurir.DataSource = kurir;
                    comboBoxKurir.DisplayMember = "Nama";
                    comboBoxKurir.DropDownStyle = ComboBoxStyle.DropDownList;
                    #endregion
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi error. Pesan kesalahan : " + ex.Message, "Error");
            }
        }
        #endregion

        #region ComboBox
        private void comboBoxPromo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //ambil promo yang dipilih
                Promo promoDipilih = (Promo)comboBoxPromo.SelectedItem;

                FormKeranjang.thisOrder.Promo = promoDipilih;

                //Check Button Status
                CheckButtonStatus();
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

                //Check Button Status
                CheckButtonStatus();
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

                //Check Button Status
                CheckButtonStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi error. Pesan kesalahan : " + ex.Message, "Error");
            }
        }
        #endregion

        #region Button
        private void buttonBayar_Click(object sender, EventArgs e)
        {
            try
            {
                FormKeranjang.thisOrder.Alamat_tujuan = textBoxAlamat.Text;

                FormKeranjang.thisOrder.Status = "Pesanan Diproses";

                Order.TambahData(FormKeranjang.thisOrder);

                foreach (Barang_Order bo in FormKeranjang.listBarangOrder)
                {
                    Barang_Order.TambahData(bo);
                }

                FormKeranjang.thisOrder = null;
                FormUtama.keranjang.Clear();

                MessageBox.Show("Pembayaran berhasil. Pesanan sedang diproses", "Info");

                FormKeranjang.IdGenerated = false;

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region DesainButton
        private void buttonBayar_MouseEnter(object sender, EventArgs e)
        {
            buttonBayar.BackgroundImage = Properties.Resources.Button_Hover;
        }
        private void buttonBayar_MouseLeave(object sender, EventArgs e)
        {
            buttonBayar.BackgroundImage = Properties.Resources.Button_Leave;
        }
        #endregion
    }
}
