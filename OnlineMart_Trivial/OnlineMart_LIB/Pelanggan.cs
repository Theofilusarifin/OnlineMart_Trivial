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
		List<Order> listOrder; //Aggregation
		List<Riwayat_isi_saldo> listRiwayatIsiSaldo; //Aggregation
		#endregion

		#region Constructor
		public Pelanggan(int id, string nama, string username, string email, string password, string telepon, double saldo, double poin)
		{
			Id = id;
			Nama = nama;
			Username = username;
			Email = email;
			Password = password;
			Telepon = telepon;
			Saldo = saldo;
			Poin = poin;
			ListOrder = new List<Order>();
			ListRiwayatIsiSaldo = new List<Riwayat_isi_saldo>();
		}
		public Pelanggan(string nama, string username, string email, string password, string telepon)
		{
			Id = id;
			Nama = nama;
			Username = username;
			Email = email;
			Password = password;
			Telepon = telepon;
			Saldo = 0;
			Poin = 0;
			ListOrder = new List<Order>();
			ListRiwayatIsiSaldo = new List<Riwayat_isi_saldo>();
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
        public List<Order> ListOrder 
		{ 
			get => listOrder;
			private set => listOrder = value; 
		}
        public List<Riwayat_isi_saldo> ListRiwayatIsiSaldo 
		{ 
			get => listRiwayatIsiSaldo; 
			private set => listRiwayatIsiSaldo = value; 
		}
        #endregion

        #region Methods
        public static Boolean TambahData(Pelanggan p)
		{
			// Querry Insert
			string sql = "insert into pelanggans (nama, username, email, password, telepon, saldo, poin) " +
				"values ('" + p.Nama + "', '" + p.Username + "', '" + p.Email + "', SHA2('" + p.Password + "', 512), '" + p.Telepon + "', " + p.Saldo + ", " + p.Poin + ")";

			int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
			if (jumlahDitambah == 0) return false;
			else return true;
		}

		public static List<Pelanggan> BacaData(string kriteria, string nilaiKriteria, Koneksi kParram)
		{
			string sql = "select nama, username, email, password, telepon, saldo, poin from pelanggans ";
			if (kriteria != "") sql += " where " + kriteria + " like '%" + nilaiKriteria + "%'";

			MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql, kParram);

			//Buat list untuk menampung data
			List<Pelanggan> listPelanggan = new List<Pelanggan>();

			while (hasil.Read())
			{
				Pelanggan p = new Pelanggan(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetString(3), hasil.GetString(4), hasil.GetString(5), hasil.GetDouble(6), hasil.GetDouble(7));

				////Ambil Order
				//string order_join = "select o.id from orders as o inner join pelanggans as p on o.pelanggan_id = p.id where p.id = " + p.id;

				//MySqlDataReader hasil_join = Koneksi.JalankanPerintahQuery(order_join);

				//while (hasil_join.Read())
				//{
				//	Order o_join = Order.AmbilData(hasil_join.GetInt32(0));

				//	//Tambahkan hasil join ke aggregation relationship
				//	p.ListOrder.Add(o_join);
				//}

				////Ambil Riwayat Isi Saldo
				//string riwayat_join = "select rwi.id from riwayat_isi_saldos as rwi inner join pelanggans as p on rwi.pelanggan_id = p.id where p.id = " + p.id;

				//MySqlDataReader hasil_join2 = Koneksi.JalankanPerintahQuery(riwayat_join);

				//while (hasil_join2.Read())
				//{
				//	Riwayat_isi_saldo rwi_join = Riwayat_isi_saldo.AmbilData(hasil_join2.GetInt32(0));

				//	//Tambahkan hasil join ke aggregation relationship
				//	p.ListRiwayatIsiSaldo.Add(rwi_join);
				//}

				listPelanggan.Add(p);
			}

			return listPelanggan;
		}
		public static Pelanggan AmbilData(int id, Koneksi koneksi)
		{
			string sql = "select id, nama, username, email, password, telepon, saldo, poin from pelanggans where id = " + id;

			MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql, koneksi);

			Pelanggan p = null;

			while (hasil.Read())
			{
				p = new Pelanggan(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetString(3), hasil.GetString(4), hasil.GetString(5), hasil.GetDouble(6), hasil.GetDouble(7));
			}

			hasil.Close();
			hasil.Dispose();

			return p;
		}

		public static Boolean UbahData(Pelanggan p)
		{
			// Querry Insert
			string sql = "update pelanggans set nama = '" + p.Nama + "', username = '" + p.Username + "', email = '" + p.Email + "', password = SHA2('" + p.Password + "', 512), telepon = '" + p.Telepon + "' where id = " + p.Id;
			int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
			if (jumlahDitambah == 0) return false;
			else return true;
		}

        public static Boolean TambahSaldo(Pelanggan p, int penambahanSaldo)
        {
            string sql = "update pelanggans set saldo = saldo + " + penambahanSaldo + " where id = " + p.Id;
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

		public static Pelanggan CekLogin(string username, string password, Koneksi kParram)
		{
			string sql = "select id, nama, username, email, password, telepon, saldo, poin from pelanggans where username = '" + username + "' and password = SHA2('" + password + "', 512)";
			MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql, kParram);

			while (hasil.Read())
			{
				Pelanggan pelanggan = new Pelanggan(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetString(3), hasil.GetString(4), hasil.GetString(5), hasil.GetDouble(6), hasil.GetDouble(7));

				return pelanggan;
			}

			hasil.Close();
			hasil.Dispose();
			
			return null;
		}
		#endregion
	}
}
