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

        public static List<Order> BacaData(string kriteria, string nilaiKriteria, Koneksi kParram)
        {
            string sql = "select id, tanggal_waktu, alamat_tujuan, ongkos_kirim, total_bayar, cara_bayar, status, " +
                         "cabang_id, pelanggan_id, driver_id, metode_pembayaran_id, promo_id, gift_redeem_id from orders ";
            if (kriteria != "") sql += " where " + kriteria + " like '%" + nilaiKriteria + "%'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql, kParram);

            List<Order> listOrder = new List<Order>();

            while (hasil.Read())
            {
                Cabang c = Cabang.AmbilData(hasil.GetInt32(7), kParram);

                Pelanggan p = Pelanggan.AmbilData(hasil.GetInt32(8), kParram);

                Driver d = Driver.AmbilData(hasil.GetInt32(9), kParram);

                Metode_pembayaran mp = Metode_pembayaran.AmbilData(hasil.GetInt32(10), kParram);

                Promo pr = Promo.AmbilData(hasil.GetInt32(11), kParram);

                Gift_Redeem gr = Gift_Redeem.AmbilData(hasil.GetInt32(12), kParram);

                Order o = new Order(long.Parse(hasil.GetString(0)), DateTime.Parse(hasil.GetString(1)), hasil.GetString(2), hasil.GetFloat(3), hasil.GetFloat(4), hasil.GetString(5), hasil.GetString(6), c, p, d, mp, pr, gr);

                //Ambil Barang_Order
                string barang_order = "select bo.barang_id, bo.jumlah, bo.harga from barang_order as bo " +
                                      "inner join orders as o on bo.order_id = o.id where o.id = " + o.Id;

                MySqlDataReader hasil_join = Koneksi.JalankanPerintahQuery(barang_order, kParram);

                while (hasil_join.Read())
                {
                    Barang b_join = Barang.AmbilData(hasil_join.GetInt32(0), kParram);

                    Barang_Order bo = new Barang_Order(b_join, o, hasil_join.GetInt32(1), hasil_join.GetFloat(2));

                    //Tambahkan hasil join ke composition relationship
                    o.ListBarangOrder.Add(bo);
                }
                hasil_join.Close();
                hasil_join.Dispose();

                listOrder.Add(o);
            }

            hasil.Close();
            hasil.Dispose();

            return listOrder;
        }

        public static Boolean UbahData(Order o)
        {
            // Querry Insert
            string sql = "update barangs set tanggal_waktu = '" + o.Tanggal_waktu + "', alamat_tujuan = '" + o.Alamat_tujuan + "', " +
                         "ongkos_kirim = '" + o.Ongkos_kirim + "', total_bayar = '" + o.Total_bayar + "', cara_bayar = '" + o.Cara_bayar + "', " +
                         "status = '" + o.Status + "', cabang_id = '" + o.Cabang.Id + "', pelanggan_id = '" + o.Pelanggan.Id + "', " +
                         "driver_id = '" + o.Driver.Id + "', metode_pembayaran_id = '" + o.Metode_pembayaran.Id + "', " +
                         "promo_id = '" + o.Promo.Id + "', gift_redeem_id = '" + o.Gift_redeem.Id + "'";

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

            hasil.Close();
            hasil.Dispose();

            return hasilNoNota;
        }

        public static Order AmbilData(long id, Koneksi kParram)
        {
            string sql = "select id, tanggal_waktu, alamat_tujuan, ongkos_kirim, total_bayar, cara_bayar, " +
                         "status, cabang_id, pelanggan_id, driver_id, metode_pembayaran_id, promo_id, gift_redeem_id" +
                         " from orders where id = " + id;

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql, kParram);

            Order o = null;

            while (hasil.Read())
            {
                Cabang c = Cabang.AmbilData(hasil.GetInt32(7), kParram);

                Pelanggan p = Pelanggan.AmbilData(hasil.GetInt32(8), kParram);

                Driver d = Driver.AmbilData(hasil.GetInt32(9), kParram);

                Metode_pembayaran mp = Metode_pembayaran.AmbilData(hasil.GetInt32(10), kParram);

                Promo pr = Promo.AmbilData(hasil.GetInt32(11), kParram);

                Gift_Redeem gr = Gift_Redeem.AmbilData(hasil.GetInt32(12), kParram);

                o = new Order(long.Parse(hasil.GetString(0)), DateTime.Parse(hasil.GetString(1)), hasil.GetString(2), hasil.GetFloat(3), hasil.GetFloat(4), hasil.GetString(5), hasil.GetString(6), c, p, d, mp, pr, gr);
            }

            hasil.Close();
            hasil.Dispose();

            return o;
        }

        public static List<Order> BacaTanggal(int driver_id, string bulan, string tahun, Koneksi koneksi)
        {
            string sql = "select id, tanggal_waktu, alamat_tujuan, ongkos_kirim, total_bayar, cara_bayar, status, " +
                         "cabang_id, pelanggan_id, driver_id, metode_pembayaran_id, promo_id, gift_redeem_id from orders" +
                         " where driver_id = " + driver_id;

            // kalau bulan dan tahun ada isinya
            if (bulan != "" && tahun != "") sql += " AND MONTH(tanggal_waktu) = '" + bulan + "' AND YEAR(tanggal_waktu) = '" + tahun + "'";
            // kalau bulan ada isinya
            else if (bulan != "") sql += " AND MONTH(tanggal_waktu) = '" + bulan + "'";
            // kalau tahun ada isinya
            else if (tahun != "") sql += " AND YEAR(tanggal_waktu) = '" + tahun + "'";
            
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql, koneksi);

            List<Order> listOrder = new List<Order>();

            // masukkan data yang ingin ditampilkan/dibaca ke class
            #region AmbilData
            while (hasil.Read())
            {
                Cabang c = Cabang.AmbilData(hasil.GetInt32(7), koneksi);

                Pelanggan p = Pelanggan.AmbilData(hasil.GetInt32(8),koneksi);

                Driver d = Driver.AmbilData(hasil.GetInt32(9), koneksi);

                Metode_pembayaran mp = Metode_pembayaran.AmbilData(hasil.GetInt32(10), koneksi);

                Promo pr = Promo.AmbilData(hasil.GetInt32(11), koneksi);

                Gift_Redeem gr = Gift_Redeem.AmbilData(hasil.GetInt32(12), koneksi);

                Order o = new Order(long.Parse(hasil.GetString(0)), DateTime.Parse(hasil.GetString(1)), hasil.GetString(2), hasil.GetFloat(3), hasil.GetFloat(4), hasil.GetString(5), hasil.GetString(6), c, p, d, mp, pr, gr);

                //Ambil Barang_Order
                string barang_order = "select bo.barang_id, bo.jumlah, bo.harga from barang_order as bo " +
                                      "inner join orders as o on bo.order_id = o.id where o.id = " + o.Id;

                MySqlDataReader hasil_join = Koneksi.JalankanPerintahQuery(barang_order, koneksi);

                while (hasil_join.Read())
                {
                    Barang b_join = Barang.AmbilData(hasil_join.GetInt32(0), koneksi);

                    Barang_Order bo = new Barang_Order(b_join, o, hasil_join.GetInt32(1), hasil_join.GetFloat(2));

                    //Tambahkan hasil join ke composition relationship
                    o.ListBarangOrder.Add(bo);
                }

                hasil_join.Close();
                hasil_join.Dispose();

                listOrder.Add(o);
            }

            hasil.Close();
            hasil.Dispose();
            #endregion

            return listOrder;

        }

        public static List<Order> AmbilTahun(Koneksi koneksi)
        {
            string sql = "select distinct YEAR(tanggal_waktu) from orders";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql, koneksi);

            List<Order> listTahun = new List<Order>();

            while (hasil.Read())
            {
                Order o = new Order(DateTime.Parse(hasil.GetString(0)));

                listTahun.Add(o);
            }

            return listTahun;
        }

        //Cetak semua order
        public static void CetakDaftarOrder(string kriteria, string nilai, string namaFile, Koneksi kParram)
        {
            List<Order> listData = Order.BacaData(kriteria, nilai, kParram);
            StreamWriter file = new StreamWriter(namaFile);
            char pemisah = '-';
            file.WriteLine(""); //Cetak 1 baris kosong
            file.WriteLine("Nama toko anda disini");
            foreach (Order o in listData)
            {
                file.WriteLine("No nota = " + o.Id);
                file.WriteLine("Tanggal = " + o.Tanggal_waktu);
                file.WriteLine("Pembeli = " + o.Pelanggan.Nama + "-" + o.Pelanggan.Id);
                file.WriteLine("Alamat = " + o.Alamat_tujuan);
                file.WriteLine("Driver = " + o.Driver.Nama);
                file.WriteLine("Metode Pembayaran = " + o.Cara_bayar);
                file.WriteLine("Promo = " + o.Promo);
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
