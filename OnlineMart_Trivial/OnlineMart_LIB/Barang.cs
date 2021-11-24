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
        List<Barang_Cabang> listBarangCabang; // Composition
        List<Barang_Order> listBarangOrder; // Composition

        #region Constructors
        public Barang(int id, string nama, int harga, Kategori kategori)
        {
            Id = id;
            Nama = nama;
            Harga = harga;
            Kategori = kategori;
            ListBarangCabang = new List<Barang_Cabang>();
            ListBarangOrder = new List<Barang_Order>();
        }
        public Barang(string nama, int harga, Kategori kategori)
        {
            Nama = nama;
            Harga = harga;
            Kategori = kategori;
            ListBarangCabang = new List<Barang_Cabang>();
            ListBarangOrder = new List<Barang_Order>();
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
            set
            {
                if (value != "")
                {
                    nama = value;
                }
                else
                {
                    throw (new ArgumentException("Tolong inputkan nama barang"));
                }
            }
        }
        public int Harga 
        { 
            get => harga;
            set
            {
                if (value.ToString() != "")
                {
                    harga = value;
                }
                else
                {
                    throw (new ArgumentException("Tolong inputkan harga barang"));
                }
            }
        }
        public Kategori Kategori 
        { 
            get => kategori; 
            set => kategori = value; 
        }
        public List<Barang_Cabang> ListBarangCabang 
        { 
            get => listBarangCabang; 
            private set => listBarangCabang = value; 
        }
        public List<Barang_Order> ListBarangOrder 
        { 
            get => listBarangOrder; 
            private set => listBarangOrder = value; 
        }
        #endregion

        #region Methods
        //Method untuk menambah data Barang
        public static Boolean TambahData(Barang b)
        {
            //string yang menampung sql query insert into
            string sql = "insert into barangs (nama, harga, kategori_id) values ('" + b.Nama + "', " + b.Harga + ", " + b.Kategori.Id + ")";

            //menjalankan perintah sql
            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0) return false;
            else return true;

        }

        //Method untuk membaca data Barang
        public static List<Barang> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "select * from barangs b inner join kategoris k on b.kategori_id = k.id ";
            //apabila kriteria tidak kosong
            if (kriteria != "") sql += " where " + kriteria + " like '%" + nilaiKriteria + "%'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Barang> listBarang = new List<Barang>();

            //kalau bisa/berhasil dibaca maka dimasukkin ke list pake constructors
            while(hasil.Read() == true)
            {
                Kategori k = new Kategori (hasil.GetInt32(4), hasil.GetString(5));

                Barang b = new Barang(hasil.GetInt32(0), hasil.GetString(1), hasil.GetInt32(2), k);

                listBarang.Add(b);
            }
            return listBarang;
        }

        public static Barang AmbilData(int id)
        {
            string sql = "select * from barangs b inner join kategoris k on b.kategori_id = k.id where b.id = " + id;

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            Barang b = null;

            while (hasil.Read())
            {
                //kalau bisa/berhasil dibaca maka dimasukkin ke list pake constructors
                Kategori k = new Kategori(hasil.GetInt32(4), hasil.GetString(5));

                b = new Barang(hasil.GetInt32(0), hasil.GetString(1), hasil.GetInt32(2), k);
            }
            return b;
        }

        public static Boolean UbahData(Barang b)
        {
            // Querry Insert
            string sql = "update barangs set nama = '" + b.Nama + "', harga = " + b.Harga + ", kategori_id = " + b.Kategori.Id + " where id = " + b.Id;
            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0) return false;
            else return true;
        }

        //Method untuk menghapus data Barang
        public static Boolean HapusData(int id)
        {
            string sql = "delete from barangs where id = " + id;

            int jumlahDihapus = Koneksi.JalankanPerintahDML(sql);
            //Dicek apakah ada data yang berubah atau tidak
            if (jumlahDihapus == 0) return false;
            else return true;
        }
        #endregion
    }
}
