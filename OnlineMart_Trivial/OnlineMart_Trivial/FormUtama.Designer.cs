
namespace OnlineMart_Trivial
{
    partial class FormUtama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUtama));
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.panelLeftNavbar = new System.Windows.Forms.Panel();
            this.panelRider = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelKonsumen = new System.Windows.Forms.Panel();
            this.panelPegawai = new System.Windows.Forms.Panel();
            this.buttonIsiSaldo = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonCekPesanan = new System.Windows.Forms.Button();
            this.buttonCetakNota = new System.Windows.Forms.Button();
            this.buttonBarangDeals = new System.Windows.Forms.Button();
            this.buttonKeranjang = new System.Windows.Forms.Button();
            this.buttonCheckout = new System.Windows.Forms.Button();
            this.buttonHistoriTransaksi = new System.Windows.Forms.Button();
            this.buttonDaftarPengiriman = new System.Windows.Forms.Button();
            this.buttonRekapPendapatan = new System.Windows.Forms.Button();
            this.buttonRekapPenjualan = new System.Windows.Forms.Button();
            this.buttonPengaturanCabang = new System.Windows.Forms.Button();
            this.buttonPengaturanKategori = new System.Windows.Forms.Button();
            this.btnRekapOmaSaldo = new System.Windows.Forms.Button();
            this.btnRekapBarang = new System.Windows.Forms.Button();
            this.buttonPengaturan = new System.Windows.Forms.Button();
            this.panelRekapPenjualan = new System.Windows.Forms.Panel();
            this.panelPengaturan = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonPengaturanPromo = new System.Windows.Forms.Button();
            this.buttonPengaturanHadiah = new System.Windows.Forms.Button();
            this.buttonPengaturanBarang = new System.Windows.Forms.Button();
            this.buttonPengaturanMetode = new System.Windows.Forms.Button();
            this.panelLeftNavbar.SuspendLayout();
            this.panelRider.SuspendLayout();
            this.panelKonsumen.SuspendLayout();
            this.panelPegawai.SuspendLayout();
            this.panelRekapPenjualan.SuspendLayout();
            this.panelPengaturan.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerLoading
            // 
            this.timerLoading.Enabled = true;
            this.timerLoading.Interval = 15;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // panelLeftNavbar
            // 
            this.panelLeftNavbar.AutoScroll = true;
            this.panelLeftNavbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(62)))), ((int)(((byte)(34)))));
            this.panelLeftNavbar.Controls.Add(this.panelPegawai);
            this.panelLeftNavbar.Controls.Add(this.panelRider);
            this.panelLeftNavbar.Controls.Add(this.panelKonsumen);
            this.panelLeftNavbar.Controls.Add(this.buttonLogout);
            this.panelLeftNavbar.Controls.Add(this.panelLogo);
            this.panelLeftNavbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftNavbar.ForeColor = System.Drawing.Color.White;
            this.panelLeftNavbar.Location = new System.Drawing.Point(0, 0);
            this.panelLeftNavbar.Name = "panelLeftNavbar";
            this.panelLeftNavbar.Size = new System.Drawing.Size(250, 931);
            this.panelLeftNavbar.TabIndex = 0;
            // 
            // panelRider
            // 
            this.panelRider.Controls.Add(this.buttonRekapPendapatan);
            this.panelRider.Controls.Add(this.buttonDaftarPengiriman);
            this.panelRider.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRider.Location = new System.Drawing.Point(0, 501);
            this.panelRider.Name = "panelRider";
            this.panelRider.Size = new System.Drawing.Size(233, 107);
            this.panelRider.TabIndex = 1;
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(233, 100);
            this.panelLogo.TabIndex = 2;
            // 
            // panelKonsumen
            // 
            this.panelKonsumen.Controls.Add(this.buttonIsiSaldo);
            this.panelKonsumen.Controls.Add(this.buttonProfile);
            this.panelKonsumen.Controls.Add(this.buttonCetakNota);
            this.panelKonsumen.Controls.Add(this.buttonCekPesanan);
            this.panelKonsumen.Controls.Add(this.buttonHistoriTransaksi);
            this.panelKonsumen.Controls.Add(this.buttonCheckout);
            this.panelKonsumen.Controls.Add(this.buttonKeranjang);
            this.panelKonsumen.Controls.Add(this.buttonBarangDeals);
            this.panelKonsumen.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelKonsumen.Location = new System.Drawing.Point(0, 100);
            this.panelKonsumen.Name = "panelKonsumen";
            this.panelKonsumen.Size = new System.Drawing.Size(233, 401);
            this.panelKonsumen.TabIndex = 2;
            // 
            // panelPegawai
            // 
            this.panelPegawai.Controls.Add(this.panelRekapPenjualan);
            this.panelPegawai.Controls.Add(this.buttonRekapPenjualan);
            this.panelPegawai.Controls.Add(this.panelPengaturan);
            this.panelPegawai.Controls.Add(this.buttonPengaturan);
            this.panelPegawai.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPegawai.Location = new System.Drawing.Point(0, 608);
            this.panelPegawai.Name = "panelPegawai";
            this.panelPegawai.Size = new System.Drawing.Size(233, 560);
            this.panelPegawai.TabIndex = 3;
            // 
            // buttonIsiSaldo
            // 
            this.buttonIsiSaldo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonIsiSaldo.Location = new System.Drawing.Point(0, 315);
            this.buttonIsiSaldo.Name = "buttonIsiSaldo";
            this.buttonIsiSaldo.Size = new System.Drawing.Size(233, 45);
            this.buttonIsiSaldo.TabIndex = 1;
            this.buttonIsiSaldo.Text = "ISI SALDO";
            this.buttonIsiSaldo.UseVisualStyleBackColor = true;
            // 
            // buttonProfile
            // 
            this.buttonProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProfile.Location = new System.Drawing.Point(0, 270);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(233, 45);
            this.buttonProfile.TabIndex = 2;
            this.buttonProfile.Text = "PROFILE";
            this.buttonProfile.UseVisualStyleBackColor = true;
            // 
            // buttonCekPesanan
            // 
            this.buttonCekPesanan.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCekPesanan.Location = new System.Drawing.Point(0, 180);
            this.buttonCekPesanan.Name = "buttonCekPesanan";
            this.buttonCekPesanan.Size = new System.Drawing.Size(233, 45);
            this.buttonCekPesanan.TabIndex = 4;
            this.buttonCekPesanan.Text = "CEK PESANAN";
            this.buttonCekPesanan.UseVisualStyleBackColor = true;
            // 
            // buttonCetakNota
            // 
            this.buttonCetakNota.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCetakNota.Location = new System.Drawing.Point(0, 225);
            this.buttonCetakNota.Name = "buttonCetakNota";
            this.buttonCetakNota.Size = new System.Drawing.Size(233, 45);
            this.buttonCetakNota.TabIndex = 3;
            this.buttonCetakNota.Text = "CETAK NOTA";
            this.buttonCetakNota.UseVisualStyleBackColor = true;
            // 
            // buttonBarangDeals
            // 
            this.buttonBarangDeals.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBarangDeals.Location = new System.Drawing.Point(0, 0);
            this.buttonBarangDeals.Name = "buttonBarangDeals";
            this.buttonBarangDeals.Size = new System.Drawing.Size(233, 45);
            this.buttonBarangDeals.TabIndex = 8;
            this.buttonBarangDeals.Text = "BARANG DAN DEALS";
            this.buttonBarangDeals.UseVisualStyleBackColor = true;
            // 
            // buttonKeranjang
            // 
            this.buttonKeranjang.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonKeranjang.Location = new System.Drawing.Point(0, 45);
            this.buttonKeranjang.Name = "buttonKeranjang";
            this.buttonKeranjang.Size = new System.Drawing.Size(233, 45);
            this.buttonKeranjang.TabIndex = 7;
            this.buttonKeranjang.Text = "KERANJANG";
            this.buttonKeranjang.UseVisualStyleBackColor = true;
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCheckout.Location = new System.Drawing.Point(0, 90);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(233, 45);
            this.buttonCheckout.TabIndex = 6;
            this.buttonCheckout.Text = "CHECKOUT";
            this.buttonCheckout.UseVisualStyleBackColor = true;
            // 
            // buttonHistoriTransaksi
            // 
            this.buttonHistoriTransaksi.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHistoriTransaksi.Location = new System.Drawing.Point(0, 135);
            this.buttonHistoriTransaksi.Name = "buttonHistoriTransaksi";
            this.buttonHistoriTransaksi.Size = new System.Drawing.Size(233, 45);
            this.buttonHistoriTransaksi.TabIndex = 5;
            this.buttonHistoriTransaksi.Text = "HISTORI TRANSAKSI";
            this.buttonHistoriTransaksi.UseVisualStyleBackColor = true;
            // 
            // buttonDaftarPengiriman
            // 
            this.buttonDaftarPengiriman.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDaftarPengiriman.Location = new System.Drawing.Point(0, 0);
            this.buttonDaftarPengiriman.Name = "buttonDaftarPengiriman";
            this.buttonDaftarPengiriman.Size = new System.Drawing.Size(233, 45);
            this.buttonDaftarPengiriman.TabIndex = 16;
            this.buttonDaftarPengiriman.Text = "DAFTAR PENGIRIMAN";
            this.buttonDaftarPengiriman.UseVisualStyleBackColor = true;
            // 
            // buttonRekapPendapatan
            // 
            this.buttonRekapPendapatan.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRekapPendapatan.Location = new System.Drawing.Point(0, 45);
            this.buttonRekapPendapatan.Name = "buttonRekapPendapatan";
            this.buttonRekapPendapatan.Size = new System.Drawing.Size(233, 45);
            this.buttonRekapPendapatan.TabIndex = 15;
            this.buttonRekapPendapatan.Text = "REKAP PENDAPATAN";
            this.buttonRekapPendapatan.UseVisualStyleBackColor = true;
            // 
            // buttonRekapPenjualan
            // 
            this.buttonRekapPenjualan.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRekapPenjualan.Location = new System.Drawing.Point(0, 335);
            this.buttonRekapPenjualan.Name = "buttonRekapPenjualan";
            this.buttonRekapPenjualan.Size = new System.Drawing.Size(233, 45);
            this.buttonRekapPenjualan.TabIndex = 1;
            this.buttonRekapPenjualan.Text = "REKAP PENJUALAN";
            this.buttonRekapPenjualan.UseVisualStyleBackColor = true;
            // 
            // buttonPengaturanCabang
            // 
            this.buttonPengaturanCabang.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPengaturanCabang.FlatAppearance.BorderSize = 0;
            this.buttonPengaturanCabang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPengaturanCabang.ForeColor = System.Drawing.Color.LightGray;
            this.buttonPengaturanCabang.Location = new System.Drawing.Point(0, 0);
            this.buttonPengaturanCabang.Name = "buttonPengaturanCabang";
            this.buttonPengaturanCabang.Size = new System.Drawing.Size(233, 45);
            this.buttonPengaturanCabang.TabIndex = 13;
            this.buttonPengaturanCabang.Text = "CABANG";
            this.buttonPengaturanCabang.UseVisualStyleBackColor = true;
            // 
            // buttonPengaturanKategori
            // 
            this.buttonPengaturanKategori.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPengaturanKategori.FlatAppearance.BorderSize = 0;
            this.buttonPengaturanKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPengaturanKategori.ForeColor = System.Drawing.Color.LightGray;
            this.buttonPengaturanKategori.Location = new System.Drawing.Point(0, 45);
            this.buttonPengaturanKategori.Name = "buttonPengaturanKategori";
            this.buttonPengaturanKategori.Size = new System.Drawing.Size(233, 45);
            this.buttonPengaturanKategori.TabIndex = 12;
            this.buttonPengaturanKategori.Text = "KATEGORI";
            this.buttonPengaturanKategori.UseVisualStyleBackColor = true;
            // 
            // btnRekapOmaSaldo
            // 
            this.btnRekapOmaSaldo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRekapOmaSaldo.Location = new System.Drawing.Point(0, 45);
            this.btnRekapOmaSaldo.Name = "btnRekapOmaSaldo";
            this.btnRekapOmaSaldo.Size = new System.Drawing.Size(233, 45);
            this.btnRekapOmaSaldo.TabIndex = 11;
            this.btnRekapOmaSaldo.Text = "OMA SALDO";
            this.btnRekapOmaSaldo.UseVisualStyleBackColor = true;
            // 
            // btnRekapBarang
            // 
            this.btnRekapBarang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRekapBarang.Location = new System.Drawing.Point(0, 0);
            this.btnRekapBarang.Name = "btnRekapBarang";
            this.btnRekapBarang.Size = new System.Drawing.Size(233, 45);
            this.btnRekapBarang.TabIndex = 10;
            this.btnRekapBarang.Text = "BARANG";
            this.btnRekapBarang.UseVisualStyleBackColor = true;
            // 
            // buttonPengaturan
            // 
            this.buttonPengaturan.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPengaturan.FlatAppearance.BorderSize = 0;
            this.buttonPengaturan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPengaturan.Location = new System.Drawing.Point(0, 0);
            this.buttonPengaturan.Name = "buttonPengaturan";
            this.buttonPengaturan.Size = new System.Drawing.Size(233, 45);
            this.buttonPengaturan.TabIndex = 9;
            this.buttonPengaturan.Text = "PENGATURAN";
            this.buttonPengaturan.UseVisualStyleBackColor = true;
            // 
            // panelRekapPenjualan
            // 
            this.panelRekapPenjualan.Controls.Add(this.btnRekapOmaSaldo);
            this.panelRekapPenjualan.Controls.Add(this.btnRekapBarang);
            this.panelRekapPenjualan.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRekapPenjualan.Location = new System.Drawing.Point(0, 380);
            this.panelRekapPenjualan.Name = "panelRekapPenjualan";
            this.panelRekapPenjualan.Size = new System.Drawing.Size(233, 111);
            this.panelRekapPenjualan.TabIndex = 15;
            // 
            // panelPengaturan
            // 
            this.panelPengaturan.Controls.Add(this.buttonPengaturanHadiah);
            this.panelPengaturan.Controls.Add(this.buttonPengaturanPromo);
            this.panelPengaturan.Controls.Add(this.buttonPengaturanMetode);
            this.panelPengaturan.Controls.Add(this.buttonPengaturanBarang);
            this.panelPengaturan.Controls.Add(this.buttonPengaturanKategori);
            this.panelPengaturan.Controls.Add(this.buttonPengaturanCabang);
            this.panelPengaturan.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPengaturan.Location = new System.Drawing.Point(0, 45);
            this.panelPengaturan.Name = "panelPengaturan";
            this.panelPengaturan.Size = new System.Drawing.Size(233, 290);
            this.panelPengaturan.TabIndex = 1;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLogout.Location = new System.Drawing.Point(0, 1168);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(233, 45);
            this.buttonLogout.TabIndex = 12;
            this.buttonLogout.Text = "LOGOUT";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // buttonPengaturanPromo
            // 
            this.buttonPengaturanPromo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPengaturanPromo.Location = new System.Drawing.Point(0, 180);
            this.buttonPengaturanPromo.Name = "buttonPengaturanPromo";
            this.buttonPengaturanPromo.Size = new System.Drawing.Size(233, 45);
            this.buttonPengaturanPromo.TabIndex = 15;
            this.buttonPengaturanPromo.Text = "PROMO";
            this.buttonPengaturanPromo.UseVisualStyleBackColor = true;
            // 
            // buttonPengaturanHadiah
            // 
            this.buttonPengaturanHadiah.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPengaturanHadiah.Location = new System.Drawing.Point(0, 225);
            this.buttonPengaturanHadiah.Name = "buttonPengaturanHadiah";
            this.buttonPengaturanHadiah.Size = new System.Drawing.Size(233, 45);
            this.buttonPengaturanHadiah.TabIndex = 14;
            this.buttonPengaturanHadiah.Text = "HADIAH";
            this.buttonPengaturanHadiah.UseVisualStyleBackColor = true;
            // 
            // buttonPengaturanBarang
            // 
            this.buttonPengaturanBarang.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPengaturanBarang.Location = new System.Drawing.Point(0, 90);
            this.buttonPengaturanBarang.Name = "buttonPengaturanBarang";
            this.buttonPengaturanBarang.Size = new System.Drawing.Size(233, 45);
            this.buttonPengaturanBarang.TabIndex = 17;
            this.buttonPengaturanBarang.Text = "BARANG";
            this.buttonPengaturanBarang.UseVisualStyleBackColor = true;
            // 
            // buttonPengaturanMetode
            // 
            this.buttonPengaturanMetode.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPengaturanMetode.Location = new System.Drawing.Point(0, 135);
            this.buttonPengaturanMetode.Name = "buttonPengaturanMetode";
            this.buttonPengaturanMetode.Size = new System.Drawing.Size(233, 45);
            this.buttonPengaturanMetode.TabIndex = 16;
            this.buttonPengaturanMetode.Text = "METODE PEMBAYARAN";
            this.buttonPengaturanMetode.UseVisualStyleBackColor = true;
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Background_Login_Register;
            this.ClientSize = new System.Drawing.Size(1864, 931);
            this.Controls.Add(this.panelLeftNavbar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Online Mart";
            this.Load += new System.EventHandler(this.FormUtama_Load);
            this.panelLeftNavbar.ResumeLayout(false);
            this.panelRider.ResumeLayout(false);
            this.panelKonsumen.ResumeLayout(false);
            this.panelPegawai.ResumeLayout(false);
            this.panelRekapPenjualan.ResumeLayout(false);
            this.panelPengaturan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerLoading;
        private System.Windows.Forms.Panel panelLeftNavbar;
        private System.Windows.Forms.Panel panelPegawai;
        private System.Windows.Forms.Panel panelRider;
        private System.Windows.Forms.Panel panelKonsumen;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonIsiSaldo;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonCekPesanan;
        private System.Windows.Forms.Button buttonCetakNota;
        private System.Windows.Forms.Button buttonBarangDeals;
        private System.Windows.Forms.Button buttonKeranjang;
        private System.Windows.Forms.Button buttonCheckout;
        private System.Windows.Forms.Button buttonHistoriTransaksi;
        private System.Windows.Forms.Button buttonDaftarPengiriman;
        private System.Windows.Forms.Button buttonRekapPendapatan;
        private System.Windows.Forms.Button buttonRekapPenjualan;
        private System.Windows.Forms.Button buttonPengaturanCabang;
        private System.Windows.Forms.Button buttonPengaturanKategori;
        private System.Windows.Forms.Button btnRekapOmaSaldo;
        private System.Windows.Forms.Button btnRekapBarang;
        private System.Windows.Forms.Button buttonPengaturan;
        private System.Windows.Forms.Panel panelRekapPenjualan;
        private System.Windows.Forms.Panel panelPengaturan;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonPengaturanPromo;
        private System.Windows.Forms.Button buttonPengaturanHadiah;
        private System.Windows.Forms.Button buttonPengaturanBarang;
        private System.Windows.Forms.Button buttonPengaturanMetode;
    }
}

