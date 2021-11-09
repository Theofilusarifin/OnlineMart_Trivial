﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineMart_LIB;

namespace OnlineMart_Trivial
{
    public partial class FormDaftarOrder : Form
    {
        public List<Order> listOrder = new List<Order>();
        public FormDaftarOrder()
        {
            InitializeComponent();
        }

		private void FormDaftarOrder_Load(object sender, EventArgs e)
		{
			//listOrder = Order.BacaData("", "");

			if (listOrder.Count > 0)
			{
				dataGridView.DataSource = listOrder; //menampilkan data

				if (!dataGridView.Columns.Contains("buttonUbah"))
				{
					DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
					bcol.HeaderText = "Aksi";
					bcol.Text = "Ubah";
					bcol.Name = "btnUbahGrid";
					bcol.UseColumnTextForButtonValue = true;
					dataGridView.Columns.Add(bcol);

					DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
					bcol2.HeaderText = "Aksi";
					bcol2.Text = "Hapus";
					bcol2.Name = "btnHapusGrid";
					bcol2.UseColumnTextForButtonValue = true;
					dataGridView.Columns.Add(bcol2);
				}
			}
			else
			{
				dataGridView.DataSource = null;
			}
		}
	}
}
