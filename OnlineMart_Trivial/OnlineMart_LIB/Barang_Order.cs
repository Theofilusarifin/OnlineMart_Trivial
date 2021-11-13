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
		#region field
		private Barang barang;
		private Order order;
		private int jumlah;
		private float harga;
        #endregion

        #region constructor
        public Barang_Order(Barang barang, Order order, int jumlah, float harga)
        {
            this.Barang = barang;
            this.Order = order;
            this.Jumlah = jumlah;
            this.Harga = harga;
        }
		#endregion

		#region property
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

		#region Method
		public static Boolean TambahData(Barang_Order bm)
		{
			string sql = "insert into barang_order (barang_id, order_id, jumlah, harga) " + "values (" + bm.Barang.Id + ", " + bm.Order.Id + ", " + bm.Jumlah  + ", " + bm.Harga + ")";

			int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
			if (jumlahDitambah == 0) return false;
			else return true;
		}
		public static List<Barang_Order> BacaData(string kriteria, string nilaiKriteria)
		{
			string sql = "select barang_id, order_id, jumlah, harga from barang_order";
			if (kriteria != "") //kalau tidak kosong tambahkan ini
			{
				sql += " where " + kriteria + " like '%" + nilaiKriteria + "%'";
			}

			MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

			List<Barang_Order> listBO = new List<Barang_Order>();
			//kalau bisa/berhasil dibaca maka dimasukkin ke list pake constructors
			while (hasil.Read() == true)
			{
				Barang b = Barang.AmbilData(hasil.GetInt32(0));

				Order o = Order.AmbilData(hasil.GetInt32(1));

				Barang_Order bo = new Barang_Order(b, o, hasil.GetInt32(2), hasil.GetFloat(3));

				listBO.Add(bo);
			}

			return listBO;
		}
		public static Metode_pembayaran AmbilData(int id)
		{
			string sql = "select id, nama from metode_pembayarans where id = " + id;

			MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

			hasil.Read();

			//kalau bisa/berhasil dibaca maka dimasukkin ke list pake constructors
			Metode_pembayaran m = new Metode_pembayaran(hasil.GetInt32(0), hasil.GetString(1));

			return m;
		}
		public static Boolean HapusData(int id)
		{
			string sql = "delete from metode_pembayarans where id = " + id;

			int jumlahDihapus = Koneksi.JalankanPerintahDML(sql);
			//Dicek apakah ada data yang berubah atau tidak
			if (jumlahDihapus == 0) return false;
			else return true;
		}
		public static Boolean UbahData(Metode_pembayaran m)
		{
			// Querry Insert
			string sql = "update metode_pembayarans set nama = '" + m.Nama + "' where id = " + m.Id;
			int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
			if (jumlahDitambah == 0) return false;
			else return true;
		}
		#endregion
	}
}
