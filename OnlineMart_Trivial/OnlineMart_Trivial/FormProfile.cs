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
            //Tampilkan data di text box
            textBoxNama.Text = FormUtama.konsumen.Nama;
            textBoxUsername.Text = FormUtama.konsumen.Username;
            textBoxEmail.Text = FormUtama.konsumen.Email;
            textBoxNomorTelepon.Text = FormUtama.konsumen.Telepon;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //Ubah menjadi data baru
                FormUtama.konsumen.Nama = textBoxNama.Text;
                FormUtama.konsumen.Username = textBoxUsername.Text;
                FormUtama.konsumen.Email = textBoxEmail.Text;
                FormUtama.konsumen.Telepon = textBoxNomorTelepon.Text;
                FormUtama.frmUtama.labelNama.Text = FormUtama.konsumen.Nama;

                Pelanggan.UbahData(FormUtama.konsumen);

                MessageBox.Show("Perubahan berhasil tersimpan!", "Informasi");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Penyimpanan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        #region DesainButton
        private void buttonEdit_MouseEnter(object sender, EventArgs e)
        {
            buttonEdit.BackgroundImage = Properties.Resources.Button_Hover;
        }
        private void buttonEdit_MouseLeave(object sender, EventArgs e)
        {
            buttonEdit.BackgroundImage = Properties.Resources.Button_Leave;
        }
        #endregion
    }
}
