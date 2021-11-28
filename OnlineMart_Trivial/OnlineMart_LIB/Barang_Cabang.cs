using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Barang_Cabang
    {
        #region Fields
        private Cabang cabang;
        private Barang barang;
        private int stok;

        #endregion

        #region Constructors
        public Barang_Cabang(Cabang cabang, Barang barang, int stok)
        {
            this.Cabang = cabang;
            this.Barang = barang;
            this.Stok = stok;
        }
        #endregion

        #region Properties
        public Cabang Cabang 
        { 
            get => cabang; 
            set => cabang = value; 
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

        #region Methods
        public static Boolean TambahData(Barang_Cabang bc)
        {
            // Querry Insert
            string sql = "insert into barang_cabang values (" + bc.Cabang.Id + ", " + bc.Barang.Id + ", " + bc.Stok + ")";

            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0) return false;
            else return true;
        }
        #endregion
    }
}
