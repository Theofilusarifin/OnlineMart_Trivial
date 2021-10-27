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
		public Pelanggan (int id1)
		{
			this.Id = id1;
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
			set => nama = value;
		}
		public string Username 
		{ 
			get => username; 
			set => username = value; 
		}
		public string Email 
		{
			get => email; 
			set => email = value;
		}
		public string Password
		{
			get => password;
			set => password = value;
		}
		public string Telepon 
		{
			get => telepon; 
			set => telepon = value;
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
		public static void TambahData(Pelanggan pelanggan)
		{
			// Querry Insert
			string sql = "INSERT into pelanggans (nama, username, email, password, telepon) " +
				"VALUES ('" + pelanggan.Nama + "', '" + pelanggan.Username + "', '" + pelanggan.Email + "', SHA2('" + pelanggan.password + "', 512), '" + pelanggan.telepon + "')";

			Koneksi.JalankanPerintahDML(sql);
		}

		public static List<Pelanggan> BacaData(string kriteria, string nilaiKriteria)
		{
			string sql = "SELECT nama, username, email, password, telepon, saldo, poin,  FROM pelanggans ";
			if (kriteria != "") sql += "WHERE " + kriteria + " LIKE '%" + nilaiKriteria + "%'";

			MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

			//Buat list untuk menampung data
			List<Pelanggan> listPelanggan = new List<Pelanggan>();

			while (hasil.Read())
			{
				Pelanggan pelanggan = new Pelanggan(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetString(3), hasil.GetString(4), hasil.GetString(5), hasil.GetDouble(6), hasil.GetDouble(7));

				listPelanggan.Add(pelanggan);
			}

			return listPelanggan;
		}

		public static Pelanggan CekLogin(string username, string password)
		{
			string sql = "SELECT id, nama, username, email, password, telepon, saldo, poin FROM pelanggans WHERE username = '" + username + "' AND password = SHA2('" + password + "', 512)";
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
