using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
//Agar objek filestream aman
using System.IO;

//Agar objek bertipe font dapat digunakan
using System.Drawing;

//Agar dapat menggunakan print avrgs
using System.Drawing.Printing;

namespace OnlineMart_LIB
{
    public class Order
    {
		#region Field
		private long id;
        private DateTime tanggal_waktu;
        private string alamat_tujuan;
        private float ongkos_kirim;
        private float total_bayar;
        private string cara_bayar;
        string status;
        Cabang cabang; //Aggregation
        Pelanggan pelanggan; //Aggregation
        Driver driver; //Aggregation
        Metode_pembayaran metode_pembayaran; //Aggregation
        Promo promo; //Aggregation
        Gift_Redeem gift_redeem; //Aggregation
        List<Barang_Order> listBarangOrder; // Composition
        Penjual penjual;
        #endregion

        #region Constructors
        public Order()
        {
            Id = 0;
            Tanggal_waktu = DateTime.Now;
            Alamat_tujuan = "";
            Ongkos_kirim = 10000;
            Total_bayar = 0;
            Cara_bayar = "Transfer";
            Status = "Menunggu Pembayaran";
            ListBarangOrder = new List<Barang_Order>();
        }
        public Order(DateTime tanggal_waktu)
        {
            Tanggal_waktu = tanggal_waktu;
        }

        //// Untuk Order keseluruhan
        //public Order(long id, DateTime tanggal_waktu, string alamat_tujuan, float ongkos_kirim, float total_bayar, string cara_bayar, string status, Cabang cabang, Pelanggan pelanggan, Driver driver, Metode_pembayaran metode_pembayaran, Promo promo, Gift_Redeem gift_redeem, Penjual penjual)
        //{
        //    Id = id;
        //    Tanggal_waktu = tanggal_waktu;
        //    Alamat_tujuan = alamat_tujuan;
        //    Ongkos_kirim = ongkos_kirim;
        //    Total_bayar = total_bayar;
        //    Cara_bayar = cara_bayar;
        //    Status = status;
        //    Cabang = cabang;
        //    Pelanggan = pelanggan;
        //    Driver = driver;
        //    Metode_pembayaran = metode_pembayaran;
        //    Promo = promo;
        //    Gift_redeem = gift_redeem;
        //    Penjual = penjual;
        //    ListBarangOrder = new List<Barang_Order>();
        //}
        //public Order(DateTime tanggal_waktu, string alamat_tujuan, float ongkos_kirim, float total_bayar, string cara_bayar, string status, Cabang cabang, Pelanggan pelanggan, Driver driver, Metode_pembayaran metode_pembayaran, Promo promo, Gift_Redeem gift_redeem, Penjual penjual)
        //{
        //    Tanggal_waktu = tanggal_waktu;
        //    Alamat_tujuan = alamat_tujuan;
        //    Ongkos_kirim = ongkos_kirim;
        //    Total_bayar = total_bayar;
        //    Cara_bayar = cara_bayar;
        //    Status = status;
        //    Cabang = cabang;
        //    Pelanggan = pelanggan;
        //    Driver = driver;
        //    Metode_pembayaran = metode_pembayaran;
        //    Promo = promo;
        //    Gift_redeem = gift_redeem;
        //    Penjual = penjual;
        //    ListBarangOrder = new List<Barang_Order>();
        //}

        // Untuk Order ke penjual
        public Order(long id, DateTime tanggal_waktu, string alamat_tujuan, float ongkos_kirim, float total_bayar, string cara_bayar, string status, Pelanggan pelanggan, Driver driver, Metode_pembayaran metode_pembayaran, Promo promo, Gift_Redeem gift_redeem, Penjual penjual)
        {
            Id = id;
            Tanggal_waktu = tanggal_waktu;
            Alamat_tujuan = alamat_tujuan;
            Ongkos_kirim = ongkos_kirim;
            Total_bayar = total_bayar;
            Cara_bayar = cara_bayar;
            Status = status;
            Pelanggan = pelanggan;
            Driver = driver;
            Metode_pembayaran = metode_pembayaran;
            Promo = promo;
            Gift_redeem = gift_redeem;
            Penjual = penjual;
            ListBarangOrder = new List<Barang_Order>();
        }
        public Order(DateTime tanggal_waktu, string alamat_tujuan, float ongkos_kirim, float total_bayar, string cara_bayar, string status, Pelanggan pelanggan, Driver driver, Metode_pembayaran metode_pembayaran, Promo promo, Gift_Redeem gift_redeem)
        {
            Tanggal_waktu = tanggal_waktu;
            Alamat_tujuan = alamat_tujuan;
            Ongkos_kirim = ongkos_kirim;
            Total_bayar = total_bayar;
            Cara_bayar = cara_bayar;
            Status = status;
            Pelanggan = pelanggan;
            Driver = driver;
            Metode_pembayaran = metode_pembayaran;
            Promo = promo;
            Gift_redeem = gift_redeem;
            Penjual = penjual;
            ListBarangOrder = new List<Barang_Order>();
        }

