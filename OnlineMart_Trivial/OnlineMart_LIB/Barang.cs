using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tambahkan ini untuk dapat memanggil private data member
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Barang
    {
        private int idBarang;
        private string nama;
        private int harga;
        private Kategori kategori;

        #region Constructors
        public Barang(int idBarang, string nama, int harga, Kategori kategori)
        {
            IdBarang = idBarang;
            Nama = nama;
            Harga = harga;
            Kategori = kategori;
        }
        #endregion

        #region Properties
        public int IdBarang { get => idBarang; set => idBarang = value; }
        public string Nama { get => nama; set => nama = value; }
        public int Harga { get => harga; set => harga = value; }
        public Kategori Kategori { get => kategori; set => kategori = value; }
        #endregion

        #region Methods
        //Method untuk menambah data Barang
        public static void TambahData(Barang b)
        {
            //string yang menampung sql query insert into
            string sqlInsert = "insert into barangs (id, nama, harga, kategori_id)" +
                               " values ('" + b.IdBarang + "', '" + b.Nama + "', '" + b.Harga + "', '" + b.Kategori.Id + "')";

            //menjalankan perintah sql
            Koneksi.JalankanPerintahDML(sqlInsert);
        }

        //Method untuk membaca data Barang
        public static List<Barang> BacaData(string kriteria, string nilaiKriteria)
        {
            string sqlRead;
            if (kriteria == "") //kalau kriteria kosong pake ini
            {
                sqlRead = "select b.id, b.nama, b.harga, k.id, k.nama" +
                          " from barangs as b inner join kategoris as k on b.kategori_id = k.id";
            }
            else // kalau kriteria g kosong pake ini
            {
                sqlRead = "select b.id, b.nama, b.harga, k.id, k.nama" +
                          " from barangs as b inner join kategoris as k on b.kategori_id = k.id" +
                          " where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sqlRead);

            List<Barang> listBarang = new List<Barang>();
            //kalau bisa/berhasil dibaca maka dimasukkin ke list pake constructors
            while(hasil.Read() == true)
            {
                Kategori k = new Kategori(hasil.GetInt32(3), hasil.GetString(4));

                Barang b = new Barang(hasil.GetInt32(0), hasil.GetString(1), hasil.GetInt32(2), k);
                
                listBarang.Add(b);
            }

            return listBarang;
        }

        //Method untuk menghapus data Barang
        public static Boolean HapusData(string id)
        {
            string sqlDelete = "delete from barangs where id = '" + id + "'";

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
