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
        private string role_user;
        private DateTime waktu;
        Pelanggan pelanggan;
        Driver driver;
        Pegawai pegawai;
        Penjual penjual;
        #endregion

        #region Constructors
        public Notifikasi(int id, string isi, string tipe, string role_user, DateTime waktu, Pelanggan pelanggan, Driver driver, Pegawai pegawai, Penjual penjual)
        {
            this.Id = id;
            this.Isi = isi;
            this.Tipe = tipe;
            this.Role_user = role_user;
            this.Waktu = waktu;
            this.Pelanggan = pelanggan;
            this.Driver = driver;
            this.Pegawai = pegawai;
            this.Penjual = penjual;
        }

        #region Detailed Constructors
        public Notifikasi(int id, string isi, string tipe, string role_user, DateTime waktu, Pelanggan pelanggan, Driver driver)
        {
            this.Id = id;
            this.Isi = isi;
            this.Tipe = tipe;
            this.Role_user = role_user;
            this.Waktu = waktu;
            this.Pelanggan = pelanggan;
            this.Driver = driver;
            this.Pegawai = null;
            this.Penjual = null;
        }

        public Notifikasi(int id, string isi, string tipe, string role_user, DateTime waktu, Pelanggan pelanggan, Pegawai pegawai)
        {
            this.Id = id;
            this.Isi = isi;
            this.Tipe = tipe;
            this.Role_user = role_user;
            this.Waktu = waktu;
            this.Pelanggan = pelanggan;
            this.Driver = null;
            this.Pegawai = pegawai;
            this.Penjual = null;
        }

        public Notifikasi(int id, string isi, string tipe, string role_user, DateTime waktu, Pelanggan pelanggan, Penjual penjual)
        {
            this.Id = id;
            this.Isi = isi;
            this.Tipe = tipe;
            this.Role_user = role_user;
            this.Waktu = waktu;
            this.Pelanggan = pelanggan;
            this.Driver = null;
            this.Pegawai = null;
            this.Penjual = penjual;
        }

        public Notifikasi(int id, string isi, string tipe, string role_user, DateTime waktu, Driver driver, Pegawai pegawai)
        {
            this.Id = id;
            this.Isi = isi;
            this.Tipe = tipe;
            this.Role_user = role_user;
            this.Waktu = waktu;
            this.Pelanggan = null;
            this.Driver = driver;
            this.Pegawai = pegawai;
            this.Penjual = null;
        }

        public Notifikasi(int id, string isi, string tipe, string role_user, DateTime waktu, Driver driver, Penjual penjual)
        {
            this.Id = id;
            this.Isi = isi;
            this.Tipe = tipe;
            this.Role_user = role_user;
            this.Waktu = waktu;
            this.Pelanggan = null;
            this.Driver = driver;
            this.Pegawai = null;
            this.Penjual = penjual;
        }

        public Notifikasi(int id, string isi, string tipe, string role_user, DateTime waktu, Pegawai pegawai, Penjual penjual)
        {
            this.Id = id;
            this.Isi = isi;
            this.Tipe = tipe;
            this.Role_user = role_user;
            this.Waktu = waktu;
            this.Pelanggan = null;
            this.Driver = null;
            this.Pegawai = pegawai;
            this.Penjual = penjual;
        }
        #endregion Detailed Constructors

        public Notifikasi(string isi, string tipe, string role_user, DateTime waktu, Pelanggan pelanggan, Driver driver, Pegawai pegawai, Penjual penjual)
        {
            this.Isi = isi;
            this.Tipe = tipe;
            this.Role_user = role_user;
            this.Waktu = waktu;
            this.Pelanggan = pelanggan;
            this.Driver = driver;
            this.Pegawai = pegawai;
            this.Penjual = penjual;
        }

        #region Detailed Constructors (no Id)
        public Notifikasi(string isi, string tipe, string role_user, DateTime waktu, Pelanggan pelanggan, Driver driver)
        {
            this.Isi = isi;
            this.Tipe = tipe;
            this.Role_user = role_user;
            this.Waktu = waktu;
            this.Pelanggan = pelanggan;
            this.Driver = driver;
            this.Pegawai = null;
            this.Penjual = null;
        }

        public Notifikasi(string isi, string tipe, string role_user, DateTime waktu, Pelanggan pelanggan, Pegawai pegawai)
        {
            this.Isi = isi;
            this.Tipe = tipe;
            this.Role_user = role_user;
            this.Waktu = waktu;
            this.Pelanggan = pelanggan;
            this.Driver = null;
            this.Pegawai = pegawai;
            this.Penjual = null;
        }

        public Notifikasi(string isi, string tipe, string role_user, DateTime waktu, Pelanggan pelanggan, Penjual penjual)
        {
            this.Isi = isi;
            this.Tipe = tipe;
            this.Role_user = role_user;
            this.Waktu = waktu;
            this.Pelanggan = pelanggan;
            this.Driver = null;
            this.Pegawai = null;
            this.Penjual = penjual;
        }

        public Notifikasi(string isi, string tipe, string role_user, DateTime waktu, Driver driver, Pegawai pegawai)
        {
            this.Isi = isi;
            this.Tipe = tipe;
            this.Role_user = role_user;
            this.Waktu = waktu;
            this.Pelanggan = null;
            this.Driver = driver;
            this.Pegawai = pegawai;
            this.Penjual = null;
        }

        public Notifikasi(string isi, string tipe, string role_user, DateTime waktu, Driver driver, Penjual penjual)
        {
            this.Isi = isi;
            this.Tipe = tipe;
            this.Role_user = role_user;
            this.Waktu = waktu;
            this.Pelanggan = null;
            this.Driver = driver;
            this.Pegawai = null;
            this.Penjual = penjual;
        }

        public Notifikasi(string isi, string tipe, string role_user, DateTime waktu, Pegawai pegawai, Penjual penjual)
        {
            this.Isi = isi;
            this.Tipe = tipe;
            this.Role_user = role_user;
            this.Waktu = waktu;
            this.Pelanggan = null;
            this.Driver = null;
            this.Pegawai = pegawai;
            this.Penjual = penjual;
        }
        #endregion Detailed Constructors (no Id)

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
        public string Role_user
        {
            get => role_user;
            set => role_user = value;
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
        public Driver Driver
        {
            get => driver;
            set => driver = value;
        }
        public Pegawai Pegawai
        {
            get => pegawai;
            set => pegawai = value;
        }
        public Penjual Penjual
        {
            get => penjual;
            set => penjual = value;
        }
        #endregion

        #region Methods        
        public static Boolean TambahData(Notifikasi n)
        {
            string sql = "";

            if (n.Pelanggan == null && n.Driver == null)
            {
                sql = "insert into notifikasis (isi, tipe, role_user, waktu, pelanggan_id, driver_id, pegawai_id, penjual_id) " +
                      "values ('" + n.Isi + "', '" + n.Tipe + "', '" + n.Role_user + "', '" + n.Waktu.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                      "null, null, " + n.Pegawai.Id + ", " + n.Penjual.Id + ")";
            }
            else if (n.Pelanggan == null && n.Pegawai == null)
            {
                sql = "insert into notifikasis (isi, tipe, role_user, waktu, pelanggan_id, driver_id, pegawai_id, penjual_id) " +
                      "values ('" + n.Isi + "', '" + n.Tipe + "', '" + n.Role_user + "', '" + n.Waktu.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                      "null, " + n.Driver.Id + ", null, " + n.Penjual.Id + ")";
            }
            else if (n.Pelanggan == null && n.Penjual == null)
            {
                sql = "insert into notifikasis (isi, tipe, role_user, waktu, pelanggan_id, driver_id, pegawai_id, penjual_id) " +
                      "values ('" + n.Isi + "', '" + n.Tipe + "', '" + n.Role_user + "', '" + n.Waktu.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                      "null, " + n.Driver.Id + ", " + n.Pegawai.Id + ", null)";
            }
            else if (n.Driver == null && n.Pegawai == null)
            {
                sql = "insert into notifikasis (isi, tipe, role_user, waktu, pelanggan_id, driver_id, pegawai_id, penjual_id) " +
                      "values ('" + n.Isi + "', '" + n.Tipe + "', '" + n.Role_user + "', '" + n.Waktu.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                      n.Pelanggan.Id + ", null, null, " + n.Penjual.Id + ")";
            }
            else if (n.Driver == null && n.Penjual == null)
            {
                sql = "insert into notifikasis (isi, tipe, role_user, waktu, pelanggan_id, driver_id, pegawai_id, penjual_id) " +
                      "values ('" + n.Isi + "', '" + n.Tipe + "', '" + n.Role_user + "', '" + n.Waktu.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                      n.Pelanggan.Id + ", null, " + n.Pegawai.Id + ", null)";
            }
            else if (n.Pegawai == null && n.Penjual == null)
            {
                sql = "insert into notifikasis (isi, tipe, role_user, waktu, pelanggan_id, driver_id, pegawai_id, penjual_id) " +
                      "values ('" + n.Isi + "', '" + n.Tipe + "', '" + n.Role_user + "', '" + n.Waktu.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                      n.Pelanggan.Id + ", " + n.Driver.Id + ", null, null)";
            }

            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0) return false;
            else return true;
        }

        public static List<Notifikasi> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "select * from notifikasis n " +
                         "left join pelanggans pel on n.pelanggan_id = pel.id " +
                         "left join drivers d on n.driver_id = d.id " +
                         "left join pegawais peg on n.pegawai_id = peg.id " +
                         "left join penjuals pen on n.penjual_id = pen.id " +
                         "left join blacklists b on pen.blacklist_id = b.id ";

            if (kriteria != "") sql += "where " + kriteria + " like '%" + nilaiKriteria + "%' ";

            sql += "order by n.waktu";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Notifikasi> listNotifikasi = new List<Notifikasi>();

            while (hasil.Read())
            {
                #region Note
                /*
                5 = pelanggan_id
                6 = driver_id
                7 = pegawai_id
                8 = penjual_id

                // kalau data null
                if (hasil.IsDBNull(7) == true)
                {

                }
                else if (hasil.IsDBNull(7) == false) // kalau data tidak null
                {

                }*/
                #endregion

                Notifikasi n = null;
                if (hasil.IsDBNull(5) && hasil.IsDBNull(6)) // kalau pelanggan & driver null
                {
                    Blacklist b = new Blacklist(hasil.GetInt32(37), hasil.GetString(38), hasil.GetString(39));

                    Penjual pen = new Penjual(hasil.GetInt32(29), hasil.GetString(30), hasil.GetString(31), hasil.GetString(32), hasil.GetString(33), hasil.GetString(34), hasil.GetString(35), b);

                    Pegawai peg = new Pegawai(hasil.GetInt32(23), hasil.GetString(25), hasil.GetString(24), hasil.GetString(26), hasil.GetString(27), hasil.GetString(28));

                    n = new Notifikasi(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetString(4), hasil.GetDateTime(3), peg, pen);
                }
                else if (hasil.IsDBNull(5) && hasil.IsDBNull(7)) // kalau pelanggan & pegawai null
                {
                    Blacklist b = new Blacklist(hasil.GetInt32(37), hasil.GetString(38), hasil.GetString(39));

                    Penjual pen = new Penjual(hasil.GetInt32(29), hasil.GetString(30), hasil.GetString(31), hasil.GetString(32), hasil.GetString(33), hasil.GetString(34), hasil.GetString(35), b);

                    Driver d = new Driver(hasil.GetInt32(17), hasil.GetString(19), hasil.GetString(18), hasil.GetString(20), hasil.GetString(21), hasil.GetString(22));

                    n = new Notifikasi(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetString(4), hasil.GetDateTime(3), d, pen);
                }
                else if (hasil.IsDBNull(5) && hasil.IsDBNull(8)) // kalau pelanggan & penjual null
                {
                    Pegawai peg = new Pegawai(hasil.GetInt32(23), hasil.GetString(25), hasil.GetString(24), hasil.GetString(26), hasil.GetString(27), hasil.GetString(28));

                    Driver d = new Driver(hasil.GetInt32(17), hasil.GetString(19), hasil.GetString(18), hasil.GetString(20), hasil.GetString(21), hasil.GetString(22));

                    n = new Notifikasi(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetString(4), hasil.GetDateTime(3), d, peg);
                }
                else if (hasil.IsDBNull(6) && hasil.IsDBNull(7)) // kalau driver & pegawai null
                {
                    Blacklist b = new Blacklist(hasil.GetInt32(37), hasil.GetString(38), hasil.GetString(39));

                    Penjual pen = new Penjual(hasil.GetInt32(29), hasil.GetString(30), hasil.GetString(31), hasil.GetString(32), hasil.GetString(33), hasil.GetString(34), hasil.GetString(35), b);

                    Pelanggan pel = new Pelanggan(hasil.GetInt32(9), hasil.GetString(11), hasil.GetString(10), hasil.GetString(12), hasil.GetString(13), hasil.GetString(14), hasil.GetDouble(15), hasil.GetDouble(16));

                    n = new Notifikasi(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetString(4), hasil.GetDateTime(3), pel, pen);
                }
                else if (hasil.IsDBNull(6) && hasil.IsDBNull(8)) // kalau driver & penjual null
                {
                    Pegawai peg = new Pegawai(hasil.GetInt32(23), hasil.GetString(25), hasil.GetString(24), hasil.GetString(26), hasil.GetString(27), hasil.GetString(28));

                    Pelanggan pel = new Pelanggan(hasil.GetInt32(9), hasil.GetString(11), hasil.GetString(10), hasil.GetString(12), hasil.GetString(13), hasil.GetString(14), hasil.GetDouble(15), hasil.GetDouble(16));

                    n = new Notifikasi(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetString(4), hasil.GetDateTime(3), pel, peg);
                }
                else if (hasil.IsDBNull(7) && hasil.IsDBNull(8)) // kalau pegawai & penjual null
                {
                    Driver d = new Driver(hasil.GetInt32(17), hasil.GetString(19), hasil.GetString(18), hasil.GetString(20), hasil.GetString(21), hasil.GetString(22));

                    Pelanggan pel = new Pelanggan(hasil.GetInt32(9), hasil.GetString(11), hasil.GetString(10), hasil.GetString(12), hasil.GetString(13), hasil.GetString(14), hasil.GetDouble(15), hasil.GetDouble(16));

                    n = new Notifikasi(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetString(4), hasil.GetDateTime(3), pel, d);
                }

                listNotifikasi.Add(n);
            }

            return listNotifikasi;
        }

        public static Boolean UbahData(Notifikasi n)
        {
            // Querry Insert
            string sql = "update notifikasis set isi = '" + n.Isi + "', tipe = '" + n.Tipe + "', role_user = '" + n.Role_user + "', " +
                         "waktu = '" + n.Waktu.ToString("yyyy-MM-dd HH:mm:ss") + "', pelanggan_id = '" + n.Pelanggan.Id + "', " +
                         "driver_id = '" + n.Driver.Id + "', pegawai_id = '" + n.Pegawai.Id + "', penjual_id = '" + n.Penjual.Id + "' " +
                         "where id = '" + n.Id + "'";

            int jumlahDiubah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDiubah == 0) return false;
            else return true;
        }

        public static Notifikasi AmbilData(int id)
        {
            string sql = "select * from notifikasis n " +
                         "inner join pelanggans pel on n.pelanggan_id = pel.id " +
                         "inner join drivers d on n.driver_id = d.id " +
                         "inner join pegawais peg on n.pegawai_id = peg.id " +
                         "inner join penjuals pen on n.penjual_id = pen.id " +
                         "inner join blacklists b on pen.blacklist_id = b.id " +
                         "where n.id = " + id;

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            Notifikasi n = null;

            while (hasil.Read())
            {
                Blacklist b = new Blacklist(hasil.GetInt32(37), hasil.GetString(38), hasil.GetString(39));

                Penjual pen = new Penjual(hasil.GetInt32(29), hasil.GetString(30), hasil.GetString(31), hasil.GetString(32), hasil.GetString(33), hasil.GetString(34), hasil.GetString(35), b);

                Pegawai peg = new Pegawai(hasil.GetInt32(23), hasil.GetString(25), hasil.GetString(24), hasil.GetString(26), hasil.GetString(27), hasil.GetString(28));

                Driver d = new Driver(hasil.GetInt32(17), hasil.GetString(19), hasil.GetString(18), hasil.GetString(20), hasil.GetString(21), hasil.GetString(22));

                Pelanggan pel = new Pelanggan(hasil.GetInt32(9), hasil.GetString(11), hasil.GetString(10), hasil.GetString(12), hasil.GetString(13), hasil.GetString(14), hasil.GetDouble(15), hasil.GetDouble(16));

                n = new Notifikasi(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), hasil.GetString(4), hasil.GetDateTime(3), pel, d, peg, pen);

            }

            return n;
        }

        public static List<string> AmbilTipe()
        {
            string sql = "select distinct(tipe) from notifikasis";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<string> listTipe = new List<string>();

            while (hasil.Read())
            {
                string tipe = hasil.GetString(0);

                listTipe.Add(tipe);
            }

            return listTipe;
        }

        public static int HitungNotifikasi(string role_user)
        {
            string sql = "select count(*) from notifikasis " +
                         "where role_user = '" + role_user + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            int NotifCount = 0;

            while (hasil.Read())
            {
                NotifCount =  hasil.GetInt32(0);
            }

            return NotifCount;
        }
        #endregion
    }
}
