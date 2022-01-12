// Tambahkan ini untuk dapat memanggil private data member
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace OnlineMart_LIB
{
    public class Barang_Penjual
	{
		#region Field
		private Penjual penjual;
		private Barang barang;
		private int stok;
		#endregion

		#region Constructor
		public Barang_Penjual(Penjual penjual, Barang barang, int stok)
		{
			this.Penjual = penjual;
			this.Barang = barang;
			this.Stok = stok;
		}
		#endregion

		#region Properties
		public Penjual Penjual 
		{ 
			get => penjual; 
			set => penjual = value; 
		}
		public Barang Barang 
		{ 
			get => barang;
			set => barang = value; 
		}
		public int Stok 
		{ 
			get => stok; 
			set => stok = value; 
		}
		#endregion

		#region Method
		public static Boolean TambahProdukPenjual(Barang_Penjual b)
		{
			string sql = "insert into barang_penjual (penjual_id, barang_id, stok) values (" + b.Penjual.Id + ", " + b.Barang.Id + ", " + b.Stok + ")";
			int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
			if (jumlahDitambah == 0) return false;
			else return true;
		}

		public static List<Barang_Penjual> BacaData(string kriteria, string nilaiKriteria, int penjual_id)
		{
			string sql = "select * from barang_penjual bp " +
						 "inner join penjuals p on bp.penjual_id = p.id " +
						 "inner join blacklists bl on p.blacklist_id = bl.id " +
						 "inner join barangs ba on bp.barang_id = ba.id " +
						 "inner join kategoris k on ba.kategori_id = k.id " +
						 "where bp.penjual_id = " + penjual_id;

			if (kriteria != "")	sql += " and " + kriteria + " like '%" + nilaiKriteria + "%'";

			MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

			List<Barang_Penjual> listBarangPenjual = new List<Barang_Penjual>();

			//kalau bisa/berhasil dibaca maka dimasukkin ke list pake constructors
			while (hasil.Read() == true)
			{
				Kategori k = new Kategori(hasil.GetInt32(20), hasil.GetString(21));

				Barang ba = new Barang(hasil.GetInt32(14), hasil.GetString(15), hasil.GetInt32(16), hasil.GetString(17), hasil.GetString(18), k);

				Blacklist bl = new Blacklist(hasil.GetInt32(11), hasil.GetString(12), hasil.GetString(13));

				Penjual p = new Penjual(hasil.GetInt32(3), hasil.GetString(4), hasil.GetString(5), hasil.GetString(6), hasil.GetString(7), hasil.GetString(8), hasil.GetString(9));

				Barang_Penjual bp = new Barang_Penjual(p, ba, int.Parse(hasil.GetString(2)));

				listBarangPenjual.Add(bp);
			}

			//hasil.Dispose();
			//hasil.Close();

			return listBarangPenjual;
		}

		public static bool UpdateStok(Barang b, Penjual p, int stok)
		{
			string sql = "update barang_penjual set stok = stok + " + stok + " where barang_id = " + b.Id + " and penjual_id = " + p.Id;
			int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
			if (jumlahDitambah == 0) return false;
			else return true;
		}
		#endregion
	}
}
