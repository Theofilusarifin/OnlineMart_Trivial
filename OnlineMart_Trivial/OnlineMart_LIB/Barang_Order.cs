﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace OnlineMart_LIB
{
    public class Barang_Order
    {
		#region Field
		private Barang barang;
		private Order order;
		private int jumlah;
		private float harga;
        #endregion

        #region Constructor
        public Barang_Order(Barang barang, Order order, int jumlah, float harga)
        {
            this.Barang = barang;
            this.Order = order;
            this.Jumlah = jumlah;
            this.Harga = harga;
        }
		#endregion

		#region Property
		public Barang Barang 
		{ 
			get => barang; 
			set => barang = value; 
		}
		public Order Order 
		{ 
			get => order; 
			set => order = value; 
		}
		public int Jumlah 
		{ 
			get => jumlah; 
			set => jumlah = value; 
		}
		public float Harga 
		{ 
			get => harga; 
			set => harga = value; 
		}
		#endregion

		#region Methods
		public static Boolean TambahData(Barang_Order bo)
		{
			// Querry Insert
			string sql = "insert into barang_order (jumlah, harga, order_id, barang_id) " +
				"values (" + bo.Jumlah + ", " + bo.Harga + ", " + bo.Order.Id + ", " + bo.Barang.Id + ")";

			int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
			if (jumlahDitambah == 0) return false;
			else return true;
		}
		#endregion
	}
}
