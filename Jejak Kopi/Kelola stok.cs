using Jejak_Kopi.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Jejak_Kopi
{
    public partial class Kelola_stok : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private int idKatalog;

        public Kelola_stok()
        {
            InitializeComponent();
        }

        // Call this constructor when opening the form to edit an existing item
        public Kelola_stok(int id, string nama, decimal stokValue, int hargaValue, string kategoriValue)
        {
            InitializeComponent();
            idKatalog = id;
            nama_kopi.Text = nama;
            stok.Text = stokValue.ToString();
            harga.Text = hargaValue.ToString();
            kategori.Text = kategoriValue;
        }

        private void edit_btn_Click_1(object sender, EventArgs e)
        {
            bool result = db.EditKopi(
                    idKatalog,
                    nama_kopi.Text,
                    decimal.Parse(stok.Text),
                    int.Parse(harga.Text),
                    kategori.Text);
            if (result)
            {
                MessageBox.Show("Data berhasil diupdate");
                Close();
            }
        }

        private void hapus_btn_Click(object sender, EventArgs e)
        {
            DialogResult konfirmasi = MessageBox.Show(
        "Yakin ingin menghapus data kopi ini?",
        "Konfirmasi Hapus",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                bool result = db.HapusKopi(idKatalog);

                if (result)
                {
                    MessageBox.Show("Data berhasil dihapus");
                    Close();
                }
            }
        }
    }
}


