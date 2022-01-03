using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMart_LIB
{
	public class Penilaian
	{
		private int id;
		private double rating;
		private string review;

		public Penilaian(int id, double rating, string review)
		{
			this.Id = id;
			this.Rating = rating;
			this.Review = review;
		}
		public Penilaian(double rating, string review)
		{
			this.Rating = rating;
			this.Review = review;
		}
		public int Id { get => id; set => id = value; }
		public double Rating { get => rating; set => rating = value; }
		public string Review { get => review; set => review = value; }

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
	}
}
