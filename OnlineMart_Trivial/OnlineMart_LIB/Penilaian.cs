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
		#region Field
		private int id;
		private double rating;
		private string review;
		private Barang barang;
		#endregion

		#region Constructor
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
		#endregion

		#region Properties
		public int Id { get => id; set => id = value; }
		public double Rating { get => rating; set => rating = value; }
		public string Review { get => review; set => review = value; }
		public Barang Barang { get => barang; set => barang = value; }
		#endregion

		#region Method
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
			string sql;
			if (kriteria != "")
			{
				if (kriteria != "review")
				{
					sql = "select p.id, p.rating, p.review, p.barang_id from penilaians p " +
						"inner join barangs b on p.barang_id = b.id where p." + kriteria + " = " + nilaiKriteria;
				}
				else
				{
					sql = "select * from penilaians p " +
						"inner join barangs b on p.barang_id = b.id where p." + kriteria + " like '%" + nilaiKriteria + "%'";
				}
			}
			else
			{
				sql = "select * from penilaians";
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
		#endregion
	}
}
