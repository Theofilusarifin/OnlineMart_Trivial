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
    public partial class FormDetailNotifikasi : Form
    {
        public FormDetailNotifikasi()
        {
            InitializeComponent();
        }

        Notifikasi notif = null;

        #region Methods
        private void TampilListBox()
        {
            //Kosongi isi listbox
            listBox.Items.Clear();

            if (notif != null)
            {
                //listBox.Items.Add(notif.Judul);
                listBox.Items.Add(notif.Waktu.ToShortDateString());
                listBox.Items.Add(notif.Isi);
            }
        }
        #endregion

        private void FormDetailNotifikasi_Load(object sender, EventArgs e)
        {
            try
            {
                notif = Notifikasi.AmbilData(FormNotifikasi.idNotif);

                TampilListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error. Pesan kesalahan : " + ex.Message, "Error");
            }
        }

        private void FormDetailNotifikasi_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                FormNotifikasi frm = (FormNotifikasi)this.Owner;
                frm.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error. Pesan kesalahan : " + ex.Message, "Error");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Desain Button
        private void buttonClose_MouseEnter(object sender, EventArgs e)
        {
            buttonClose.BackgroundImage = Properties.Resources.Button_Hover;
        }
        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.BackgroundImage = Properties.Resources.Button_Leave;
        }
        #endregion
    }
}
