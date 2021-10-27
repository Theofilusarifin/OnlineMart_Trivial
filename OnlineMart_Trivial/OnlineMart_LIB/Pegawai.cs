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
        private int idPegawai;
        private string nama;
        private string username;
        private string email;
        private string password;
        private string telepon;

        #region Constructors
        public Pegawai(int idPegawai, string nama, string username, string email, string password, string telepon)
        {
            IdPegawai = idPegawai;
            Nama = nama;
            Username = username;
            Email = email;
            Password = password;
            Telepon = telepon;
        }
        #endregion

        #region Properties
        public int IdPegawai 
        { 
            get => idPegawai; 
            set => idPegawai = value; 
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
        public static void TambahData(Pegawai pegawai)
        {
            // Querry Insert
            string sql = "INSERT into pegawais (nama, username, email, password, telepon) " +
                "VALUES ('" + pegawai.Nama + "', '" + pegawai.Username + "', '" + pegawai.Email + "', SHA2('" + pegawai.password + "', 512), '" + pegawai.telepon + "')";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static List<Pegawai> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "SELECT nama, username, email, password, telepon, FROM pegawais ";
            if (kriteria != "") sql += "WHERE " + kriteria + " LIKE '%" + nilaiKriteria + "%'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            //Buat list untuk menampung data
            List<Pegawai> listPegawai = new List<Pegawai>();

            while (hasil.Read())
            {
                Pegawai pegawai = new Pegawai(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetString(3), hasil.GetString(4), hasil.GetString(5));

                listPegawai.Add(pegawai);
            }

            return listPegawai;
        }

        public static Pegawai CekLogin(string username, string password)
        {
            string sql = "SELECT nama, username, email, password, telepon, FROM pegawais WHERE username = '" + username + "' AND password = SHA2('" + password + "', 512)";
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
