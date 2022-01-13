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
	public partial class FormTambahStok : Form
	{
		public FormTambahStok()
		{
			InitializeComponent();
		}

		#region Form Load
		private void FormTambahStok_Load(object sender, EventArgs e)
		{
			textBoxNama.Text = FormDaftarBarangPenjual.barang.Nama;
			textBoxNama.ReadOnly = true;
		}
		#endregion

		#region Button Tambah
		private void buttonTambah_Click(object sender, EventArgs e)
		{
			try
			{
				Boolean hasil = Barang_Penjual.UpdateStok(FormDaftarBarangPenjual.barang, FormUtama.penjual, int.Parse(textBoxStok.Text));
				if (hasil)
				{
					MessageBox.Show("Stok berhasil di update");
					FormDaftarBarangPenjual frm = (FormDaftarBarangPenjual)this.Owner;
					frm.FormDaftarBarangPenjual_Load(sender, e);

					this.Close();
				}
				else
				{
					MessageBox.Show("Stok gagal di update");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		#endregion

		#region DesainButton
		private void buttonTambah_MouseEnter(object sender, EventArgs e)
		{
			buttonTambah.BackgroundImage = Properties.Resources.Button_Hover;
		}
		private void buttonTambah_MouseLeave(object sender, EventArgs e)
		{
			buttonTambah.BackgroundImage = Properties.Resources.Button_Leave;
		}
		#endregion
	}
}
