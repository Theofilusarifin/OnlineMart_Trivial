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
    public partial class FormTambahPromo : Form
    {
        public FormTambahPromo()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                Promo p = new Promo(textBoxTipe.Text, textBoxNama.Text, int.Parse(textBoxDiskon.Text), int.Parse(textBoxDiskonMaksimal.Text), float.Parse(textBoxPembelanjaanMinimum.Text));

                Promo.TambahData(p, FormUtama.koneksi);

                MessageBox.Show("Data Promo berhasil ditambahkan", "Informasi");

                // Update Data Di Form Daftar
                FormDaftarPromo frm = (FormDaftarPromo)this.Owner;
                frm.FormDaftarPromo_Load(sender, e);

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Promo gagal ditambahkan. Pesan kesalahan : " + ex.Message, "Kesalahan");
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
