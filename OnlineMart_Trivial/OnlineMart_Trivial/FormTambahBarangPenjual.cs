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
using System.IO;

namespace OnlineMart_Trivial
{
	public partial class FormTambahBarangPenjual : Form
	{
		public FormTambahBarangPenjual()
		{
			InitializeComponent();
		}
		List<Kategori> listKategori = new List<Kategori>();
		string path = "";

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
				var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
				var stringChars = new char[8];
				var random = new Random();

				for (int i = 0; i < stringChars.Length; i++)
				{
					stringChars[i] = chars[random.Next(chars.Length)];
				}

				var finalString = new String(stringChars);

				string fileName = textBoxNama.Text + "_" + finalString + ".png";
				path = Path.Combine(FormUtama.location+"/barang/", fileName);

				Kategori kategori = (Kategori)comboBoxKategori.SelectedItem;

				Barang barang = new Barang(textBoxNama.Text, int.Parse(textBoxHarga.Text), textBoxDeskripsi.Text, fileName, kategori);


				Barang.TambahData(barang);

				MessageBox.Show("Data Barang berhasil ditambahkan", "Informasi");

				Image gambar_barang = pictureBoxBarang.Image;
				gambar_barang.Save(path);
				//MessageBox.Show(path);

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

        private void pictureBoxBarang_Click(object sender, EventArgs e)
        {
			OpenFileDialog opf = new OpenFileDialog();
			opf.Filter = "Choose Image(*.png)|*.png";

			if (opf.ShowDialog() == DialogResult.OK)
			{
				pictureBoxBarang.Image = Image.FromFile(opf.FileName);
			}
		}
    }
}
