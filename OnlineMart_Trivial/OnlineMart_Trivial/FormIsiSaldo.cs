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
    public partial class FormIsiSaldo : Form
    {
        public FormIsiSaldo()
        {
            InitializeComponent();
        }
        public List<Metode_pembayaran> listMetodePembayaran = new List<Metode_pembayaran>();
        private void FormIsiSaldo_Load(object sender, EventArgs e)
        {
           listMetodePembayaran = Metode_pembayaran.BacaData("","");

            comboBoxMetodePembayaran.DataSource = listMetodePembayaran;
            comboBoxMetodePembayaran.DisplayMember = "Nama";

            comboBoxMetodePembayaran.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonBeli_Click(object sender, EventArgs e)
        {
            try
            {
                //menambahkan riwayat isi saldo
                Riwayat_isi_saldo r = new Riwayat_isi_saldo(DateTime.Now, int.Parse(textBoxSaldo.Text), FormUtama.konsumen);
                Riwayat_isi_saldo.TambahData(r);

                //update saldo
                Pelanggan.TambahSaldo(FormUtama.konsumen, int.Parse(textBoxSaldo.Text));

                MessageBox.Show("Isi saldo telah berhasil", "Informasi");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi error dalam melakukan isi saldo. Pesan kesalahan: " + ex.Message);
            }
        }

        #region DesainButton
        private void buttonBeli_MouseEnter(object sender, EventArgs e)
        {
            buttonBeli.BackgroundImage = Properties.Resources.Button_Hover;
        }
        private void buttonBeli_MouseLeave(object sender, EventArgs e)
        {
            buttonBeli.BackgroundImage = Properties.Resources.Button_Leave;
        }
        #endregion
    }
}
