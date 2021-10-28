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
    public partial class FormUbahCabang : Form
    {
        public static int IdDipilih;

        public FormUbahCabang()
        {
            InitializeComponent();
        }

        List<Pegawai> listPegawai = new List<Pegawai>();

        private void FormUbahCabang_Load(object sender, EventArgs e)
        {
            listPegawai = Pegawai.BacaData("", "");

            comboBoxPegawai.DataSource = listPegawai;
            comboBoxPegawai.DisplayMember = "Nama";

            comboBoxPegawai.DropDownStyle = ComboBoxStyle.DropDownList;

            //Ambil data yang sesuai id
            Cabang c = Cabang.AmbilData(IdDipilih);

            //Tampilkan data di text box
            textBoxNama.Text = c.Nama;
            textBoxAlamat.Text = c.Alamat;
            comboBoxPegawai.Text = c.Pegawai.Nama;
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                Pegawai pDipilih = Pegawai.AmbilData(comboBoxPegawai.Text);
                Cabang clama = Cabang.AmbilData(IdDipilih);

                //Ubah menjadi data baru
                clama.Nama = textBoxNama.Text;
                clama.Alamat = textBoxAlamat.Text;
                clama.Pegawai = pDipilih;
                Cabang.UbahData(clama);

                MessageBox.Show("Perubahan berhasil tersimpan!", "Info");

                // Update Data Di Form Daftar
                FormDaftarCabang frm = (FormDaftarCabang)this.Owner;
                frm.FormDaftarCabang_Load(sender, e);

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Penyimpanan gagal. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
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
