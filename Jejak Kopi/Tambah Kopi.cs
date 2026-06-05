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
    public partial class Tambah_Kopi : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private int idKatalog;
        public Tambah_Kopi()
        {
            InitializeComponent();
        }

        private void tambah_btn_Click(object sender, EventArgs e)
        {
            bool result = db.TambahKopi(
                    nama_kopi.Text,
                    decimal.Parse(stok.Text),
                    int.Parse(harga.Text),
                    kategori.Text);

            if (result)
            {
                MessageBox.Show("Data berhasil ditambahkan");
            }
        }
    }
}
