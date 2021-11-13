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
		private float minimal_belanja;
		#endregion

		#region constructor
		public Promo(int id, string tipe, string nama, int diskon, int diskon_max, float minimal_belanja)
		{
			this.Id = id;
			this.Tipe = tipe;
			this.Nama = nama;
			this.Diskon = diskon;
			this.Diskon_max = diskon_max;
			this.Minimal_belanja = minimal_belanja;
		}
		public Promo(string tipe, string nama, int diskon, int diskon_max, float minimal_belanja)
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
		public float Minimal_belanja 
		{
			get => minimal_belanja; 
			set => minimal_belanja = value;
		}
		#endregion

		#region Method
		public static void TambahData(Promo p)
		{
			string sql = "Insert into promos (tipe, nama, diskon, diskon_max, minimal_belanja) "
				+ " values('" + p.Tipe + "', '" + p.Nama + "', " + p.Diskon + ", " + p.Diskon_max + ", " + p.Minimal_belanja + ")";
			Koneksi.JalankanPerintahDML(sql);
		}

		public static List<Promo> BacaData(string kriteria, string nilaiKriteria)
		{
			string sql = "select id, tipe, nama, diskon, diskon_max, minimal_belanja from promos ";
			if (kriteria != "") sql += " where " + kriteria + " like '%" + nilaiKriteria + "%'";

			MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

			//Buat list untuk menampung data
			List<Promo> listpromo = new List<Promo>();

			while (hasil.Read())
			{
				Promo p = new Promo(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetInt32(3), hasil.GetInt32(4), hasil.GetFloat(5));

				listpromo.Add(p);
			}

			return listpromo;
		}
		
        public static Promo AmbilData(int id)
        {
            string sql = "select id, tipe, nama, diskon, diskon_max, minimal_belanja from promos where id = " + id;

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            hasil.Read();

			//kalau bisa/berhasil dibaca maka dimasukkin ke list pake constructors
			Promo p = new Promo(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetInt32(3), hasil.GetInt32(4), hasil.GetFloat(5));

			return p;
        }

        public static Boolean UbahData(Promo p)
        {
            // Querry Insert
            string sql = "update promos set tipe = '" + p.Tipe + "', nama = '" + p.Nama + "', diskon = " + p.Diskon + ", diskon_max = " + p.Diskon_max + ", minimal_belanja = " + p.Minimal_belanja + " where id = " + p.Id;
            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0) return false;
            else return true;
        }

		public static Boolean HapusData(int id)
		{
			string sql = "delete from promos where id = " + id;
			int jumlahDataDihapus = Koneksi.JalankanPerintahDML(sql);
			//Dicek apakah ada data yang berubah atau tidak
			if (jumlahDataDihapus == 0) return false;
			else return true;
		}
		#endregion
	}
}
