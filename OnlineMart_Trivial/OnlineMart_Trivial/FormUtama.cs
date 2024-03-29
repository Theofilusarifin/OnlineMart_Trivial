﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Tambahkan using reference
using OnlineMart_LIB;

namespace OnlineMart_Trivial
{
    public partial class FormUtama : Form
    {
        public static FormUtama frmUtama = null;
        public static string role;
        public static Pegawai pegawai;
        public static Penjual penjual;
        public static Driver rider;
        public static Pelanggan konsumen;
        public static List<Barang> keranjang = new List<Barang>();
        public static Koneksi koneksi = null;
        public static Cabang cDipilih = null;
        public static Penjual pDipilih = null;
        public static bool firstLogin = true;

        public static string pilihVendor = "";

        // Ubah path sesuai dengan Path Resource masing-masing

        // Path Arifin
        public static string location = @"C:\Users\asus\Documents\GitHub\OnlineMart_Trivial\OnlineMart_Trivial\OnlineMart_Trivial\Resources";

        // Path Henri
        //public static string location = @"D:\Kuliah\GitHub\OnlineMart_Trivial\OnlineMart_Trivial\OnlineMart_Trivial\Resources";

        // Path Yaska
        //public static string location = @"C:\Users\LENOVO\Documents\GitHub\OnlineMart_Trivial\OnlineMart_Trivial\OnlineMart_Trivial\Resources";

        public FormUtama()
        {
            InitializeComponent();
            HideSubMenuFirst();
            frmUtama = this;
            //Background Transparant
            //pictureBoxOnboarding.Parent = pictureBoxBackground;
        }

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

        #region OpenFormAuth
        int opening = 0;
        private void timerLoading_Tick(object sender, EventArgs e)
        {
            opening++;
            if (opening == 1)
            {
                FormAuth frm = new FormAuth(); //Create Object
                frm.MdiParent = this; //Set form utama menjadi parent dari objek form yang dibuat
                frm.Show(); //Tampilkan form
                // Method ShowDialog() tidak bisa digunakan jika menerapkan MdiParent, bisanya Method Show();
                timerLoading.Stop();
                opening = 0;
            }
        }
        #endregion

        #region OpenChildForm
        public Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelActiveForm.Controls.Add(childForm);
            panelActiveForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        #endregion

        #region FormLoad
        private void FormUtama_Load(object sender, EventArgs e)
        {
            //Ubah form ini (FormUtama) menjadi fullscreen (maximized)
            //this.WindowState = FormWindowState.Maximized;

            //Ubah FormUtama menjadi MdiParent (MdiContainer)
            this.IsMdiContainer = true;

            try
            {
                //Ambil nilai di db setting
                koneksi = new Koneksi();
                //MessageBox.Show("Koneksi Berhasil");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi Gagal. Pesan Kesalahan : " + ex.Message);
            }
        }
        #endregion

        #region SubMenuPanel

        public void HideSubMenuFirst()
        {
            panelPengaturan.Hide();
            panelRekapPenjualan.Hide();
        }
        public void HideSubMenu()
        {
            if (panelPengaturan.Visible) panelPengaturan.Hide();
            if (panelRekapPenjualan.Visible) panelRekapPenjualan.Hide();
        }

