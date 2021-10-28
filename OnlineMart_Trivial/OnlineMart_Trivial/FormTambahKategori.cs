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
    public partial class FormTambahKategori : Form
    {
        public FormTambahKategori()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                Kategori kategori = new Kategori(textBoxNama.Text);

                Kategori.TambahData(kategori);

                MessageBox.Show("Data Kategori berhasil ditambahkan", "Informasi");

                // Update Data Di Form Daftar
                FormDaftarKategori frm = (FormDaftarKategori)this.Owner;
                frm.FormDaftarKategori_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Kategori gagal ditambahkan. Pesan kesalahan : " + ex.Message, "Kesalahan");
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
