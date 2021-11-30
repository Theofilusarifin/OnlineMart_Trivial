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
    public partial class FormUbahPassword : Form
    {
        public FormUbahPassword()
        {
            InitializeComponent();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPassBaru.Text == textBoxPassBaruConfirm.Text)
                {
                    //Ciptakan objek yang akan ditambahkan
                    FormUtama.konsumen.Password = textBoxPassBaru.Text;
                    Pelanggan.UbahData(FormUtama.konsumen);
                    MessageBox.Show("Perubahan Password Telah Berhasil!", "Info");
                    this.Close();
                }
                else MessageBox.Show("Password Baru Tidak Sama", "Kesalahan");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Penyimpanan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        #region DesainButton
        private void buttonUbah_MouseEnter(object sender, EventArgs e)
        {
            buttonUbah.BackgroundImage = Properties.Resources.Button_Hover;
        }
        private void buttonUbah_MouseLeave(object sender, EventArgs e)
        {
            buttonUbah.BackgroundImage = Properties.Resources.Button_Leave;
        }
        #endregion
    }
}
