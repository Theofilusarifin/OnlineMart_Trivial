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
    public partial class FormLoading : Form
    {
        public FormLoading()
        {
            InitializeComponent();
        }

        int notifCount = 0;
        string role_user = "";
        DateTime waktu = DateTime.MinValue;

        #region No Tick Constrols
        //Optimized Controls(No Tick)
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        #endregion

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            panelLoading.Width += 3;
            if (panelLoading.Width >= 533)
            {
                timerLoading.Stop();
                this.Close();
            }
        }

        private void FormLoading_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                FormUtama.frmUtama.panelLeftNavbar.Show();
                FormUtama.frmUtama.panelLeft.Show();
                FormUtama.frmUtama.panelHeader.Show();
                FormUtama.frmUtama.panelActiveForm.Show();
                FormUtama.frmUtama.panelLeftNavbar.BringToFront();

                if (FormUtama.role == "konsumen")
                {
                    FormUtama.frmUtama.panelKonsumen.Show();

                    role_user = "konsumen";
                    waktu = FormUtama.waktuKonsumen;
                }
                else if (FormUtama.role == "rider")
                {
                    FormUtama.frmUtama.panelRider.Show();

                    role_user = "driver";
                    waktu = FormUtama.waktuDriver;
                }
                else if (FormUtama.role == "pegawai")
                {
                    FormUtama.frmUtama.panelPegawai.Show();

                    role_user = "pegawai";
                    waktu = FormUtama.waktuPegawai;
                }
                else if (FormUtama.role == "penjual")
                {
                    FormUtama.frmUtama.panelPenjual.Show();

                    role_user = "penjual";
                    waktu = FormUtama.waktuPenjual;
                }
                else MessageBox.Show("Terjadi error, role tidak terdefinisi");

                //  NANTI INI ATUREN LAGI FIN :)
                #region Notifikasi
                if (FormUtama.koneksi != null)
                {
                    notifCount = Notifikasi.HitungNotifikasi(role_user, waktu);
                    if (notifCount == 0)
                    {
                        FormUtama.frmUtama.NotifRedCircle.BackColor = Color.Transparent; // untuk sementara
                        FormUtama.frmUtama.labelNotifCount.Text = "";
                    }
                    else if (notifCount > 0 && notifCount < 10) // notif 1-9
                    {
                        FormUtama.frmUtama.NotifRedCircle.BackColor = Color.Tomato;
                        FormUtama.frmUtama.NotifRedCircle.Size = new Size(17, 17);
                        FormUtama.frmUtama.NotifRedCircle.Location = new Point(1045, 14);

                        FormUtama.frmUtama.labelNotifCount.Text = notifCount.ToString();
                    }
                    else if (notifCount >= 10 && notifCount < 100) // notif 10-99
                    {
                        FormUtama.frmUtama.NotifRedCircle.BackColor = Color.Tomato;
                        FormUtama.frmUtama.NotifRedCircle.Size = new Size(23, 23);
                        FormUtama.frmUtama.NotifRedCircle.Location = new Point(1045, 11);

                        FormUtama.frmUtama.labelNotifCount.Text = notifCount.ToString();
                    }
                    else if (notifCount >= 100) // notif > 99
                    {
                        FormUtama.frmUtama.NotifRedCircle.BackColor = Color.Tomato;
                        FormUtama.frmUtama.NotifRedCircle.Size = new Size(29, 29);
                        FormUtama.frmUtama.NotifRedCircle.Location = new Point(1045, 8);

                        FormUtama.frmUtama.labelNotifCount.Text = "99+";
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error, Pesan kesalahan : " + ex.Message, "Error");
                MessageBox.Show("waktu = " + waktu.ToString("yyyy-MM-dd HH:mm:ss"));
                MessageBox.Show("DateTime.Now = " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            }
        }
    }
}
