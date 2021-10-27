
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
            this.panelPegawai = new System.Windows.Forms.Panel();
            this.panelRekapPenjualan = new System.Windows.Forms.Panel();
            this.btnRekapOmaSaldo = new System.Windows.Forms.Button();
            this.btnRekapBarang = new System.Windows.Forms.Button();
            this.buttonRekapPenjualan = new System.Windows.Forms.Button();
            this.panelPengaturan = new System.Windows.Forms.Panel();
            this.buttonPengaturanHadiah = new System.Windows.Forms.Button();
            this.buttonPengaturanPromo = new System.Windows.Forms.Button();
            this.buttonPengaturanMetode = new System.Windows.Forms.Button();
            this.buttonPengaturanBarang = new System.Windows.Forms.Button();
            this.buttonPengaturanKategori = new System.Windows.Forms.Button();
            this.buttonPengaturanCabang = new System.Windows.Forms.Button();
            this.buttonPengaturan = new System.Windows.Forms.Button();
            this.panelRider = new System.Windows.Forms.Panel();
            this.buttonRekapPendapatan = new System.Windows.Forms.Button();
            this.buttonDaftarPengiriman = new System.Windows.Forms.Button();
            this.panelKonsumen = new System.Windows.Forms.Panel();
            this.buttonIsiSaldo = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonCetakNota = new System.Windows.Forms.Button();
            this.buttonCekPesanan = new System.Windows.Forms.Button();
            this.buttonHistoriTransaksi = new System.Windows.Forms.Button();
            this.buttonCheckout = new System.Windows.Forms.Button();
            this.buttonKeranjang = new System.Windows.Forms.Button();
            this.buttonBarangDeals = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelActiveForm = new System.Windows.Forms.Panel();
            this.panelTitleActiveForm = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLeftNavbar.SuspendLayout();
            this.panelPegawai.SuspendLayout();
            this.panelRekapPenjualan.SuspendLayout();
            this.panelPengaturan.SuspendLayout();
            this.panelRider.SuspendLayout();
            this.panelKonsumen.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panelLeftNavbar.Visible = false;
            // 
            // panelPegawai
            // 
            this.panelPegawai.Controls.Add(this.panelRekapPenjualan);
            this.panelPegawai.Controls.Add(this.buttonRekapPenjualan);
            this.panelPegawai.Controls.Add(this.panelPengaturan);
            this.panelPegawai.Controls.Add(this.buttonPengaturan);
            this.panelPegawai.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPegawai.Location = new System.Drawing.Point(0, 692);
            this.panelPegawai.Name = "panelPegawai";
            this.panelPegawai.Size = new System.Drawing.Size(233, 560);
            this.panelPegawai.TabIndex = 3;
            this.panelPegawai.Visible = false;
            // 
            // panelRekapPenjualan
            // 
            this.panelRekapPenjualan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(107)))));
            this.panelRekapPenjualan.Controls.Add(this.btnRekapOmaSaldo);
            this.panelRekapPenjualan.Controls.Add(this.btnRekapBarang);
            this.panelRekapPenjualan.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRekapPenjualan.Location = new System.Drawing.Point(0, 380);
            this.panelRekapPenjualan.Name = "panelRekapPenjualan";
            this.panelRekapPenjualan.Size = new System.Drawing.Size(233, 111);
            this.panelRekapPenjualan.TabIndex = 15;
            // 
            // btnRekapOmaSaldo
            // 
            this.btnRekapOmaSaldo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRekapOmaSaldo.FlatAppearance.BorderSize = 0;
            this.btnRekapOmaSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRekapOmaSaldo.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRekapOmaSaldo.Location = new System.Drawing.Point(0, 45);
            this.btnRekapOmaSaldo.Name = "btnRekapOmaSaldo";
            this.btnRekapOmaSaldo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRekapOmaSaldo.Size = new System.Drawing.Size(233, 45);
            this.btnRekapOmaSaldo.TabIndex = 11;
            this.btnRekapOmaSaldo.Text = "OMA SALDO";
            this.btnRekapOmaSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRekapOmaSaldo.UseVisualStyleBackColor = true;
            this.btnRekapOmaSaldo.Click += new System.EventHandler(this.btnRekapOmaSaldo_Click);
            // 
            // btnRekapBarang
            // 
            this.btnRekapBarang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRekapBarang.FlatAppearance.BorderSize = 0;
            this.btnRekapBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRekapBarang.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRekapBarang.Location = new System.Drawing.Point(0, 0);
            this.btnRekapBarang.Name = "btnRekapBarang";
            this.btnRekapBarang.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnRekapBarang.Size = new System.Drawing.Size(233, 45);
            this.btnRekapBarang.TabIndex = 10;
            this.btnRekapBarang.Text = "BARANG";
            this.btnRekapBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRekapBarang.UseVisualStyleBackColor = true;
            this.btnRekapBarang.Click += new System.EventHandler(this.btnRekapBarang_Click);
            // 
            // buttonRekapPenjualan
            // 
            this.buttonRekapPenjualan.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRekapPenjualan.FlatAppearance.BorderSize = 0;
            this.buttonRekapPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRekapPenjualan.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRekapPenjualan.Location = new System.Drawing.Point(0, 335);
            this.buttonRekapPenjualan.Name = "buttonRekapPenjualan";
            this.buttonRekapPenjualan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonRekapPenjualan.Size = new System.Drawing.Size(233, 45);
            this.buttonRekapPenjualan.TabIndex = 1;
            this.buttonRekapPenjualan.Text = "REKAP PENJUALAN";
            this.buttonRekapPenjualan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRekapPenjualan.UseVisualStyleBackColor = true;
            this.buttonRekapPenjualan.Click += new System.EventHandler(this.buttonRekapPenjualan_Click);
            // 
            // panelPengaturan
            // 
            this.panelPengaturan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(107)))));
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
            // buttonPengaturanHadiah
            // 
            this.buttonPengaturanHadiah.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPengaturanHadiah.FlatAppearance.BorderSize = 0;
            this.buttonPengaturanHadiah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPengaturanHadiah.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPengaturanHadiah.Location = new System.Drawing.Point(0, 225);
            this.buttonPengaturanHadiah.Name = "buttonPengaturanHadiah";
            this.buttonPengaturanHadiah.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonPengaturanHadiah.Size = new System.Drawing.Size(233, 45);
            this.buttonPengaturanHadiah.TabIndex = 14;
            this.buttonPengaturanHadiah.Text = "HADIAH";
            this.buttonPengaturanHadiah.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPengaturanHadiah.UseVisualStyleBackColor = true;
            this.buttonPengaturanHadiah.Click += new System.EventHandler(this.buttonPengaturanHadiah_Click);
            // 
            // buttonPengaturanPromo
            // 
            this.buttonPengaturanPromo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPengaturanPromo.FlatAppearance.BorderSize = 0;
            this.buttonPengaturanPromo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPengaturanPromo.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPengaturanPromo.Location = new System.Drawing.Point(0, 180);
            this.buttonPengaturanPromo.Name = "buttonPengaturanPromo";
            this.buttonPengaturanPromo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonPengaturanPromo.Size = new System.Drawing.Size(233, 45);
            this.buttonPengaturanPromo.TabIndex = 15;
            this.buttonPengaturanPromo.Text = "PROMO";
            this.buttonPengaturanPromo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPengaturanPromo.UseVisualStyleBackColor = true;
            this.buttonPengaturanPromo.Click += new System.EventHandler(this.buttonPengaturanPromo_Click);
            // 
            // buttonPengaturanMetode
            // 
            this.buttonPengaturanMetode.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPengaturanMetode.FlatAppearance.BorderSize = 0;
            this.buttonPengaturanMetode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPengaturanMetode.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPengaturanMetode.Location = new System.Drawing.Point(0, 135);
            this.buttonPengaturanMetode.Name = "buttonPengaturanMetode";
            this.buttonPengaturanMetode.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonPengaturanMetode.Size = new System.Drawing.Size(233, 45);
            this.buttonPengaturanMetode.TabIndex = 16;
            this.buttonPengaturanMetode.Text = "METODE PEMBAYARAN";
            this.buttonPengaturanMetode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPengaturanMetode.UseVisualStyleBackColor = true;
            this.buttonPengaturanMetode.Click += new System.EventHandler(this.buttonPengaturanMetode_Click);
            // 
            // buttonPengaturanBarang
            // 
            this.buttonPengaturanBarang.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPengaturanBarang.FlatAppearance.BorderSize = 0;
            this.buttonPengaturanBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPengaturanBarang.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPengaturanBarang.Location = new System.Drawing.Point(0, 90);
            this.buttonPengaturanBarang.Name = "buttonPengaturanBarang";
            this.buttonPengaturanBarang.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonPengaturanBarang.Size = new System.Drawing.Size(233, 45);
            this.buttonPengaturanBarang.TabIndex = 17;
            this.buttonPengaturanBarang.Text = "BARANG";
            this.buttonPengaturanBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPengaturanBarang.UseVisualStyleBackColor = true;
            this.buttonPengaturanBarang.Click += new System.EventHandler(this.buttonPengaturanBarang_Click);
            // 
            // buttonPengaturanKategori
            // 
            this.buttonPengaturanKategori.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPengaturanKategori.FlatAppearance.BorderSize = 0;
            this.buttonPengaturanKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPengaturanKategori.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPengaturanKategori.ForeColor = System.Drawing.Color.White;
            this.buttonPengaturanKategori.Location = new System.Drawing.Point(0, 45);
            this.buttonPengaturanKategori.Name = "buttonPengaturanKategori";
            this.buttonPengaturanKategori.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonPengaturanKategori.Size = new System.Drawing.Size(233, 45);
            this.buttonPengaturanKategori.TabIndex = 12;
            this.buttonPengaturanKategori.Text = "KATEGORI";
            this.buttonPengaturanKategori.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPengaturanKategori.UseVisualStyleBackColor = true;
            this.buttonPengaturanKategori.Click += new System.EventHandler(this.buttonPengaturanKategori_Click);
            // 
            // buttonPengaturanCabang
            // 
            this.buttonPengaturanCabang.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPengaturanCabang.FlatAppearance.BorderSize = 0;
            this.buttonPengaturanCabang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPengaturanCabang.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPengaturanCabang.ForeColor = System.Drawing.Color.White;
            this.buttonPengaturanCabang.Location = new System.Drawing.Point(0, 0);
            this.buttonPengaturanCabang.Name = "buttonPengaturanCabang";
            this.buttonPengaturanCabang.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonPengaturanCabang.Size = new System.Drawing.Size(233, 45);
            this.buttonPengaturanCabang.TabIndex = 13;
            this.buttonPengaturanCabang.Text = "CABANG";
            this.buttonPengaturanCabang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPengaturanCabang.UseVisualStyleBackColor = true;
            this.buttonPengaturanCabang.Click += new System.EventHandler(this.buttonPengaturanCabang_Click);
            // 
            // buttonPengaturan
            // 
            this.buttonPengaturan.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPengaturan.FlatAppearance.BorderSize = 0;
            this.buttonPengaturan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPengaturan.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPengaturan.Location = new System.Drawing.Point(0, 0);
            this.buttonPengaturan.Name = "buttonPengaturan";
            this.buttonPengaturan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonPengaturan.Size = new System.Drawing.Size(233, 45);
            this.buttonPengaturan.TabIndex = 9;
            this.buttonPengaturan.Text = "PENGATURAN";
            this.buttonPengaturan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPengaturan.UseVisualStyleBackColor = true;
            this.buttonPengaturan.Click += new System.EventHandler(this.buttonPengaturan_Click);
            // 
            // panelRider
            // 
            this.panelRider.Controls.Add(this.buttonRekapPendapatan);
            this.panelRider.Controls.Add(this.buttonDaftarPengiriman);
            this.panelRider.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRider.Location = new System.Drawing.Point(0, 585);
            this.panelRider.Name = "panelRider";
            this.panelRider.Size = new System.Drawing.Size(233, 107);
            this.panelRider.TabIndex = 1;
            this.panelRider.Visible = false;
            // 
            // buttonRekapPendapatan
            // 
            this.buttonRekapPendapatan.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRekapPendapatan.FlatAppearance.BorderSize = 0;
            this.buttonRekapPendapatan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRekapPendapatan.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRekapPendapatan.Location = new System.Drawing.Point(0, 45);
            this.buttonRekapPendapatan.Name = "buttonRekapPendapatan";
            this.buttonRekapPendapatan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonRekapPendapatan.Size = new System.Drawing.Size(233, 45);
            this.buttonRekapPendapatan.TabIndex = 15;
            this.buttonRekapPendapatan.Text = "REKAP PENDAPATAN";
            this.buttonRekapPendapatan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRekapPendapatan.UseVisualStyleBackColor = true;
            this.buttonRekapPendapatan.Click += new System.EventHandler(this.buttonRekapPendapatan_Click);
            // 
            // buttonDaftarPengiriman
            // 
            this.buttonDaftarPengiriman.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDaftarPengiriman.FlatAppearance.BorderSize = 0;
            this.buttonDaftarPengiriman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDaftarPengiriman.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDaftarPengiriman.Location = new System.Drawing.Point(0, 0);
            this.buttonDaftarPengiriman.Name = "buttonDaftarPengiriman";
            this.buttonDaftarPengiriman.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonDaftarPengiriman.Size = new System.Drawing.Size(233, 45);
            this.buttonDaftarPengiriman.TabIndex = 16;
            this.buttonDaftarPengiriman.Text = "DAFTAR PENGIRIMAN";
            this.buttonDaftarPengiriman.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDaftarPengiriman.UseVisualStyleBackColor = true;
            this.buttonDaftarPengiriman.Click += new System.EventHandler(this.buttonDaftarPengiriman_Click);
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
            this.panelKonsumen.Location = new System.Drawing.Point(0, 184);
            this.panelKonsumen.Name = "panelKonsumen";
            this.panelKonsumen.Size = new System.Drawing.Size(233, 401);
            this.panelKonsumen.TabIndex = 2;
            this.panelKonsumen.Visible = false;
            // 
            // buttonIsiSaldo
            // 
            this.buttonIsiSaldo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonIsiSaldo.FlatAppearance.BorderSize = 0;
            this.buttonIsiSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIsiSaldo.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIsiSaldo.Location = new System.Drawing.Point(0, 315);
            this.buttonIsiSaldo.Name = "buttonIsiSaldo";
            this.buttonIsiSaldo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonIsiSaldo.Size = new System.Drawing.Size(233, 45);
            this.buttonIsiSaldo.TabIndex = 1;
            this.buttonIsiSaldo.Text = "ISI SALDO";
            this.buttonIsiSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIsiSaldo.UseVisualStyleBackColor = true;
            this.buttonIsiSaldo.Click += new System.EventHandler(this.buttonIsiSaldo_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProfile.FlatAppearance.BorderSize = 0;
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProfile.Location = new System.Drawing.Point(0, 270);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonProfile.Size = new System.Drawing.Size(233, 45);
            this.buttonProfile.TabIndex = 2;
            this.buttonProfile.Text = "PROFILE";
            this.buttonProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // buttonCetakNota
            // 
            this.buttonCetakNota.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCetakNota.FlatAppearance.BorderSize = 0;
            this.buttonCetakNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCetakNota.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCetakNota.Location = new System.Drawing.Point(0, 225);
            this.buttonCetakNota.Name = "buttonCetakNota";
            this.buttonCetakNota.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonCetakNota.Size = new System.Drawing.Size(233, 45);
            this.buttonCetakNota.TabIndex = 3;
            this.buttonCetakNota.Text = "CETAK NOTA";
            this.buttonCetakNota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCetakNota.UseVisualStyleBackColor = true;
            this.buttonCetakNota.Click += new System.EventHandler(this.buttonCetakNota_Click);
            // 
            // buttonCekPesanan
            // 
            this.buttonCekPesanan.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCekPesanan.FlatAppearance.BorderSize = 0;
            this.buttonCekPesanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCekPesanan.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCekPesanan.Location = new System.Drawing.Point(0, 180);
            this.buttonCekPesanan.Name = "buttonCekPesanan";
            this.buttonCekPesanan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonCekPesanan.Size = new System.Drawing.Size(233, 45);
            this.buttonCekPesanan.TabIndex = 4;
            this.buttonCekPesanan.Text = "CEK PESANAN";
            this.buttonCekPesanan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCekPesanan.UseVisualStyleBackColor = true;
            this.buttonCekPesanan.Click += new System.EventHandler(this.buttonCekPesanan_Click);
            // 
            // buttonHistoriTransaksi
            // 
            this.buttonHistoriTransaksi.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHistoriTransaksi.FlatAppearance.BorderSize = 0;
            this.buttonHistoriTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHistoriTransaksi.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHistoriTransaksi.Location = new System.Drawing.Point(0, 135);
            this.buttonHistoriTransaksi.Name = "buttonHistoriTransaksi";
            this.buttonHistoriTransaksi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonHistoriTransaksi.Size = new System.Drawing.Size(233, 45);
            this.buttonHistoriTransaksi.TabIndex = 5;
            this.buttonHistoriTransaksi.Text = "HISTORI TRANSAKSI";
            this.buttonHistoriTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHistoriTransaksi.UseVisualStyleBackColor = true;
            this.buttonHistoriTransaksi.Click += new System.EventHandler(this.buttonHistoriTransaksi_Click);
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCheckout.FlatAppearance.BorderSize = 0;
            this.buttonCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckout.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckout.Location = new System.Drawing.Point(0, 90);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonCheckout.Size = new System.Drawing.Size(233, 45);
            this.buttonCheckout.TabIndex = 6;
            this.buttonCheckout.Text = "CHECKOUT";
            this.buttonCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCheckout.UseVisualStyleBackColor = true;
            this.buttonCheckout.Click += new System.EventHandler(this.buttonCheckout_Click);
            // 
            // buttonKeranjang
            // 
            this.buttonKeranjang.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonKeranjang.FlatAppearance.BorderSize = 0;
            this.buttonKeranjang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKeranjang.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeranjang.Location = new System.Drawing.Point(0, 45);
            this.buttonKeranjang.Name = "buttonKeranjang";
            this.buttonKeranjang.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonKeranjang.Size = new System.Drawing.Size(233, 45);
            this.buttonKeranjang.TabIndex = 7;
            this.buttonKeranjang.Text = "KERANJANG";
            this.buttonKeranjang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKeranjang.UseVisualStyleBackColor = true;
            // 
            // buttonBarangDeals
            // 
            this.buttonBarangDeals.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBarangDeals.FlatAppearance.BorderSize = 0;
            this.buttonBarangDeals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBarangDeals.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBarangDeals.Location = new System.Drawing.Point(0, 0);
            this.buttonBarangDeals.Name = "buttonBarangDeals";
            this.buttonBarangDeals.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonBarangDeals.Size = new System.Drawing.Size(233, 45);
            this.buttonBarangDeals.TabIndex = 8;
            this.buttonBarangDeals.Text = "BARANG DAN DEALS";
            this.buttonBarangDeals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBarangDeals.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(0, 1252);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonLogout.Size = new System.Drawing.Size(233, 45);
            this.buttonLogout.TabIndex = 12;
            this.buttonLogout.Text = "LOGOUT";
            this.buttonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(233, 184);
            this.panelLogo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OnlineMart_Trivial.Properties.Resources.White_Logo1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelActiveForm
            // 
            this.panelActiveForm.Location = new System.Drawing.Point(250, 137);
            this.panelActiveForm.Name = "panelActiveForm";
            this.panelActiveForm.Size = new System.Drawing.Size(1614, 794);
            this.panelActiveForm.TabIndex = 1;
            this.panelActiveForm.Visible = false;
            // 
            // panelTitleActiveForm
            // 
            this.panelTitleActiveForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleActiveForm.Location = new System.Drawing.Point(250, 0);
            this.panelTitleActiveForm.Name = "panelTitleActiveForm";
            this.panelTitleActiveForm.Size = new System.Drawing.Size(1614, 53);
            this.panelTitleActiveForm.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(285, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 3;
            // 
            // FormUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OnlineMart_Trivial.Properties.Resources.Background_Login_Register;
            this.ClientSize = new System.Drawing.Size(1864, 931);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitleActiveForm);
            this.Controls.Add(this.panelActiveForm);
            this.Controls.Add(this.panelLeftNavbar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1880, 970);
            this.Name = "FormUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Online Mart";
            this.Load += new System.EventHandler(this.FormUtama_Load);
            this.panelLeftNavbar.ResumeLayout(false);
            this.panelPegawai.ResumeLayout(false);
            this.panelRekapPenjualan.ResumeLayout(false);
            this.panelPengaturan.ResumeLayout(false);
            this.panelRider.ResumeLayout(false);
            this.panelKonsumen.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerLoading;
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
        private System.Windows.Forms.Button buttonPengaturanPromo;
        private System.Windows.Forms.Button buttonPengaturanHadiah;
        private System.Windows.Forms.Button buttonPengaturanBarang;
        private System.Windows.Forms.Button buttonPengaturanMetode;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel panelLeftNavbar;
        public System.Windows.Forms.Panel panelPegawai;
        public System.Windows.Forms.Panel panelRider;
        public System.Windows.Forms.Panel panelKonsumen;
        public System.Windows.Forms.Panel panelLogo;
        public System.Windows.Forms.Button buttonLogout;
        public System.Windows.Forms.Panel panelActiveForm;
        private System.Windows.Forms.Panel panelTitleActiveForm;
        private System.Windows.Forms.Panel panel1;
    }
}

