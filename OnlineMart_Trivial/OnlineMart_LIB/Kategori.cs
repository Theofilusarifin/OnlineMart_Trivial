using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Kategori
    {
        private int id;
        private string nama;

        #region Constructors
        public Kategori(int id, string nama)
        {
            Id = id;
            Nama = nama;
        }
        public Kategori(string nama)
        {
            Nama = nama;
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
            set => nama = value; 
        }
        #endregion

        #region Method    
        public static Boolean TambahData(Kategori k)
        {
            string sql = "insert into kategoris (nama) values ('" + k.Nama + "')";

            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0) return false;
            else return true;
        }

        public static List<Kategori> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "select * from kategoris ";
            if(kriteria != "") sql += " where " + kriteria + " like '%" + nilaiKriteria + "%'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Kategori> listKategori = new List<Kategori>();

            while(hasil.Read() == true)
            {
                Kategori k = new Kategori( hasil.GetInt32(0), hasil.GetString(1));
                listKategori.Add(k);
            }
            return listKategori;
        }

        public static Boolean UbahData(Kategori k)
        {
            // Querry Insert
            string sql = "update kategoris set nama = '" + k.Nama + "' where id = " + k.Id;
            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0) return false;
            else return true;
        }

        public static Boolean HapusData(int id)
        {
            string sql = "delete from kategoris where id = " + id;
            int jumlahDataDihapus = Koneksi.JalankanPerintahDML(sql);
            //Dicek apakah ada data yang berubah atau tidak
            if (jumlahDataDihapus == 0) return false;
            else return true;
        }
        #endregion
    }
}
