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
    }
}
