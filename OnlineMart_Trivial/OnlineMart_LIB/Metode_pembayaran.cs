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
		#region field
		private int id;
		private string name;
		#endregion

		#region constructor
		public Metode_pembayaran(int id, string name)
		{
			this.Id = id;
			this.Name = name;
		}
		public Metode_pembayaran(string name)
		{
			this.Name = name;
		}
		#endregion

		#region property
		public int Id { get => id; set => id = value; }
		public string Name { get => name; set => name = value; }
		#endregion

		#region Method
		public static Boolean TambahData (Metode_pembayaran m)
		{
			string sql = "insert into metode_pembayarans (nama) " + "values ('" + m.Name + "')";

			int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
			if (jumlahDitambah == 0)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
		public static List<Metode_pembayaran> BacaData(string kriteria, string nilaiKriteria)
		{
			string sql = "";
			if (kriteria == "" && nilaiKriteria == "")
			{
				sql += "select * from metode_pembayarans"; //Apabila tidak ada kriteria
			}
			else if (kriteria == "nama")
			{
				sql += "select id, nama from metode_pembayarans where " + kriteria + " like '%" + nilaiKriteria + "%'"; //Apabila ada kriteria
			}
			else
			{
				sql += "select id, nama from metode_pembayarans where " + kriteria + " = " + nilaiKriteria; //Apabila ada kriteria
			}
			MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

			List<Metode_pembayaran> listPembayaran = new List<Metode_pembayaran>();
			while (hasil.Read())
			{
				Metode_pembayaran metode_Pembayarans = new Metode_pembayaran(hasil.GetInt32(0), hasil.GetString(1));

				listPembayaran.Add(metode_Pembayarans);
			}
			return listPembayaran;
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
			string sql = "update metode_pembayarans set nama = '" + m.Name + "' where id = " + m.Id;
			int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
			if (jumlahDitambah == 0) return false;
			else return true;
		}
		#endregion
	}
}
