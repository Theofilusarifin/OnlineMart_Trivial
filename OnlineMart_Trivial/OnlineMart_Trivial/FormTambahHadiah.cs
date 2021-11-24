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
    public partial class FormTambahHadiah : Form
    {
        public FormTambahHadiah()
        {
            InitializeComponent();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                Gift g = new Gift(textBoxNama.Text, int.Parse(textBoxHarga.Text));

                Gift.TambahData(g);

                MessageBox.Show("Data Gift berhasil ditambahkan", "Informasi");

                // Update Data Di Form Daftar
                FormDaftarHadiah frm = (FormDaftarHadiah)this.Owner;
                frm.FormDaftarGift_Load(sender, e);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Gift gagal ditambahkan. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        #region DesainButton
        private void buttonTambah_MouseEnter(object sender, EventArgs e)
        {
            buttonTambah.BackgroundImage = Properties.Resources.Button_Hover;
        }
        private void buttonTambah_MouseLeave(object sender, EventArgs e)
        {
            buttonTambah.BackgroundImage = Properties.Resources.Button_Leave;
        }
        #endregion
    }
}
