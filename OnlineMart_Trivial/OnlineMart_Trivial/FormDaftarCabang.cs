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
    public partial class FormDaftarCabang : Form
    {
        public FormDaftarCabang()
        {
            InitializeComponent();
        }

        public List<Cabang> listCabang = new List<Cabang>();

        private void FormatDataGrid()
        {
            //Kosongi semua kolom di datagridview
            dataGridView.Columns.Clear();

            //Menambah kolom di datagridview
            dataGridView.Columns.Add("id", "Id");
            dataGridView.Columns.Add("nama", "Nama Cabang");
            dataGridView.Columns.Add("alamat", "Alamat");
            dataGridView.Columns.Add("pegawai_id", "Pegawai");

            //Agar lebar kolom dapat menyesuaikan panjang / isi data
            dataGridView.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["alamat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns["pegawai_id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Agar user tidak bisa menambah baris maupun mengetik langsung di datagridview
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            //Kosongi isi datagridview
            dataGridView.Rows.Clear();

            if (listCabang.Count > 0)
            {
                foreach (Cabang c in listCabang)
                {
                    dataGridView.Rows.Add(c.Id, c.Nama, c.Alamat, c.Pegawai.Nama);
                }
            }
            else
            {
                dataGridView.DataSource = null;
            }

            //Tampilkan button Ubah dan Hapus
            if (!dataGridView.Columns.Contains("btnUbahGrid"))
            {
                DataGridViewButtonColumn bcolUbah = new DataGridViewButtonColumn();

                bcolUbah.HeaderText = "Aksi";
                bcolUbah.Text = "Ubah";
                bcolUbah.Name = "btnUbahGrid";
                bcolUbah.UseColumnTextForButtonValue = true;
                dataGridView.Columns.Add(bcolUbah);

                DataGridViewButtonColumn bcolHapus = new DataGridViewButtonColumn();

                bcolHapus.HeaderText = "Aksi";
                bcolHapus.Text = "Hapus";
                bcolHapus.Name = "btnHapusGrid";
                bcolHapus.UseColumnTextForButtonValue = true;
                dataGridView.Columns.Add(bcolHapus);
            }
        }

        private void FormDaftarCabang_Load(object sender, EventArgs e)
        {
            // Panggil Method untuk menambah kolom pada datagridview
            FormatDataGrid();

            // Tampilkan semua data
            listCabang = Cabang.BacaData("", "");

            //Tampilkan semua isi list di datagridview (Panggil method TampilDataGridView)
            TampilDataGrid();
        }

        private void textBoxKriteria_TextChanged(object sender, EventArgs e)
        {
            string kriteria = "";
            switch (comboBoxKriteria.Text)
            {
                case "Id":
                    kriteria = "C.id";
                    break;

                case "Nama":
                    kriteria = "C.nama";
                    break;

                case "Alamat":
                    kriteria = "C.alamat";
                    break;

                case "Pegawai":
                    kriteria = "P.nama";
                    break;
            }

            listCabang = Cabang.BacaData(kriteria, textBoxKriteria.Text);
            FormatDataGrid();
            TampilDataGrid();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Menghapus data bila button hapus diklik
            int id = int.Parse(dataGridView.CurrentRow.Cells["Id"].Value.ToString());


            //Kalau button hapus diklik
            if (e.ColumnIndex == dataGridView.Columns["btnHapusGrid"].Index && e.RowIndex >= 0)
            {
                string idHapus = dataGridView.CurrentRow.Cells["Id"].Value.ToString();
                string namaHapus = dataGridView.CurrentRow.Cells["Nama"].Value.ToString();

                //User ditanya sesuai dibawah
                DialogResult hasil = MessageBox.Show(this, "Anda yakin akan menghapus Id " + idHapus + " - " + namaHapus + "?",
                                                     "HAPUS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Kalau User klik yes barang akan dihapus
                if (hasil == DialogResult.Yes)
                {
                    Boolean hapus = Barang.HapusData(id);

                    if (hapus == true)
                    {
                        MessageBox.Show("Penghapusan data berhasil");
                    }
                    else
                    {
                        MessageBox.Show("Penghapusan data gagal");
                    }
                }

            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahCabang tambah = new FormTambahCabang();
            tambah.Owner = this;
            tambah.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
