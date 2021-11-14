using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Riwayat_isi_saldo
    {
        #region Fields
        private int id;
        private DateTime waktu;
        private int isiSaldo;
        private Pelanggan pelanggan;
        #endregion

        #region Constructors
        public Riwayat_isi_saldo(int id, DateTime waktu, int isiSaldo, Pelanggan pelanggan)
        {
            this.id = id;
            this.waktu = waktu;
            this.isiSaldo = isiSaldo;
            this.pelanggan = pelanggan;
        }
        public Riwayat_isi_saldo( DateTime waktu, int isiSaldo, Pelanggan pelanggan)
        {
            this.waktu = waktu;
            this.isiSaldo = isiSaldo;
            this.pelanggan = pelanggan;
        }
        #endregion

        #region Properties
        public int Id 
        { 
            get => id; 
            set => id = value; 
        }
        public DateTime Waktu 
        { 
            get => waktu; 
            set => waktu = value; 
        }
        public int IsiSaldo 
        { 
            get => isiSaldo; 
            set => isiSaldo = value; 
        }
        public Pelanggan Pelanggan 
        { 
            get => pelanggan; 
            set => pelanggan = value; 
        }
        #endregion

        #region Methods
        public static Boolean TambahData(Riwayat_isi_saldo r)
        {
            //menampung string
            string sql = "insert into riwayat_isi_saldos (waktu, isi_saldo, pelanggan_id) values ('" + r.Waktu.ToString("yyyy-MM-dd HH:mm:ss") + "', " + r.IsiSaldo + ", " + r.Pelanggan.Id + ")";

            //menjalankan perintah sql
            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0) return false;
            else return true;
        }
        public static List<Riwayat_isi_saldo> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql = "select id, waktu, isi_saldo, pelanggan_id from riwayat_isi_saldos ";
            if (kriteria != "") //apabila kriteria tidak kosong
            {
                sql += " where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }
            
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Riwayat_isi_saldo> listRiwayat = new List<Riwayat_isi_saldo>();
            //kalau bisa/berhasil dibaca maka dimasukkin ke list pake constructors
            while (hasil.Read() == true)
            {

                Pelanggan p = Pelanggan.AmbilData(hasil.GetInt32(3));

                Riwayat_isi_saldo r = new Riwayat_isi_saldo(hasil.GetInt32(0), DateTime.Parse(hasil.GetString(1)), hasil.GetInt32(2), p);               
              
                listRiwayat.Add(r);
            }

            return listRiwayat;
        }
        public static Riwayat_isi_saldo AmbilData(int id)
        {
            string sql = "select id, waktu, isi_saldo, pelanggan_id from riwayat_isi_saldos where id = " + id;

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            hasil.Read();

            Pelanggan p = Pelanggan.AmbilData(hasil.GetInt32(3));

            Riwayat_isi_saldo r = new Riwayat_isi_saldo(hasil.GetInt32(0), DateTime.Parse(hasil.GetString(1)), hasil.GetInt32(2), p);

            return r;
        }
        public static Boolean UbahData(Riwayat_isi_saldo r)
        {
            // Querry Insert
            string sql = "update riwayat_isi_saldos set waktu = '" + r.Waktu.ToString("yyyy-MM-dd HH:mm:ss") + "', isi_saldo = " + r.isiSaldo + ", pelanggan_id = " + r.Pelanggan.Id + " where id = " + r.Id;
            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0) return false;
            else return true;
        }

        //hapus data
        public static Boolean HapusData(int id)
        {
            string sql = "delete from riwayat_isi_saldos where id = " + id;

            int jumlahDataDihapus = Koneksi.JalankanPerintahDML(sql);
            //menegcek data berubah atau tidak
            if (jumlahDataDihapus == 0) return false;
            else return true;
        }
        #endregion
    }
}

