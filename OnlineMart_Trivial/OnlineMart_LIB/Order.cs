using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

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
			string sql = "insert into orders (tanggal_waktu, alamat_tujuan, ongkos_kirim, total_bayar, cara_bayar, status, " +
                         "cabang_id, pelanggan_id, driver_id, metode_pembayaran_id, promo_id, gift_redeem_id) " +
				         "values ('" + o.Tanggal_waktu.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + o.Alamat_tujuan + "', " + 
                         o.Ongkos_kirim + ", " + o.Total_bayar + ", '" + o.Cara_bayar + "', " + o.Cabang.Id + ", " + 
                         o.Pelanggan.Id + ", " + o.Driver.Id + ", " + o.Metode_pembayaran.Id + ", " + + o.Promo.Id + ", " + 
                         o.Gift_redeem.Id + ")";

            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0) return false;
            else return true;
        }

        public static List<Order> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "select id, tanggal_waktu, alamat_tujuan, ongkos_kirim, total_bayar, cara_bayar, status, " +
                         "cabang_id, pelanggan_id, driver_id, metode_pembayaran_id, promo_id, gift_redeem_id from orders ";
            if (kriteria != "") sql += " where " + kriteria + " like '%" + nilaiKriteria + "%'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Order> listOrder = new List<Order>();

            while (hasil.Read())
            {
                Cabang c = Cabang.AmbilData(hasil.GetInt32(7));

                Pelanggan p = Pelanggan.AmbilData(hasil.GetInt32(8));

                Driver d = Driver.AmbilData(hasil.GetInt32(9));

                Metode_pembayaran mp = Metode_pembayaran.AmbilData(hasil.GetInt32(10));

                Promo pr = Promo.AmbilData(hasil.GetInt32(11));

                Gift_Redeem gr = Gift_Redeem.AmbilData(hasil.GetInt32(12));

                Order o = new Order(long.Parse(hasil.GetString(0)), DateTime.Parse(hasil.GetString(1)), hasil.GetString(2), hasil.GetFloat(3), hasil.GetFloat(4), hasil.GetString(5), hasil.GetString(6), c, p, d, mp, pr, gr);

                //Ambil Barang_Order
                string barang_order = "select bo.barang_id, bo.jumlah, bo.harga from barang_order as bo " +
                                      "inner join orders as o on bo.order_id = o.id where o.id = " + o.Id;

                MySqlDataReader hasil_join = Koneksi.JalankanPerintahQuery(barang_order);

                while (hasil_join.Read())
                {
                    Barang b_join = Barang.AmbilData(hasil_join.GetInt32(0));

                    Barang_Order bo = new Barang_Order(b_join, o, hasil_join.GetInt32(1), hasil_join.GetFloat(2));

                    //Tambahkan hasil join ke composition relationship
                    o.ListBarangOrder.Add(bo);
                }

                listOrder.Add(o);
            }
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
        public static string GenerateIdOrder()
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

        public static Order AmbilData(long id)
        {
            string sql = "select id, tanggal_waktu, alamat_tujuan, ongkos_kirim, total_bayar, cara_bayar, " +
                         "status, cabang_id, pelanggan_id, driver_id, metode_pembayaran_id, promo_id, gift_redeem_id" +
                         " from orders where id = " + id;

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            hasil.Read();

            Cabang c = Cabang.AmbilData(hasil.GetInt32(7));

            Pelanggan p = Pelanggan.AmbilData(hasil.GetInt32(8));

            Driver d = Driver.AmbilData(hasil.GetInt32(9));

            Metode_pembayaran mp = Metode_pembayaran.AmbilData(hasil.GetInt32(10));

            Promo pr = Promo.AmbilData(hasil.GetInt32(11));

            Gift_Redeem gr = Gift_Redeem.AmbilData(hasil.GetInt32(12));

            Order o = new Order(hasil.GetInt32(0), DateTime.Parse(hasil.GetString(1)), hasil.GetString(2), hasil.GetFloat(3), hasil.GetFloat(4), hasil.GetString(5), hasil.GetString(6), c, p, d, mp, pr, gr);

            return o;
        }
        #endregion
    }
}
