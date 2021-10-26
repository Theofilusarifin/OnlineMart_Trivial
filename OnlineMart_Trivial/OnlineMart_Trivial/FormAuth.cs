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
    public partial class FormAuth : Form
    {
        public FormAuth()
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

        #region Design Button
        private void buttonLoginKonsumen_MouseEnter(object sender, EventArgs e)
        {
            buttonLoginKonsumen.BackgroundImage = Properties.Resources.Button_Hover;
        }
        private void buttonLoginKonsumen_MouseLeave(object sender, EventArgs e)
        {
            buttonLoginKonsumen.BackgroundImage = Properties.Resources.Button_Leave;
        }
        private void buttonRegisterKonsumen_MouseEnter(object sender, EventArgs e)
        {
            buttonRegisterKonsumen.BackgroundImage = Properties.Resources.Button_Hover;
        }
        private void buttonRegisterKonsumen_MouseLeave(object sender, EventArgs e)
        {
            buttonRegisterKonsumen.BackgroundImage = Properties.Resources.Button_Leave;
        }
        private void buttonLoginRider_MouseEnter(object sender, EventArgs e)
        {
            buttonLoginRider.BackgroundImage = Properties.Resources.Button_Hover;
        }
        private void buttonLoginRider_MouseLeave(object sender, EventArgs e)
        {
            buttonLoginRider.BackgroundImage = Properties.Resources.Button_Leave;
        }
        private void buttonRegisterRider_MouseEnter(object sender, EventArgs e)
        {
            buttonRegisterRider.BackgroundImage = Properties.Resources.Button_Hover;
        }
        private void buttonRegisterRider_MouseLeave(object sender, EventArgs e)
        {
            buttonRegisterRider.BackgroundImage = Properties.Resources.Button_Leave;
        }
        private void buttonLoginPegawai_MouseEnter(object sender, EventArgs e)
        {
            buttonLoginPegawai.BackgroundImage = Properties.Resources.Button_Hover;
        }
        private void buttonLoginPegawai_MouseLeave(object sender, EventArgs e)
        {
            buttonLoginPegawai.BackgroundImage = Properties.Resources.Button_Leave;
        }
        #endregion

        #region Button Action
        private void buttonLoginKonsumen_Click(object sender, EventArgs e)
        {
            FormLoginKonsumen frm = new FormLoginKonsumen(); //Create Object
            frm.Owner = this;
            frm.Show();
            this.Hide();
        }
        private void buttonRegisterKonsumen_Click(object sender, EventArgs e)
        {
            FormRegisterKonsumen frm = new FormRegisterKonsumen(); //Create Object
            frm.Owner = this;
            frm.Show();
            this.Hide();
        }
        private void buttonLoginRider_Click(object sender, EventArgs e)
        {
            FormLoginRider frm = new FormLoginRider(); //Create Object
            frm.Owner = this;
            frm.Show();
            this.Hide();
        }
        private void buttonRegisterRider_Click(object sender, EventArgs e)
        {
            FormRegisterRider frm = new FormRegisterRider(); //Create Object
            frm.Owner = this;
            frm.Show();
            this.Hide();
        }
        private void buttonLoginPegawai_Click(object sender, EventArgs e)
        {
            FormLoginPegawai frm = new FormLoginPegawai(); //Create Object
            frm.Owner = this;
            frm.Show();
            this.Hide();
        }
        #endregion
    }
}
