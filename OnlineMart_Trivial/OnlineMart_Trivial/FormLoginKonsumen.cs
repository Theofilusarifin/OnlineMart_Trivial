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
    public partial class FormLoginKonsumen : Form
    {
        public FormLoginKonsumen()
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
                //Create Objek Koneksi
                Koneksi koneksi = new Koneksi();
                // Username dan Password
                Pelanggan pelanggan = Pelanggan.CekLogin(textBoxUsername.Text, textBoxPassword.Text, FormUtama.koneksi);

                if (!(pelanggan is null)) //Jika ditemukan pegawai dengan username dan password yang cocok
                {
                    FormUtama.role = "konsumen";
                    // tampilkan nama yang sedang login ke label yang ada di FormUtama
                    FormUtama.konsumen = pelanggan;
                    FormUtama.frmUtama.labelNama.Text = pelanggan.Nama;
                    FormUtama.frmUtama.labelPoin.Text = pelanggan.Poin.ToString();
                    FormUtama.frmUtama.labelSaldo.Text = pelanggan.Saldo.ToString();


                    FormUtama.frmUtama.pictureBoxPoin.Show();
                    FormUtama.frmUtama.pictureBoxSaldo.Show();
                    FormUtama.frmUtama.labelPoinHeader.Show();
                    FormUtama.frmUtama.labelPoin.Show();
                    FormUtama.frmUtama.labelSaldoHeader.Show();
                    FormUtama.frmUtama.labelSaldo.Show();


                    FormLoading form = new FormLoading(); //Create Object
                    form.Owner = this;
                    form.Show();
                    this.Hide();

                    //this.DialogResult = DialogResult.OK;
                    //this.Close(); //Tutup FormLogin
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
                    textBoxUsername.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        private void FormLoginKonsumen_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAuth frm = (FormAuth)this.Owner;
            frm.Show();
        }

        private void FormLoginKonsumen_Load(object sender, EventArgs e)
        {
            textBoxUsername.Focus();
        }

        private void labelRegistrasi_Click(object sender, EventArgs e)
        {
            FormRegisterKonsumen frm = new FormRegisterKonsumen(); //Create Object
            frm.Owner = this.Owner;
            frm.Show();
            this.Owner.Hide();
            this.Hide();
        }
    }
}
