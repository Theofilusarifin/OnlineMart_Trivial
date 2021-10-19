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
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
            //Background Transparant
            pictureBoxOnboarding.Parent = pictureBoxBackground;
        }

        public void HideControl()
        {
            pictureBoxOnboarding.Hide();
            buttonLoginKonsumen.Hide();
            buttonLoginPegawai.Hide();
            buttonLoginRider.Hide();
            buttonRegisterKonsumen.Hide();
            buttonRegisterRider.Hide();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        { 
            //Ubah FormUtama menjadi MdiParent (MdiContainer)
            this.IsMdiContainer = true;
            menuStripKonsumen.Hide();
            menuStripPegawai.Hide();
            menuStripRider.Hide();
        }

        private void buttonRegisterKonsumen_Click(object sender, EventArgs e)
        {
            FormRegisterKonsumen frm = new FormRegisterKonsumen();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void buttonRegisterRider_Click(object sender, EventArgs e)
        {
            FormRegisterRider frm = new FormRegisterRider();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void buttonLoginKonsumen_Click(object sender, EventArgs e)
        {
            FormLoginKonsumen frm = new FormLoginKonsumen();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void buttonLoginRider_Click(object sender, EventArgs e)
        {
            FormLoginRider frm = new FormLoginRider();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void buttonLoginPegawai_Click(object sender, EventArgs e)
        {
            FormLoginPegawai frm = new FormLoginPegawai();
            frm.Owner = this;
            frm.ShowDialog();
        }
        private void buttonLoginKonsumen_Enter(object sender, EventArgs e)
        {
            buttonRegisterKonsumen.BackgroundImage = Properties.Resources.Button_Hover;
        }

        //Desain Button Register Konsumen
        private void buttonRegisterKonsumen_MouseLeave(object sender, EventArgs e)
        {
            buttonRegisterKonsumen.BackgroundImage = Properties.Resources.Button_Leave;
        }
        private void buttonRegisterKonsumen_MouseEnter(object sender, EventArgs e)
        {
            buttonRegisterKonsumen.BackgroundImage = Properties.Resources.Button_Hover;
        }

        //Desain Button Login Konsumen
        private void buttonLoginKonsumen_MouseLeave(object sender, EventArgs e)
        {
            buttonLoginKonsumen.BackgroundImage = Properties.Resources.Button_Leave;
        }
        private void buttonLoginKonsumen_MouseEnter(object sender, EventArgs e)
        {
            buttonLoginKonsumen.BackgroundImage = Properties.Resources.Button_Hover;
        }

        //Desain Button Register Rider
        private void buttonRegisterRider_MouseLeave(object sender, EventArgs e)
        {
            buttonRegisterRider.BackgroundImage = Properties.Resources.Button_Leave;
        }
        private void buttonRegisterRider_MouseEnter(object sender, EventArgs e)
        {
            buttonRegisterRider.BackgroundImage = Properties.Resources.Button_Hover;
        }

        //Desain Button Login Rider
        private void buttonLoginRider_MouseLeave(object sender, EventArgs e)
        {
            buttonLoginRider.BackgroundImage = Properties.Resources.Button_Leave;
        }
        private void buttonLoginRider_MouseEnter(object sender, EventArgs e)
        {
            buttonLoginRider.BackgroundImage = Properties.Resources.Button_Hover;
        }

        //Desain Button Login Pegawai
        private void buttonLoginPegawai_MouseLeave(object sender, EventArgs e)
        {
            buttonLoginPegawai.BackgroundImage = Properties.Resources.Button_Leave;
        }
        private void buttonLoginPegawai_MouseEnter(object sender, EventArgs e)
        {
            buttonLoginPegawai.BackgroundImage = Properties.Resources.Button_Hover;
        }
    }
}
