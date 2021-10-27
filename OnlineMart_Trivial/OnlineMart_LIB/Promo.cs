using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{

	public class Promo
	{
		#region field
		private int id;
		private string tipe;
		private string nama;
		private int diskon;
		private int diskon_max;
		private double minimal_belanja;
		#endregion

		#region constructor
		public Promo(int id, string tipe, string nama, int diskon, int diskon_max, double minimal_belanja)
		{
			this.Id = id;
			this.Tipe = tipe;
			this.Nama = nama;
			this.Diskon = diskon;
			this.Diskon_max = diskon_max;
			this.Minimal_belanja = minimal_belanja;
		}
		public Promo(string tipe, string nama, int diskon, int diskon_max, double minimal_belanja)
		{
			this.Tipe = tipe;
			this.Nama = nama;
			this.Diskon = diskon;
			this.Diskon_max = diskon_max;
			this.Minimal_belanja = minimal_belanja;
		}
		#endregion

		#region property
		public int Id 
		{
			get => id; 
			set => id = value;
		}
		public string Tipe 
		{
			get => tipe; 
			set => tipe = value;
		}
		public string Nama 
		{
			get => nama;
			set => nama = value;
		}
		public int Diskon 
		{
			get => diskon;
			set => diskon = value;
		}
		public int Diskon_max 
		{
			get => diskon_max;
			set => diskon_max = value;
		}
		public double Minimal_belanja 
		{
			get => minimal_belanja; 
			set => minimal_belanja = value;
		}
		#endregion

		#region Method
		public static List<Promo> BacaData(string kriteria, string nilaiKriteria)
		{
			string sql = "";

			if (kriteria == "") //apabila kriteria kosong
			{
				sql = "select * from promos";
			}
			else
			{
				sql = "select * from promos where " + kriteria + " like '%" + nilaiKriteria + "%'";
			}

			MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

			List<Promo> listpromo = new List<Promo>();

			while (hasil.Read() == true)
			{
				Promo p = new Promo(int.Parse(hasil.GetValue(0).ToString()), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), int.Parse(hasil.GetValue(3).ToString()), int.Parse(hasil.GetValue(4).ToString()), int.Parse(hasil.GetValue(5).ToString()));
				//GetValue(0) menandakan kita mengambil data dari kolom pertama tabel promo dimana kolom pertama adalah kolom kode promo. GetValue(1) berarti kita mengambil data dari kolom ke 2 tabel promo dimana kolom kedua adalah kolom nama promo
				listpromo.Add(p);
			}
			return listpromo;
		}
		public static void TambahData(Promo p)
		{
			string sql = "Insert into promos (id, tipe, nama, diskon, diskon_max, minimal_belanja) " 
				+ " values('" + p.Id + "', '" + p.Tipe + "', '" + p.Nama + "', '" + p.Diskon + "', '" + p.Diskon_max + "', '" + p.Minimal_belanja + "')";
			Koneksi.JalankanPerintahDML(sql);
		}

		public static Boolean HapusData(string id)
		{
			string sql = "delete from promos where id='" + id + "'";
			int jumlahDataBerubah = Koneksi.JalankanPerintahDML(sql);

			if (jumlahDataBerubah == 0)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
		#endregion
	}
}