        // Untuk Order ke cabang
        public Order(long id, DateTime tanggal_waktu, string alamat_tujuan, float ongkos_kirim, float total_bayar, string cara_bayar, string status, Cabang cabang, Pelanggan pelanggan, Driver driver, Metode_pembayaran metode_pembayaran, Promo promo, Gift_Redeem gift_redeem)
        {
            Id = id;
            Tanggal_waktu = tanggal_waktu;
            Alamat_tujuan = alamat_tujuan;
            Ongkos_kirim = ongkos_kirim;
            Total_bayar = total_bayar;
            Cara_bayar = cara_bayar;
            Status = status;
            Cabang = cabang;
            Pelanggan = pelanggan;
            Driver = driver;
            Metode_pembayaran = metode_pembayaran;
            Promo = promo;
            Gift_redeem = gift_redeem;
            ListBarangOrder = new List<Barang_Order>();
        }
        public Order(DateTime tanggal_waktu, string alamat_tujuan, float ongkos_kirim, float total_bayar, string cara_bayar, string status, Cabang cabang, Pelanggan pelanggan, Driver driver, Metode_pembayaran metode_pembayaran, Promo promo, Gift_Redeem gift_redeem)
        {
            Tanggal_waktu = tanggal_waktu;
            Alamat_tujuan = alamat_tujuan;
            Ongkos_kirim = ongkos_kirim;
            Total_bayar = total_bayar;
            Cara_bayar = cara_bayar;
            Status = status;
            Cabang = cabang;
            Pelanggan = pelanggan;
            Driver = driver;
            Metode_pembayaran = metode_pembayaran;
            Promo = promo;
            Gift_redeem = gift_redeem;
            ListBarangOrder = new List<Barang_Order>();
        }

        public Order(long id, DateTime tanggal_waktu, string alamat_tujuan, float ongkos_kirim, float total_bayar, string cara_bayar, string status)
        {
            Id = id;
            Tanggal_waktu = tanggal_waktu;
            Alamat_tujuan = alamat_tujuan;
            Ongkos_kirim = ongkos_kirim;
            Total_bayar = total_bayar;
            Cara_bayar = cara_bayar;
            Status = status;
            ListBarangOrder = new List<Barang_Order>();
        }

        public Order(long id, Pelanggan pelanggan, Driver driver)
        {
            Id = id;
            Pelanggan = pelanggan;
            Driver = driver;
        }
        public Order(long id, Pelanggan pelanggan, Penjual penjual)
        {
            Id = id;
            Pelanggan = pelanggan;
            Penjual = penjual;
        }
        #endregion

        #region Properties
        public long Id 
        { 
            get => id; 
            set => id = value; 
        }
        public DateTime Tanggal_waktu 
        { 
            get => tanggal_waktu; 
            set => tanggal_waktu = value; 
        }
        public string Alamat_tujuan 
        { 
            get => alamat_tujuan; 
            set => alamat_tujuan = value; 
        }
        public float Ongkos_kirim 
        { 
            get => ongkos_kirim; 
            set => ongkos_kirim = value; 
        }
        public float Total_bayar 
        { 
            get => total_bayar; 
            set => total_bayar = value; 
        }
        public string Cara_bayar 
        { 
            get => cara_bayar; 
            set => cara_bayar = value; 
        }
        public string Status 
        { 
            get => status; 
            set => status = value; 
        }
        public Cabang Cabang 
        { 
            get => cabang; 
            set => cabang = value; 
        }
        public Pelanggan Pelanggan 
        { 
            get => pelanggan; 
            set => pelanggan = value; 
        }
        public Driver Driver 
        { 
            get => driver; 
            set => driver = value; 
        }
        public Penjual Penjual 
        { 
            get => penjual; 
            set => penjual = value; 
        }
        public Metode_pembayaran Metode_pembayaran 
        { 
            get => metode_pembayaran; 
            set => metode_pembayaran = value; 
        }
        public Promo Promo 
        { 
            get => promo; 
            set => promo = value; 
        }
        public Gift_Redeem Gift_redeem 
        { 
            get => gift_redeem; 
            set => gift_redeem = value; 
        }
        public List<Barang_Order> ListBarangOrder
        { 
            get => listBarangOrder; 
            private set => listBarangOrder = value; 
        }
		#endregion

