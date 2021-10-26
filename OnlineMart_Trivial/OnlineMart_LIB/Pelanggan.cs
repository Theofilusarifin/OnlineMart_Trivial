using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Pelanggan
    {
		#region Field
		private int id;
        private string nama;
        private string email;
        private string telepon;
        private double saldo;
        private double poin;
		#endregion

		#region Constructor
		public Pelanggan (int id1)
		{
			this.Id = id1;
		}
		public Pelanggan(int id, string nama, string email, string telepon, double saldo, double poin)
		{
			this.Id = id;
			this.Nama = nama;
			this.Email = email;
			this.Telepon = telepon;
			this.Saldo = saldo;
			this.Poin = poin;
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
			set => nama = value;
		}
		public string Email 
		{
			get => email; 
			set => email = value;
		}
		public string Telepon 
		{
			get => telepon; 
			set => telepon = value;
		}
		public double Saldo 
		{
			get => saldo; 
			set => saldo = value;
		}
		public double Poin 
		{
			get => poin; 
			set => poin = value;
		}
		#endregion
	}
}
