using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tambahkan ini untuk dapat memanggil private data member
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Cabang
    {
        private int id;
        private string nama;
        private string alamat;
        private Pegawai pegawai;

        #region Constructors
        public Cabang(int id, string nama, string alamat, Pegawai pegawai)
        {
            Id = id;
            Nama = nama;
            Alamat = alamat;
            Pegawai = pegawai;
        }
        public Cabang(string nama, string alamat, Pegawai pegawai)
        {
            Nama = nama;
            Alamat = alamat;
            Pegawai = pegawai;
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
        public string Alamat 
        { 
            get => alamat; 
            set => alamat = value; 
        }
        public Pegawai Pegawai 
        { 
            get => pegawai; 
            set => pegawai = value; 
        }
        #endregion

        #region Methods
        //Method untuk menambah data Cabang
        public static void TambahData(Cabang c)
        {
            //string yang menampung sql query insert into
            string sql = "insert into cabangs (id, nama, alamat, pegawai_id) values (" + c.Id + ", '" + c.Nama + "', '" + c.Alamat + "', '" + c.Pegawai.Id + "')";

            //menjalankan perintah sql
            Koneksi.JalankanPerintahDML(sql);
        }

        //Method untuk membaca data Cabang
        public static List<Cabang> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "select C.id, C.nama, C.alamat, P.id, P.nama, P.username, P.email, P.password p.telepon from cabangs as C inner join pegawais as P on C.pegawai_id = P.id ";
            if (kriteria != "") //kalau tidak kosong tambahkan ini
            {
<<<<<<< Updated upstream
                sqlRead = "select c.id, c.nama, c.alamat, p.id, p.nama, p.username, p.email, p.password, p.telepon" +
                          " from cabangs as c inner join pegawais as p on c.pegawai_id = p.id";
            }
            else //kalau kriteria g kosong pake ini
            {
                sqlRead = "select c.id, c.nama, c.alamat, p.id, p.nama, p.username, p.email, p.password, p.telepon" +
                          " from cabangs as c inner join pegawais as p on c.pegawai_id = p.id" +
                          " where " + kriteria + " like '%" + nilaiKriteria + "%'";
=======
                sql += " where " + kriteria + " like '%" + nilaiKriteria + "%'";
>>>>>>> Stashed changes
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Cabang> listCabang = new List<Cabang>();
            //kalau bisa/berhasil dibaca maka dimasukkin ke list pake constructors
            while(hasil.Read() == true)
            {

                Pegawai p = new Pegawai(hasil.GetInt32(3), hasil.GetString(4), hasil.GetString(5), hasil.GetString(6), hasil.GetString(7), hasil.GetString(8));

                Cabang c = new Cabang(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), p);
                
                listCabang.Add(c);
            }

            return listCabang;
        }

        public static Boolean UbahData(Cabang c)
        {
            // Querry Insert
            string sql = "update cabangs set nama = '" + c.Nama + "', alamat = '" + c.Alamat + "', pegawai = " + c.Pegawai.Id + " where id = " + c.Id;
            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0) return false;
            else return true;
        }

        //Method untuk menghapus data Cabang
        public static Boolean HapusData(Cabang c)
        {
            string sql = "delete from cabangs where id = " + c.Id;

            int jumlahDataDihapus = Koneksi.JalankanPerintahDML(sql);
            //Dicek apakah ada data yang berubah atau tidak
            if (jumlahDataDihapus == 0) return false;
            else return true;
        }
        #endregion
    }
}
