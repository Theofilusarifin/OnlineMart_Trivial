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
        #endregion

        #region Constructors
        public Order(int id, DateTime tanggal_waktu, string alamat_tujuan, float ongkos_kirim, float total_bayar, string cara_bayar, string status, Cabang cabang, Pelanggan pelanggan, Driver driver, Metode_pembayaran metode_pembayaran, Promo promo)
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
        }
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public DateTime Tanggal_waktu { get => tanggal_waktu; set => tanggal_waktu = value; }
        public string Alamat_tujuan { get => alamat_tujuan; set => alamat_tujuan = value; }
        public float Ongkos_kirim { get => ongkos_kirim; set => ongkos_kirim = value; }
        public float Total_bayar { get => total_bayar; set => total_bayar = value; }
        public string Cara_bayar { get => cara_bayar; set => cara_bayar = value; }
        public string Status { get => status; set => status = value; }
        public Cabang Cabang { get => cabang; set => cabang = value; }
        public Pelanggan Pelanggan { get => pelanggan; set => pelanggan = value; }
        public Driver Driver { get => driver; set => driver = value; }
        public Metode_pembayaran Metode_pembayaran { get => metode_pembayaran; set => metode_pembayaran = value; }
        public Promo Promo { get => promo; set => promo = value; }
        #endregion

        #region Method
        public static Boolean TambahData(Order o)
		{
			string sql = "INSERT INTO orders (id, tanggal_waktu, alamat_tujuan, ongkos_kirim, total_bayar, cara_bayar, " +
				"cabang_id, driver_id, pelanggan_id, promo_id, status, metode_pembayaran) " +
				"values ('" + o.Id + "', '" + o.Tanggal_waktu + "', '" + o.Alamat_tujuan + "', '" + o.Ongkos_kirim + "'," +
				" '" + o.Total_bayar + "', '" + o.Cara_bayar + "', '" + o.Cabang.Id + "', '" + o.Driver.Id + "', '" + o.Pelanggan.Id + "'," +
				" '" + o.Promo.Id + "', '" + o.Status + "', '" + o.Metode_pembayaran + "')";

			int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
			if (jumlahDitambah == 0)
				return false;
			else
				return true;
		}

        public static List<Order> BacaData(string kriteria, string nilaiKriteria)
        {
			string sql = "select o.id, o.tanggal_waktu, o.alamat_tujuan, o.ongkos_kirim, o.total_bayar, o.cara_bayar, " +
						 "c.id, c.nama, c.alamat, p.id, p.nama, p.username, p.email, p.password, p.telepon, " +
						 "d.id, d.nama, d.username, d.email, d.password, d.telepon, " +
						 "pe.id, pe.nama, pe.username, pe.email, pe.password, pe.telepon, pe.saldo, pe.poin, " +
						 "pr.id, pr.tipe, pr.nama, pr.diskon, pr.diskon_max, pr.minimal_belanja, o.status, o.metode_pembayaran " +
						 "from pegawais as p inner join cabangs as c on p.id = c.pegawai_id " +
						 "inner join orders as o on c.id = o.cabang_id " +
						 "inner join drivers as d on o.driver_id = d.id " +
						 "inner join pelanggans as pe on o.pelanggan_id = pe.id " +
						 "inner join promos as pr on o.promo_id = pr.id";

            if (kriteria != "") //kalau tidak kosong tambahkan ini
            {
                sql += " where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

			MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Order> listOrder = new List<Order>();
            //kalau bisa/berhasil dibaca maka dimasukkin ke list pake constructors
            while (hasil.Read())
            {
                Pegawai p = new Pegawai(hasil.GetInt32(9), hasil.GetString(10), hasil.GetString(11), hasil.GetString(12), 
                    hasil.GetString(13), hasil.GetString(14));
                Cabang c = new Cabang(hasil.GetInt32(6), hasil.GetString(7), hasil.GetString(8), p);
                Driver d = new Driver(hasil.GetInt32(15), hasil.GetString(16), hasil.GetString(17), hasil.GetString(18), 
                    hasil.GetString(19), hasil.GetString(20));
                Pelanggan pe = new Pelanggan(hasil.GetInt32(21), hasil.GetString(22), hasil.GetString(23), hasil.GetString(24), 
                    hasil.GetString(25), hasil.GetString(26), hasil.GetDouble(27), hasil.GetDouble(28));
                Promo pr = new Promo(hasil.GetInt32(29), hasil.GetString(30), hasil.GetString(31), hasil.GetInt32(32), 
                    hasil.GetInt32(33), hasil.GetDouble(34));

                //Order o = new Order(hasil.GetInt32(0), hasil.GetDateTime(1), hasil.GetString(2), hasil.GetFloat(3), hasil.GetFloat(4),
                //    hasil.GetString(5), c, d, pe, pr, hasil.GetString(35), hasil.GetString(36));

                //listOrder.Add(o);
            }
            return listOrder;
        }
        #endregion
    }
}
