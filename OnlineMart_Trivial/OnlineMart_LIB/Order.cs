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
            Pelanggan = pelanggan;
            Driver = driver;
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
        public static Boolean TambahData(Order o)
		{
			string sql = "insert into orders (id, tanggal_waktu, alamat_tujuan, ongkos_kirim, total_bayar, cara_bayar, status, " +
                         "cabang_id, pelanggan_id, driver_id, metode_pembayaran_id, promo_id, gift_redeem_id) " +
				         "values (" + o.Id + ", '" + o.Tanggal_waktu.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + o.Alamat_tujuan + "', " + 
                         o.Ongkos_kirim + ", " + o.Total_bayar + ", '" + o.Cara_bayar + "','" + o.Status + "', " + o.Cabang.Id + ", " + 
                         o.Pelanggan.Id + ", " + o.Driver.Id + ", " + o.Metode_pembayaran.Id + ", " + + o.Promo.Id + ", " + 
                         o.Gift_redeem.Id + ")";

            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0) return false;
            else return true;
        }

        public static List<Order> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "select * from orders o " +
                         "inner join pelanggans p on o.pelanggan_id = p.id " +
                         "inner join drivers d on o.driver_id = d.id " +
                         "inner join cabangs c on o.cabang_id = c.id " +
                         "inner join pegawais pe on c.pegawai_id = pe.id " +
                         "inner join metode_pembayarans mp on o.metode_pembayaran_id = mp.id " +
                         "inner join promos pr on o.promo_id = pr.id " +
                         "inner join gift_redeems gr on o.gift_redeem_id = gr.id " +
                         "inner join gifts g on gr.gift_id = g.id ";

            if (kriteria != "") sql += " where " + kriteria + " like '%" + nilaiKriteria + "%' ";

            sql += " order by o.tanggal_waktu ";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Order> listOrder = new List<Order>();

            while (hasil.Read())
            {
                Pelanggan p = new Pelanggan(hasil.GetInt32(13), hasil.GetString(14), hasil.GetString(15), hasil.GetString(16), hasil.GetString(17), hasil.GetString(18), hasil.GetDouble(19), hasil.GetDouble(20));

                Driver d = new Driver(hasil.GetInt32(21), hasil.GetString(22), hasil.GetString(23), hasil.GetString(24), hasil.GetString(25), hasil.GetString(26));

                Pegawai pe = new Pegawai(hasil.GetInt32(31), hasil.GetString(32), hasil.GetString(33), hasil.GetString(34), hasil.GetString(35), hasil.GetString(36));

                Cabang c = new Cabang(hasil.GetInt32(27), hasil.GetString(28), hasil.GetString(29), pe);

                Metode_pembayaran mp = new Metode_pembayaran(hasil.GetInt32(37), hasil.GetString(38));

                Promo pr = new Promo(hasil.GetInt32(39), hasil.GetString(40), hasil.GetString(41), hasil.GetInt32(42), hasil.GetInt32(43), hasil.GetFloat(44));

                Gift g = new Gift(hasil.GetInt32(49), hasil.GetString(50), hasil.GetInt32(51));

                Gift_Redeem gr = new Gift_Redeem(hasil.GetInt32(45), DateTime.Parse(hasil.GetString(46)), hasil.GetInt32(47), g);

                Order o = new Order(long.Parse(hasil.GetString(0)), DateTime.Parse(hasil.GetString(1)), hasil.GetString(2), hasil.GetFloat(3), hasil.GetFloat(4), hasil.GetString(5), hasil.GetString(6), c, p, d, mp, pr, gr);

                listOrder.Add(o);
            }

            return listOrder;
        }

        public static List<Order> BacaData(string status, string kriteria, string nilaiKriteria)
        {
            string sql = "select * from orders o " +
                         "inner join pelanggans p on o.pelanggan_id = p.id " +
                         "inner join drivers d on o.driver_id = d.id " +
                         "inner join cabangs c on o.cabang_id = c.id " +
                         "inner join pegawais pe on c.pegawai_id = pe.id " +
                         "inner join metode_pembayarans mp on o.metode_pembayaran_id = mp.id " +
                         "inner join promos pr on o.promo_id = pr.id " +
                         "inner join gift_redeems gr on o.gift_redeem_id = gr.id " +
                         "inner join gifts g on gr.gift_id = g.id " +
                         "where o.status = '" + status + "' and " + kriteria + " like '%" + nilaiKriteria + "%' ";

            sql += " order by o.tanggal_waktu ";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Order> listOrder = new List<Order>();

            while (hasil.Read())
            {
                Pelanggan p = new Pelanggan(hasil.GetInt32(13), hasil.GetString(14), hasil.GetString(15), hasil.GetString(16), hasil.GetString(17), hasil.GetString(18), hasil.GetDouble(19), hasil.GetDouble(20));

                Driver d = new Driver(hasil.GetInt32(21), hasil.GetString(22), hasil.GetString(23), hasil.GetString(24), hasil.GetString(25), hasil.GetString(26));

                Pegawai pe = new Pegawai(hasil.GetInt32(31), hasil.GetString(32), hasil.GetString(33), hasil.GetString(34), hasil.GetString(35), hasil.GetString(36));

                Cabang c = new Cabang(hasil.GetInt32(27), hasil.GetString(28), hasil.GetString(29), pe);

                Metode_pembayaran mp = new Metode_pembayaran(hasil.GetInt32(37), hasil.GetString(38));

                Promo pr = new Promo(hasil.GetInt32(39), hasil.GetString(40), hasil.GetString(41), hasil.GetInt32(42), hasil.GetInt32(43), hasil.GetFloat(44));

                Gift g = new Gift(hasil.GetInt32(49), hasil.GetString(50), hasil.GetInt32(51));

                Gift_Redeem gr = new Gift_Redeem(hasil.GetInt32(45), DateTime.Parse(hasil.GetString(46)), hasil.GetInt32(47), g);

                Order o = new Order(long.Parse(hasil.GetString(0)), DateTime.Parse(hasil.GetString(1)), hasil.GetString(2), hasil.GetFloat(3), hasil.GetFloat(4), hasil.GetString(5), hasil.GetString(6), c, p, d, mp, pr, gr);

                listOrder.Add(o);
            }

            return listOrder;
        }

        public static List<Order> BacaOrderDiproses(string kriteria, string nilaiKriteria)
        {
            string sql = "select * from orders o " +
                "inner join pelanggans p on o.pelanggan_id = p.id " +
                "inner join drivers d on o.driver_id = d.id " +
                "inner join cabangs c on o.cabang_id = c.id " +
                "inner join pegawais pe on c.pegawai_id = pe.id " +
                "inner join metode_pembayarans mp on o.metode_pembayaran_id = mp.id " +
                "inner join promos pr on o.promo_id = pr.id " +
                "inner join gift_redeems gr on o.gift_redeem_id = gr.id " +
                "inner join gifts g on gr.gift_id = g.id where status = 'Pesanan Diproses' ";

            if (kriteria != "") sql += " and " + kriteria + " like '%" + nilaiKriteria + "%' ";

            sql += " order by o.tanggal_waktu ";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Order> listOrder = new List<Order>();

            while (hasil.Read())
            {
                Pelanggan p = new Pelanggan(hasil.GetInt32(13), hasil.GetString(14), hasil.GetString(15), hasil.GetString(16), hasil.GetString(17), hasil.GetString(18), hasil.GetDouble(19), hasil.GetDouble(20));

                Driver d = new Driver(hasil.GetInt32(21), hasil.GetString(22), hasil.GetString(23), hasil.GetString(24), hasil.GetString(25), hasil.GetString(26));

                Pegawai pe = new Pegawai(hasil.GetInt32(31), hasil.GetString(32), hasil.GetString(33), hasil.GetString(34), hasil.GetString(35), hasil.GetString(36));

                Cabang c = new Cabang(hasil.GetInt32(27), hasil.GetString(28), hasil.GetString(29), pe);

                Metode_pembayaran mp = new Metode_pembayaran(hasil.GetInt32(37), hasil.GetString(38));

                Promo pr = new Promo(hasil.GetInt32(39), hasil.GetString(40), hasil.GetString(41), hasil.GetInt32(42), hasil.GetInt32(43), hasil.GetFloat(44));

                Gift g = new Gift(hasil.GetInt32(49), hasil.GetString(50), hasil.GetInt32(51));

                Gift_Redeem gr = new Gift_Redeem(hasil.GetInt32(45), DateTime.Parse(hasil.GetString(46)), hasil.GetInt32(47), g);

                Order o = new Order(long.Parse(hasil.GetString(0)), DateTime.Parse(hasil.GetString(1)), hasil.GetString(2), hasil.GetFloat(3), hasil.GetFloat(4), hasil.GetString(5), hasil.GetString(6), c, p, d, mp, pr, gr);

                listOrder.Add(o);
            }

            return listOrder;
        }

        public static Boolean UbahData(Order o)
        {
            // Querry Insert
            string sql = "update orders set tanggal_waktu = '" + o.Tanggal_waktu + "', alamat_tujuan = '" + o.Alamat_tujuan + "', " +
                         "ongkos_kirim = '" + o.Ongkos_kirim + "', total_bayar = '" + o.Total_bayar + "', cara_bayar = '" + o.Cara_bayar + "', " +
                         "status = '" + o.Status + "', driver_id = '" + o.Driver.Id + "', cabang_id = '" + o.Cabang.Id + "', " +
                         "metode_pembayaran_id = '" + o.Metode_pembayaran.Id + "', promo_id = '" + o.Promo.Id + "', " +
                         "gift_redeem_id = '" + o.Gift_redeem.Id + "', pelanggan_id = '" + o.Pelanggan.Id + "' " +
                         "where id = '" + o.Id + "'";

            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0) return false;
            else return true;
        }

        public static bool UpdateStok(Barang_Order bo, Cabang bc)
		{
            string sql = "update barang_cabang set stok = stok - " + bo.Jumlah + " where barang_id = " + bo.Barang.Id + " and cabang_id = " + bc.Id;
            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0) return false;
            else return true;
        }

        // membuat id order dengan format yyyyMMddxxxx (yyyy-MM-dd-xxxx)
        // yyyy = tahun ini, MM = bulan ini, dd = hari ini, xxxx = transaksi ke x hari ini
        public static string GenerateIdOrder(Koneksi kParram)
        {
            // ambil no urut transaksi hari ini (tanggal sistem)
            string sql = "select right(id, 4) as NoUrutTransaksi" +
                         " from orders" +
                         " where Date(tanggal_waktu) = Date(CURRENT_DATE)" +
                         " order by tanggal_waktu DESC limit 1";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

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
                         "inner join pelanggans p on o.pelanggan_id = p.id " +
                         "inner join drivers d on o.driver_id = d.id " +
                         "inner join cabangs c on o.cabang_id = c.id " +
                         "inner join pegawais pe on c.pegawai_id = pe.id " +
                         "inner join metode_pembayarans mp on o.metode_pembayaran_id = mp.id " +
                         "inner join promos pr on o.promo_id = pr.id " +
                         "inner join gift_redeems gr on o.gift_redeem_id = gr.id " +
                         "inner join gifts g on gr.gift_id = g.id " +
                         "where o.id = " + id;

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            Order o = null;

            while (hasil.Read())
            {
                Pelanggan p = new Pelanggan(hasil.GetInt32(13), hasil.GetString(14), hasil.GetString(15), hasil.GetString(16), hasil.GetString(17), hasil.GetString(18), hasil.GetDouble(19), hasil.GetDouble(20));

                Driver d = new Driver(hasil.GetInt32(21), hasil.GetString(22), hasil.GetString(23), hasil.GetString(24), hasil.GetString(25), hasil.GetString(26));

                Pegawai pe = new Pegawai(hasil.GetInt32(31), hasil.GetString(32), hasil.GetString(33), hasil.GetString(34), hasil.GetString(35), hasil.GetString(36));

                Cabang c = new Cabang(hasil.GetInt32(27), hasil.GetString(28), hasil.GetString(29), pe);

                Metode_pembayaran mp = new Metode_pembayaran(hasil.GetInt32(37), hasil.GetString(38));

                Promo pr = new Promo(hasil.GetInt32(39), hasil.GetString(40), hasil.GetString(41), hasil.GetInt32(42), hasil.GetInt32(43), hasil.GetFloat(44));

                Gift g = new Gift(hasil.GetInt32(49), hasil.GetString(50), hasil.GetInt32(51));

                Gift_Redeem gr = new Gift_Redeem(hasil.GetInt32(45), DateTime.Parse(hasil.GetString(46)), hasil.GetInt32(47), g);

                o = new Order(long.Parse(hasil.GetString(0)), DateTime.Parse(hasil.GetString(1)), hasil.GetString(2), hasil.GetFloat(3), hasil.GetFloat(4), hasil.GetString(5), hasil.GetString(6), c, p, d, mp, pr, gr);
            }

            return o;
        }

        public static List<Order> BacaTanggal(Driver driver, string bulan, string tahun)
        {
            string sql = "select * from orders o " +
                " where driver_id = " + driver.Id;

            // kalau bulan dan tahun ada isinya
            if (bulan != "" && tahun != "") sql += " AND MONTH(tanggal_waktu) = " + bulan + " AND YEAR(tanggal_waktu) = " + tahun;
            // kalau bulan ada isinya
            else if (bulan != "") sql += " AND MONTH(tanggal_waktu) = '" + bulan + "'";
            // kalau tahun ada isinya
            else if (tahun != "") sql += " AND YEAR(tanggal_waktu) = '" + tahun + "'";
            
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Order> listOrder = new List<Order>();

            // masukkan data yang ingin ditampilkan/dibaca ke class
            while (hasil.Read())
            {
                Order o = new Order(long.Parse(hasil.GetString(0)), DateTime.Parse(hasil.GetString(1)), hasil.GetString(2), hasil.GetFloat(3), hasil.GetFloat(4), hasil.GetString(5), hasil.GetString(6));

                listOrder.Add(o);
            }
            return listOrder;
        }

        public static List<Int32> AmbilTahun()
        {
            string sql = "select distinct YEAR(tanggal_waktu) from orders";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Int32> listTahun = new List<Int32>();

            while (hasil.Read())
            {
                listTahun.Add(hasil.GetInt32(0));
            }

            return listTahun;
        }

        //Cetak semua order
        public static void CetakDaftarOrder(string kriteria, string nilai, string namaFile, Koneksi kParram)
        {
            List<Order> listData = Order.BacaData(kriteria, nilai);
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
