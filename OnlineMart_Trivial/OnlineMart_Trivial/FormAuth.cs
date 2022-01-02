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

        private void pictureBoxKonsumen_Click(object sender, EventArgs e)
        {
            FormLoginKonsumen frm = new FormLoginKonsumen(); //Create Object
            frm.Owner = this;
            frm.Show();
            this.Hide();
        }

        private void pictureBoxRider_Click(object sender, EventArgs e)
        {
            FormLoginRider frm = new FormLoginRider(); //Create Object
            frm.Owner = this;
            frm.Show();
            this.Hide();
        }

        private void pictureBoxPegawai_Click(object sender, EventArgs e)
        {
            FormLoginPegawai frm = new FormLoginPegawai(); //Create Object
            frm.Owner = this;
            frm.Show();
            this.Hide();
        }

        private void pictureBoxPenjual_Click(object sender, EventArgs e)
        {
            FormLoginPenjual frm = new FormLoginPenjual(); //Create Object
            frm.Owner = this;
            frm.Show();
            this.Hide();
        }
    }
}
