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
		#region Fields
		private int id;
		private string tipe;
		private string nama;
		private int diskon;
		private int diskon_max;
		private float minimal_belanja;
		List<Order> listOrder; //Aggregation
		#endregion

		#region Constructors
		public Promo(int id, string tipe, string nama, int diskon, int diskon_max, float minimal_belanja)
		{
			Id = id;
			Tipe = tipe;
			Nama = nama;
			Diskon = diskon;
			Diskon_max = diskon_max;
			Minimal_belanja = minimal_belanja;
			ListOrder = new List<Order>();
		}
		public Promo(string tipe, string nama, int diskon, int diskon_max, float minimal_belanja)
		{
			Tipe = tipe;
			Nama = nama;
			Diskon = diskon;
			Diskon_max = diskon_max;
			Minimal_belanja = minimal_belanja;
			ListOrder = new List<Order>();
		}
		#endregion

		#region Properties
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
        public List<Order> ListOrder 
		{ 
			get => listOrder; 
			private set => listOrder = value; 
		}
        #endregion

        #region Methods
        public static Boolean TambahData(Promo p, Koneksi kParram)
		{
			string sql = "insert into promos (tipe, nama, diskon, diskon_max, minimal_belanja) "
				+ " values('" + p.Tipe + "', '" + p.Nama + "', " + p.Diskon + ", " + p.Diskon_max + ", " + p.Minimal_belanja + ")";

			int jumlahDitambah = Koneksi.JalankanPerintahDML(sql, kParram);
			if (jumlahDitambah == 0) return false;
			else return true;
		}

		public static List<Promo> BacaData(string kriteria, string nilaiKriteria, Koneksi kParram)
		{
			string sql = "select id, tipe, nama, diskon, diskon_max, minimal_belanja from promos ";
			if (kriteria != "") sql += " where " + kriteria + " like '%" + nilaiKriteria + "%'";

			MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql, kParram);

			//Buat list untuk menampung data
			List<Promo> listpromo = new List<Promo>();

			while (hasil.Read())
			{
				Promo p = new Promo(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetInt32(3), hasil.GetInt32(4), hasil.GetFloat(5));

				listpromo.Add(p);
			}

			hasil.Dispose();
			hasil.Close();

			return listpromo;
		}

        public static Promo AmbilData(int id)
        {
            string sql = "select id, tipe, nama, diskon, diskon_max, minimal_belanja from promos where id = " + id;

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            Promo p = null;

            while (hasil.Read())
            {
                p = new Promo(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetInt32(3), hasil.GetInt32(4), hasil.GetFloat(5));
            }

            return p;
        }

        public static Boolean UbahData(Promo p, Koneksi kParram)
        {
            // Querry Insert
            string sql = "update promos set tipe = '" + p.Tipe + "', nama = '" + p.Nama + "', diskon = " + p.Diskon + ", diskon_max = " + p.Diskon_max + ", minimal_belanja = " + p.Minimal_belanja + " where id = " + p.Id;
            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql, kParram);
            if (jumlahDitambah == 0) return false;
            else return true;
        }

		public static Boolean HapusData(int id, Koneksi kParram)
		{
			string sql = "delete from promos where id = " + id;
			int jumlahDataDihapus = Koneksi.JalankanPerintahDML(sql, kParram);
			//Dicek apakah ada data yang berubah atau tidak
			if (jumlahDataDihapus == 0) return false;
			else return true;
		}
		#endregion
	}
}