		#region Method
		public static Boolean TambahDataOrderCabang(Order o, Koneksi kParram)
		{
			string sql = "insert into orders (id, tanggal_waktu, alamat_tujuan, ongkos_kirim, total_bayar, cara_bayar, status, " +
                         "cabang_id, pelanggan_id, driver_id, metode_pembayaran_id, promo_id, gift_redeem_id) " +
				         "values (" + o.Id + ", '" + o.Tanggal_waktu.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + o.Alamat_tujuan + "', " + 
                         o.Ongkos_kirim + ", " + o.Total_bayar + ", '" + o.Cara_bayar + "','" + o.Status + "', " + o.Cabang.Id + ", " + 
                         o.Pelanggan.Id + ", " + o.Driver.Id + ", " + o.Metode_pembayaran.Id + ", " + + o.Promo.Id + ", " + 
                         o.Gift_redeem.Id + ")";

            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql, kParram);
            if (jumlahDitambah == 0) return false;
            else return true;
        }

        public static Boolean TambahDataOrderPenjual(Order o, Koneksi kParram)
        {
            string sql = "insert into orders (id, tanggal_waktu, alamat_tujuan, ongkos_kirim, total_bayar, cara_bayar, status, " +
                         "penjual_id, pelanggan_id, driver_id, metode_pembayaran_id, promo_id, gift_redeem_id) " +
                         "values (" + o.Id + ", '" + o.Tanggal_waktu.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + o.Alamat_tujuan + "', " +
                         o.Ongkos_kirim + ", " + o.Total_bayar + ", '" + o.Cara_bayar + "','" + o.Status + "', " + o.Penjual.Id + ", " +
                         o.Pelanggan.Id + ", " + o.Driver.Id + ", " + o.Metode_pembayaran.Id + ", " + +o.Promo.Id + ", " +
                         o.Gift_redeem.Id + ")";

            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql, kParram);
            if (jumlahDitambah == 0) return false;
            else return true;
        }

        public static List<Order> BacaData(string kriteria, string nilaiKriteria, Koneksi kParram)
        {
            string sql = "select * from orders o " +
                         "inner join cabangs c on o.cabang_id = c.id " +
                         "inner join pegawais peg on c.pegawai_id = peg.id " +
                         "inner join pelanggans pel on o.pelanggan_id = pel.id " +
                         "inner join drivers d on o.driver_id = d.id " +
                         "inner join metode_pembayarans mp on o.metode_pembayaran_id = mp.id " +
                         "inner join promos pr on o.promo_id = pr.id " +
                         "inner join gift_redeems gr on o.gift_redeem_id = gr.id " +
                         "inner join gifts g on gr.gift_id = g.id " + 
                         "inner join penjuals pen on o.penjual_id = pen.id ";

            if (kriteria != "") sql += " where " + kriteria + " like '%" + nilaiKriteria + "%' ";

            sql += " order by o.tanggal_waktu ";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql, kParram);

            List<Order> listOrder = new List<Order>();

            while (hasil.Read())
            {
                Gift g = new Gift(hasil.GetInt32(50), hasil.GetString(51), hasil.GetInt32(52));

                Gift_Redeem gr = new Gift_Redeem(hasil.GetInt32(46), hasil.GetDateTime(47), hasil.GetInt32(48), g);

                Promo pr = new Promo(hasil.GetInt32(40), hasil.GetString(41), hasil.GetString(42), hasil.GetInt32(43), hasil.GetInt32(44), hasil.GetFloat(45));

                Metode_pembayaran mp = new Metode_pembayaran(hasil.GetInt32(38), hasil.GetString(39));

                Driver d = new Driver(hasil.GetInt32(32), hasil.GetString(34), hasil.GetString(33), hasil.GetString(35), hasil.GetString(36), hasil.GetString(37));

                Pelanggan pel = new Pelanggan(hasil.GetInt32(24), hasil.GetString(26), hasil.GetString(25), hasil.GetString(27), hasil.GetString(28), hasil.GetString(29), hasil.GetDouble(30), hasil.GetDouble(31));

                Pegawai peg = new Pegawai(hasil.GetInt32(18), hasil.GetString(20), hasil.GetString(19), hasil.GetString(21), hasil.GetString(22), hasil.GetString(23));

                Order o = null;
                int cabang_id = hasil.GetInt32(14);

                if (cabang_id == 0)
                {
                    Penjual pen = new Penjual(hasil.GetInt32(53), hasil.GetString(54), hasil.GetString(55), hasil.GetString(56), hasil.GetString(57), hasil.GetString(58), hasil.GetString(59));
                    o = new Order(long.Parse(hasil.GetString(0)), hasil.GetDateTime(1), hasil.GetString(2), hasil.GetFloat(3), hasil.GetFloat(4), hasil.GetString(5), hasil.GetString(6), pel, d, mp, pr, gr, pen);
                }
                else
                {
                    Cabang c = new Cabang(cabang_id, hasil.GetString(15), hasil.GetString(16), peg);
                    o = new Order(long.Parse(hasil.GetString(0)), hasil.GetDateTime(1), hasil.GetString(2), hasil.GetFloat(3), hasil.GetFloat(4), hasil.GetString(5), hasil.GetString(6), c, pel, d, mp, pr, gr);
                }

                listOrder.Add(o);
            }

            hasil.Dispose();
            hasil.Close();

            return listOrder;
        }

        public static List<Order> BacaData(string status, string kriteria, string nilaiKriteria, Koneksi kParram)
        {
            string sql = "select * from orders o " +
                         "inner join cabangs c on o.cabang_id = c.id " +
                         "inner join pegawais peg on c.pegawai_id = peg.id " +
                         "inner join pelanggans pel on o.pelanggan_id = pel.id " +
                         "inner join drivers d on o.driver_id = d.id " +
                         "inner join metode_pembayarans mp on o.metode_pembayaran_id = mp.id " +
                         "inner join promos pr on o.promo_id = pr.id " +
                         "inner join gift_redeems gr on o.gift_redeem_id = gr.id " +
                         "inner join gifts g on gr.gift_id = g.id " +
                         "inner join penjuals pen on o.penjual_id = pen.id " + 
                         "where o.status = '" + status + "' and " + kriteria + " like '%" + nilaiKriteria + "%' " +
                         "order by o.tanggal_waktu asc";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql, kParram);

            List<Order> listOrder = new List<Order>();

            while (hasil.Read())
            {
                Gift g = new Gift(hasil.GetInt32(50), hasil.GetString(51), hasil.GetInt32(52));

                Gift_Redeem gr = new Gift_Redeem(hasil.GetInt32(46), hasil.GetDateTime(47), hasil.GetInt32(48), g);

                Promo pr = new Promo(hasil.GetInt32(40), hasil.GetString(41), hasil.GetString(42), hasil.GetInt32(43), hasil.GetInt32(44), hasil.GetFloat(45));

                Metode_pembayaran mp = new Metode_pembayaran(hasil.GetInt32(38), hasil.GetString(39));

                Driver d = new Driver(hasil.GetInt32(32), hasil.GetString(34), hasil.GetString(33), hasil.GetString(35), hasil.GetString(36), hasil.GetString(37));

                Pelanggan pel = new Pelanggan(hasil.GetInt32(24), hasil.GetString(26), hasil.GetString(25), hasil.GetString(27), hasil.GetString(28), hasil.GetString(29), hasil.GetDouble(30), hasil.GetDouble(31));

                Pegawai peg = new Pegawai(hasil.GetInt32(18), hasil.GetString(20), hasil.GetString(19), hasil.GetString(21), hasil.GetString(22), hasil.GetString(23));

                Order o = null;
                int cabang_id = hasil.GetInt32(14);

                if (cabang_id == 0)
                {
                    Penjual pen = new Penjual(hasil.GetInt32(53), hasil.GetString(54), hasil.GetString(55), hasil.GetString(56), hasil.GetString(57), hasil.GetString(58), hasil.GetString(59));
                    o = new Order(long.Parse(hasil.GetString(0)), hasil.GetDateTime(1), hasil.GetString(2), hasil.GetFloat(3), hasil.GetFloat(4), hasil.GetString(5), hasil.GetString(6), pel, d, mp, pr, gr, pen);
                }
                else
                {
                    Cabang c = new Cabang(cabang_id, hasil.GetString(15), hasil.GetString(16), peg);
                    o = new Order(long.Parse(hasil.GetString(0)), hasil.GetDateTime(1), hasil.GetString(2), hasil.GetFloat(3), hasil.GetFloat(4), hasil.GetString(5), hasil.GetString(6), c, pel, d, mp, pr, gr);
                }

                listOrder.Add(o);
            }

            hasil.Dispose();
            hasil.Close();

            return listOrder;
        }

        public static List<Order> BacaOrderDiproses(string kriteria, string nilaiKriteria, Koneksi kParram)
        {
            string sql = "select * from orders o " +
                         "inner join cabangs c on o.cabang_id = c.id " +
                         "inner join pegawais peg on c.pegawai_id = peg.id " +
                         "inner join pelanggans pel on o.pelanggan_id = pel.id " +
                         "inner join drivers d on o.driver_id = d.id " +
                         "inner join metode_pembayarans mp on o.metode_pembayaran_id = mp.id " +
                         "inner join promos pr on o.promo_id = pr.id " +
                         "inner join gift_redeems gr on o.gift_redeem_id = gr.id " +
                         "inner join gifts g on gr.gift_id = g.id " +
                         "inner join penjuals pen on o.penjual_id = pen.id " +
                         "where o.status = 'Pesanan Diproses' ";

            if (kriteria != "") sql += " and " + kriteria + " = " + nilaiKriteria + " ";

            sql += " order by o.tanggal_waktu ";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql, kParram);

            List<Order> listOrder = new List<Order>();

            while (hasil.Read())
            {
                Gift g = new Gift(hasil.GetInt32(50), hasil.GetString(51), hasil.GetInt32(52));

                Gift_Redeem gr = new Gift_Redeem(hasil.GetInt32(46), hasil.GetDateTime(47), hasil.GetInt32(48), g);

                Promo pr = new Promo(hasil.GetInt32(40), hasil.GetString(41), hasil.GetString(42), hasil.GetInt32(43), hasil.GetInt32(44), hasil.GetFloat(45));

                Metode_pembayaran mp = new Metode_pembayaran(hasil.GetInt32(38), hasil.GetString(39));

                Driver d = new Driver(hasil.GetInt32(32), hasil.GetString(34), hasil.GetString(33), hasil.GetString(35), hasil.GetString(36), hasil.GetString(37));

                Pelanggan pel = new Pelanggan(hasil.GetInt32(24), hasil.GetString(26), hasil.GetString(25), hasil.GetString(27), hasil.GetString(28), hasil.GetString(29), hasil.GetDouble(30), hasil.GetDouble(31));

                Pegawai peg = new Pegawai(hasil.GetInt32(18), hasil.GetString(20), hasil.GetString(19), hasil.GetString(21), hasil.GetString(22), hasil.GetString(23));

                Order o = null;
                int cabang_id = hasil.GetInt32(14);

                if (cabang_id == 0)
                {
                    Penjual pen = new Penjual(hasil.GetInt32(53), hasil.GetString(54), hasil.GetString(55), hasil.GetString(56), hasil.GetString(57), hasil.GetString(58), hasil.GetString(59));
                    o = new Order(long.Parse(hasil.GetString(0)), hasil.GetDateTime(1), hasil.GetString(2), hasil.GetFloat(3), hasil.GetFloat(4), hasil.GetString(5), hasil.GetString(6), pel, d, mp, pr, gr, pen);
                }
                else
                {
                    Cabang c = new Cabang(cabang_id, hasil.GetString(15), hasil.GetString(16), peg);
                    o = new Order(long.Parse(hasil.GetString(0)), hasil.GetDateTime(1), hasil.GetString(2), hasil.GetFloat(3), hasil.GetFloat(4), hasil.GetString(5), hasil.GetString(6), c, pel, d, mp, pr, gr);
                }

                listOrder.Add(o);
            }

            hasil.Dispose();
            hasil.Close();

            return listOrder;
        }

        public static Boolean UbahData(Order o, Koneksi kParram)
        {
            // Querry Insert
            string sql = "update orders set tanggal_waktu = '" + o.Tanggal_waktu.ToString("yyyy-MM-dd HH:mm:ss") + "', alamat_tujuan = '" + o.Alamat_tujuan + "', " +
                         "ongkos_kirim = '" + o.Ongkos_kirim + "', total_bayar = '" + o.Total_bayar + "', cara_bayar = '" + o.Cara_bayar + "', " +
                         "status = '" + o.Status + "', driver_id = '" + o.Driver.Id + "', cabang_id = '" + o.Cabang.Id + "', " +
                         "metode_pembayaran_id = '" + o.Metode_pembayaran.Id + "', promo_id = '" + o.Promo.Id + "', " +
                         "gift_redeem_id = '" + o.Gift_redeem.Id + "', pelanggan_id = '" + o.Pelanggan.Id + "' " +
                         "where id = '" + o.Id + "'";

            int jumlahDiubah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDiubah == 0) return false;
            else return true;
        }

        public static bool UpdateStok(Barang_Order bo, Cabang bc, Koneksi kParram)
		{
            string sql = "update barang_cabang set stok = stok - " + bo.Jumlah + " where barang_id = " + bo.Barang.Id + " and cabang_id = " + bc.Id;
            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql, kParram);
            if (jumlahDitambah == 0) return false;
            else return true;
        }

        // membuat id order dengan format yyyyMMddxxxx (yyyy-MM-dd-xxxx)
        // yyyy = tahun ini, MM = bulan ini, dd = hari ini, xxxx = transaksi ke x hari ini
        public static string GenerateIdOrder(Koneksi kParram)
        {
            // ambil no urut transaksi hari ini (tanggal sistem)
            string sql = "select right(id, 4) as NoUrutTransaksi " +
                         "from orders " +
                         "where Date(tanggal_waktu) = Date(CURRENT_DATE) " +
                         "order by tanggal_waktu DESC limit 1";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql, kParram);

            string hasilNoNota = "";
            if (hasil.Read()) // jika ditemukan nota jual di tanggal hari ini
            {
                if (hasil.GetString(0) != "")
                {
                    int noUrutTrans = int.Parse(hasil.GetString(0)) + 1;
                    //gunakan PadLeftuntuk menambahkan 0 di depan
                    hasilNoNota = DateTime.Now.Year +
                                  DateTime.Now.Month.ToString().PadLeft(2, '0') +
                                  DateTime.Now.Day.ToString().PadLeft(2, '0') +
                                  noUrutTrans.ToString().PadLeft(4, '0');
                }
            }
            else
            {
                hasilNoNota = DateTime.Now.Year +
                              DateTime.Now.Month.ToString().PadLeft(2, '0') +
                              DateTime.Now.Day.ToString().PadLeft(2, '0') +
                              "0001";
            }

            hasil.Dispose();
            hasil.Close();

            return hasilNoNota;
        }

        //public static Order AmbilData(long id, Koneksi kParram)
        //{
        //    string sql = "select id, tanggal_waktu, alamat_tujuan, ongkos_kirim, total_bayar, cara_bayar, " +
        //                 "status, cabang_id, pelanggan_id, driver_id, metode_pembayaran_id, promo_id, gift_redeem_id" +
        //                 " from orders where id = " + id;

        //    MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql, kParram);

        //    Order o = null;

        //    while (hasil.Read())
        //    {
        //        Cabang c = Cabang.AmbilData(hasil.GetInt32(7), kParram);

        //        Pelanggan p = Pelanggan.AmbilData(hasil.GetInt32(8), kParram);

        //        Driver d = Driver.AmbilData(hasil.GetInt32(9), kParram);

        //        Metode_pembayaran mp = Metode_pembayaran.AmbilData(hasil.GetInt32(10), kParram);

        //        Promo pr = Promo.AmbilData(hasil.GetInt32(11), kParram);

        //        Gift_Redeem gr = Gift_Redeem.AmbilData(hasil.GetInt32(12), kParram);

        //        o = new Order(long.Parse(hasil.GetString(0)), DateTime.Parse(hasil.GetString(1)), hasil.GetString(2), hasil.GetFloat(3), hasil.GetFloat(4), hasil.GetString(5), hasil.GetString(6), c, p, d, mp, pr, gr);
        //    }

        //    hasil.Close();
        //    hasil.Dispose();

        //    return o;
        //}

        public static Order AmbilData(long id)
        {
            string sql = "select * from orders o " +
                         "inner join cabangs c on o.cabang_id = c.id " +
                         "inner join pegawais peg on c.pegawai_id = peg.id " +
                         "inner join pelanggans pel on o.pelanggan_id = pel.id " +
                         "inner join drivers d on o.driver_id = d.id " +
                         "inner join metode_pembayarans mp on o.metode_pembayaran_id = mp.id " +
                         "inner join promos pr on o.promo_id = pr.id " +
                         "inner join gift_redeems gr on o.gift_redeem_id = gr.id " +
                         "inner join gifts g on gr.gift_id = g.id " +
                         "inner join penjuals pen on o.penjual_id = pen.id " +
                         "where o.id = " + id;

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            Order o = null;

            while (hasil.Read())
            {
                Gift g = new Gift(hasil.GetInt32(50), hasil.GetString(51), hasil.GetInt32(52));

                Gift_Redeem gr = new Gift_Redeem(hasil.GetInt32(46), hasil.GetDateTime(47), hasil.GetInt32(48), g);

                Promo pr = new Promo(hasil.GetInt32(40), hasil.GetString(41), hasil.GetString(42), hasil.GetInt32(43), hasil.GetInt32(44), hasil.GetFloat(45));

                Metode_pembayaran mp = new Metode_pembayaran(hasil.GetInt32(38), hasil.GetString(39));

                Driver d = new Driver(hasil.GetInt32(32), hasil.GetString(34), hasil.GetString(33), hasil.GetString(35), hasil.GetString(36), hasil.GetString(37));

                Pelanggan pel = new Pelanggan(hasil.GetInt32(24), hasil.GetString(26), hasil.GetString(25), hasil.GetString(27), hasil.GetString(28), hasil.GetString(29), hasil.GetDouble(30), hasil.GetDouble(31));

                Pegawai peg = new Pegawai(hasil.GetInt32(18), hasil.GetString(20), hasil.GetString(19), hasil.GetString(21), hasil.GetString(22), hasil.GetString(23));

                int cabang_id = hasil.GetInt32(14);

                if (cabang_id == 0)
                {
                    Penjual pen = new Penjual(hasil.GetInt32(53), hasil.GetString(54), hasil.GetString(55), hasil.GetString(56), hasil.GetString(57), hasil.GetString(58), hasil.GetString(59));
                    o = new Order(long.Parse(hasil.GetString(0)), hasil.GetDateTime(1), hasil.GetString(2), hasil.GetFloat(3), hasil.GetFloat(4), hasil.GetString(5), hasil.GetString(6), pel, d, mp, pr, gr, pen);
                }
                else
                {
                    Cabang c = new Cabang(cabang_id, hasil.GetString(15), hasil.GetString(16), peg);
                    o = new Order(long.Parse(hasil.GetString(0)), hasil.GetDateTime(1), hasil.GetString(2), hasil.GetFloat(3), hasil.GetFloat(4), hasil.GetString(5), hasil.GetString(6), c, pel, d, mp, pr, gr);
                }

            }

            return o;
        }

        public static List<Order> BacaTanggal(Driver driver, string bulan, string tahun, Koneksi kParram)
        {
            string sql = "select * from orders " +
                         "where driver_id = " + driver.Id;

            // kalau bulan dan tahun ada isinya
            if (bulan != "" && tahun != "") sql += " AND MONTH(tanggal_waktu) = '" + bulan + "' AND YEAR(tanggal_waktu) = '" + tahun + "'";
            // kalau bulan ada isinya
            else if (bulan != "") sql += " AND MONTH(tanggal_waktu) = '" + bulan + "'";
            // kalau tahun ada isinya
            else if (tahun != "") sql += " AND YEAR(tanggal_waktu) = '" + tahun + "'";
            
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql, kParram);

            List<Order> listOrder = new List<Order>();

            // masukkan data yang ingin ditampilkan/dibaca ke class
            while (hasil.Read())
            {
                Order o = new Order(long.Parse(hasil.GetString(0)), hasil.GetDateTime(1), hasil.GetString(2), hasil.GetFloat(3), hasil.GetFloat(4), hasil.GetString(5), hasil.GetString(6));

                listOrder.Add(o);
            }

            hasil.Dispose();
            hasil.Close();

            return listOrder;
        }

        public static List<Int32> AmbilTahun(Koneksi kParram)
        {
            string sql = "select distinct YEAR(tanggal_waktu) from orders";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql, kParram);

            List<Int32> listTahun = new List<Int32>();

            while (hasil.Read())
            {
                listTahun.Add(hasil.GetInt32(0));
            }

            hasil.Dispose();
            hasil.Close();

            return listTahun;
        }

        public static List<string> AmbilStatus(Koneksi kParram)
        {
            string sql = "select distinct(status) from orders";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql, kParram);

            List<string> listStatus = new List<string>();

            while (hasil.Read())
            {
                listStatus.Add(hasil.GetString(0));
            }

            hasil.Dispose();
            hasil.Close();

            return listStatus;
        }

        //Cetak semua order
        public static void CetakDaftarOrder(string kriteria, string nilai, string namaFile, Koneksi kParram)
        {
            List<Order> listData = Order.BacaData(kriteria, nilai, kParram);
            StreamWriter file = new StreamWriter(namaFile);
            char pemisah = '-';
            file.WriteLine(""); //Cetak 1 baris kosong
            file.WriteLine("Online Mart - Trivial");
            foreach (Order o in listData)
            {
                file.WriteLine("No nota = " + o.Id);
                file.WriteLine("Tanggal = " + o.Tanggal_waktu);
                file.WriteLine("Pembeli = " + o.Pelanggan.Nama + "-" + o.Pelanggan.Id);
                file.WriteLine("Alamat = " + o.Alamat_tujuan);
                file.WriteLine("Driver = " + o.Driver.Nama);
                file.WriteLine("Metode Pembayaran = " + o.Cara_bayar);
                file.WriteLine("Promo = " + o.Promo.Nama);
                file.WriteLine("Ongkos Kirim = " + o.Ongkos_kirim);
                file.WriteLine("Total Bayar = " + o.Total_bayar.ToString("#,###"));

                file.WriteLine("-".PadRight(50, pemisah));
                file.WriteLine("Terima kasih!");
                file.WriteLine("=".PadRight(50, '='));
            }
            file.Close();

            Cetak c = new Cetak(namaFile, 10, 9, 9, 9);
            c.CetakKePrinter();
        }

        //Cetak 1 Order
        public void CetakOrder(string namaFile)
        {
            StreamWriter file = new StreamWriter(namaFile);
            char pemisah = '-';
            file.WriteLine(""); //Cetak 1 baris kosong
            file.WriteLine("Nama toko anda disini");
            file.WriteLine("No nota = " + Id);
            file.WriteLine("Tanggal = " + Tanggal_waktu);
            file.WriteLine("Pembeli = " + Pelanggan.Nama + "-" + Pelanggan.Id);
            file.WriteLine("Alamat = " + Alamat_tujuan);
            file.WriteLine("Driver = " + Driver.Nama);
            file.WriteLine("Metode Pembayaran = " + Cara_bayar);
            file.WriteLine("Promo = " + Promo);
            file.WriteLine("Ongkos Kirim = " + Ongkos_kirim);
            file.WriteLine("Total Bayar = " + Total_bayar.ToString("#,###"));

            file.WriteLine("-".PadRight(50, pemisah));
            file.WriteLine("Terima kasih!");
            file.WriteLine("=".PadRight(50, '='));
            file.Close();

            Cetak c = new Cetak(namaFile, 10, 9, 9, 9);
            c.CetakKePrinter();
        }
        #endregion
    }
}
