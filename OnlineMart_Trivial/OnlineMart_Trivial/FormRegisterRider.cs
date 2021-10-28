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
    public partial class FormRegisterRider : Form
    {
        public FormRegisterRider()
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPassword.Text == textBoxKonfirmasiPassword.Text)
                {
                    //Ciptakan objek yang akan ditambahkan
                    Driver driver = new Driver(textBoxNama.Text, textBoxUsername.Text, textBoxEmail.Text, textBoxPassword.Text, textBoxNomorTelepon.Text);
                    Driver.TambahData(driver);
                    MessageBox.Show("Registrasi Telah Berhasil! Harap lakukan login dengan akun anda.", "Info");
                    ////this.Close();
                }
                else MessageBox.Show("Password Tidak Sama", "Kesalahan");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Penyimpanan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        private void buttonRegister_MouseEnter(object sender, EventArgs e)
        {
            buttonRegister.BackgroundImage = Properties.Resources.Button_Hover;
        }

        private void buttonRegister_MouseLeave(object sender, EventArgs e)
        {
            buttonRegister.BackgroundImage = Properties.Resources.Button_Leave;
        }

        private void FormRegisterRider_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAuth frm = (FormAuth)this.Owner;
            frm.Show();
        }

        private void FormRegisterRider_Load(object sender, EventArgs e)
        {
            textBoxNama.Focus();
        }
    }
}
