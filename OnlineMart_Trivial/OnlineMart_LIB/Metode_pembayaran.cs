using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
	public class Metode_pembayaran
	{
		#region Field
		private int id;
		private string nama;
		List<Order> listOrder; //Aggregation
		#endregion

		#region Constructor
		public Metode_pembayaran(int id, string nama)
		{
			Id = id;
			Nama = nama;
			ListOrder = new List<Order>();
		}
		public Metode_pembayaran(string nama)
		{
			Nama = nama;
			ListOrder = new List<Order>();
		}
		#endregion

		#region Property
		public int Id 
		{ 
			get => id; 
			set => id = value; 
		}
		public string Nama 
		{ 
			get => nama; 
			set => nama = value; 
		}
        public List<Order> ListOrder 
		{ 
			get => listOrder; 
			private set => listOrder = value; 
		}
        #endregion

        #region Method
        public static Boolean TambahData (Metode_pembayaran m)
		{
			string sql = "insert into metode_pembayarans (nama) values ('" + m.Nama + "')";

			int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
			if (jumlahDitambah == 0) return false;
			else return true;
		}
		public static List<Metode_pembayaran> BacaData(string kriteria, string nilaiKriteria)
		{
			string sql = "select id, nama from metode_pembayarans ";
			if (kriteria != "") sql += " where " + kriteria + " like '%" + nilaiKriteria + "%'";

			MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

			List<Metode_pembayaran> listMetodePembayaran = new List<Metode_pembayaran>();

			while (hasil.Read() == true)
			{
				Metode_pembayaran mp = new Metode_pembayaran(hasil.GetInt32(0), hasil.GetString(1));

				////Ambil Order
				//string order_join = "select o.id from orders as o inner join metode_pembayarans as mp on o.metode_pembayaran_id = mp.id where mp.id = " + mp.id;

				//MySqlDataReader hasil_join = Koneksi.JalankanPerintahQuery(order_join);

				//while (hasil_join.Read())
				//{
				//	Order o_join = Order.AmbilData(hasil_join.GetInt32(0));

				//	//Tambahkan hasil join ke aggregation relationship
				//	mp.ListOrder.Add(o_join);
				//}

				listMetodePembayaran.Add(mp);
			}

			hasil.Close();
			hasil.Dispose();

			return listMetodePembayaran;
		}

        public static Metode_pembayaran AmbilData(int id, Koneksi koneksi)
        {
            string sql = "select id, nama from metode_pembayarans where id = " + id;

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql, koneksi);

            Metode_pembayaran m = null;

            while (hasil.Read())
            {
                //kalau bisa/berhasil dibaca maka dimasukkin ke list pake constructors
                m = new Metode_pembayaran(hasil.GetInt32(0), hasil.GetString(1));
            }

            hasil.Close();
            hasil.Dispose();

            return m;
        }

        public static Boolean UbahData(Metode_pembayaran m)
		{
			// Querry Insert
			string sql = "update metode_pembayarans set nama = '" + m.Nama + "' where id = " + m.Id;
			int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
			if (jumlahDitambah == 0) return false;
			else return true;
		}

		public static Boolean HapusData(int id)
		{
			string sql = "delete from metode_pembayarans where id = " + id;

			int jumlahDihapus = Koneksi.JalankanPerintahDML(sql);
			//Dicek apakah ada data yang berubah atau tidak
			if (jumlahDihapus == 0) return false;
			else return true;
		}
		#endregion
	}
}
