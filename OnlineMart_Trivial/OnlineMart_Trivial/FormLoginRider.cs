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
    public partial class FormLoginRider : Form
    {
        public FormLoginRider()
        {
            InitializeComponent();
        }

        bool passwordSeen = false;

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

        private void buttonLogin_MouseLeave(object sender, EventArgs e)
        {
            buttonLogin.BackgroundImage = Properties.Resources.Button_Leave;
        }

        private void buttonLogin_MouseEnter(object sender, EventArgs e)
        {
            buttonLogin.BackgroundImage = Properties.Resources.Button_Hover;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //create object baru
                Koneksi koneksi = new Koneksi();
                //create username dan password
                Driver rider = Driver.CekLogin(textBoxUsername.Text, textBoxPassword.Text);

                //kalau username dan pass nya benar
                if (!(rider is null))
                {
                    FormUtama.role = "rider";
                    FormUtama.rider = rider;
                    FormUtama.frmUtama.labelNama.Text = rider.Nama;

                    FormLoading form = new FormLoading(); //Create Object
                    form.Owner = this;
                    form.Show();
                    this.Hide();
                }
                else
                {
                    var original = this.Location;
                    var rnd = new Random(1337);
                    const int shake_amplitude = 10;
                    for (int i = 0; i < 10; i++)
                    {
                        this.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                        System.Threading.Thread.Sleep(20);
                    }
                    this.Location = original;
                    MessageBox.Show(this, "Username tidak ditemukan atau password salah");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal. Pesan kesalahan : " + ex.Message, "Kesalahan");
                textBoxUsername.Focus();
            }
        }

        private void FormLoginRider_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAuth frm = (FormAuth)this.Owner;
            frm.Show();
        }

        private void FormLoginRider_Load(object sender, EventArgs e)
        {
            textBoxUsername.Focus();
        }

        private void labelRegistrasi_Click(object sender, EventArgs e)
        {
            FormRegisterRider frm = new FormRegisterRider(); //Create Object
            frm.Owner = this.Owner;
            frm.Show();
            this.Owner.Hide();
            this.Hide();
        }

        private void pictureBoxMata_Click(object sender, EventArgs e)
        {
            if (!passwordSeen)
            {
                pictureBoxMata.Image = Properties.Resources.Open_Eye;
                textBoxPassword.PasswordChar = '\0';
                passwordSeen = true;
            }
            else if (passwordSeen)
            {
                pictureBoxMata.Image = Properties.Resources.Closed_Eye;
                textBoxPassword.PasswordChar = '⚉';
                passwordSeen = false;
            }
        }
    }
}
