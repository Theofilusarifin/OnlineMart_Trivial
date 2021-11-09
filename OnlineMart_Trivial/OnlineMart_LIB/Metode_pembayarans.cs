using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
	class Metode_pembayarans
	{
		#region field
		private int id;
		private string name;
		#endregion

		#region constructor
		public Metode_pembayarans(int id, string name)
		{
			this.Id = id;
			this.Name = name;
		}
		#endregion

		#region property
		public int Id { get => id; set => id = value; }
		public string Name { get => name; set => name = value; }
		#endregion

		#region Method
		public static Boolean TambahData (Metode_pembayarans m)
		{
			string sql = "insert into metode_pembayarans (nama) " + "values ('" + m.Name + "')";

			int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
			if (jumlahDitambah == 0)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
		public static List<Metode_pembayarans> BacaData(string kriteria, string nilaiKriteria)
		{
			string sql = "";
			if (kriteria == "" && nilaiKriteria == "")
			{
				sql += "select * from metode_pembayarans"; //Apabila tidak ada kriteria
			}
			else
			{
				sql += "select id, nama from metode_pembayarans where " + kriteria + " like '%" + nilaiKriteria + "%'"; //Apabila ada kriteria
			}

			MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

			List<Metode_pembayarans> listPembayaran = new List<Metode_pembayarans>();
			while (hasil.Read())
			{
				Metode_pembayarans metode_Pembayarans = new Metode_pembayarans(hasil.GetInt32(0), hasil.GetString(1));

				listPembayaran.Add(metode_Pembayarans);
			}
			return listPembayaran;
		}
		#endregion
	}
}