        public void ShowSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                HideSubMenu();
                subMenu.Show();
            }
            else subMenu.Hide();
        }
        #endregion

        #region Notifikasi
        private void BelNotifikasi_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new FormNotifikasi());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
        #endregion

        #region ButtonKonsumen
        private void buttonBarangDeals_Click(object sender, EventArgs e)
        {
            try
            {
                if (pilihVendor == "penjual")
                {
                    MessageBox.Show("Anda tidak bisa memilih vendor yang berbeda!", "Informasi");
                }
                else
                {
                    openChildForm(new FormDaftarBarangPelanggan());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        private void buttonBarangPenjual_Click(object sender, EventArgs e)
        {
            try
            {
                if (pilihVendor == "cabang")
                {
                    MessageBox.Show("Anda tidak bisa memilih vendor yang berbeda!", "Informasi");
                }
                else
                {
                    openChildForm(new FormBarangPenjual());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        private void buttonKeranjang_Click(object sender, EventArgs e)
        {
            try
            {
                if (keranjang.Count() == 0)
                {
                    MessageBox.Show("Masukkan barang ke dalam keranjang terlebih dahulu!", "Informasi");
                }
                else
                {
                    openChildForm(new FormKeranjang());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormKeranjang.thisOrder.Total_bayar != 0)
                { 
                    //Buka Form
                    Form form = Application.OpenForms["FormCheckout"];

                    if (form == null) //Jika Form ini belum di-create sebelumnya
                    {
                        FormCheckout frm = new FormCheckout(); //Create Object
                        frm.Owner = this;
                        frm.Show();
                        frm.BringToFront(); //Tampilkan form
                    }
                    else
                    {
                        form.Show();
                        form.BringToFront(); //Agar form tampil di depan
                    }
                }
                else
                {
                    MessageBox.Show("Lakukan Checkout pada halaman keranjang terlebih dahulu", "Informasi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
        private void buttonHistoriTransaksi_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new FormHistoryTransaksi());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
        private void buttonCekPesanan_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new FormCekPesanan());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
        private void buttonCetakNota_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new FormCetakNota());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
        private void buttonIsiSaldo_Click(object sender, EventArgs e)
        {
            try
            {
                //Buka Form
                Form form = Application.OpenForms["FormIsiSaldo"];

                if (form == null) //Jika Form ini belum di-create sebelumnya
                {
                    FormIsiSaldo frm = new FormIsiSaldo(); //Create Object
                    frm.Owner = this;
                    frm.Show();
                    frm.BringToFront(); //Agar form tampil di depan
                }
                else
                {
                    form.Show();
                    form.BringToFront(); //Agar form tampil di depan
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
        private void buttonProfile_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new FormProfile());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
        private void buttonMiniGamesKonsumen_Click(object sender, EventArgs e)
        {
            try
            {
                //Buka Form
                Form form = Application.OpenForms["FormMiniGames"];

                if (form == null) //Jika Form ini belum di-create sebelumnya
                {
                    FormMiniGames frm = new FormMiniGames(); //Create Object
                    frm.Owner = this;
                    frm.Show();
                    frm.BringToFront(); //Agar form tampil di depan
                }
                else
                {
                    form.Show();
                    form.BringToFront(); //Agar form tampil di depan
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
        #endregion

        #region ButtonRider
        private void buttonDaftarPengiriman_Click(object sender, EventArgs e)
        {
            try
            {
                HideSubMenu();
                openChildForm(new FormDaftarPengiriman());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
        private void buttonRekapPendapatan_Click(object sender, EventArgs e)
        {
            try
            {
                HideSubMenu();
                openChildForm(new FormRekapPendapatan());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
        private void buttonChatKonsumen_Click(object sender, EventArgs e)
        {
            try
            {
                HideSubMenu();
                openChildForm(new FormChatPelanggan());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
        #endregion

        #region ButtonPegawai
        private void buttonPengaturan_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelPengaturan);
        }
        private void buttonPengaturanCabang_Click(object sender, EventArgs e)
        {
            try
            {
                HideSubMenu();
                openChildForm(new FormDaftarCabang());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
        private void buttonPengaturanKategori_Click(object sender, EventArgs e)
        {
            try
            {
                HideSubMenu();
                openChildForm(new FormDaftarKategori());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
        private void buttonPengaturanBarang_Click(object sender, EventArgs e)
        {
            try
            {
                HideSubMenu();
                openChildForm(new FormDaftarBarang());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
        private void buttonPengaturanStok_Click(object sender, EventArgs e)
        {
            try
            {
                HideSubMenu();
                openChildForm(new FormDaftarBarangCabang());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
        private void buttonPengaturanMetodePembayaran_Click(object sender, EventArgs e)
        {
            try
            {
                HideSubMenu();
                openChildForm(new FormDaftarMetodePembayaran());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
        private void buttonPengaturanPromo_Click(object sender, EventArgs e)
        {
            try
            {
                HideSubMenu();
                openChildForm(new FormDaftarPromo());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
        private void buttonPengaturanHadiah_Click(object sender, EventArgs e)
        {
            try
            {
                HideSubMenu();
                openChildForm(new FormDaftarHadiah());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        private void buttonRekapPenjualan_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelRekapPenjualan);
        }

        private void btnRekapBarang_Click(object sender, EventArgs e)
        {
            try
            {
                HideSubMenu();
                openChildForm(new FormRekapPenjualanBarang());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
        private void btnRekapOmaSaldo_Click(object sender, EventArgs e)
        {
            try
            {
                HideSubMenu();
                openChildForm(new FormRekapPenjualanOmaSaldo());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
        private void buttonAccPenjual_Click(object sender, EventArgs e)
        {
            try
            {
                HideSubMenu();
                openChildForm(new FormAccPenjual());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
        private void buttonBlacklistPenjualPegawai_Click(object sender, EventArgs e)
        {
            try
            {
                HideSubMenu();
                openChildForm(new FormDaftarPenjual());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
        #endregion

        #region ButtonPenjual

        private void btnDaftarBarangPenjual_Click(object sender, EventArgs e)
        {
            try
            {
                HideSubMenu();
                openChildForm(new FormDaftarBarangPenjual());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
        private void btnChatPenjual_Click(object sender, EventArgs e)
        {
            try
            {
                HideSubMenu();
                openChildForm(new FormChatPenjual());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
        #endregion

        #region ButtonLogout
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            try
            {
                //User ditanya sesuai dibawah
                DialogResult hasil = MessageBox.Show(this, "Anda yakin ingin logout?", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                //Kalau User klik yes barang akan dihapus
                if (hasil == DialogResult.Yes)
                {
                    role = null;
                    pegawai = null;
                    rider = null;
                    konsumen = null;
                    keranjang.Clear();
                    FormKeranjang.listBarangOrder.Clear();
                    if (activeForm != null) activeForm.Close();

                    panelKonsumen.Hide();
                    panelPegawai.Hide();
                    panelRider.Hide();
                    panelPenjual.Hide();

                    labelPoin.Text = "";
                    labelSaldo.Text = "";
                    labelPoinHeader.Hide();
                    labelPoin.Hide();
                    labelSaldoHeader.Hide();
                    labelSaldo.Hide();

                    labelNama.Text = "";
                    panelLeftNavbar.Hide();
                    panelLeft.Hide();
                    panelHeader.Hide();
                    panelActiveForm.Hide();
                    FormAuth frm = new FormAuth(); //Create Object
                    frm.MdiParent = this; //Set form utama menjadi parent dari objek form yang dibuat
                    frm.Show(); //Tampilkan form
                                // Method ShowDialog() tidak bisa digunakan jika menerapkan MdiParent, bisanya Method Show();

                    pilihVendor = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }

		#endregion

		#region Button Chat konsumen ke Penjual
		private void buttonChat_Click(object sender, EventArgs e)
		{
            try
            {
                HideSubMenu();
                openChildForm(new FormChatPenjual());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
		#endregion

		#region Button Chat Penjual ke konsumen
		private void buttonChatPenjual_Click(object sender, EventArgs e)
		{
            try
            {
                HideSubMenu();
                openChildForm(new FormChatPenjual());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka halaman. Pesan kesalahan : " + ex.Message, "Kesalahan");
            }
        }
		#endregion

    }
}
