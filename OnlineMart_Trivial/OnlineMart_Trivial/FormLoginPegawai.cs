using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineMart_Trivial
{
    public partial class FormLoginPegawai : Form
    {
        public FormLoginPegawai()
        {
            InitializeComponent();
        }

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
            FormUtama.role = "pegawai";

            FormLoading form = new FormLoading(); //Create Object
            form.Owner = this;
            form.Show();
            this.Hide();
        }

        private void FormLoginPegawai_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAuth frm = (FormAuth)this.Owner;
            frm.Show();
        }
    }
}
