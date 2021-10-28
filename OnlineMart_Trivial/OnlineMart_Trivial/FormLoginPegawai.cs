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
    public partial class FormLoginPegawai : Form
    {
        public FormLoginPegawai()
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
                //create object baru
                Koneksi koneksi = new Koneksi();
                //create username dan password
                Pegawai pegawai = Pegawai.CekLogin(textBoxUsername.Text, textBoxPassword.Text);

                //kalau username dan pass nya benar
                if(!(pegawai is null))
                {
                    FormUtama.role = "pegawai";
                    FormUtama.pegawai = pegawai;
                    FormUtama.frmUtama.labelNama.Text = pegawai.Nama;

                    FormLoading form = new FormLoading(); //Create Object
                    form.Owner = this;
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(this, "Username tidak ditemukan atau password salah");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Koneksi gagal. Pesan kesalahan : " + ex.Message, "Kesalahan");
                textBoxUsername.Focus();
            }
        }

        private void FormLoginPegawai_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAuth frm = (FormAuth)this.Owner;
            frm.Show();
        }

        private void FormLoginPegawai_Load(object sender, EventArgs e)
        {
            textBoxUsername.Focus();
        }
    }
}
