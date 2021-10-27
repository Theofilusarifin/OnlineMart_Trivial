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
    public partial class FormRegisterKonsumen : Form
    {
        public FormRegisterKonsumen()
        {
            InitializeComponent();
        }

        private void buttonLogin_MouseLeave(object sender, EventArgs e)
        {
            buttonRegister.BackgroundImage = Properties.Resources.Button_Leave;
        }

        private void buttonLogin_MouseEnter(object sender, EventArgs e)
        {
            buttonRegister.BackgroundImage = Properties.Resources.Button_Hover;
        }

        private void FormRegisterKonsumen_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAuth frm = (FormAuth)this.Owner;
            frm.Show();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPassword.Text == textBoxKonfirmasiPassword.Text)
                {
                    //Ciptakan objek yang akan ditambahkan
                    Pelanggan pelanggan = new Pelanggan(textBoxNama.Text, textBoxUsername.Text, textBoxEmail.Text, textBoxPassword.Text, textBoxNomorTelepon.Text);
                    Pelanggan.TambahData(pelanggan);
                    MessageBox.Show("Registrasi Telah Berhasil! Harap lakukan login dengan akun anda.", "Info");
                    this.Close();
                }
                else MessageBox.Show("Password Tidak Sama", "Kesalahan");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Penyimpanan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
    }
}
