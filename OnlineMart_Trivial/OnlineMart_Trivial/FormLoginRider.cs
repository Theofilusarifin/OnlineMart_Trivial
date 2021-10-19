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
    public partial class FormLoginRider : Form
    {
        public FormLoginRider()
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
            FormUtama frm = (FormUtama)this.Owner;
            frm.pictureBoxOnboarding.Hide();
            frm.buttonLoginKonsumen.Hide();
            frm.buttonLoginPegawai.Hide();
            frm.buttonLoginRider.Hide();
            frm.buttonRegisterKonsumen.Hide();
            frm.buttonRegisterRider.Hide();
            frm.menuStripPegawai.Show();

            this.Close();
        }
    }
}
