using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Pegawai
    {
        private int id;
        private string nama;
        private string username;
        private string email;
        private string password;
        private string telepon;

        #region Constructors
        public Pegawai(int id, string nama, string username, string email, string password, string telepon)
        {
            Id = id;
            Nama = nama;
            Username = username;
            Email = email;
            Password = password;
            Telepon = telepon;
        }
        public Pegawai(string nama, string username, string email, string password, string telepon)
        {
            Nama = nama;
            Username = username;
            Email = email;
            Password = password;
            Telepon = telepon;
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
        public string Username 
        { 
            get => username; 
            set => username = value; 
        }
        public string Email 
        { 
            get => email; 
            set => email = value; 
        }
        public string Password 
        { 
            get => password; 
            set => password = value; 
        }
        public string Telepon 
        { 
            get => telepon; 
            set => telepon = value; 
        }
        #endregion

        #region Methods
        public static Boolean TambahData(Pegawai p)
        {
            // Querry Insert
            string sql = "insert into pegawais (nama, username, email, password, telepon) " +
                " values ('" + p.Nama + "', '" + p.Username + "', '" + p.Email + "', SHA2('" + p.Password + "', 512), '" + p.Telepon + "')";

            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0) return false;
            else return true;
        }

        public static List<Pegawai> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "select id, nama, username, email, password, telepon from pegawais ";
            if (kriteria != "") sql += " where " + kriteria + " like '%" + nilaiKriteria + "%'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            //Buat list untuk menampung data
            List<Pegawai> listPegawai = new List<Pegawai>();

            while (hasil.Read())
            {
                Pegawai p = new Pegawai(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetString(3), hasil.GetString(4), hasil.GetString(5));

                listPegawai.Add(p);
            }

            return listPegawai;
        }

        public static Boolean UbahData(Pegawai p)
        {
            // Querry Insert
            string sql = "update pegawais set nama = '" + p.Nama + "', username = '" + p.Username + "', email = '" + p.Email + "', password = SHA2('" + p.Password + "', 512), telepon = '" + p.Telepon + "' where id = " + p.Id;
            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0) return false;
            else return true;
        }

        public static Boolean HapusData(Pegawai p)
        {
            string sql = "delete from pegawais where id = " + p.Id;
            int jumlahDataDihapus = Koneksi.JalankanPerintahDML(sql);
            //Dicek apakah ada data yang berubah atau tidak
            if (jumlahDataDihapus == 0) return false;
            else return true;
        }

        public static Pegawai CekLogin(string username, string password)
        {
            string sql = "select id, nama, username, email, password, telepon from pegawais where username = '" + username + "' and password = SHA2('" + password + "', 512)";
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            while (hasil.Read())
            {
                Pegawai pegawai = new Pegawai(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetString(3), hasil.GetString(4), hasil.GetString(5));

                return pegawai;
            }
            return null;
        }
        #endregion
    }
}
