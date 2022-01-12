using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Tambahkan ini untuk dapat memanggil private data member
using MySql.Data.MySqlClient;

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

		public static List<Barang> BacaData(string kriteria, string nilaiKriteria, int id)
		{
			string sql = "select b.*, k.* from barang b " +
				"inner join barang_penjual bp on b.id = bp.barang_id " +
				"inner join kategoris k on b.kategori_id = k.id " +
				"where bp.penjual_id = " + id;
			if (kriteria != "")
			{
				sql += " and " + kriteria + " like%'" + nilaiKriteria + "%'";
			}
			MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

			List<Barang> listBarang = new List<Barang>();

			//kalau bisa/berhasil dibaca maka dimasukkin ke list pake constructors
			while (hasil.Read() == true)
			{
				Kategori k = new Kategori(hasil.GetInt32(6), hasil.GetString(7));

				Barang b = new Barang(hasil.GetInt32(0), hasil.GetString(1), hasil.GetInt32(2), hasil.GetString(3), hasil.GetString(4), k);

				listBarang.Add(b);
			}

			//hasil.Dispose();
			//hasil.Close();

			return listBarang;
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
