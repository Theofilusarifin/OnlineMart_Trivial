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
        /*private int idBarang;
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
        private static void TambahData(Barang b)
        {
            //string yang menampung sql query insert into
            string sqlInsert = "insert into barangs (id, nama, harga, kategoris_id)" +
                               " values (" + b.IdBarang + ", '" + b.Nama + "', " + b.Harga + ", '" + b.Kategori. + "')";

            //menjalankan perintah sql
            Koneksi.JalankanPerintahDML(sqlInsert);
        }

        //Method untuk membaca data Barang
        private static List<Barang> BacaData(string kriteria, string nilaiKriteria)
        {
            string sqlRead;
            if (kriteria == "")
            {
                sqlRead = "select b.id as Id Barang, b.nama as Nama Barang, b.harga as Harga, k.id as Id Kategori" +
                          " from barangs as b inner join kategoris as k on b.kategoris_id = k.id";
            }
            else
            {
                sqlRead = "select b.id as Id Barang, b.nama as Nama Barang, b.harga as Harga, k.id as Id Kategori" +
                          " from barangs as b inner join kategoris as k on b.kategoris_id = k.id" +
                          " where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sqlRead);

            List<Barang> listBarang = new List<Barang>();
            while(hasil.Read() == true)
            {
                Kategori k = new Kategori();

                Barang b = new Barang();
                
                listBarang.Add(b);
            }

            return listBarang;
        }

        //Method untuk menghapus data Barang
        public static Boolean HapusData(string kode)
        {
            string sqlDelete = "delete from barangs where kodeKategori='" + kode + "'";

            int jumlahDataBerubah = Koneksi.JalankanPerintahDML(sqlDelete);
            if (jumlahDataBerubah == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion*/
    }
}
