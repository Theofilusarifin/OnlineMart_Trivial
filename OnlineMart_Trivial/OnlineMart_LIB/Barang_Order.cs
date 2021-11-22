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
			string sql = "insert into barang_order (jumlah, harga, order_id, barang_id) " +
				"values (" + bo.Jumlah + ", " + bo.Harga + ", " + bo.Order.Id + ", " + bo.Barang.Id + ")";

			int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
			if (jumlahDitambah == 0) return false;
			else return true;
		}

		public static List<Barang_Order> BacaPenjualanBarang(string cabang_id, string bulan, string tahun, Koneksi koneksi)
		{
			string sql = "SELECT order_id, barang_id, jumlah, harga FROM orders AS o INNER JOIN barang_order AS bo ON o.id = bo.order_id";

			// kalau cabang ada isinya
			if (cabang_id != "") sql += " where o.cabang_id = '" + cabang_id + "'";
			// kalau bulan ada isinya
			else if (bulan != "") sql += " where MONTH(o.tanggal_waktu) = '" + bulan + "'";
			// kalau tahun ada isinya
			else if (tahun != "") sql += " where YEAR(o.tanggal_waktu) = '" + tahun + "'";
			// kalau cabang dan bulan ada isinya
			else if (cabang_id != "" && bulan != "") sql += " where o.cabang_id = '" + cabang_id + "' and MONTH(o.tanggal_waktu) = '" + bulan + "'";
			// kalau cabang dan tahun ada isinya
			else if (cabang_id != "" && tahun != "") sql += " where o.cabang_id = '" + cabang_id + "' and YEAR(o.tanggal_waktu) = '" + tahun + "'";
			// kalau bulan dan tahun ada isinya
			else if (bulan != "" && tahun != "") sql += " where MONTH(o.tanggal_waktu) = '" + bulan + "' and YEAR(o.tanggal_waktu) = '" + tahun + "'";
			// kalau semua ada isinya
			else if (cabang_id != "" && bulan != "" && tahun != "") sql += " where o.cabang_id = '" + cabang_id + "' and MONTH(o.tanggal_waktu) = '" + bulan + "' and YEAR(o.tanggal_waktu) = '" + tahun + "'";

			MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql, koneksi);

			List<Barang_Order> listPenjualanBarang = new List<Barang_Order>();

			while(hasil.Read())
            {
				Order order = Order.AmbilData(long.Parse(hasil.GetInt32(0).ToString()));

				Barang barang = Barang.AmbilData(hasil.GetInt32(1));

				Barang_Order bo = new Barang_Order(barang, order, hasil.GetInt32(2), hasil.GetFloat(3));

				listPenjualanBarang.Add(bo);
            }

			return listPenjualanBarang;
		}
		#endregion
	}
}
