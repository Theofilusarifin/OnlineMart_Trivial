using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Kategori
    {
        private int id;
        private string nama;

        #region Constructors
        public Kategori(int id, string nama)
        {
            Id = id;
            Nama = nama;
        }
        #endregion

        #region Properties
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        #endregion

        #region Method    
        public static void TambahData(Kategori k)
        {
            string sqlInsert = "Insert into kategoris (Id, Nama)" +  " values ('" + k.Id + "','" + k.Nama + "')";

            Koneksi.JalankanPerintahDML(sqlInsert);
        }
        public static List<Kategori> BacaData(string kriteria, string nilaiKriteria)
        {
            string sqlRead = "";
            if(kriteria == "")
            {
                sqlRead = "select * from kategoris";
            }
            else
            {
                sqlRead = "select * from kategoris where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sqlRead);

            List<Kategori> listKategori = new List<Kategori>();

            while(hasil.Read() == true)
            {
                Kategori k = new Kategori(int.Parse(hasil.GetValue(0).ToString()), hasil.GetValue(1).ToString());
                listKategori.Add(k);
            }
            return listKategori;
        }
        public static Boolean HapusData(string id)
        {
            string sqlDelete = "delete from kategoris where id = '" + id + "'";
            int jumlahDataBerubah = Koneksi.JalankanPerintahDML(sqlDelete);

            if(jumlahDataBerubah == 0)
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
