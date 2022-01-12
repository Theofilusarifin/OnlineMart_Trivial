using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace OnlineMart_LIB
{
    public class Barang_Order
    {
		#region Field
		private Barang barang;
		private Order order;
		private int jumlah;
		private float harga;
        #endregion

        #region Constructor
        public Barang_Order(Barang barang, Order order, int jumlah, float harga)
        {
            this.Barang = barang;
            this.Order = order;
            this.Jumlah = jumlah;
            this.Harga = harga;
        }
		#endregion

		#region Property
		public Barang Barang 
		{ 
			get => barang; 
			set => barang = value; 
		}
		public Order Order 
		{ 
			get => order; 
			set => order = value; 
		}
		public int Jumlah 
		{ 
			get => jumlah; 
			set => jumlah = value; 
		}
		public float Harga 
		{ 
			get => harga; 
			set => harga = value; 
		}
		#endregion

		#region Methods
		public static Boolean TambahData(Barang_Order bo)
		{
			// Querry Insert
			string sql = "insert into barang_order values (" + bo.Jumlah + ", " + bo.Harga + ", " + bo.Order.Id + ", " + bo.Barang.Id + ")";

			int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
			if (jumlahDitambah == 0) return false;
			else return true;
		}

		public static List<Barang_Order> BacaSemuaData()
		{
			string sql = "select * from barang_order bo " +
						 "inner join orders o on bo.order_id = o.id " +
						 "inner join cabangs as c on o.cabang_id = c.id " +
						 "inner join pegawais as pe on c.pegawai_id = pe.id " +
						 "inner join pelanggans p on o.pelanggan_id = p.id " +
						 "inner join drivers d on o.driver_id = d.id " +
						 "inner join metode_pembayarans mp on o.metode_pembayaran_id = mp.id " +
						 "inner join promos pr on o.promo_id = pr.id " +
						 "inner join gift_redeems gr on o.gift_redeem_id = gr.id " +
						 "inner join gifts g on gr.gift_id = g.id " +
						 "inner join barangs b on bo.barang_id = b.id " +
						 "inner join kategoris k on b.kategori_id = k.id "+
						 "inner join penjuals pen on o.penjual_id = pen.id " +
						 " order by o.tanggal_waktu ";

			MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

			List<Barang_Order> listPenjualanBarang = new List<Barang_Order>();

			while (hasil.Read())
			{
				Pegawai pe = new Pegawai(hasil.GetInt32(22), hasil.GetString(23), hasil.GetString(24), hasil.GetString(25), hasil.GetString(26), hasil.GetString(27));

				Pelanggan p = new Pelanggan(hasil.GetInt32(28), hasil.GetString(29), hasil.GetString(30), hasil.GetString(31), hasil.GetString(32), hasil.GetString(33), hasil.GetDouble(34), hasil.GetDouble(35));

				Driver d = new Driver(hasil.GetInt32(36), hasil.GetString(37), hasil.GetString(38), hasil.GetString(39), hasil.GetString(40), hasil.GetString(41));

				Metode_pembayaran mp = new Metode_pembayaran(hasil.GetInt32(42), hasil.GetString(43));

				Promo pr = new Promo(hasil.GetInt32(44), hasil.GetString(45), hasil.GetString(46), hasil.GetInt32(47), hasil.GetInt32(48), hasil.GetFloat(49));

				Gift g = new Gift(hasil.GetInt32(54), hasil.GetString(55), hasil.GetInt32(56));

				Gift_Redeem gr = new Gift_Redeem(hasil.GetInt32(50), DateTime.Parse(hasil.GetString(51)), hasil.GetInt32(51), g);

				Order o = null;
				int cabang_id = hasil.GetInt32(11);
				if (cabang_id == 0)
                {
					Penjual pen = new Penjual(hasil.GetInt32(65), hasil.GetString(66), hasil.GetString(67), hasil.GetString(68), hasil.GetString(69), hasil.GetString(70), hasil.GetString(71));
					o = new Order(long.Parse(hasil.GetString(4)), DateTime.Parse(hasil.GetString(5)), hasil.GetString(6), hasil.GetFloat(7), hasil.GetFloat(8), hasil.GetString(9), hasil.GetString(10), p, d, mp, pr, gr, pen);
                }
				else
                {
					Cabang c = new Cabang(hasil.GetInt32(18), hasil.GetString(19), hasil.GetString(20), pe);
					o = new Order(long.Parse(hasil.GetString(4)), DateTime.Parse(hasil.GetString(5)), hasil.GetString(6), hasil.GetFloat(7), hasil.GetFloat(8), hasil.GetString(9), hasil.GetString(10), c, p, d, mp, pr, gr);
				}

				Kategori k = new Kategori(hasil.GetInt32(63), hasil.GetString(64));

				Barang b = new Barang(hasil.GetInt32(57), hasil.GetString(58), hasil.GetInt32(59), hasil.GetString(60), hasil.GetString(61), k);

				Barang_Order bo = new Barang_Order(b, o, hasil.GetInt32(0), hasil.GetFloat(1));

				listPenjualanBarang.Add(bo);
			}

			//hasil.Dispose();
			//hasil.Close();

			return listPenjualanBarang;
		}

		public static List<Barang_Order> BacaPenjualanBarang(Cabang cabang, string bulan, string tahun)
		{
			string sql = "select * from barang_order bo " +
						 "inner join orders o on bo.order_id = o.id " +
						 "inner join cabangs as c on o.cabang_id = c.id " +
						 "inner join pegawais as pe on c.pegawai_id = pe.id " +
						 "inner join pelanggans p on o.pelanggan_id = p.id " +
						 "inner join drivers d on o.driver_id = d.id " +
						 "inner join metode_pembayarans mp on o.metode_pembayaran_id = mp.id " +
						 "inner join promos pr on o.promo_id = pr.id " +
						 "inner join gift_redeems gr on o.gift_redeem_id = gr.id " +
						 "inner join gifts g on gr.gift_id = g.id " +
						 "inner join barangs b on bo.barang_id = b.id " +
						 "inner join kategoris k on b.kategori_id = k.id " +
						 "inner join penjuals pen on o.penjual_id = pen.id " +
						 "order by o.tanggal_waktu ";

			// kalau semua ada isinya
			if (cabang != null && bulan != "" && tahun != "") sql += " where o.cabang_id = " + cabang.Id +
																	 " and MONTH(o.tanggal_waktu) = '" + bulan + "'" +
																	 " and YEAR(o.tanggal_waktu) = '" + tahun + "'";
			// kalau cabang dan bulan ada isinya
			else if (cabang != null && bulan != "") sql += " where o.cabang_id = " + cabang.Id +
														   " and MONTH(o.tanggal_waktu) = '" + bulan + "'";
			// kalau cabang dan tahun ada isinya
			else if (cabang != null && tahun != "") sql += " where o.cabang_id = " + cabang.Id +
														   " and YEAR(o.tanggal_waktu) = '" + tahun + "'";
			// kalau bulan dan tahun ada isinya
			else if (bulan != "" && tahun != "") sql += " where MONTH(o.tanggal_waktu) = '" + bulan + "'" +
														" and YEAR(o.tanggal_waktu) = '" + tahun + "'";
			// kalau cabang ada isinya
			else if (cabang != null) sql += " where o.cabang_id = " + cabang.Id;
			// kalau bulan ada isinya
			else if (bulan != "") sql += " where MONTH(o.tanggal_waktu) = '" + bulan + "'";
			// kalau tahun ada isinya
			else if (tahun != "") sql += " where YEAR(o.tanggal_waktu) = '" + tahun + "'";
			
			MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

			List<Barang_Order> listPenjualanBarang = new List<Barang_Order>();

			while(hasil.Read())
            {
				Pegawai pe = new Pegawai(hasil.GetInt32(22), hasil.GetString(23), hasil.GetString(24), hasil.GetString(25), hasil.GetString(26), hasil.GetString(27));

				Pelanggan p = new Pelanggan(hasil.GetInt32(28), hasil.GetString(29), hasil.GetString(30), hasil.GetString(31), hasil.GetString(32), hasil.GetString(33), hasil.GetDouble(34), hasil.GetDouble(35));

				Driver d = new Driver(hasil.GetInt32(36), hasil.GetString(37), hasil.GetString(38), hasil.GetString(39), hasil.GetString(40), hasil.GetString(41));

				Metode_pembayaran mp = new Metode_pembayaran(hasil.GetInt32(42), hasil.GetString(43));

				Promo pr = new Promo(hasil.GetInt32(44), hasil.GetString(45), hasil.GetString(46), hasil.GetInt32(47), hasil.GetInt32(48), hasil.GetFloat(49));

				Gift g = new Gift(hasil.GetInt32(54), hasil.GetString(55), hasil.GetInt32(56));

				Gift_Redeem gr = new Gift_Redeem(hasil.GetInt32(50), DateTime.Parse(hasil.GetString(51)), hasil.GetInt32(51), g);

				Order o = null;
				int cabang_id = hasil.GetInt32(11);
				if (cabang_id == 0)
				{
					Penjual pen = new Penjual(hasil.GetInt32(65), hasil.GetString(66), hasil.GetString(67), hasil.GetString(68), hasil.GetString(69), hasil.GetString(70), hasil.GetString(71));
					o = new Order(long.Parse(hasil.GetString(4)), DateTime.Parse(hasil.GetString(5)), hasil.GetString(6), hasil.GetFloat(7), hasil.GetFloat(8), hasil.GetString(9), hasil.GetString(10), p, d, mp, pr, gr, pen);
				}
				else
				{
					Cabang c = new Cabang(hasil.GetInt32(18), hasil.GetString(19), hasil.GetString(20), pe);
					o = new Order(long.Parse(hasil.GetString(4)), DateTime.Parse(hasil.GetString(5)), hasil.GetString(6), hasil.GetFloat(7), hasil.GetFloat(8), hasil.GetString(9), hasil.GetString(10), c, p, d, mp, pr, gr);
				}

				Kategori k = new Kategori(hasil.GetInt32(63), hasil.GetString(64));

				Barang b = new Barang(hasil.GetInt32(57), hasil.GetString(58), hasil.GetInt32(59), hasil.GetString(60), hasil.GetString(61), k);

				Barang_Order bo = new Barang_Order(b, o, hasil.GetInt32(0), hasil.GetFloat(1));

				listPenjualanBarang.Add(bo);
			}

			//hasil.Dispose();
			//hasil.Close();

			return listPenjualanBarang;
		}
		#endregion
	}
}
