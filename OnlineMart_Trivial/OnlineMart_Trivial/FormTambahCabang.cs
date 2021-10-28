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
    public partial class FormTambahCabang : Form
    {
        public FormTambahCabang()
        {
            InitializeComponent();
        }

        List<Pegawai> listPegawai = new List<Pegawai>();

        private void FormTambahCabang_Load(object sender, EventArgs e)
        {
            listPegawai = Pegawai.BacaData("", "");

            comboBoxPegawai.DataSource = listPegawai;
            comboBoxPegawai.DisplayMember = "nama";

            comboBoxPegawai.DropDownStyle = ComboBoxStyle.DropDownList;

            textBoxNama.Focus();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                Pegawai pegawai = (Pegawai)comboBoxPegawai.SelectedItem;

                Cabang cabang = new Cabang(textBoxNama.Text, textBoxAlamat.Text, pegawai);

                Cabang.TambahData(cabang);

                MessageBox.Show("Data Cabang berhasil ditambahkan", "Informasi");

                // Update Data Di Form Daftar
                FormDaftarCabang frm = (FormDaftarCabang)this.Owner;
                frm.FormDaftarCabang_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Cabang gagal ditambahkan. Pesan kesalahan : " + ex.Message, "Kesalahan");
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
