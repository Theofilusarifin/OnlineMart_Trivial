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

        public static List<Barang_Cabang> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "select * from barang_cabang bc " +
                         "inner join cabangs c on bc.cabang_id = c.id " +
                         "inner join pegawais p on c.pegawai_id = p.id " +
                         "inner join barangs b on bc.barang_id = b.id;";

            if (kriteria != "") sql += " where " + kriteria + " like '%" + nilaiKriteria + "%'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Barang_Cabang> listBarangCabang = new List<Barang_Cabang>();

            while (hasil.Read())
            {
                Pegawai pegawai = new Pegawai(hasil.GetInt32(7), hasil.GetString(8), hasil.GetString(9), hasil.GetString(10), hasil.GetString(11), hasil.GetString(12));

                Cabang cabang = new Cabang(hasil.GetInt32(3), hasil.GetString(4), hasil.GetString(5), pegawai);

                Kategori kategori = new Kategori(hasil.GetInt32(17), hasil.GetString(18));

                Barang barang = new Barang(hasil.GetInt32(13), hasil.GetString(14), hasil.GetInt32(15), kategori);

                Barang_Cabang barang_cabang = new Barang_Cabang(cabang, barang, hasil.GetInt32(2));

                listBarangCabang.Add(barang_cabang);
            }

            return listBarangCabang;
        }
        #endregion
    }
}
