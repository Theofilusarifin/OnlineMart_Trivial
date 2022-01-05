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
    public partial class FormProfile : Form
    {
        public FormProfile()
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

        private void FormProfile_Load(object sender, EventArgs e)
        {
            Pelanggan p = Pelanggan.AmbilData(FormUtama.konsumen.Id);
            //Tampilkan data di text box
            textBoxNama.Text = p.Nama;
            textBoxUsername.Text = p.Username;
            textBoxEmail.Text = p.Email;
            textBoxNomorTelepon.Text = p.Telepon;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                FormUbahPassword frm = new FormUbahPassword(); //Create Object
                frm.Owner = this;
                frm.Show();
                frm.BringToFront(); //Agar form tampil di depan
            }
            catch (Exception ex)
            {
                MessageBox.Show("Penyimpanan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        #region DesainButton
        private void buttonEdit_MouseEnter(object sender, EventArgs e)
        {
            buttonUbahPassword.BackgroundImage = Properties.Resources.Button_Hover;
        }
        private void buttonEdit_MouseLeave(object sender, EventArgs e)
        {
            buttonUbahPassword.BackgroundImage = Properties.Resources.Button_Leave;
        }
        private void buttonClose_MouseEnter(object sender, EventArgs e)
        {
            buttonClose.BackgroundImage = Properties.Resources.Button_Hover;
        }
        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.BackgroundImage = Properties.Resources.Button_Leave;
        }
        #endregion

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
