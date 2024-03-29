﻿using System;
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

        int notifCountKonsumen = 0;
        int notifCountDriver = 0;
        int notifCountPegawai = 0;
        int notifCountPenjual = 0;
        int notifCountAkhir = 0;
        int notifCount = 0;
        string role_user = "";

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

        #region FormClosing
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

                    FormUtama.frmUtama.pictureBoxPoin.Show();
                    FormUtama.frmUtama.pictureBoxSaldo.Show();
                    FormUtama.frmUtama.labelPoinHeader.Show();
                    FormUtama.frmUtama.labelPoin.Show();
                    FormUtama.frmUtama.labelPoin.Text = FormUtama.konsumen.Poin.ToString();
                    FormUtama.frmUtama.labelSaldoHeader.Show();
                    FormUtama.frmUtama.labelSaldo.Show();
                    FormUtama.frmUtama.labelSaldo.Text = FormUtama.konsumen.Saldo.ToString();
                    FormUtama.frmUtama.labelSaldoHeader.BringToFront();
                    FormUtama.frmUtama.labelPoinHeader.BringToFront();
                    FormUtama.frmUtama.labelSaldo.BringToFront();
                    FormUtama.frmUtama.labelPoin.BringToFront();


                }
                else if (FormUtama.role == "rider")
                {
                    FormUtama.frmUtama.panelRider.Show();

                    role_user = "driver";
                }
                else if (FormUtama.role == "pegawai")
                {
                    FormUtama.frmUtama.panelPegawai.Show();

                    role_user = "pegawai";
                }
                else if (FormUtama.role == "penjual")
                {
                    FormUtama.frmUtama.panelPenjual.Show();

                    role_user = "penjual";
                }
                else MessageBox.Show("Terjadi error, role tidak terdefinisi");

                #region Notifikasi
                //MessageBox.Show("firstLogin = " + FormUtama.firstLogin);
                // kalau baru pertama kali login di user manapun
                if (FormUtama.firstLogin == true)
                {
                    // hitung notifikasi awal setiap user
                    notifCountKonsumen = Notifikasi.HitungNotifikasi("konsumen");
                    notifCountDriver = Notifikasi.HitungNotifikasi("driver");
                    notifCountPegawai = Notifikasi.HitungNotifikasi("pegawai");
                    notifCountPenjual = Notifikasi.HitungNotifikasi("penjual");

                    //MessageBox.Show("notifCountKonsumen = " + notifCountKonsumen +
                    //                "\nnotifCountDriver = " + notifCountDriver +
                    //                "\nnotifCountPegawai = " + notifCountPegawai +
                    //                "\nnotifCountPenjual = " + notifCountPenjual);

                    FormUtama.firstLogin = false;
                    //MessageBox.Show("firstLogin = " + FormUtama.firstLogin);
                }

                if (FormUtama.firstLogin == false)
                {
                    // hitung notif akhir
                    notifCountAkhir = Notifikasi.HitungNotifikasi(role_user);
                    //MessageBox.Show("notifCountAkhir = " + notifCountAkhir);

                    // hitung notif yang ditampilkan
                    //MessageBox.Show("role_user = " + role_user);
                    switch (role_user)
                    {
                        case "konsumen":
                            notifCount = notifCountAkhir - notifCountKonsumen;
                            break;
                        case "driver":
                            notifCount = notifCountAkhir - notifCountDriver;
                            break;
                        case "pegawai":
                            notifCount = notifCountAkhir - notifCountPegawai;
                            break;
                        case "penjual":
                            notifCount = notifCountAkhir - notifCountPenjual;
                            break;
                    }

                    #region Tampilkan Notif
                    //MessageBox.Show("notifCount = " + notifCount);
                    if (notifCount == 0)
                    {
                        FormUtama.frmUtama.NotifRedCircle.Image = null;
                        FormUtama.frmUtama.BelNotifikasi.Image = null;
                        FormUtama.frmUtama.labelNotifCount.Text = "";
                    }
                    else if (notifCount > 0 && notifCount < 10) // notif 1-9
                    {
                        FormUtama.frmUtama.NotifRedCircle.Image = Properties.Resources.notification;
                        FormUtama.frmUtama.BelNotifikasi.Image = Properties.Resources.notification_panel;
                        FormUtama.frmUtama.NotifRedCircle.Size = new Size(17, 17);
                        FormUtama.frmUtama.NotifRedCircle.Location = new Point(1709, 14);

                        FormUtama.frmUtama.labelNotifCount.Text = notifCount.ToString();
                    }
                    else if (notifCount >= 10 && notifCount < 100) // notif 10-99
                    {
                        FormUtama.frmUtama.NotifRedCircle.Image = Properties.Resources.notification;
                        FormUtama.frmUtama.BelNotifikasi.Image = Properties.Resources.notification_panel;
                        FormUtama.frmUtama.NotifRedCircle.Size = new Size(23, 23);
                        FormUtama.frmUtama.NotifRedCircle.Location = new Point(1709, 11);

                        FormUtama.frmUtama.labelNotifCount.Text = notifCount.ToString();
                    }
                    else if (notifCount >= 100) // notif > 99
                    {
                        FormUtama.frmUtama.NotifRedCircle.Image = Properties.Resources.notification;
                        FormUtama.frmUtama.BelNotifikasi.Image = Properties.Resources.notification_panel;
                        FormUtama.frmUtama.NotifRedCircle.Size = new Size(29, 29);
                        FormUtama.frmUtama.NotifRedCircle.Location = new Point(1709, 8);

                        FormUtama.frmUtama.labelNotifCount.Text = "99+";
                    }
                    #endregion

                    //// countNotifAkhir jadi countNotifAwal
                    //switch (role_user)
                    //{
                    //    case "konsumen":
                    //        notifCountKonsumen = notifCountAkhir;
                    //        break;
                    //    case "driver":
                    //        notifCountDriver = notifCountAkhir;
                    //        break;
                    //    case "pegawai":
                    //        notifCountPegawai = notifCountAkhir;
                    //        break;
                    //    case "penjual":
                    //        notifCountPenjual = notifCountAkhir;
                    //        break;
                    //}
                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Error, Pesan kesalahan : " + ex.Message, "Error");
            }
        }
        #endregion
    }
}
