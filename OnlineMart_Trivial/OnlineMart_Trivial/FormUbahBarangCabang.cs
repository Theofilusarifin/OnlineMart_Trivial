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
    public partial class FormUbahBarangCabang : Form
    {
        public static int IdBarangDipilih;
        public static int IdCabangDipilih;
        Barang_Cabang bc = null;

        public FormUbahBarangCabang()
        {
            InitializeComponent();
        }
        private void FormUbahBarangCabang_Load(object sender, EventArgs e)
        {
            //Ambil data yang sesuai id
            bc = Barang_Cabang.AmbilData(IdCabangDipilih, IdBarangDipilih);

            //Tampilkan data di text box
            textBoxBarang.Text = bc.Barang.Nama;
            textBoxCabang.Text = bc.Cabang.Nama;
            textBoxStok.Text = bc.Stok.ToString();

            textBoxBarang.ReadOnly = true;
            textBoxCabang.ReadOnly = true;
        }
        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                //Ubah menjadi data baru
                bc.Stok = int.Parse(textBoxStok.Text);
                Barang_Cabang.UbahData(bc);

                MessageBox.Show("Perubahan berhasil tersimpan!", "Info");

                // Update Data Di Form Daftar
                FormDaftarBarangCabang frm = (FormDaftarBarangCabang)this.Owner;
                frm.FormDaftarBarangCabang_Load(sender, e);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Penyimpanan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        #region DesainButton
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
