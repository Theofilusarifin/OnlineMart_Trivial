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
    public partial class FormUbahMetodePembayaran : Form
    {
        public static int IdDipilih;
        public FormUbahMetodePembayaran()
        {
            InitializeComponent();
        }

		private void buttonUbah_Click(object sender, EventArgs e)
		{
            try
            {
                Metode_pembayarans m = Metode_pembayarans.AmbilData(IdDipilih);

                //Ubah menjadi data baru
                m.Name = textBoxNama.Text;
                Metode_pembayarans.UbahData(m);

                MessageBox.Show("Perubahan berhasil tersimpan!", "Info");

                // Update Data Di Form Daftar
                FormDaftarMetodePembayaran frm = (FormDaftarMetodePembayaran)this.Owner;
                frm.FormDaftarMetodePembayaran_Load_1(sender, e);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Penyimpanan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

		private void FormUbahMetodePembayaran_Load(object sender, EventArgs e)
		{
            //Ambil data yang sesuai id
            Metode_pembayarans m = Metode_pembayarans.AmbilData(IdDipilih);

            //Tampilkan data di text box
            textBoxNama.Text = m.Name;
        }
	}
}