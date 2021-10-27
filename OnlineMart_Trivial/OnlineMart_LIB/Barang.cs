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
        private int id;
        private string nama;
        private int harga;
        private Kategori kategori;

        #region Constructors
        public Barang(int id, string nama, int harga, Kategori kategori)
        {
            Id = id;
            Nama = nama;
            Harga = harga;
            Kategori = kategori;
        }
        public Barang(string nama, int harga, Kategori kategori)
        {
            Nama = nama;
            Harga = harga;
            Kategori = kategori;
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
        public int Harga 
        { 
            get => harga; 
            set => harga = value; 
        }
        public Kategori Kategori 
        { 
            get => kategori; 
            set => kategori = value; 
        }
        #endregion

        #region Methods
        //Method untuk menambah data Barang
        public static Boolean TambahData(Barang b)
        {
            //string yang menampung sql query insert into
            string sql = "insert into barangs (id, nama, harga, kategori_id) values ('" + b.Id + "', '" + b.Nama + "', '" + b.Harga + "', '" + b.Kategori.Id + "')";

            //menjalankan perintah sql
            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0) return false;
            else return true;

        }

        //Method untuk membaca data Barang
        public static List<Barang> BacaData(string kriteria, string nilaiKriteria)
        {
<<<<<<< Updated upstream
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
=======
            string sql = "select B.id, B.nama, B.harga, K.id, K.nama from barangs as B inner join kategoris as K on B.kategori_id = K.id ";
            if (kriteria != "") //apabila kriteria tidak kosong
            {
                sql += " where " + kriteria + " like '%" + nilaiKriteria + "%'";
>>>>>>> Stashed changes
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

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
        public static Boolean UbahData(Barang b)
        {
            // Querry Insert
            string sql = "update barangs set nama = '" + b.Nama + "', harga = " + b.Harga + ", kategori_id = " + b.Kategori.Id + " WHERE id = " + b.Id;
            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0) return false;
            else return true;
        }

        //Method untuk menghapus data Barang
        public static Boolean HapusData(Barang barang)
        {
            string sql = "delete from barangs where id = '" + barang.Id + "'";

            int jumlahDihapus = Koneksi.JalankanPerintahDML(sql);
            //Dicek apakah ada data yang berubah atau tidak
            if (jumlahDihapus == 0) return false;
            else return true;
        }
        #endregion
    }
}
