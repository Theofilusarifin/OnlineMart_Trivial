using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
	public class Penjual
	{
		#region Fields
		private int id;
		private string username;
		private string nama;
		private string email;
		private string password;
		private string status;
		private string telpon;
		private Blacklist blacklist;
        #endregion

        #region Constructor
        public Penjual(int id, string username, string nama, string email, string password, string status, string telpon, Blacklist blacklist)
        {
            this.Id = id;
            this.Username = username;
            this.Nama = nama;
            this.Email = email;
            this.Password = password;
            this.Status = status;
            this.Telpon = telpon;
            this.Blacklist = blacklist;
        }

        public Penjual(string username, string nama, string email, string password, string status, string telpon, Blacklist blacklist)
        {
            this.Username = username;
            this.Nama = nama;
            this.Email = email;
            this.Password = password;
            this.Status = status;
            this.Telpon = telpon;
            this.Blacklist = blacklist;
        }

        public Penjual(int id, string username, string nama, string email, string password, string status, string telpon)
		{
			this.Id = id;
			this.Username = username;
			this.Nama = nama;
			this.Email = email;
			this.Password = password;
			this.Status = status;
			this.Telpon = telpon;
			this.Blacklist = null;
		}

		public Penjual(string username, string nama, string email, string password, string status, string telpon)
		{
			this.Username = username;
			this.Nama = nama;
			this.Email = email;
			this.Password = password;
			this.Status = status;
			this.Telpon = telpon;
			this.Blacklist = null;
		}
		#endregion

		#region Properties
		public int Id { get => id; set => id = value; }
		public string Username { get => username; set => username = value; }
		public string Nama { get => nama; set => nama = value; }
		public string Email { get => email; set => email = value; }
		public string Password { get => password; set => password = value; }
		public string Status { get => status; set => status = value; }
		public string Telpon { get => telpon; set => telpon = value; }
		public Blacklist Blacklist { get => blacklist; set => blacklist = value; }
		#endregion

		#region Method
		public static Boolean TambahData(Penjual p)
		{
			//string yang menampung sql query insert into
			string sql = "insert into penjuals (username, nama, email, password, status, telepon) " +
				         "values ('" + p.Username + "', '" + p.Nama + "', '" + p.Email + "', SHA2('" + p.Password +"', 512), '" +
						 p.Status + "', '" + p.Telpon + "')";

			//menjalankan perintah sql
			int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
			if (jumlahDitambah == 0) return false;
			else return true;
		}

		public static List<Penjual> BacaData(string kriteria, string nilaiKriteria)
		{
			string sql = "select * from penjuals p ";

			//apabila kriteria tidak kosong
			if (kriteria != "") sql += " where " + kriteria + " like '%" + nilaiKriteria + "%'";

			MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

			List<Penjual> listPenjual = new List<Penjual>();

			//kalau bisa/berhasil dibaca maka dimasukkin ke list pake constructors
			while (hasil.Read() == true)
			{
				Penjual p = new Penjual(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetString(3), hasil.GetString(4), hasil.GetString(5), hasil.GetString(6));
				listPenjual.Add(p);
			}

			return listPenjual;
		}

		public static Boolean UbahData(Penjual p)
		{
			// Querry Insert
			string sql = "update penjuals set username = '" + p.Username + "', nama = '" + p.Nama + "', email = '" + p.Email + "', status = '" + p.Status + "', telepon = '" + p.Telpon + "' where id = " + p.Id;
			int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
			if (jumlahDitambah == 0) return false;
			else return true;
		}

		public static Boolean UpdateBlacklist(Penjual p)
		{
			// Querry Insert
			string sql = "update penjuals set blacklist_id = " + Blacklist.AmbilIdTerakhir() + " where id = " + p.Id;
			int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
			if (jumlahDitambah == 0) return false;
			else return true;
		}

		public static Boolean HapusData(int id)
		{
			string sql = "delete from penjuals where id = " + id;

			int jumlahDihapus = Koneksi.JalankanPerintahDML(sql);
			//Dicek apakah ada data yang berubah atau tidak
			if (jumlahDihapus == 0) return false;
			else return true;
		}

		public static Penjual CekLogin(string username, string password)
		{
			string sql = "select id, username, nama, email, password, status, telepon from penjuals where username = '" + username + "' and password = SHA2('" + password + "', 512) and blacklist_id is NULL and status = 'OK' ";
			MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

			while (hasil.Read())
			{
				Penjual penjual = new Penjual(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetString(3), hasil.GetString(4), hasil.GetString(5), hasil.GetString(6));

				return penjual;
			}

			return null;
		}

		public static Penjual AmbilData(int id)
		{
			string sql = "select id, username, nama, email, password, status, telepon from penjuals where id = " + id;
			MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

			while (hasil.Read())
			{
				Penjual penjual = new Penjual(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetString(3), hasil.GetString(4), hasil.GetString(5), hasil.GetString(6));

				return penjual;
			}
			return null;
		}

		public static Penjual AmbilPertama()
		{
			string sql = "select * from penjuals p left join blacklists b on p.blacklist_id = b.id limit 1";

			MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

			Penjual p = null;

			while (hasil.Read())
			{
				p = new Penjual(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetString(3), hasil.GetString(4), hasil.GetString(5), hasil.GetString(6));
			}

			return p;
		}

		public static Boolean RemoveBlacklist(Penjual p)
		{
			// Querry Insert
			string sql = "update penjuals set blacklist_id = NULL where id = " + p.Id;
			int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
			if (jumlahDitambah == 0) return false;
			else return true;
		}
		#endregion
	}
}
