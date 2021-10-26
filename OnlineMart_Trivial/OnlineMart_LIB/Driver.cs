using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Driver
    {
		#region Field
		private int id;
        private string nama;
        private string email;
        private string password;
        private string telepon;
		#endregion

		#region Constructor
		public Driver(int id1)
		{
			this.Id = id1;
		}
		public Driver(int id, string nama, string email, string password, string telepon)
		{
			this.Id = id;
			this.Nama = nama;
			this.Email = email;
			this.Password = password;
			this.Telepon = telepon;
		}
		#endregion

		#region Property
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
		public string Password 
		{
			get => password; 
			set => password = value;
		}
		public string Telepon 
		{
			get => telepon;
			set => telepon = value;
		}
		#endregion
	}
}
