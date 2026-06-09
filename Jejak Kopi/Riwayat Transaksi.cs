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
    public partial class Riwayat_Transaksi : Form
    {
        private int idUser;
        private readonly DatabaseHelper dbHelper;
        private string usern;
        private FormUtama _induk;

        public Riwayat_Transaksi(string usern, FormUtama induk)
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            this.usern = usern;
            label4.Text = usern;
            _induk = induk;
            LoadRiwayat();
        }

        public void LoadRiwayat()
        {
            try
            {
                User user = dbHelper.GetUserByUsername(usern);
                if (user == null)
                {
                    return;
                }

                DataTable dt = dbHelper.GetRiwayatUser(user.id);

                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();
                dataGridView1.AutoGenerateColumns = false;

                DataGridViewTextBoxColumn coltanggalpesan = new DataGridViewTextBoxColumn();
                coltanggalpesan.DataPropertyName = "tanggal_pesanan";
                coltanggalpesan.HeaderText = "Tanggal Pesan";
                coltanggalpesan.Width = 100;
                dataGridView1.Columns.Add(coltanggalpesan);

                DataGridViewTextBoxColumn colstatus = new DataGridViewTextBoxColumn();
                colstatus.DataPropertyName = "status_pesanan";
                colstatus.HeaderText = "Status Pesanan";
                colstatus.Width = 100;
                dataGridView1.Columns.Add(colstatus);

                DataGridViewTextBoxColumn coltanggalpengiriman = new DataGridViewTextBoxColumn();
                coltanggalpengiriman.DataPropertyName = "tanggal_pengiriman";
                coltanggalpengiriman.HeaderText = "Tanggal Pengiriman";
                coltanggalpengiriman.Width = 100;
                dataGridView1.Columns.Add(coltanggalpengiriman);

                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {

            }
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            _induk.BukaPanel(_induk.FormUser);
        }

        private void Katalog_btn_Click(object sender, EventArgs e)
        {
            _induk.BukaPanel(_induk.FormKatalogUser);
        }

        private void Keranjang_btn_Click(object sender, EventArgs e)
        {
            _induk.BukaPanel(_induk.FormKeranjang);
        }
    }
}
