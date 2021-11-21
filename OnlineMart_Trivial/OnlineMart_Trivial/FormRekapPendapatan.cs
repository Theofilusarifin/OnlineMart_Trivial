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
    public partial class FormRekapPendapatan : Form
    {
        public FormRekapPendapatan()
        {
            InitializeComponent();
        }

        private void FormRekapPendapatan_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxbulan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string bulan = "";
            #region switch case
            switch (comboBoxbulan.SelectedItem)
            {
                case "Januari":
                    bulan = "1";
                    break;
                case "Februari":
                    bulan = "2";
                    break;
                case "Maret":
                    bulan = "3";
                    break;
                case "April":
                    bulan = "4";
                    break;
                case "Mei":
                    bulan = "5";
                    break;
                case "Juni":
                    bulan = "6";
                    break;
                case "Juli":
                    bulan = "7";
                    break;
                case "Agustus":
                    bulan = "8";
                    break;
                case "September":
                    bulan = "9";
                    break;
                case "Oktober":
                    bulan = "10";
                    break;
                case "November":
                    bulan = "11";
                    break;
                case "Desember":
                    bulan = "12";
                    break;
            }
            #endregion

            Order.BacaTanggal(bulan, "", FormUtama.koneksi);

            FormRekapPendapatan_Load(sender, e);
        }
    }
}
