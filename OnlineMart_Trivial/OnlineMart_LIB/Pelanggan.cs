using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Pelanggan
    {
		#region Field
		private int id;
        private string nama;
		private string username;
        private string email;
		private string password;
		private string telepon;
        private double saldo;
        private double poin;
		#endregion

		#region Constructor
		public Pelanggan(int id, string nama, string username, string email, string password, string telepon, double saldo, double poin)
		{
			this.Id = id;
			this.Nama = nama;
			this.Username = username;
			this.Email = email;
			this.Password = password;
			this.Telepon = telepon;
			this.Saldo = saldo;
			this.Poin = poin;
		}
		public Pelanggan(string nama, string username, string email, string password, string telepon)
		{
			this.Nama = nama;
			this.Username = username;
			this.Email = email;
			this.Password = password;
			this.Telepon = telepon;
			this.Saldo = 0;
			this.Poin = 0;
		}
		#endregion

		#region Properties
		public int Id 
		{ 
			get => id; 
			set => id = value; 
		}
		public string Nama 
		{ 
			get => nama;
			set
			{
				if (value != "")
				{
					nama = value;
				}
				else
				{
					throw (new ArgumentException("Tolong inputkan nama pelanggan"));
				}
			}
		}
		public string Username 
		{ 
			get => username;
			set
			{
				if (value != "")
				{
					username = value;
				}
				else
				{
					throw (new ArgumentException("Tolong inputkan username pelanggan"));
				}
			}
		}
		public string Email 
		{
			get => email;
			set
			{
				if (value != "")
				{
					email = value;
				}
				else
				{
					throw (new ArgumentException("Tolong inputkan email pelanggan"));
				}
			}
		}
		public string Password
		{
			get => password;
			set
			{
				if (value != "")
				{
					password = value;
				}
				else
				{
					throw (new ArgumentException("Tolong inputkan password pelanggan"));
				}
			}
		}
		public string Telepon
		{
			get => telepon;
			set
			{
				if (value != "")
				{
					telepon = value;
				}
				else
				{
					throw (new ArgumentException("Tolong inputkan telepon pelanggan"));
				}
			}
		}

		public double Saldo 
		{
			get => saldo; 
			set => saldo = value;
		}
		public double Poin 
		{
			get => poin; 
			set => poin = value;
		}
		#endregion

		#region METHODS
		public static Boolean TambahData(Pelanggan p)
		{
			// Querry Insert
			string sql = "insert into pelanggans (nama, username, email, password, telepon, saldo, poin) " +
				"values ('" + p.Nama + "', '" + p.Username + "', '" + p.Email + "', SHA2('" + p.Password + "', 512), '" + p.Telepon + "', " + p.Saldo + ", " + p.Poin + ")";

			int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
			if (jumlahDitambah == 0) return false;
			else return true;
		}

		public static List<Pelanggan> BacaData(string kriteria, string nilaiKriteria)
		{
			string sql = "select nama, username, email, password, telepon, saldo, poin from pelanggans ";
			if (kriteria != "") sql += " where " + kriteria + " like '%" + nilaiKriteria + "%'";

			MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

			//Buat list untuk menampung data
			List<Pelanggan> listPelanggan = new List<Pelanggan>();

			while (hasil.Read())
			{
				Pelanggan p = new Pelanggan(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetString(3), hasil.GetString(4), hasil.GetString(5), hasil.GetDouble(6), hasil.GetDouble(7));

				listPelanggan.Add(p);
			}

			return listPelanggan;
		}

		public static Boolean UbahData(Pelanggan p)
		{
			// Querry Insert
			string sql = "update pelanggans set nama = '" + p.Nama + "', username = '" + p.Username + "', email = '" + p.Email + "', password = SHA2('" + p.Password + "', 512), telepon = '" + p.Telepon + "' where id = " + p.Id;
			int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
			if (jumlahDitambah == 0) return false;
			else return true;
		}

		public static Boolean HapusData(Pelanggan p)
		{
			string sql = "delete from pelanggans where id = " + p.Id;
			int jumlahDataDihapus = Koneksi.JalankanPerintahDML(sql);
			//Dicek apakah ada data yang berubah atau tidak
			if (jumlahDataDihapus == 0) return false;
			else return true;
		}

		public static Pelanggan CekLogin(string username, string password)
		{
			string sql = "select id, nama, username, email, password, telepon, saldo, poin from pelanggans where username = '" + username + "' and password = SHA2('" + password + "', 512)";
			MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

			while (hasil.Read())
			{
				Pelanggan pelanggan = new Pelanggan(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetString(3), hasil.GetString(4), hasil.GetString(5), hasil.GetDouble(6), hasil.GetDouble(7));

				return pelanggan;
			}
			return null;
		}
		#endregion
	}
}
