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

		public static Penjual penjual;

		#region Form Load
		private void FormBlacklist_Load(object sender, EventArgs e)
		{
			textBoxNama.Text = penjual.Nama;
			textBoxNama.ReadOnly = true;

		}
		#endregion

		#region Button Tambah
		private void buttonTambah_Click(object sender, EventArgs e)
		{
			try
			{
				Blacklist b = new Blacklist(textBoxJenis.Text, textBoxAlasan.Text);
				Blacklist.TambahData(b);
				if (Penjual.UpdateBlacklist(penjual))
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
