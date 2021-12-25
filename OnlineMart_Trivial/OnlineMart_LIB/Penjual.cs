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
		private int id;
		private string username;
		private string nama;
		private string email;
		private string password;
		private string status;
		private string telpon;
		private Blacklist blacklist_id;

		public Penjual(int id, string username, string nama, string email, string password, string status, string telpon, Blacklist blacklist_id)
		{
			this.Id = id;
			this.Username = username;
			this.Nama = nama;
			this.Email = email;
			this.Password = password;
			this.Status = status;
			this.Telpon = telpon;
			this.Blacklist_id = blacklist_id;
		}
		public Penjual(string username, string nama, string email, string password, string status, string telpon, Blacklist blacklist_id)
		{
			this.Username = username;
			this.Nama = nama;
			this.Email = email;
			this.Password = password;
			this.Status = status;
			this.Telpon = telpon;
			this.Blacklist_id = blacklist_id;
		}

		public int Id { get => id; set => id = value; }
		public string Username { get => username; set => username = value; }
		public string Nama { get => nama; set => nama = value; }
		public string Email { get => email; set => email = value; }
		public string Password { get => password; set => password = value; }
		public string Status { get => status; set => status = value; }
		public string Telpon { get => telpon; set => telpon = value; }
		public Blacklist Blacklist_id { get => blacklist_id; set => blacklist_id = value; }

		public static Boolean TambahData(Penjual p)
		{
			//string yang menampung sql query insert into
			string sql = "insert into penjuals (username, nama, email, password, status, telpon, blacklist_id) values ('" + p.Username + "', '" + p.Nama + "', '" + p.Email + "', SHA2('" + p.Password +"', 512), '" + p.Status + "', '" + p.Telpon + "', " + p.Blacklist_id.Id + ")";

			//menjalankan perintah sql
			int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
			if (jumlahDitambah == 0) return false;
			else return true;
		}
		public static List<Penjual> BacaData(string kriteria, string nilaiKriteria)
		{
			string sql = "select * from penjuals p inner join blacklists b on b.id = p.blacklist_id ";
			//apabila kriteria tidak kosong
			if (kriteria != "" && kriteria != "id") sql += " where " + kriteria + " like '%" + nilaiKriteria + "%'";
			if (kriteria == "id") sql += " where id = " + nilaiKriteria;
			MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

			List<Penjual> listPenjual = new List<Penjual>();

			//kalau bisa/berhasil dibaca maka dimasukkin ke list pake constructors
			while (hasil.Read() == true)
			{
				Blacklist b = Blacklist.AmbilData(hasil.GetInt32(7));
				Penjual p = new Penjual(hasil.GetString(1), hasil.GetString(2), hasil.GetString(3), hasil.GetString(4), hasil.GetString(5), hasil.GetString(6), b);
				listPenjual.Add(p);
			}
			return listPenjual;
		}
		public static Boolean UbahData(Penjual p)
		{
			// Querry Insert
			string sql = "update penjuals set username = '" + p.Username + "', nama = '" + p.Nama + "', email = '" + p.Email + "', password = SHA2('" + p.Password + "', 512), status = '" + p.Status + "', telpon = '" + p.Telpon + "', blacklist_id = " + p.blacklist_id.Id + " where id = " + p.Id;
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
	}
}
