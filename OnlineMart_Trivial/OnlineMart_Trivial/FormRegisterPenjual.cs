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
    public partial class FormRegisterPenjual : Form
    {
        public FormRegisterPenjual()
        {
            InitializeComponent();
        }

        #region No Tick Constrols
        //Optimized Controls(No Tick)
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        #endregion

        private void buttonRegister_MouseEnter(object sender, EventArgs e)
        {
            buttonRegister.BackgroundImage = Properties.Resources.Button_Hover;
        }
        private void buttonRegister_MouseLeave(object sender, EventArgs e)
        {
            buttonRegister.BackgroundImage = Properties.Resources.Button_Leave;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPassword.Text == textBoxKonfirmasiPassword.Text)
                {
                    List<Penjual> listPelanggan = Penjual.BacaData("username", textBoxUsername.Text);

                    // Check apakah username telah digunakan atau belum
                    if (listPelanggan.Count == 0)
                    {
                        //Ciptakan objek yang akan ditambahkan
                        Penjual penjual = new Penjual(textBoxNama.Text, textBoxUsername.Text, textBoxEmail.Text, textBoxPassword.Text, "Pending", textBoxNomorTelepon.Text);
                        Penjual.TambahData(penjual);
                        MessageBox.Show("Registrasi Telah Berhasil! Harap lakukan login dengan akun anda.", "Info");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username telah digunakan. Mohon coba memasukkan username lain.", "Info");
                    }
                }
                else MessageBox.Show("Password Tidak Sama", "Kesalahan");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Penyimpanan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        private void FormRegisterPenjual_Load(object sender, EventArgs e)
        {
            textBoxNama.Focus();
        }

        private void FormRegisterPenjual_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAuth frm = (FormAuth)this.Owner;
            frm.Show();
        }
    }
}
