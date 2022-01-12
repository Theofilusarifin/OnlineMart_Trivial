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
    public partial class FormTukarHadiah : Form
    {
        public FormTukarHadiah()
        {
            InitializeComponent();
        }

        List<Gift> listGift = new List<Gift>();
        Gift gDipilih = null;

        private void FormTukarHadiah_Load(object sender, EventArgs e)
        {
            listGift = Gift.BacaData("", "", FormUtama.koneksi);

            comboBoxHadiah.DataSource = listGift;
            comboBoxHadiah.DisplayMember = "nama";
            comboBoxHadiah.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonTukar_Click(object sender, EventArgs e)
        {
            // Check apakah poin cukup atau tidak
            if(FormUtama.konsumen.Poin >= gDipilih.JumlahPoin)
            {
                //Masukan data gift redeem
                Gift_Redeem gr = new Gift_Redeem(DateTime.Now, gDipilih.JumlahPoin, gDipilih);
                Pelanggan.UpdatePoin(gDipilih, FormUtama.konsumen, FormUtama.koneksi);
                Gift_Redeem.TambahData(gr, FormUtama.koneksi);
                MessageBox.Show("Selamat! Hadiah berhasil ditukarkan!", "Informasi");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Poin anda tidak cukup untuk menukarkan hadiah ini");
            }
        }

        private void comboBoxPegawai_SelectedIndexChanged(object sender, EventArgs e)
        {
            gDipilih = (Gift)comboBoxHadiah.SelectedItem;
            textBoxBiayaPoin.Text = gDipilih.JumlahPoin.ToString();
        }

        #region DesainButton
        private void buttonTukar_MouseEnter(object sender, EventArgs e)
        {
            buttonTukar.BackgroundImage = Properties.Resources.Button_Hover;
        }
        private void buttonTukar_MouseLeave(object sender, EventArgs e)
        {
            buttonTukar.BackgroundImage = Properties.Resources.Button_Leave;
        }
        #endregion

    }
}
