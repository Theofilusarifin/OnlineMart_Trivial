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

        List<Notifikasi> listNotifikasi = new List<Notifikasi>();

        private void FormDetailNotifikasi_Load(object sender, EventArgs e)
        {
            listNotifikasi = Notifikasi.BacaData("n.id", "");
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
    }
}
