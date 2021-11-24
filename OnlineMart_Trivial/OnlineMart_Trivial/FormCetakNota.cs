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
	public partial class FormCetakNota : Form
	{
		public List<Order> listOrder = new List<Order>(); //deklarasi list order
		public FormCetakNota()
		{
			InitializeComponent();
		}

        #region FormLoad
        private void FormCetakNota_Load(object sender, EventArgs e)
		{
			try
			{
				listOrder = Order.BacaData("pelanggan_id", FormUtama.konsumen.Id.ToString());
				listBoxData.Enabled = false;
				//foreach(Order o in listOrder)
				//{
				//	comboBoxKriteria.Items.Add(o);
				//	comboBoxKriteria.DisplayMember = "Id";
				//	comboBoxKriteria.DropDownStyle = ComboBoxStyle.DropDownList;
				//}
				comboBoxKriteria.DataSource = listOrder;
				comboBoxKriteria.DisplayMember = "Id";
				comboBoxKriteria.DropDownStyle = ComboBoxStyle.DropDownList;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Pesan kesalahan : " + ex.Message, "Kesalahan");
			}
		}
        #endregion

        #region ComboBox
        private void comboBoxKriteria_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				Order o = (Order)comboBoxKriteria.SelectedItem;
				listBoxData.Items.Add("Id: " + o.Id);
				listBoxData.Items.Add("Tanggal: " + o.Tanggal_waktu);
				listBoxData.Items.Add("Alamat: " + o.Alamat_tujuan);
				listBoxData.Items.Add("Ongkos Kirim: " + o.Ongkos_kirim);
				listBoxData.Items.Add("Total Bayar: " + o.Total_bayar);
				listBoxData.Items.Add("Status: " + o.Status);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Pesan kesalahan : " + ex.Message, "Kesalahan");
			}
		}
        #endregion

        #region Button
        private void buttonCetak_Click(object sender, EventArgs e)
		{
			try
			{
				Order o = (Order)comboBoxKriteria.SelectedItem; //ambil objek dari combo box
				o.CetakOrder("Order " + o.Id + ".txt"); //Mulai cetak file
				MessageBox.Show("Order berhasil dicetak!");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Pesan kesalahan : " + ex.Message, "Kesalahan");
			}
		}

		private void buttonCetakSemua_Click(object sender, EventArgs e)
		{
			try
			{
				Order.CetakDaftarOrder("pelanggan_id", FormUtama.konsumen.Id.ToString(), "daftarnota.txt", FormUtama.koneksi);
				MessageBox.Show("Seluruh Order berhasil dicetak!");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Pesan kesalahan : " + ex.Message, "Kesalahan");
			}
		}
		#endregion

		#region DesainButton
		private void buttonCetak_MouseEnter(object sender, EventArgs e)
        {
			buttonCetak.BackgroundImage = Properties.Resources.Button_Hover;
		}
		private void buttonCetak_MouseLeave(object sender, EventArgs e)
        {
			buttonCetak.BackgroundImage = Properties.Resources.Button_Leave;
		}
		private void buttonCetakSemua_MouseEnter(object sender, EventArgs e)
        {
			buttonCetakSemua.BackgroundImage = Properties.Resources.Button_Hover;
		}
		private void buttonCetakSemua_MouseLeave(object sender, EventArgs e)
        {
			buttonCetakSemua.BackgroundImage = Properties.Resources.Button_Leave;
		}
		#endregion
	}
}
