using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Driver
    {
		#region Field
		private int id;
        private string nama;
		private string username;
		private string email;
        private string password;
        private string telepon;
		List<Order> listOrder; //Aggregation
		#endregion

		#region Constructor
		public Driver(int id, string nama, string username, string email, string password, string telepon)
		{
			Id = id;
			Nama = nama;
			Username = username;
			Email = email;
			Password = password;
			Telepon = telepon;
			ListOrder = new List<Order>();
		}
		public Driver(string nama, string username, string email, string password, string telepon)
		{
			Nama = nama;
			Username = username;
			Email = email;
			Password = password;
			Telepon = telepon;
			ListOrder = new List<Order>();
		}
		#endregion

		#region Property
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
					throw (new ArgumentException("Tolong inputkan nama driver"));
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
					throw (new ArgumentException("Tolong inputkan username driver"));
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
					throw (new ArgumentException("Tolong inputkan email driver"));
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
					throw (new ArgumentException("Tolong inputkan password driver"));
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
					throw (new ArgumentException("Tolong inputkan telepon driver"));
				}
			}
		}

        public List<Order> ListOrder 
		{ 
			get => listOrder; 
			private set => listOrder = value; 
		}
        #endregion

        #region Methods
        public static Boolean TambahData(Driver driver, Koneksi kParram)
        {
            // Querry Insert
            string sql = "insert into drivers (nama, username, email, password, telepon) " +
                "values ('" + driver.Nama + "', '" + driver.Username + "', '" + driver.Email + "', SHA2('" + driver.Password + "', 512), '" + driver.Telepon + "')";

			int jumlahDitambah = Koneksi.JalankanPerintahDML(sql, kParram);
			if (jumlahDitambah == 0) return false;
			else return true;
		}

		public static List<Driver> BacaData(string kriteria, string nilaiKriteria, Koneksi kParram)
		{
			string sql = "select * from drivers ";
			if (kriteria != "") sql += " where " + kriteria + " like '%" + nilaiKriteria + "%'";

			MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql, kParram);

			//Buat list untuk menampung data
			List<Driver> listDriver = new List<Driver>();

			while (hasil.Read())
			{
				Driver d = new Driver(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetString(3), hasil.GetString(4), hasil.GetString(5));

				listDriver.Add(d);
			}

			hasil.Dispose();
			hasil.Close();

			return listDriver;
		}

        public static Driver AmbilData(int id)
        {
            string sql = "select id, username, nama, email, password, telepon from drivers where id = " + id;

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            Driver d = null;

            while (hasil.Read())
            {
                d = new Driver(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetString(3), hasil.GetString(4), hasil.GetString(5));
            }
            return d;
        }

        public static Boolean UbahData(Driver d, Koneksi kParram)
		{
			// Querry
			string sql = "update drivers set nama = '" + d.Nama + "', username = '" + d.Username + "', email = '" + d.Email + "', password = SHA2('" + d.Password + "', 512), telepon = '" + d.Telepon + "' where id = " + d.Id;
			int jumlahDitambah = Koneksi.JalankanPerintahDML(sql, kParram);
			if (jumlahDitambah == 0) return false;
			else return true;
		}

		//Method untuk menghapus data Cabang
		public static Boolean HapusData(Driver d, Koneksi kParram)
		{
			string sql = "delete from drivers where id = " + d.Id;

			int jumlahDataDihapus = Koneksi.JalankanPerintahDML(sql, kParram);
			//Dicek apakah ada data yang berubah atau tidak
			if (jumlahDataDihapus == 0) return false;
			else return true;
		}

		public static Driver CekLogin(string username, string password, Koneksi kParram)
        {
			string sql = "select id, nama, username, email, password, telepon from drivers where username = '" + username + "' and password = SHA2('" + password + "', 512)";
			MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql, kParram);

            while (hasil.Read())
            {
				Driver driver = new Driver(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetString(3), hasil.GetString(4), hasil.GetString(5));

				hasil.Close();
				hasil.Dispose();

				return driver;
            }

			hasil.Close();
			hasil.Dispose();

			return null;
        }
        #endregion
    }
}
