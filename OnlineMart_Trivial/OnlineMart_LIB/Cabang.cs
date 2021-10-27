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
        public Cabang (int idCabang)
		{
            IdCabang = idCabang;
        }
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
            string sqlInsert = "insert into cabangs (id, nama, alamat, pegawai_id)" +
                               " values (" + c.IdCabang + ", '" + c.Nama + "', '" + c.Alamat + "', '" + c.Pegawai.IdPegawai + "')";

            //menjalankan perintah sql
            Koneksi.JalankanPerintahDML(sqlInsert);
        }

        public static Boolean UbahData(Cabang c)
        {
            // Querry Insert
            string sql = "UPDATE cabangs SET Nama = '" + c.Nama + "', TglLahir = '" + c.TglLahir.ToString("yyyy-MM-dd") + "', " +
                         "Alamat = '" + c.Alamat + "', Gaji = " + c.Gaji + ", Username = '" + c.Username + "', Password = SHA2('" +
                         c.Password + "', 512), IdJabatan = '" + c.Jabatan + "' " +
                         " WHERE KodePegawai = " + c.KodePegawai;
            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0) return false;
            else return true;
        }

        //Method untuk membaca data Cabang
        public static List<Cabang> BacaData(string kriteria, string nilaiKriteria)
        {
            string sqlRead;
            if (kriteria == "") //kalau kriteria kosong pake ini
            {
                sqlRead = "select c.id, c.nama, c.alamat, p.id, p.nama, p.username, p.email, p.password, p.telepon" +
                          " from cabangs as c inner join pegawais as p on c.pegawai_id = p.id";
            }
            else //kalau kriteria g kosong pake ini
            {
                sqlRead = "select c.id, c.nama, c.alamat, p.id, p.nama, p.username, p.email, p.password, p.telepon" +
                          " from cabangs as c inner join pegawais as p on c.pegawai_id = p.id" +
                          " where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sqlRead);

            List<Cabang> listCabang = new List<Cabang>();
            //kalau bisa/berhasil dibaca maka dimasukkin ke list pake constructors
            while(hasil.Read() == true)
            {

                Pegawai p = new Pegawai(hasil.GetInt32(3), hasil.GetString(4), hasil.GetString(5), hasil.GetString(6), hasil.GetString(7),
                                        hasil.GetString(8));

                Cabang c = new Cabang(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), p);
                
                listCabang.Add(c);
            }

            return listCabang;
        }

        //Method untuk menghapus data Cabang
        public static Boolean HapusData(string id)
        {
            string sqlDelete = "delete from cabangs where id = '" + id + "'";

            int jumlahDataBerubah = Koneksi.JalankanPerintahDML(sqlDelete);
            //Dicek apakah ada data yang berubah atau tidak
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
