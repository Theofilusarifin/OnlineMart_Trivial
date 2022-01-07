using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Notifikasi
    {
        #region Fields
        private int id;
        private string isi;
        private string tipe;
        private DateTime waktu;
        Pelanggan pelanggan;
        #endregion

        #region Constructors
        public Notifikasi(int id, string isi, string tipe, DateTime waktu, Pelanggan pelanggan)
        {
            this.Id = id;
            this.Isi = isi;
            this.Tipe = tipe;
            this.Waktu = waktu;
            this.Pelanggan = pelanggan;
        }

        public Notifikasi(string isi, string tipe, DateTime waktu, Pelanggan pelanggan)
        {
            this.Isi = isi;
            this.Tipe = tipe;
            this.Waktu = waktu;
            this.Pelanggan = pelanggan;
        }
        #endregion

        #region Properties
        public int Id 
        { 
            get => id; 
            set => id = value; 
        }
        public string Isi 
        {
            get => isi;
            set => isi = value;
        }
        public string Tipe 
        {
            get => tipe;
            set => tipe = value; 
        }
        public DateTime Waktu 
        {
            get => waktu;
            set => waktu = value; 
        }
        public Pelanggan Pelanggan 
        {
            get => pelanggan;
            set => pelanggan = value; 
        }
        #endregion

        #region Methods
        public static Boolean TambahData(Notifikasi n)
        {
            string sql = "insert into notifikasis (isi, tipe, waktu, pelanggan_id) " +
                         "values ('" + n.Isi + "', '" + n.Tipe + "', " +
                         n.Waktu.ToString("yyyy-MM-dd HH:mm:ss") + ", " + n.Pelanggan.Id + ")";

            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0) return false;
            else return true;
        }

        public static List<Notifikasi> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "select * from notifikasis n " +
                         "inner join pelanggans p on n.pelanggan_id = p.id ";

            if (kriteria != "") sql += "where " + kriteria + " like '%" + nilaiKriteria + "%' ";

            sql += "order by n.waktu";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Notifikasi> listNotifikasi = new List<Notifikasi>();

            while (hasil.Read())
            {
                Pelanggan p = new Pelanggan(hasil.GetInt32(5), hasil.GetString(7), hasil.GetString(6), hasil.GetString(8), hasil.GetString(9), hasil.GetString(10), hasil.GetDouble(11), hasil.GetDouble(12));

                Notifikasi n = new Notifikasi(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetDateTime(3), p);

                listNotifikasi.Add(n);
            }

            return listNotifikasi;
        }

        public static Boolean UbahData(Notifikasi n)
        {
            // Querry Insert
            string sql = "update notifikasis set isi = '" + n.Isi + "', tipe = '" + n.Tipe + "', " +
                         "waktu = '" + n.Waktu.ToString("yyyy-MM-dd HH:mm:ss") + "', pelanggan_id = '" + n.Pelanggan.Id + "' " +
                         "where id = '" + n.Id + "'";

            int jumlahDiubah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDiubah == 0) return false;
            else return true;
        }

        public static Notifikasi AmbilData(int id)
        {
            string sql = "select * from notifikasis n " +
                         "inner join pelanggans p on n.pelanggan_id = p.id " +
                         "where n.id = " + id;

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            Notifikasi n = null;

            while (hasil.Read())
            {
                Pelanggan p = new Pelanggan(hasil.GetInt32(5), hasil.GetString(7), hasil.GetString(6), hasil.GetString(8), hasil.GetString(9), hasil.GetString(10), hasil.GetDouble(11), hasil.GetDouble(12));

                n = new Notifikasi(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetDateTime(3), p);
            }

            return n;
        }
        #endregion
    }
}
