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
    public partial class FormTambahMetodePembayaran : Form
    {
        public FormTambahMetodePembayaran()
        {
            InitializeComponent();
        }

		private void buttonTambah_Click(object sender, EventArgs e)
		{
            try
            {
                Metode_pembayarans m = new Metode_pembayarans(textBoxNama.Text);

                Metode_pembayarans.TambahData(m);

                MessageBox.Show("Data Metode Pembayaran berhasil ditambahkan", "Informasi");

                // Update Data Di Form Daftar
                FormDaftarMetodePembayaran frm = (FormDaftarMetodePembayaran)this.Owner;
                frm.FormDaftarMetodePembayaran_Load_1(sender, e);

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Kategori gagal ditambahkan. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
	}
}