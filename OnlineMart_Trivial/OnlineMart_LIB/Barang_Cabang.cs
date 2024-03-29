﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Barang_Cabang
    {
        #region Fields
        private Cabang cabang;
        private Barang barang;
        private int stok;

        #endregion

        #region Constructors
        public Barang_Cabang(Cabang cabang, Barang barang, int stok)
        {
            this.Cabang = cabang;
            this.Barang = barang;
            this.Stok = stok;
        }
        #endregion

        #region Properties
        public Cabang Cabang 
        { 
            get => cabang; 
            set => cabang = value; 
        }
        public Barang Barang 
        { 
            get => barang; 
            set => barang = value; 
        }
        public int Stok 
        { 
            get => stok; 
            set => stok = value; 
        }
        #endregion

        #region Methods
        public static Boolean TambahData(Barang_Cabang bc)
        {
            // Querry Insert
            string sql = "insert into barang_cabang values (" + bc.Cabang.Id + ", " + bc.Barang.Id + ", " + bc.Stok + ")";

            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0) return false;
            else return true;
        }

        public static List<Barang_Cabang> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "select * from barang_cabang bc " +
                         "inner join cabangs c on bc.cabang_id = c.id " +
                         "inner join pegawais p on c.pegawai_id = p.id " +
                         "inner join barangs b on bc.barang_id = b.id " +
                         "inner join kategoris k on b.kategori_id = k.id ";

            if (kriteria != "") sql += " where " + kriteria + " like '%" + nilaiKriteria + "%'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Barang_Cabang> listBarangCabang = new List<Barang_Cabang>();

            while (hasil.Read())
            {
                Pegawai pegawai = new Pegawai(hasil.GetInt32(7), hasil.GetString(8), hasil.GetString(9), hasil.GetString(10), hasil.GetString(11), hasil.GetString(12));

                Cabang cabang = new Cabang(hasil.GetInt32(3), hasil.GetString(4), hasil.GetString(5), pegawai);

                Kategori kategori = new Kategori(hasil.GetInt32(19), hasil.GetString(20));

                Barang barang = new Barang(hasil.GetInt32(13), hasil.GetString(14), hasil.GetInt32(15), hasil.GetString(16), hasil.GetString(17), kategori);

                Barang_Cabang barang_cabang = new Barang_Cabang(cabang, barang, hasil.GetInt32(2));

                listBarangCabang.Add(barang_cabang);
            }
            //hasil.Dispose();
            //hasil.Close();

            return listBarangCabang;
        }

        public static List<Barang_Cabang> BacaData(string cabang_id, string kriteria, string nilaiKriteria)
        {
            string sql = "select * from barang_cabang bc " +
                         "inner join cabangs c on bc.cabang_id = c.id " +
                         "inner join pegawais p on c.pegawai_id = p.id " +
                         "inner join barangs b on bc.barang_id = b.id " +
                         "inner join kategoris k on b.kategori_id = k.id " +
                         "where bc.cabang_id = " + cabang_id;

            if (kriteria != "") sql += " and " + kriteria + " like '%" + nilaiKriteria + "%'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Barang_Cabang> listBarangCabang = new List<Barang_Cabang>();

            while (hasil.Read())
            {
                Pegawai pegawai = new Pegawai(hasil.GetInt32(7), hasil.GetString(8), hasil.GetString(9), hasil.GetString(10), hasil.GetString(11), hasil.GetString(12));

                Cabang cabang = new Cabang(hasil.GetInt32(3), hasil.GetString(4), hasil.GetString(5), pegawai);

                Kategori kategori = new Kategori(hasil.GetInt32(19), hasil.GetString(20));

                Barang barang = new Barang(hasil.GetInt32(13), hasil.GetString(14), hasil.GetInt32(15), hasil.GetString(16), hasil.GetString(17), kategori);

                Barang_Cabang barang_cabang = new Barang_Cabang(cabang, barang, hasil.GetInt32(2));

                listBarangCabang.Add(barang_cabang);
            }

            //hasil.Dispose();
            //hasil.Close();

            return listBarangCabang;
        }

        public static Boolean UbahData(Barang_Cabang barang_cabang)
        {
            // Querry Insert
            string sql = "update barang_cabang set stok = '" + barang_cabang.Stok + "' " +
                         "where cabang_id = '" + barang_cabang.Cabang.Id + "' and barang_id = '" + barang_cabang.Barang.Id + "'";

            int jumlahDiubah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDiubah == 0) return false;
            else return true;
        }

        public static Barang_Cabang AmbilData(int cabang_id, int barang_id)
        {
            string sql = "select * from barang_cabang bc " +
                         "inner join cabangs c on bc.cabang_id = c.id " +
                         "inner join pegawais p on c.pegawai_id = p.id " +
                         "inner join barangs b on bc.barang_id = b.id " +
                         "inner join kategoris k on b.kategori_id = k.id " +
                         "where bc.cabang_id = " + cabang_id + " and bc.barang_id = " + barang_id;

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            Barang_Cabang bc = null;

            while (hasil.Read())
            {
                Pegawai pegawai = new Pegawai(hasil.GetInt32(7), hasil.GetString(8), hasil.GetString(9), hasil.GetString(10), hasil.GetString(11), hasil.GetString(12));

                Cabang cabang = new Cabang(hasil.GetInt32(3), hasil.GetString(4), hasil.GetString(5), pegawai);

                Kategori kategori = new Kategori(hasil.GetInt32(19), hasil.GetString(20));

                Barang barang = new Barang(hasil.GetInt32(13), hasil.GetString(14), hasil.GetInt32(15), hasil.GetString(16), hasil.GetString(17), kategori);

                bc = new Barang_Cabang(cabang, barang, hasil.GetInt32(2));

            }
            return bc;
        }
        #endregion
    }
}
