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
        private Pelanggan pelanggan; //Aggregation
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
            string sql = "select * from riwayat_isi_saldos rws inner join pelanggans p on rws.pelanggan_id = p.id ";
            
            //apabila kriteria tidak kosong
            if (kriteria != "") sql += " where " + kriteria + " like '%" + nilaiKriteria + "%'";
            
            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Riwayat_isi_saldo> listRiwayat = new List<Riwayat_isi_saldo>();
            //kalau bisa/berhasil dibaca maka dimasukkin ke list pake constructors
            while (hasil.Read() == true)
            {

                Pelanggan p = new Pelanggan(hasil.GetInt32(4), hasil.GetString(5), hasil.GetString(6), hasil.GetString(7), hasil.GetString(8), hasil.GetString(9), hasil.GetDouble(10), hasil.GetDouble(11));

                Riwayat_isi_saldo r = new Riwayat_isi_saldo(hasil.GetInt32(0), DateTime.Parse(hasil.GetString(1)), hasil.GetInt32(2), p);               
              
                listRiwayat.Add(r);
            }

            return listRiwayat;
        }
        //public static Riwayat_isi_saldo AmbilData(int id, Koneksi kParram)
        //{
        //    string sql = "select id, waktu, isi_saldo, pelanggan_id from riwayat_isi_saldos where id = " + id;

        //    MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql, kParram);

        //    Riwayat_isi_saldo r = null;

        //    while (hasil.Read())
        //    {
        //        Pelanggan p = Pelanggan.AmbilData(hasil.GetInt32(3), kParram);

        //        r = new Riwayat_isi_saldo(hasil.GetInt32(0), DateTime.Parse(hasil.GetString(1)), hasil.GetInt32(2), p);
        //    }

        //    hasil.Close();
        //    hasil.Dispose();

        //    return r;
        //}
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

        public static List<Riwayat_isi_saldo> BacaTanggal(string bulan, string tahun)
        {
            string sql = "select * from riwayat_isi_saldos rws inner join pelanggans p on rws.pelanggan_id = p.id ";

            // kalau bulan dan tahun ada isinya
            if (bulan != "" && tahun != "") sql += " where MONTH(rws.waktu) = " + bulan + " and YEAR(rws.waktu) = " + tahun;
            // kalau bulan ada isinya
            else if (bulan != "") sql += " where MONTH(rws.waktu) = " + bulan;
            // kalau tahun ada isinya
            else if (tahun != "") sql += " where YEAR(rws.waktu) = " + tahun;

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Riwayat_isi_saldo> listRiwayatIsiSaldo = new List<Riwayat_isi_saldo>();

            // masukkan data yang ingin ditampilkan/dibaca ke class
            while (hasil.Read())
            {
                Pelanggan p = new Pelanggan(hasil.GetInt32(4), hasil.GetString(5), hasil.GetString(6), hasil.GetString(7), hasil.GetString(8), hasil.GetString(9), hasil.GetDouble(10), hasil.GetDouble(11));

                Riwayat_isi_saldo r = new Riwayat_isi_saldo(hasil.GetInt32(0), DateTime.Parse(hasil.GetString(1)), hasil.GetInt32(2), p);

                listRiwayatIsiSaldo.Add(r);
            }
            return listRiwayatIsiSaldo;
        }

        public static List<Int32> AmbilTahun()
        {
            string sql = "select distinct YEAR(waktu) from riwayat_isi_saldos";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Int32> listTahun = new List<Int32>();

            while (hasil.Read())
            {
                listTahun.Add(hasil.GetInt32(0));
            }

            return listTahun;
        }

        #endregion
    }
}

