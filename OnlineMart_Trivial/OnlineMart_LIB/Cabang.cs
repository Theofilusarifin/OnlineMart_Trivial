﻿using System;
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
        #region Fields
        private int id;
        private string nama;
        private string alamat;
        private Pegawai pegawai;
        List<Order> listOrder; //Aggregation
        List<Barang_Cabang> listBarangCabang; // Composition
        #endregion

        #region Constructors
        public Cabang(int id, string nama, string alamat, Pegawai pegawai)
        {
            Id = id;
            Nama = nama;
            Alamat = alamat;
            Pegawai = pegawai;
            ListOrder = new List<Order>();
            ListBarangCabang = new List<Barang_Cabang>();
        }
        public Cabang(string nama, string alamat, Pegawai pegawai)
        {
            Nama = nama;
            Alamat = alamat;
            Pegawai = pegawai;
            ListOrder = new List<Order>();
            ListBarangCabang = new List<Barang_Cabang>();
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
                    throw (new ArgumentException("Tolong inputkan nama cabang"));
                }
            }
        }
        public string Alamat 
        { 
            get => alamat;
            set
            {
                if (value != "")
                {
                    alamat = value;
                }
                else
                {
                    throw (new ArgumentException("Tolong inputkan alamat cabang"));
                }
            } 
        }
        public Pegawai Pegawai 
        { 
            get => pegawai;
            set
            {
                pegawai = value;
            }
        }

        public List<Order> ListOrder 
        { 
            get => listOrder; 
            private set => listOrder = value; 
        }
        public List<Barang_Cabang> ListBarangCabang 
        { 
            get => listBarangCabang; 
            private set => listBarangCabang = value; 
        }
        #endregion

        #region Methods
        //Method untuk menambah data Cabang
        public static Boolean TambahData(Cabang c)
        {
            //string yang menampung sql query insert into
            string sql = "insert into cabangs (nama, alamat, pegawai_id) values ('" + c.Nama + "', '" + c.Alamat + "', " + c.Pegawai.Id + ")";

            //menjalankan perintah sql
            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0) return false;
            else return true;
        }

        //Method untuk membaca data Cabang
        public static List<Cabang> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "select * from cabangs c inner join pegawais p on c.pegawai_id = p.id ";
            //kalau tidak kosong tambahkan ini
            if (kriteria != "") sql += " where " + kriteria + " like '%" + nilaiKriteria + "%'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Cabang> listCabang = new List<Cabang>();
            //kalau bisa/berhasil dibaca maka dimasukkin ke list pake constructors
            while(hasil.Read() == true)
            {
                Pegawai p = new Pegawai(hasil.GetInt32(4), hasil.GetString(5), hasil.GetString(6), hasil.GetString(7), hasil.GetString(8), hasil.GetString(9));

                Cabang c = new Cabang(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), p);

                //Ambil Barang_Cabang
                //string barang_cabang = "select * from barang_cabang bc " +
                //    "inner join cabangs c on bc.cabang_id = c.id " +
                //    "inner join barangs b on bc.barang_id = b.id " +
                //    "inner join kategoris k on b.kategori_id = k.id " +
                //    "where c.id = " + c.Id;

                //MySqlDataReader hasil_join = Koneksi.JalankanPerintahQuery(barang_cabang);

                //while (hasil_join.Read())
                //{
                //    Kategori k = new Kategori(hasil_join.GetInt32(11), hasil_join.GetString(12));

                //    Barang b = new Barang(hasil_join.GetInt32(7), hasil_join.GetString(8), hasil_join.GetInt32(9), k);

                //    Barang_Cabang bc = new Barang_Cabang(c, b, hasil_join.GetInt32(2));

                //    //Tambahkan hasil join ke composition relationship
                //    c.ListBarangCabang.Add(bc);
                //}
                listCabang.Add(c);
            }
            return listCabang;
        }

        public static Cabang AmbilData(int id, Koneksi kParram)
        {
            string sql = "select id, nama, alamat, pegawai_id from cabangs where id = " + id;

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql, kParram);

            Cabang c = null;

            while (hasil.Read())
            {
                Pegawai p = Pegawai.AmbilData(hasil.GetInt32(3), kParram);

                c = new Cabang(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), p);
            }

            hasil.Close();
            hasil.Dispose();

            return c;
        }

        public static Boolean UbahData(Cabang c)
        {
            // Querry Insert
            string sql = "update cabangs set nama = '" + c.Nama + "', alamat = '" + c.Alamat + "', pegawai_id = " + c.Pegawai.Id + " where id = " + c.Id;
            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0) return false;
            else return true;
        }

        //Method untuk menghapus data Cabang
        public static Boolean HapusData(int id)
        {
            string sql = "delete from cabangs where id = " + id;

            int jumlahDataDihapus = Koneksi.JalankanPerintahDML(sql);
            //Dicek apakah ada data yang berubah atau tidak
            if (jumlahDataDihapus == 0) return false;
            else return true;
        }
        #endregion
    }
}
