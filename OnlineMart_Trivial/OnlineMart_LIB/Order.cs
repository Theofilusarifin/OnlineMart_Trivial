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
        Cabang cabang;
        Driver driver;
        Pelanggan pelanggan;
        Promo promo;
        //status dan metode pembayaran dibuat string karena apabila dibuat enum, nanti error soalnya nda bisa dijadikan property
        //+ dipanggil di method lain. Nanti untuk status dan metode pembayaran dikasih combo box dan outputnya berupa string
        //jadi bisa di pake di dalam method + constructor
        string status;
		string metode_pembayaran;
        #endregion

        #region Constructors
        public Order(int id, DateTime tanggal_waktu, string alamat_tujuan, float ongkos_kirim, float total_bayar, string cara_bayar, 
            Cabang cabang, Driver driver, Pelanggan pelanggan, Promo promo, string status, string metode_pembayaran)
        {
            Id = id;
            Tanggal_waktu = tanggal_waktu;
            Alamat_tujuan = alamat_tujuan;
            Ongkos_kirim = ongkos_kirim;
            Total_bayar = total_bayar;
            Cara_bayar = cara_bayar;
            Cabang = cabang;
            Driver = driver;
            Pelanggan = pelanggan;
            Promo = promo;
            Status = status;
            Metode_pembayaran = metode_pembayaran;
        }
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public DateTime Tanggal_waktu { get => tanggal_waktu; set => tanggal_waktu = value; }
        public string Alamat_tujuan { get => alamat_tujuan; set => alamat_tujuan = value; }
        public float Ongkos_kirim { get => ongkos_kirim; set => ongkos_kirim = value; }
        public float Total_bayar { get => total_bayar; set => total_bayar = value; }
        public string Cara_bayar { get => cara_bayar; set => cara_bayar = value; }
        public Cabang Cabang { get => cabang; set => cabang = value; }
        public Driver Driver { get => driver; set => driver = value; }
        public Pelanggan Pelanggan { get => pelanggan; set => pelanggan = value; }
        public Promo Promo { get => promo; set => promo = value; }
        public string Status { get => status; set => status = value; }
        public string Metode_pembayaran { get => metode_pembayaran; set => metode_pembayaran = value; }
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

        /*public static List<Order> BacaData(string kriteria, string nilaiKriteria)
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



			MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Order> listOrder = new List<Order>(); //Untuk menampung data
            while (hasil.Read())
            {
				Pegawai p = new Pegawai
                Cabang c = new Cabang()
                Driver d = new Driver
                Pelanggan pe = new Pelanggan
                Promo pr = new Promo

                Order o = new Order(hasil.GetInt32(0), hasil.GetDateTime(1), hasil.GetString(2), hasil.GetFloat(3), hasil.GetFloat(4),
                    hasil.GetString(5), c, d, pe, pr, hasil.GetString(), hasil.GetString());

                listOrder.Add(o);
            }
            return listOrder;
        }*/
        #endregion
    }
}
