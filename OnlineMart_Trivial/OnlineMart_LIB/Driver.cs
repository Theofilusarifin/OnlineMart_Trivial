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
		#endregion

		#region Constructor
		public Driver(int id1)
		{
			this.Id = id1;
		}
		public Driver(int id, string nama, string username, string email, string password, string telepon)
		{
			this.Id = id;
			this.Nama = nama;
			this.Username = username;
			this.Email = email;
			this.Password = password;
			this.Telepon = telepon;
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
        #endregion

        #region METHODS
        public static void TambahData(Driver driver)
        {
            // Querry Insert
            string sql = "INSERT into drivers (nama, username, email, password, telepon) " +
                "VALUES ('" + driver.Nama + "', '" + driver.Username + "', '" + driver.Email + "', SHA2('" + driver.password + "', 512), '" + driver.telepon + "')";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static List<Driver> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "SELECT nama, username, email, password, telepon, FROM drivers ";
            if (kriteria != "") sql += "WHERE " + kriteria + " LIKE '%" + nilaiKriteria + "%'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            //Buat list untuk menampung data
            List<Driver> listDriver = new List<Driver>();

            while (hasil.Read())
            {
				Driver driver = new Driver(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetString(3), hasil.GetString(4), hasil.GetString(5));

                listDriver.Add(driver);
            }

            return listDriver;
        }

        public static Driver CekLogin(string username, string password)
        {
			string sql = "SELECT nama, username, email, password, telepon, FROM drivers WHERE username = '" + username + "' AND password = SHA2('" + password + "', 512";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            while (hasil.Read())
            {
				Driver driver = new Driver(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetString(3), hasil.GetString(4), hasil.GetString(5));

				return driver;
            }
            return null;
        }

        #endregion
    }
}
