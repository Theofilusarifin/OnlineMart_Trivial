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
        private string email;
        private string password;
        private string telepon;

        #region Constructors
        public Pegawai(int idPegawai, string nama, string email, string password, string telepon)
        {
            IdPegawai = idPegawai;
            Nama = nama;
            Email = email;
            Password = password;
            Telepon = telepon;
        }
        #endregion

        #region Properties
        public int IdPegawai { get => idPegawai; set => idPegawai = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Telepon { get => telepon; set => telepon = value; }
        #endregion

        #region Methods
        #endregion
    }
}
