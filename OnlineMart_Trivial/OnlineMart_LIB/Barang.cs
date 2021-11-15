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
            string sql = "select id, nama, harga, kategori_id from barangs ";
            if (kriteria != "") //apabila kriteria tidak kosong
            {
                sql += " where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Barang> listBarang = new List<Barang>();
            //kalau bisa/berhasil dibaca maka dimasukkin ke list pake constructors
            while(hasil.Read() == true)
            {
                Kategori k = Kategori.AmbilData(hasil.GetInt32(3));

                Barang b = new Barang(hasil.GetInt32(0), hasil.GetString(1), hasil.GetInt32(2), k);
                
                ////Ambil Barang_Cabang
                //string barang_cabang = "select bc.cabang_id, bc.stok from barang_cabang as bc " +
                //"inner join barangs as b on bc.barang_id = b.id where b.id = " + b.id;

                //MySqlDataReader hasil_join = Koneksi.JalankanPerintahQuery(barang_cabang);

                //while (hasil_join.Read())
                //{
                //    Cabang c_join = Cabang.AmbilData(hasil_join.GetInt32(0));

                //    Barang_Cabang bc = new Barang_Cabang(c_join, b, hasil_join.GetInt32(1));

                //    //Tambahkan hasil join ke composition relationship
                //    b.ListBarangCabang.Add(bc);
                //}

                ////Ambil Barang_Order
                //string barang_order = "select bo.order_id, bo.jumlah, bo.harga from barang_order as bo " +
                //"inner join barangs as b on bo.barang_id = b.id where b.id = " + b.id;

                //MySqlDataReader hasil_join2 = Koneksi.JalankanPerintahQuery(barang_order);

                //while (hasil_join2.Read())
                //{
                //    Order o_join = Order.AmbilData(hasil_join.GetInt32(0));

                //    Barang_Order bo = new Barang_Order(b, o_join, hasil_join.GetInt32(1), hasil_join.GetFloat(2));

                //    //Tambahkan hasil join ke composition relationship
                //    b.ListBarangOrder.Add(bo);
                //}

                listBarang.Add(b);
            }
            return listBarang;
        }

        public static Barang AmbilData(int id)
        {
            string sql = "select id, nama, harga, kategori_id from barangs where id = " + id;

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            hasil.Read();

            //kalau bisa/berhasil dibaca maka dimasukkin ke list pake constructors
            Kategori k = Kategori.AmbilData(hasil.GetInt32(3)); 

            Barang b = new Barang(hasil.GetInt32(0), hasil.GetString(1), hasil.GetInt32(2), k);

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
