using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
	public class Penilaian
	{
		private int id;
		private double rating;
		private string review;
		private Barang barang;

		public Penilaian(int id, double rating, string review, Barang barang)
		{
			this.Id = id;
			this.Rating = rating;
			this.Review = review;
			this.Barang = barang;
		}
		public Penilaian(double rating, string review, Barang barang)
		{
			this.Rating = rating;
			this.Review = review;
			this.Barang = barang;
		}
		public int Id { get => id; set => id = value; }
		public double Rating { get => rating; set => rating = value; }
		public string Review { get => review; set => review = value; }
		public Barang Barang { get => barang; set => barang = value; }

		public static Boolean TambahData(Penilaian p)
		{
			string sql = "insert into penilaians (id, rating review) values (" + p.Id + ", " + p.Rating + ", '" + p.Review + "')";
			int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
			if (jumlahDitambah == 0) return false;
			else return true;
		}
		public static Boolean UbahData(Penilaian p)
		{
			string sql = "update penilaians set rating = " + p.Rating + ", review = '" + p.Review + "' where id = " + p.Id;
			int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
			if (jumlahDitambah == 0) return false;
			else return true;
		}
		public static Boolean HapusData(Penilaian p)
		{
			string sql = "delete from penilaians where id = " + p.Id;
			int jumlahDihapus = Koneksi.JalankanPerintahDML(sql);
			//Dicek apakah ada data yang berubah atau tidak
			if (jumlahDihapus == 0) return false;
			else return true;
		}
		public static List<Penilaian> BacaData(string kriteria, string nilaiKriteria)
		{
			string sql = "select * from penilaians";
			if (kriteria != "review")
			{
				sql += " where " + kriteria + " = " + nilaiKriteria;
			}
			else if (kriteria == "")
			{
				sql = "select * from penilaians";
			}
			else
			{
				sql += " where " + kriteria + " like '%" + nilaiKriteria + "%'";
			}
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
			List<Penilaian> penilaians = new List<Penilaian>();
			while (hasil.Read())
			{
				Barang b = Barang.AmbilData(hasil.GetInt32(3));
				Penilaian p = new Penilaian(hasil.GetInt32(0), hasil.GetDouble(1), hasil.GetString(2), b);
				penilaians.Add(p);
			}
			return penilaians;
		}
		
	}
}
