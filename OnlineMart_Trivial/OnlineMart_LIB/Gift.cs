using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Gift
    {
        private int id;
        private string nama;
        private int jumlahPoin;

        #region Constructors
        public Gift(int id, string nama, int jumlahPoin)
        {
            Id = id;
            Nama = nama;
            JumlahPoin = jumlahPoin;
        }
        public Gift(string nama, int jumlahPoin)
        {
            Nama = nama;
            JumlahPoin = jumlahPoin;
        }
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public int JumlahPoin { get => jumlahPoin; set => jumlahPoin = value; }
        #endregion

        #region Methods
        public static Boolean TambahData(Gift g)
        {
            string sql = "Insert into gifts (id, nama, jumlah_poin) values ('" + g.Id + "', '" + g.Nama + "', '" + g.JumlahPoin + "')";

            //menjalankan perintah SQL
            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0) return false;
            else return true;
        }

        public static List<Gift> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "select id, nama, jumlah_poin from gifts ";
            if (kriteria != "") sql += " where " + kriteria + " like '%" + nilaiKriteria + "%'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            //Buat list untuk menampung data
            List<Gift> listGift = new List<Gift>();

            while (hasil.Read())
            {
                Gift g = new Gift(hasil.GetInt32(0), hasil.GetString(1), hasil.GetInt32(2));
                listGift.Add(g);
            }

            return listGift;
        }

        public static Gift AmbilData(int id)
        {
            string sql = "select id, nama, jumlah_poin from gifts where id = " + id;

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            hasil.Read();

            //kalau bisa/berhasil dibaca maka dimasukkin ke list pake constructors
            Gift g = new Gift(hasil.GetInt32(0), hasil.GetString(1), hasil.GetInt32(2));

            return g;
        }

        public static Boolean HapusData(int id)
        {
            string sql = "delete from gifts where id = " + id;
            int jumlahDataDihapus = Koneksi.JalankanPerintahDML(sql);

            //Dicek apakah ada data yang berubah atau tidak
            if (jumlahDataDihapus == 0) return false;
            else return true;
        }
        public static Boolean UbahData(Gift g)
        {
            // Querry Insert
            string sql = "update gifts set nama = '" + g.Nama + "', jumlah_poin = " + g.JumlahPoin + " where id = " + g.id;

            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0) return false;
            else return true;
        }
        #endregion
    }
}
