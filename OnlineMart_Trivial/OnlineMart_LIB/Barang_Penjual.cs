using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMart_LIB
{
	public class Barang_Penjual
	{
		private Penjual penjual;
		private Barang barang;
		private int stok;

		public Barang_Penjual(Penjual penjual, Barang barang, int stok)
		{
			this.Penjual = penjual;
			this.Barang = barang;
			this.Stok = stok;
		}

		public Penjual Penjual { get => penjual; set => penjual = value; }
		public Barang Barang { get => barang; set => barang = value; }
		public int Stok { get => stok; set => stok = value; }

		public static Boolean TambahProdukPenjual(Barang_Penjual b)
		{
			string sql = "insert into barang_penjual (penjual_id, barang_id, stok) values (" + b.Penjual.Id + ", " + b.Barang.Id + ", " + b.Stok + ")";
			int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
			if (jumlahDitambah == 0) return false;
			else return true;
		}
	}
}
