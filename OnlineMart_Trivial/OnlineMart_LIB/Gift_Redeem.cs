﻿using System;
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
		private int poin_redeem;
		private Gift gift; //Aggregation
		List<Order> listOrder; //Aggregation
		#endregion

		#region Constructor
		public Gift_Redeem(int id)
		{
			Id = id;
		}
		public Gift_Redeem(int id, DateTime waktu, int poin_redeem, Gift gift)
        {
            Id = id;
            Waktu = waktu;
            Poin_redeem = poin_redeem;
            Gift = gift;
			ListOrder = new List<Order>();
		}
		public Gift_Redeem(DateTime waktu, int poin_redeem, Gift gift)
		{
			Waktu = waktu;
			Poin_redeem = poin_redeem;
			Gift = gift;
			ListOrder = new List<Order>();
		}
		#endregion

		#region Property
		public int Id 
		{ 
			get => id; 
			set => id = value; 
		}
		public DateTime Waktu 
		{ 
			get => waktu; 
			set => waktu = value; 
		}
		public int Poin_redeem 
		{ 
			get => poin_redeem; 
			set => poin_redeem = value; 
		}
		public Gift Gift 
		{ 
			get => gift; 
			set => gift = value; 
		}
        public List<Order> ListOrder 
		{ 
			get => listOrder; 
			private set => listOrder = value; 
		}
        #endregion

        #region Methods
        public static Boolean TambahData(Gift_Redeem gr)
		{
			// Querry Insert
			string sql = "Insert into gift_redeems (id, waktu, poin_redeem, gift_id) values (" + gr.Id + ", '" + gr.Waktu.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + gr.Poin_redeem + "', " + gr.Gift.Id + ")";

			//menjalankan perintah SQL
			int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
			if (jumlahDitambah == 0) return false;
			else return true;
		}

		public static List<Gift_Redeem> BacaData(string kriteria, string nilaiKriteria)
		{
			string sql = "select * from gift_redeems gr inner join gifts g on gr.gift_id = g.id ";
			if (kriteria != "") sql += " where " + kriteria + " like '%" + nilaiKriteria + "%'";

			MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

			//Buat list untuk menampung data
			List<Gift_Redeem> listGiftRedeem = new List<Gift_Redeem>();

			while (hasil.Read())
			{
				Gift g = new Gift(hasil.GetInt32(4), hasil.GetString(5), hasil.GetInt32(6));

				Gift_Redeem gr = new Gift_Redeem(hasil.GetInt32(0), DateTime.Parse(hasil.GetString(1)), hasil.GetInt32(2), g);

				listGiftRedeem.Add(gr);
			}

			return listGiftRedeem;
		}

		public static Gift_Redeem AmbilData(int id)
        {
            string sql = "select * from gift_redeems gr inner join gifts g on gr.gift_id = g.id where gr.id = " + id;

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            Gift g = null;
            Gift_Redeem gr = null;

            while (hasil.Read())
            {
				g = new Gift(hasil.GetInt32(4), hasil.GetString(5), hasil.GetInt32(6));

				gr = new Gift_Redeem(hasil.GetInt32(0), DateTime.Parse(hasil.GetString(1)), hasil.GetInt32(2), g);
			}
            return gr;
        }

        public static Boolean UbahData(Gift_Redeem gr)
		{
			// Querry Insert
			string sql = "update gift_redeems set waktu = '" + gr.Waktu.ToString("yyyy-MM-dd HH:mm:ss") + "', poin_redeem = '" + gr.Poin_redeem + "', gift_id = " + gr.Gift.Id + " where id = " + gr.Id;
			int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
			if (jumlahDitambah == 0) return false;
			else return true;
		}

		//Method untuk menghapus data Cabang
		public static Boolean HapusData(Gift_Redeem gr)
		{
			string sql = "delete from gift_redeems where id = " + gr.Id;

			int jumlahDataDihapus = Koneksi.JalankanPerintahDML(sql);
			//Dicek apakah ada data yang berubah atau tidak
			if (jumlahDataDihapus == 0) return false;
			else return true;
		}
		#endregion
	}
}
