using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tambahkan ini untuk dapat memanggil private data member
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Chat
    {
        #region Fields
        private int id;
        private string isi;
        private DateTime waktu;
        private string role_pengirim;
        Order order;
        Driver driver;
        Pelanggan pelanggan;
        #endregion

        #region Constructors
        public Chat(string isi, DateTime waktu, string role_pengirim, Order order, Driver driver, Pelanggan pelanggan)
        {
            this.Isi = isi;
            this.Waktu = waktu;
            this.Role_pengirim = role_pengirim;
            this.Order = order;
            this.Driver = driver;
            this.Pelanggan = pelanggan;
        }
        public Chat(int id, string isi, DateTime waktu, string role_pengirim, Order order, Driver driver, Pelanggan pelanggan)
        {
            this.Id = id;
            this.Isi = isi;
            this.Waktu = waktu;
            this.Role_pengirim = role_pengirim;
            this.Order = order;
            this.Driver = driver;
            this.Pelanggan = pelanggan;
        }
        #endregion

        #region Properties
        public int Id 
        {
            get => id; 
            set => id = value; 
        }
        public string Isi 
        { 
            get => isi; 
            set => isi = value; 
        }
        public DateTime Waktu 
        { 
            get => waktu; 
            set => waktu = value; 
        }
        public string Role_pengirim 
        { 
            get => role_pengirim; 
            set => role_pengirim = value; 
        }
        public Order Order 
        { 
            get => order; 
            set => order = value; 
        }
        public Driver Driver 
        { 
            get => driver; 
            set => driver = value; 
        }
        public Pelanggan Pelanggan 
        { 
            get => pelanggan; 
            set => pelanggan = value; 
        }
        #endregion

        #region Methods

        //Method untuk menambah data
        public static Boolean TambahData(Chat c)
        {
            //string yang menampung sql query insert into
            string sql = "insert into chats (isi, waktu, role_pengirim, ordder_id, driver_id, pelanggan_id) values ('" + c.Isi + "', '" + c.Waktu.ToString("yyyy-MM-dd HH:mm:ss") + "', " + c.Role_pengirim + ", " + c.Order.Id + ", " + c.Driver.Id + ", " + c.Pelanggan.Id + ")";

            //menjalankan perintah sql
            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0) return false;
            else return true;
        }

        //Method untuk membaca data Cabang
        public static List<Chat> BacaData(string kriteria, long idOrder)
        {
            string sql = "select id, isi, waktu, role_pengirim, order_id, driver_id, pelanggan_id from chats ";
            if (kriteria != "") //kalau tidak kosong tambahkan ini
            {
                sql += " where " + kriteria + " like '%" + idOrder + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Chat> listChat = new List<Chat>();
            //kalau bisa/berhasil dibaca maka dimasukkin ke list pake constructors
            while (hasil.Read() == true)
            {
                Order o = Order.AmbilData(hasil.GetInt32(4));

                Driver d = Driver.AmbilData(hasil.GetInt32(5));

                Pelanggan p = Pelanggan.AmbilData(hasil.GetInt32(6));

                Chat c = new Chat(hasil.GetInt32(0), hasil.GetString(1), DateTime.Parse(hasil.GetString(2)), hasil.GetString(3), o, d, p);

                listChat.Add(c);
            }

            return listChat;
        }

        #endregion
    }
}
