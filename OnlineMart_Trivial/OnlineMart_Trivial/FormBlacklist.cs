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
	public partial class FormBlacklist : Form
	{
		public FormBlacklist()
		{
			InitializeComponent();
		}

		#region Form Load
		private void FormBlacklist_Load(object sender, EventArgs e)
		{
			textBoxNama.Text = FormDaftarPenjual.penjual.Nama;
			textBoxNama.ReadOnly = true;

		}
		#endregion

		#region Button Tambah
		private void buttonTambah_Click(object sender, EventArgs e)
		{
			try
			{
				Blacklist b = new Blacklist(textBoxJenis.Text, textBoxAlasan.Text);
				if (Penjual.UbahData(FormDaftarPenjual.penjual, FormUtama.koneksi))
				{
					MessageBox.Show("Data Penjual berhasil di blacklist", "Informasi");

					// Update Data Di Form Daftar
					FormDaftarPenjual frm = (FormDaftarPenjual)this.Owner;
					frm.FormDaftarPenjual_Load(sender, e);

					this.Close();
				}
				else
				{
					MessageBox.Show("Data Penjual gagal di blacklist", "Informasi");
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Data Barang gagal ditambahkan. Pesan kesalahan : " + ex.Message, "Kesalahan");
			}
		}
		#endregion
	}
}
