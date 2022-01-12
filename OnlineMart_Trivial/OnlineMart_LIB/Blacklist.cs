using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
	public class Blacklist
	{
        #region Fields
        private int id;
		private string jenis;
		private string alasan;
        #endregion

        #region Constructors
        public Blacklist(int id, string jenis, string alasan)
		{
			this.Id = id;
			this.Jenis = jenis;
			this.Alasan = alasan;
		}
		public Blacklist(string jenis, string alasan)
		{
			this.Id = id;
			this.Jenis = jenis;
			this.Alasan = alasan;
		}
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
		public string Jenis { get => jenis; set => jenis = value; }
		public string Alasan { get => alasan; set => alasan = value; }
        #endregion

        #region Methods
        public static Blacklist AmbilData(int id)
		{
			string sql = "select * from blacklists where id = " + id;
			MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
			Blacklist b = null;
			while (hasil.Read() == true)
			{
				b = new Blacklist(hasil.GetString(1), hasil.GetString(2));
			}
			return b;
		}

		public static Boolean UbahData(Blacklist b)
		{
			// Querry Insert
			string sql = "update blacklists set jenis = '" + b.Jenis + "', alasan = '" + b.Alasan + "' where id = " + b.Id;
			int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
			if (jumlahDitambah == 0) return false;
			else return true;
		}

		public static Boolean HapusData(int id)
		{
			string sql = "delete from blacklists where id = " + id;

			int jumlahDihapus = Koneksi.JalankanPerintahDML(sql);
			//Dicek apakah ada data yang berubah atau tidak
			if (jumlahDihapus == 0) return false;
			else return true;
		}

		public static Boolean TambahData(Blacklist b)
		{
			//string yang menampung sql query insert into
			string sql = "insert into blacklists (jenis, alasan) values ('" + b.Jenis + "', '" + b.Alasan + "')";

			//menjalankan perintah sql
			int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
			if (jumlahDitambah == 0) return false;
			else return true;
		}

		public static List<Blacklist> BacaData(string kriteria, string nilaiKriteria)
		{
			string sql = "select * from blacklists";
			//apabila kriteria tidak kosong
			if (kriteria != "" && kriteria != "id") sql += " where " + kriteria + " like '%" + nilaiKriteria + "%'";
			if (kriteria == "id") sql += " where id = " + nilaiKriteria;
			MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

			List<Blacklist> listBlacklist = new List<Blacklist>();
			Blacklist b = null;
			//kalau bisa/berhasil dibaca maka dimasukkin ke list pake constructors
			while (hasil.Read() == true)
			{
				b = new Blacklist(hasil.GetString(1), hasil.GetString(2));
				listBlacklist.Add(b);
            }

            return listBlacklist;
		}
        #endregion
    }
}
