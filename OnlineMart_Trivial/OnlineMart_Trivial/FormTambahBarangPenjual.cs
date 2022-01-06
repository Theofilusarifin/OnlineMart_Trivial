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
	public partial class FormTambahBarangPenjual : Form
	{
		public FormTambahBarangPenjual()
		{
			InitializeComponent();
		}
		List<Kategori> listKategori = new List<Kategori>();

		private void FormTambahBarangPenjual_Load(object sender, EventArgs e)
		{
			listKategori = Kategori.BacaData("", "");

			comboBoxKategori.DataSource = listKategori;
			comboBoxKategori.DisplayMember = "Nama";

			comboBoxKategori.DropDownStyle = ComboBoxStyle.DropDownList;

			textBoxNama.Focus();
		}

		private void buttonTambah_Click(object sender, EventArgs e)
		{
			try
			{
				Kategori kategori = (Kategori)comboBoxKategori.SelectedItem;

				Barang barang = new Barang(textBoxNama.Text, int.Parse(textBoxHarga.Text), kategori);

				Barang.TambahData(barang);
				Barang_Penjual bp = new Barang_Penjual(FormUtama.penjual, barang, 0);
				Barang_Penjual.TambahProdukPenjual(bp);
				MessageBox.Show("Data Barang berhasil ditambahkan", "Informasi");

				// Update Data Di Form Daftar
				FormDaftarBarang frm = (FormDaftarBarang)this.Owner;
				frm.FormDaftarBarang_Load(sender, e);

				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Data Barang gagal ditambahkan. Pesan kesalahan : " + ex.Message, "Kesalahan");
			}
		}
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
