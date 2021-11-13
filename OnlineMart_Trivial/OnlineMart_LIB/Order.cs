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
		private int id;
        private DateTime tanggal_waktu;
        private string alamat_tujuan;
        private float ongkos_kirim;
        private float total_bayar;
        private string cara_bayar;
        string status;
        Cabang cabang;
        Pelanggan pelanggan;
        Driver driver;
        Metode_pembayaran metode_pembayaran;
        Promo promo;
        Gift_Redeem gift_redeem;
        #endregion

        #region Constructors
        public Order(int id, DateTime tanggal_waktu, string alamat_tujuan, float ongkos_kirim, float total_bayar, string cara_bayar, string status, Cabang cabang, Pelanggan pelanggan, Driver driver, Metode_pembayaran metode_pembayaran, Promo promo, Gift_Redeem gift_redeem)
        {
            this.Id = id;
            this.Tanggal_waktu = tanggal_waktu;
            this.Alamat_tujuan = alamat_tujuan;
            this.Ongkos_kirim = ongkos_kirim;
            this.Total_bayar = total_bayar;
            this.Cara_bayar = cara_bayar;
            this.Status = status;
            this.Cabang = cabang;
            this.Pelanggan = pelanggan;
            this.Driver = driver;
            this.Metode_pembayaran = metode_pembayaran;
            this.Promo = promo;
            this.Gift_redeem = gift_redeem;
        }

        public Order(DateTime tanggal_waktu, string alamat_tujuan, float ongkos_kirim, float total_bayar, string cara_bayar, string status, Cabang cabang, Pelanggan pelanggan, Driver driver, Metode_pembayaran metode_pembayaran, Promo promo, Gift_Redeem gift_redeem)
        {
            this.Id = Id;
            this.Tanggal_waktu = tanggal_waktu;
            this.Alamat_tujuan = alamat_tujuan;
            this.Ongkos_kirim = ongkos_kirim;
            this.Total_bayar = total_bayar;
            this.Cara_bayar = cara_bayar;
            this.Status = status;
            this.Cabang = cabang;
            this.Pelanggan = pelanggan;
            this.Driver = driver;
            this.Metode_pembayaran = metode_pembayaran;
            this.Promo = promo;
            this.Gift_redeem = gift_redeem;
        }
        #endregion

        #region Properties
        public int Id 
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
        #endregion

        #region Method
        public static Boolean TambahData(Order o)
		{
			string sql = "inset into orders (tanggal_waktu, alamat_tujuan, ongkos_kirim, total_bayar, cara_bayar, status, " +
                "cabang_id, pelanggan_id, driver_id, metode_pembayaran_id, promo_id, gift_redeem_id) " +
				"values ('" + o.Tanggal_waktu.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + o.Alamat_tujuan + "', " + o.Ongkos_kirim + ", " +
				o.Total_bayar + ", '" + o.Cara_bayar + "', " + o.Cabang.Id + ", " + o.Pelanggan.Id + ", " + o.Driver.Id + ", " + o.Metode_pembayaran.Id + ", " +
				+ o.Promo.Id + ", " + o.Gift_redeem.Id + ")";

            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0) return false;
            else return true;
        }

        public static List<Order> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "select id, tanggal_waktu, alamat_tujuan, ongkos_kirim, total_bayar, cara_bayar, status, cabang_id, pelanggan_id, driver_id, metode_pembayaran_id, promo_id, gift_redeem_id from promos ";
            if (kriteria != "") sql += " where " + kriteria + " like '%" + nilaiKriteria + "%'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Order> listOrder = new List<Order>();

            while (hasil.Read() == true)
            {
                Cabang c = Cabang.AmbilData(hasil.GetInt32(7));

                Pelanggan p = Pelanggan.AmbilData(hasil.GetInt32(8));

                Driver d = Driver.AmbilData(hasil.GetInt32(9));

                Metode_pembayaran mp = Metode_pembayaran.AmbilData(hasil.GetInt32(10));

                Promo pr = Promo.AmbilData(hasil.GetInt32(11));

                Gift_Redeem gr = Gift_Redeem.AmbilData(hasil.GetInt32(12));

                Order o = new Order(hasil.GetInt32(0), DateTime.Parse(hasil.GetString(1)), hasil.GetString(2), hasil.GetFloat(3), hasil.GetFloat(4), hasil.GetString(5), hasil.GetString(6), c, p, d, mp, pr, gr);
                
                listOrder.Add(o);
            }
            return listOrder;
        }

        public static Order AmbilData(int id)
        {
            string sql = "select id, tanggal_waktu, alamat_tujuan, ongkos_kirim, total_bayar, cara_bayar, status, cabang_id, pelanggan_id, driver_id, metode_pembayaran_id, promo_id, gift_redeem_id from promos where id = " + id;

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
