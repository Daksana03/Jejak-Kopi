using Jejak_Kopi.Database;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Jejak_Kopi
{
    public partial class Daftar_Pelanggan : Form
    {
        private string inuser;
        private FormUtamaAdmin _induk;

        public Daftar_Pelanggan()
        {
            InitializeComponent();
            LoadData();
            //inuser = adminName;         // <- set the field so it exists for button handlers
            //label2.Text = adminName;
            //label4.Text = adminName;
        }

        public Daftar_Pelanggan(string adminName, FormUtamaAdmin induk) : this()
        {
            inuser = adminName;         // <- set the field so it exists for button handlers
            label2.Text = adminName;
            label4.Text = adminName;
            _induk = induk;

        }

        private void LoadData()
        {
            string query = "SELECT * FROM daftar_pelanggan";

            DataTable dt = new(); // simplified 'new' expression

            using var conn = new Jejak_Kopi.Database.DatabaseHelper().GetConnection(); // 'using var' is shorter
            conn.Open();
            using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn))
            {
                da.Fill(dt);
            }

            data_pelanggan.DataSource = null;
            data_pelanggan.AutoGenerateColumns = false;
            data_pelanggan.Columns.Clear();

            DataGridViewTextBoxColumn colId = new(); // simplified 'new' expressions
            colId.DataPropertyName = "id_pengguna";
            colId.HeaderText = "ID";
            colId.Width = 50;
            data_pelanggan.Columns.Add(colId);

            DataGridViewTextBoxColumn colNama = new();
            colNama.DataPropertyName = "nama_lengkap";
            colNama.HeaderText = "Nama Lengkap";
            colNama.Width = 160;
            data_pelanggan.Columns.Add(colNama);

            DataGridViewTextBoxColumn colUsername = new();
            colUsername.DataPropertyName = "username";
            colUsername.HeaderText = "Username";
            colUsername.Width = 120;
            data_pelanggan.Columns.Add(colUsername);

            DataGridViewTextBoxColumn colTelp = new();
            colTelp.DataPropertyName = "no_telpon";
            colTelp.HeaderText = "No. Telepon";
            colTelp.Width = 130;
            data_pelanggan.Columns.Add(colTelp);

            DataGridViewTextBoxColumn colEmail = new();
            colEmail.DataPropertyName = "email";
            colEmail.HeaderText = "Email";
            colEmail.Width = 170;
            data_pelanggan.Columns.Add(colEmail);

            DataGridViewTextBoxColumn colStatus = new();
            colStatus.DataPropertyName = "status";
            colStatus.HeaderText = "Status";
            colStatus.Width = 80;
            data_pelanggan.Columns.Add(colStatus);

            data_pelanggan.DataSource = dt;
            data_pelanggan.ReadOnly = true;
            data_pelanggan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            //Form3 mainDashboard = new Form3(inuser, _induk);
            //mainDashboard.Show();
            //this.Hide();
            _induk.BukaPanel(_induk.FormAdmin);
        }

        private void data_pelanggan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Data_btn_Click(object sender, EventArgs e)
        {
            _induk.BukaPanel(_induk.FormDataBiji);
        }

        private void Pesanan_btn_Click(object sender, EventArgs e)
        {
            _induk.BukaPanel(_induk.FormPesanan);
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Laporan_btn_Click(object sender, EventArgs e)
        {
            _induk.BukaPanel(_induk.FormLaporan);
        }
    }
}
