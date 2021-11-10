using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Gift_Redeem
    {
		#region Field
		private int id;
		private DateTime waktu;
		private string poin_redeem;
		private Gift gift;
        #endregion

        #region Constructor
        public Gift_Redeem(int id, DateTime waktu, string poin_redeem, Gift gift)
        {
            this.Id = id;
            this.Waktu = waktu;
            this.Poin_redeem = poin_redeem;
            this.Gift = gift;
        }
		#endregion

		#region Property
		public int Id { get => id; set => id = value; }
		public DateTime Waktu { get => waktu; set => waktu = value; }
		public string Poin_redeem { get => poin_redeem; set => poin_redeem = value; }
		public Gift Gift { get => gift; set => gift = value; }
		#endregion

		#region METHODS
		public static Boolean TambahData(Driver driver)
		{
			// Querry Insert
			string sql = "insert into drivers (nama, username, email, password, telepon) " +
				"values ('" + driver.Nama + "', '" + driver.Username + "', '" + driver.Email + "', SHA2('" + driver.Password + "', 512), '" + driver.Telepon + "')";

			int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
			if (jumlahDitambah == 0) return false;
			else return true;
		}

		public static List<Driver> BacaData(string kriteria, string nilaiKriteria)
		{
			string sql = "select nama, username, email, password, telepon from drivers ";
			if (kriteria != "") sql += " where " + kriteria + " like '%" + nilaiKriteria + "%'";

			MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

			//Buat list untuk menampung data
			List<Driver> listDriver = new List<Driver>();

			while (hasil.Read())
			{
				Driver d = new Driver(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetString(3), hasil.GetString(4), hasil.GetString(5));

				listDriver.Add(d);
			}

			return listDriver;
		}

		public static Boolean UbahData(Driver d)
		{
			// Querry Insert
			string sql = "update drivers set nama = '" + d.Nama + "', username = '" + d.Username + "', email = '" + d.Email + "', password = SHA2('" + d.Password + "', 512), telepon = '" + d.Telepon + "' where id = " + d.Id;
			int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
			if (jumlahDitambah == 0) return false;
			else return true;
		}

		//Method untuk menghapus data Cabang
		public static Boolean HapusData(Driver d)
		{
			string sql = "delete from drivers where id = " + d.Id;

			int jumlahDataDihapus = Koneksi.JalankanPerintahDML(sql);
			//Dicek apakah ada data yang berubah atau tidak
			if (jumlahDataDihapus == 0) return false;
			else return true;
		}

		public static Driver CekLogin(string username, string password)
		{
			string sql = "select id, nama, username, email, password, telepon from drivers where username = '" + username + "' and password = SHA2('" + password + "', 512)";
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
