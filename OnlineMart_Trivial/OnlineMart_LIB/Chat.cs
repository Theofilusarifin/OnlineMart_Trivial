using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string sql = "insert into chats (isi, waktu, role_pengirim, order_id, driver_id, pelanggan_id) values ('" + c.Isi + "', '" + c.Waktu.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + c.Role_pengirim + "', " + c.Order.Id + ", " + c.Driver.Id + ", " + c.Pelanggan.Id + ")";

            //menjalankan perintah sql
            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0) return false;
            else return true;
        }

        //Method untuk membaca data
        public static List<Chat> BacaData(string kriteria, string idOrder)
        {
            string sql = "select * from chats c " +
                "inner join orders o on c.order_id = o.id " +
                "inner join pelanggans p on o.pelanggan_id = p.id " +
                "inner join drivers d on o.driver_id = d.id ";
            
            //kalau tidak kosong tambahkan ini
            if (kriteria != "") sql += " where " + kriteria + " like '%" + idOrder + "%'" + " order by c.waktu";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Chat> listChat = new List<Chat>();
            //kalau bisa/berhasil dibaca maka dimasukkin ke list pake constructors
            while (hasil.Read() == true)
            {
				Driver d = new Driver(hasil.GetInt32(28), hasil.GetString(29), hasil.GetString(30), hasil.GetString(31), hasil.GetString(32), hasil.GetString(33));

                Pelanggan p = new Pelanggan(hasil.GetInt32(20), hasil.GetString(21), hasil.GetString(22), hasil.GetString(23), hasil.GetString(24), hasil.GetString(25), hasil.GetDouble(26), hasil.GetDouble(27));

                Order o = new Order(long.Parse(hasil.GetString(4)), p, d);

                Chat c = new Chat(hasil.GetInt32(0), hasil.GetString(1), DateTime.Parse(hasil.GetString(2)), hasil.GetString(3), o, d, p);

                listChat.Add(c);
            }

            return listChat;
        }

        #endregion
    }
}
