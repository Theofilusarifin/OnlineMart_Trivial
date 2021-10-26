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
    public partial class FormDaftarGift : Form
    {
        public FormDaftarGift()
        {
            InitializeComponent();
        }

        public List<Gift> listGift = new List<Gift>();

        private void FormDaftarGift_Load(object sender, EventArgs e)
        {
            listGift = Gift.BacaData("","");

            if(listGift.Count > 0)
            {
                //kalau ada data maka tampilkan di data grid
                dataGridViewGift.DataSource = listGift;

                if(!dataGridViewGift.Columns.Contains("btnUbahGrid"))
                {
                    DataGridViewButtonColumn bcolUbah = new DataGridViewButtonColumn();

                    bcolUbah.HeaderText = "Aksi";
                    bcolUbah.Text = "Ubah";
                    bcolUbah.Name = "btnUbahGrid";
                    bcolUbah.UseColumnTextForButtonValue = true;
                    dataGridViewGift.Columns.Add(bcolUbah);

                    DataGridViewButtonColumn bcolHapus = new DataGridViewButtonColumn();
                    bcolHapus.HeaderText = "Aksi";
                    bcolHapus.Text = "Hapus";
                    bcolHapus.Name = "btnHapusGrid";
                    bcolHapus.UseColumnTextForButtonValue = true;
                    dataGridViewGift.Columns.Add(bcolHapus);
                }
            }
            else
            {
                dataGridViewGift.DataSource = null;
            }
        }
    }
}
