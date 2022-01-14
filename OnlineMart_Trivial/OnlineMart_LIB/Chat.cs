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
        private string role_tujuan;
        Order order;
        Driver driver;
        Pelanggan pelanggan;
        Penjual penjual;
        #endregion

        #region Constructors
        public Chat(int id, string isi, DateTime waktu, string role_pengirim, string role_tujuan, Order order, Driver driver, Pelanggan pelanggan)
        {
            this.Id = id;
            this.Isi = isi;
            this.Waktu = waktu;
            this.Role_pengirim = role_pengirim;
            this.Role_tujuan = role_tujuan;
            this.Order = order;
            this.Driver = driver;
            this.Pelanggan = pelanggan;
            this.Penjual = null;
        }
        public Chat(string isi, DateTime waktu, string role_pengirim, string role_tujuan, Order order, Driver driver, Pelanggan pelanggan)
        {
            this.Isi = isi;
            this.Waktu = waktu;
            this.Role_pengirim = role_pengirim;
            this.Role_tujuan = role_tujuan;
            this.Order = order;
            this.Driver = driver;
            this.Pelanggan = pelanggan;
            this.Penjual = null;
        }
        public Chat(int id, string isi, DateTime waktu, string role_pengirim, string role_tujuan, Order order, Penjual penjual, Pelanggan pelanggan)
        {
            this.Id = id;
            this.Isi = isi;
            this.Waktu = waktu;
            this.Role_pengirim = role_pengirim;
            this.Role_tujuan = role_tujuan;
            this.Order = order;
            this.Penjual = penjual;
            this.Pelanggan = pelanggan;
            this.Driver = null;
        }
        public Chat(string isi, DateTime waktu, string role_pengirim, string role_tujuan, Order order, Penjual penjual, Pelanggan pelanggan)
        {
            this.Isi = isi;
            this.Waktu = waktu;
            this.Role_pengirim = role_pengirim;
            this.Role_tujuan = role_tujuan;
            this.Order = order;
            this.Penjual = penjual;
            this.Pelanggan = pelanggan;
            this.Driver = null;
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
        public string Role_tujuan
        {
            get => role_tujuan;
            set => role_tujuan = value;
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
		public Penjual Penjual 
        {
            get => penjual;
            set => penjual = value;
        }
		#endregion

		#region Methods
		//Method untuk menambah data
		public static Boolean TambahData(Chat c)
        {
            //string yang menampung sql query insert into
            string sql = "";
            if (c.Role_pengirim == "konsumen" && c.role_tujuan == "driver")
            {
                sql += "insert into chats (isi, waktu, role_pengirim, role_tujuan, order_id, driver_id, pelanggan_id) " +
                       "values ('" + c.Isi + "', '" + c.Waktu.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                       "'" + c.Role_pengirim + "', '" + c.Role_tujuan + "', " + c.Order.Id + ", " + c.Driver.Id + ", " +
                       "" + c.Pelanggan.Id + ")";
            }
            else if (c.Role_pengirim == "konsumen" && c.role_tujuan == "penjual")
            {
                sql += "insert into chats (isi, waktu, role_pengirim, role_tujuan, order_id, penjual_id, pelanggan_id) " +
                       "values ('" + c.Isi + "', '" + c.Waktu.ToString("yyyy-MM-dd HH:mm:ss") + "', " +
                       "'" + c.Role_pengirim + "', '" + c.Role_tujuan + "', " + c.Order.Id + ", " + c.Penjual.Id + ", " +
                       "" + c.Pelanggan.Id + ")";
            }
            else if (c.Role_pengirim == "driver" && c.role_tujuan == "konsumen")
			{
                sql += "insert into chats (isi, waktu, role_pengirim, role_tujuan, order_id, driver_id, pelanggan_id) " +
                       "values ('" + c.Isi + "', '" + c.Waktu.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + c.Role_pengirim + "', " +
                       "'" + c.Role_tujuan + "', " + c.Order.Id + ", " + c.Driver.Id + ", " + c.Pelanggan.Id + ")";
            }
            else if (c.Role_pengirim == "penjual" && c.role_tujuan == "konsumen")
            {
                sql += "insert into chats (isi, waktu, role_pengirim, role_tujuan, order_id, penjual_id, pelanggan_id) " +
                       "values ('" + c.Isi + "', '" + c.Waktu.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + c.Role_pengirim + "', " +
                       "'" + c.Role_tujuan + "', " + c.Order.Id + ", " + c.Penjual.Id + ", " + c.Pelanggan.Id + ")";
            }
            //menjalankan perintah sql
            int jumlahDitambah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDitambah == 0) return false;
            else return true;
        }

        //Method untuk membaca data
        public static List<Chat> BacaData(string kriteria, string idOrder)
        {
            string sql = "select * from chats c " +
                         "left join orders o on c.order_id = o.id " +
                         "left join penjuals pj on o.penjual_id = pj.id " +
                         "left join pelanggans p on o.pelanggan_id = p.id " +
                         "left join drivers d on o.driver_id = d.id ";
            
            //kalau tidak kosong tambahkan ini
            if (kriteria != "") sql += " where " + kriteria + " like '%" + idOrder + "%' order by c.waktu";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            List<Chat> listChat = new List<Chat>();
            //kalau bisa/berhasil dibaca maka dimasukkin ke list pake constructors
            while (hasil.Read() == true)
            {
                string role_pengirim = hasil.GetString(3);
                string role_tujuan = hasil.GetString(4);

                Pelanggan p = new Pelanggan(hasil.GetInt32(31), hasil.GetString(32), hasil.GetString(33), hasil.GetString(34), hasil.GetString(35), hasil.GetString(36), hasil.GetDouble(37), hasil.GetDouble(38));

                Chat c = null;

                if (role_pengirim == "driver" || role_tujuan == "driver")
                {
                    Driver d = new Driver(hasil.GetInt32(39), hasil.GetString(40), hasil.GetString(41), hasil.GetString(42), hasil.GetString(43), hasil.GetString(44));
                    Order o = new Order(long.Parse(hasil.GetString(5)), p, d);
                    c = new Chat(hasil.GetInt32(0), hasil.GetString(1), DateTime.Parse(hasil.GetString(2)), role_pengirim, role_tujuan, o, d, p);
                }
                else if (role_pengirim == "penjual" || role_tujuan == "penjual")
                {
                    Penjual pe = new Penjual(hasil.GetInt32(23), hasil.GetString(24), hasil.GetString(25), hasil.GetString(26), hasil.GetString(27), hasil.GetString(28), hasil.GetString(29));
                    Order o = new Order(long.Parse(hasil.GetString(5)), p, pe);
                    c = new Chat(hasil.GetInt32(0), hasil.GetString(1), DateTime.Parse(hasil.GetString(2)), role_pengirim, role_tujuan, o, pe, p);
                }

                listChat.Add(c);
            }

            hasil.Dispose();
            hasil.Close();

            return listChat;
        }

        #endregion
    }
}
