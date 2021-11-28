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

        private void FormTukarHadiah_Load(object sender, EventArgs e)
        {
            listGift = Pegawai.BacaData("", "");

            comboBoxPegawai.DataSource = listGift;
            comboBoxPegawai.DisplayMember = "nama";

            comboBoxPegawai.DropDownStyle = ComboBoxStyle.DropDownList;

            textBoxNama.Focus();
        }

        private void buttonTukar_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPegawai_SelectedIndexChanged(object sender, EventArgs e)
        {

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
