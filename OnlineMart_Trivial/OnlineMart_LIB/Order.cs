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
        private double ongkos_kirim;
        private double total_bayar;
        private string cara_bayar;
        Cabang cabang;
        Driver driver;
        Pelanggan pelanggan;
        Promo promo;
		//status dan metode pembayaran dibuat string karena apabila dibuat enum, nanti error soalnya nda bisa dijadikan property + dipanggil di method lain. Nanti utnuk status dan metode pembayaran dikasih combo box dan outputnya berupa string jadi bisa di pake di dalam method + constructor
		string status;
		string metode_pembayaran;
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
		public double Ongkos_kirim 
		{
			get => ongkos_kirim;
			set => ongkos_kirim = value;
		}
		public double Total_bayar 
		{
			get => total_bayar;
			set => total_bayar = value;
		}
		public string Cara_bayar 
		{
			get => cara_bayar; 
			set => cara_bayar = value;
		}
		public Cabang Cabang 
		{
			get => cabang;
			set => cabang = value;
		}
		public Driver Driver 
		{
			get => driver; 
			set => driver = value;
		}
		public Pelanggan Pelanggan 
		{
			get => pelanggan;
			set => pelanggan = value; 
		}
		public Promo Promo 
		{
			get => promo;
			set => promo = value;
		}
		public string Status 
		{
			get => status;
			set => status = value;
		}
		public string Metode_pembayaran 
		{
			get => metode_pembayaran; 
			set => metode_pembayaran = value;
		}
		#endregion

		#region Constructor
		public Order(int id, DateTime tanggal_waktu, string alamat_tujuan, double ongkos_kirim, double total_bayar, string cara_bayar, Cabang cabang, Driver driver, Pelanggan pelanggan, Promo promo, string status, string metode_pembayaran)
		{
			this.Id = id;
			this.Tanggal_waktu = tanggal_waktu;
			this.Alamat_tujuan = alamat_tujuan;
			this.Ongkos_kirim = ongkos_kirim;
			this.Total_bayar = total_bayar;
			this.Cara_bayar = cara_bayar;
			this.Cabang = cabang;
			this.Driver = driver;
			this.Pelanggan = pelanggan;
			this.Promo = promo;
			this.Status = status;
			this.Metode_pembayaran = metode_pembayaran;
		}
		#endregion

		#region Method
		public static void TambahData(Order o)
		{
            string sql = "INSERT INTO orders (id, tanggal_waktu, alamat_tujuan, ongkos_kirim, total_bayar, cara_bayar, cabang, driver, pelanggan, promo, status, metode_pembayaran) " + " values "
                 + "('" + o.Id + "','" + o.Tanggal_waktu + "','" + o.Alamat_tujuan + "','" + o.Ongkos_kirim + "','" + o.Total_bayar + "','" + o.Cara_bayar + "','" + o.Cabang + "','" + o.Driver + "','" + o.Pelanggan + "','" + o.Promo + "','" + o.Status + "','" + o.Metode_pembayaran + "')";
		}
		//public static List<Order> BacaData(string kriteria, string nilaiKriteria)
		//{
		//	string sql = "";
		//	if (kriteria == "")
		//	{
		//		sql = "select o.id as id, o.tanggal_waktu as tanggal_waktu, o.ongkos_kirim as ongkos_kirim, o.total_bayar as total_bayar, o.cara_bayar as cara_bayar, o.cabangs_id as cabangs_id, o.drivers_id as drivers_id, o.pelanggans_id as pelanggans_id, o.promo_id as promo_id, o.status as status, o.metode_pembayaran as metode_pembayaran from orders as o inner join cabangs as c on o.cabangs_id = c.id inner join drivers as d on o.drivers_id = d.id inner join pelanggans as pe on o.pelanggans_id = pe.id inner join promos as pr on o.promo_id = pr.id; ";
		//	}
		//	else
		//	{
		//		sql = "select o.id as id, o.tanggal_waktu as tanggal_waktu, o.ongkos_kirim as ongkos_kirim, o.total_bayar as total_bayar, o.cara_bayar as cara_bayar, o.cabangs_id as cabangs_id, o.drivers_id as drivers_id, o.pelanggans_id as pelanggans_id, o.promo_id as promo_id, o.status as status, o.metode_pembayaran as metode_pembayaran from orders as o inner join cabangs as c on o.cabangs_id = c.id inner join drivers as d on o.drivers_id = d.id inner join pelanggans as pe on o.pelanggans_id = pe.id inner join promos as pr on o.promo_id = pr.id " + " where " + kriteria + " LIKE '%" + nilaiKriteria + "%';";
		//	}

		//	MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

		//	List<Order> listOrder = new List<Order>(); //Untuk menampung data
		//	while (hasil.Read() == true)
		//	{
		//		Cabang c = new Cabang(int.Parse(hasil.GetValue(6).ToString()));
		//		Driver d = new Driver(int.Parse(hasil.GetValue(7).ToString()));
		//		Pelanggan pe = new Pelanggan(int.Parse(hasil.GetValue(8).ToString()));
		//		Promo pr = new Promo(int.Parse(hasil.GetValue(9).ToString()));

		//		Order o = new Order(int.Parse(hasil.GetValue(0).ToString()), DateTime.Parse(hasil.GetValue(1).ToString()), hasil.GetValue(2).ToString(), double.Parse(hasil.GetValue(3).ToString()), double.Parse(hasil.GetValue(4).ToString()), hasil.GetValue(5).ToString(), c, d, pe, pr, hasil.GetValue(10).ToString(), hasil.GetValue(11).ToString());

		//		listOrder.Add(o);
		//	}
		//	return listOrder;
		//}
		#endregion
	}
}
