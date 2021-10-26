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
        private int idCabang;
        private string nama;
        private string alamat;
        private Pegawai pegawai;

        #region Constructors
        public Cabang(int idCabang, string nama, string alamat, Pegawai pegawai)
        {
            IdCabang = idCabang;
            Nama = nama;
            Alamat = alamat;
            Pegawai = pegawai;
        }
        #endregion

        #region Properties
        public int IdCabang { get => idCabang; set => idCabang = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public Pegawai Pegawai { get => pegawai; set => pegawai = value; }
        #endregion

        #region Methods
        //Method untuk menambah data Cabang
        public static void TambahData(Cabang c)
        {
            //string yang menampung sql query insert into
            string sqlInsert = "insert into cabangs (id, nama, alamat, pegawais_id)" +
                               " values (" + c.IdCabang + ", '" + c.Nama + "', " + c.Alamat + ", '" + c.Pegawai.IdPegawai + "')";

            //menjalankan perintah sql
            Koneksi.JalankanPerintahDML(sqlInsert);
        }

        //Method untuk membaca data Cabang
        public static List<Cabang> BacaData(string kriteria, string nilaiKriteria)
        {
            string sqlRead;
            if (kriteria == "") //kalau kriteria kosong pake ini
            {
                sqlRead = "select c.id as IdCabang, c.nama as Nama Cabang, c.alamat, p.id as IdPegawai," +
                          " p.nama as Nama Pegawai, p.email, p.password, p.telepon" +
                          " from cabangs as c inner join pegawais as p on c.pegawais_id = p.id";
            }
            else //kalau kriteria g kosong pake ini
            {
                sqlRead = "select c.id as IdCabang, c.nama as Nama Cabang, c.alamat, p.id as IdPegawai," +
                          " p.nama as Nama Pegawai, p.email, p.password, p.telepon" +
                          " from cabangs as c inner join pegawais as p on c.pegawais_id = p.id" +
                          " where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sqlRead);

            List<Cabang> listCabang = new List<Cabang>();
            //kalau bisa/berhasil dibaca maka dimasukkin ke list pake constructors
            while(hasil.Read() == true)
            {
                Pegawai p = new Pegawai(int.Parse(hasil.GetValue(3).ToString()), hasil.GetValue(4).ToString(), hasil.GetValue(5).ToString(),
                                        hasil.GetValue(6).ToString(), hasil.GetValue(7).ToString());

                Cabang c = new Cabang(int.Parse(hasil.GetValue(0).ToString()), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), p);
                
                listCabang.Add(c);
            }

            return listCabang;
        }

        //Method untuk menghapus data Cabang
        public static Boolean HapusData(string kode)
        {
            string sqlDelete = "delete from cabangs where kodeKategori = '" + kode + "'";

            int jumlahDataBerubah = Koneksi.JalankanPerintahDML(sqlDelete);
            //Dicek apakah ada data yang berubah atu tidak
            if (jumlahDataBerubah == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion
    }
}
