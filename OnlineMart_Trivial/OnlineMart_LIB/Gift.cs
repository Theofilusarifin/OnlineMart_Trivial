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
        public static void TambahData(Gift g)
        {
            string sqlInsert = "Insert into gifts (id, nama, jumlah_poin)" + " values ('" + g.Id + "', '" + g.Nama + "', '" + g.JumlahPoin + "')";

            //menjalankan perintah SQL
            Koneksi.JalankanPerintahDML(sqlInsert);
        }

        public static List<Gift> BacaData(string kriteria, string nilaiKriteria)
        {
            string sqlRead;
            if(kriteria == "")
            {
                sqlRead = "select * from gifts";
            }
            else
            {
                sqlRead = "select * from gifts where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            // baru dibaca pakai method Query
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sqlRead);

            List<Gift> listGift = new List<Gift>();

            while(hasil.Read() == true)
            {
                Gift g = new Gift(int.Parse(hasil.GetValue(0).ToString()), hasil.GetValue(1).ToString(), int.Parse(hasil.GetValue(2).ToString()));
                listGift.Add(g);
            }
            return listGift;
        }

        public static Boolean HapusData(int id)
        {
            string sqlDelete = "delete from gifts where id ='" + id + "'";
            int jumlahDataBerubah = Koneksi.JalankanPerintahDML(sqlDelete);

            if(jumlahDataBerubah == 0)
            {
                //jika data tidak berubah, maka tidak return apa apa
                return false;
            }
            else
            {
                return true;
            }
        }
        public static Boolean UbahData(Gift g)
        {
            // Querry Insert
            string sql = "update gifts set nama = '" + g.Nama + "', jumlah_poin = " + g.JumlahPoin + " where id = " + g.id;
            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0) return false;
            else return true;
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
        #endregion
    }
}
