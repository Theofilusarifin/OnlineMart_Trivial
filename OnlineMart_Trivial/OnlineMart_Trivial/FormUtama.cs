using System;
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
        public static Driver rider;
        public static Pelanggan konsumen;
        public static List<Barang> keranjang = new List<Barang>();

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
        private Form activeForm = null;
        private void openChildForm(Form childForm)
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
                Koneksi koneksi = new Koneksi();
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

        #region ButtonKonsumen
        private void buttonCheckout_Click(object sender, EventArgs e)
        {

        }
        private void buttonHistoriTransaksi_Click(object sender, EventArgs e)
        {

        }
        private void buttonCekPesanan_Click(object sender, EventArgs e)
        {

        }
        private void buttonCetakNota_Click(object sender, EventArgs e)
        {

        }
        private void buttonProfile_Click(object sender, EventArgs e)
        {

        }
        private void buttonIsiSaldo_Click(object sender, EventArgs e)
        {
            FormIsiSaldo frm = new FormIsiSaldo();
            frm.Owner = this;
            frm.Show();
        }
        #endregion

        #region ButtonRider
        private void buttonDaftarPengiriman_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            openChildForm(new FormDaftarPengiriman());
        }
        private void buttonRekapPendapatan_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region ButtonPegawai
        private void buttonPengaturan_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelPengaturan);
        }
        private void buttonRekapPenjualan_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelRekapPenjualan);
        }
        private void buttonPengaturanCabang_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            openChildForm(new FormDaftarCabang());
        }
        private void buttonPengaturanKategori_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            openChildForm(new FormDaftarKategori());
        }
        private void buttonPengaturanBarang_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            openChildForm(new FormDaftarBarang());
        }
        private void buttonPengaturanMetode_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            openChildForm(new FormDaftarMetodePembayaran());
        }
        private void buttonPengaturanPromo_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            openChildForm(new FormDaftarPromo());
        }
        private void buttonPengaturanHadiah_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            openChildForm(new FormDaftarHadiah());
        }
        private void btnRekapBarang_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        private void btnRekapOmaSaldo_Click(object sender, EventArgs e)
        {
            HideSubMenu();
        }
        #endregion

        #region ButtonLogout
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            //User ditanya sesuai dibawah
            DialogResult hasil = MessageBox.Show(this, "Anda yakin ingin logout?","LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //Kalau User klik yes barang akan dihapus
            if (hasil == DialogResult.Yes)
            {
                role = null;
                pegawai = null;
                rider = null;
                konsumen = null;
                panelKonsumen.Hide();
                panelPegawai.Hide();
                panelRider.Hide();
                labelNama.Text = "";
                panelLeftNavbar.Hide();
                panelLeft.Hide();
                panelHeader.Hide();
                panelActiveForm.Hide();
                FormAuth frm = new FormAuth(); //Create Object
                frm.MdiParent = this; //Set form utama menjadi parent dari objek form yang dibuat
                frm.Show(); //Tampilkan form
                            // Method ShowDialog() tidak bisa digunakan jika menerapkan MdiParent, bisanya Method Show();
            }
            
        }
        #endregion
    }
}
