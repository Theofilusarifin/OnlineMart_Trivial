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
                Metode_pembayaran m = new Metode_pembayaran(textBoxNama.Text);

                Metode_pembayaran.TambahData(m);

                MessageBox.Show("Data Metode Pembayaran berhasil ditambahkan", "Informasi");

                // Update Data Di Form Daftar
                FormDaftarMetodePembayaran frm = (FormDaftarMetodePembayaran)this.Owner;
                frm.FormDaftarMetodePembayaran_Load_1(sender, e);

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Metode Pembayaran gagal ditambahkan. Pesan kesalahan : " + ex.Message, "Kesalahan");
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
