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
    public partial class FormUbahPromo : Form
    {
        public static int IdDipilih;

        public FormUbahPromo()
        {
            InitializeComponent();
        }
        Promo p = null;
        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                //Ubah menjadi data baru
                p.Tipe = textBoxTipe.Text;
                p.Nama = textBoxNama.Text;
                p.Diskon = int.Parse(textBoxDiskon.Text);
                p.Diskon_max = int.Parse(textBoxDiskonMaksimal.Text);
                p.Minimal_belanja = float.Parse(textBoxPembelanjaanMinimum.Text);
                Promo.UbahData(p, FormUtama.koneksi);

                MessageBox.Show("Perubahan berhasil tersimpan!", "Info");

                // Update Data Di Form Daftar
                FormDaftarPromo frm = (FormDaftarPromo)this.Owner;
                frm.FormDaftarPromo_Load(sender, e);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Penyimpanan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        private void FormUbahPromo_Load(object sender, EventArgs e)
        {
            //Ambil data yang sesuai id
            p = Promo.AmbilData(IdDipilih);

            //Tampilkan data di text box
            textBoxTipe.Text = p.Tipe;
            textBoxNama.Text = p.Nama;
            textBoxDiskon.Text = p.Diskon.ToString();
            textBoxDiskonMaksimal.Text = p.Diskon_max.ToString();
            textBoxPembelanjaanMinimum.Text = p.Minimal_belanja.ToString();
        }

        #region DesignButton
        private void buttonUbah_MouseEnter(object sender, EventArgs e)
        {
            buttonUbah.BackgroundImage = Properties.Resources.Button_Hover;
        }
        private void buttonUbah_MouseLeave(object sender, EventArgs e)
        {
            buttonUbah.BackgroundImage = Properties.Resources.Button_Leave;
        }
        #endregion
    }
}
