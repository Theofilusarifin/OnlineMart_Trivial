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
        #region Fields
        private int id;
        private string nama;
        private int jumlahPoin;
        List<Gift_Redeem> listGiftRedeem; //Aggregation
        #endregion

        #region Constructors
        public Gift(int id, string nama, int jumlahPoin)
        {
            Id = id;
            Nama = nama;
            JumlahPoin = jumlahPoin;
            ListGiftRedeem = new List<Gift_Redeem>();
        }
        public Gift(string nama, int jumlahPoin)
        {
            Nama = nama;
            JumlahPoin = jumlahPoin;
            ListGiftRedeem = new List<Gift_Redeem>();
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
        public int JumlahPoin 
        { 
            get => jumlahPoin; 
            set => jumlahPoin = value; 
        }
        public List<Gift_Redeem> ListGiftRedeem 
        { 
            get => listGiftRedeem; 
            private set => listGiftRedeem = value; 
        }
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
            string sql = "select * from gifts ";
            if (kriteria != "") sql += " where " + kriteria + " like '%" + nilaiKriteria + "%'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            //Buat list untuk menampung data
            List<Gift> listGift = new List<Gift>();

            while (hasil.Read())
            {
                Gift g = new Gift(hasil.GetInt32(0), hasil.GetString(1), hasil.GetInt32(2));

                ////Ambil Gift_Redeems
                //string gift_redeems = "select gr.id from gift_redeems as gr inner join gifts as g on gr.gift_id = g.id where g.id = " + g.id;

                //MySqlDataReader hasil_join = Koneksi.JalankanPerintahQuery(gift_redeems);

                //while (hasil_join.Read())
                //{
                //    Gift_Redeem gr_join = Gift_Redeem.AmbilData(hasil_join.GetInt32(0));

                //    //Tambahkan hasil join ke aggregation relationship
                //    g.ListGiftRedeem.Add(gr_join);
                //}

                listGift.Add(g);
            }
            return listGift;
        }

        public static Gift AmbilData(int id, Koneksi kParram)
        {
            string sql = "select id, nama, jumlah_poin from gifts where id = " + id;

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql, kParram);

            Gift g = null;

            while (hasil.Read())
            {
                //kalau bisa/berhasil dibaca maka dimasukkin ke list pake constructors
                g = new Gift(hasil.GetInt32(0), hasil.GetString(1), hasil.GetInt32(2));
            }

            hasil.Close();
            hasil.Dispose();

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
