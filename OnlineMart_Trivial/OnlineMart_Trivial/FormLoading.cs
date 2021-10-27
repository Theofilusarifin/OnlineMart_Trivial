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
    public partial class FormLoading : Form
    {
        public FormLoading()
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

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            panelLoading.Width += 3;
            if (panelLoading.Width >= 533)
            {
                timerLoading.Stop();
                this.Close();
            }
        }

        private void FormLoading_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormUtama.frmUtama.panelLeftNavbar.Show();
            FormUtama.frmUtama.panelActiveForm.Show();
            FormUtama.frmUtama.panelTitleActiveForm.Show();
            FormUtama.frmUtama.panelHeader.Show();
            FormUtama.frmUtama.panelFooter.Show();
            FormUtama.frmUtama.panelLeftNavbar.BringToFront();

            if (FormUtama.role == "konsumen")
            {
                FormUtama.frmUtama.panelKonsumen.Show();
            }
            else if (FormUtama.role == "rider")
            {
                FormUtama.frmUtama.panelRider.Show();
            }
            else if (FormUtama.role == "pegawai")
            {
                FormUtama.frmUtama.panelPegawai.Show();
            }
            else MessageBox.Show("Terjadi error, role tidak terdefinisi");
        }
    }
}
