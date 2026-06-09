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
    public partial class Data_Biji_Kopi : Form
    {
        private readonly string adminName;
        private readonly DatabaseHelper dbHelper;
        private FormUtamaAdmin _induk;

        public Data_Biji_Kopi(string adminName, FormUtamaAdmin induk)
        {
            InitializeComponent();
            this.adminName = adminName;
            label2.Text = adminName;
            label4.Text = adminName;
            //edit_btn.Click += button2_Click_1;
            //btn_tambah.Click += button1_Click_1;

            dbHelper = new DatabaseHelper();
            LoadDataKopi();   // isi grid saat form dibuka
            _induk = induk;
        }

        // Mengisi DataGridView dengan data dari database
        private void LoadDataKopi()
        {
            DataTable dt = dbHelper.GetDataKopi();

            // Konfigurasi DataGridView
            data_kopi.DataSource = null;
            data_kopi.AutoGenerateColumns = false;
            data_kopi.Columns.Clear();

            // Tambahkan kolom sesuai view
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.DataPropertyName = "id_katalog";
            colId.HeaderText = "ID";
            colId.Width = 50;
            data_kopi.Columns.Add(colId);

            DataGridViewTextBoxColumn colNama = new DataGridViewTextBoxColumn();
            colNama.DataPropertyName = "nama_menu";
            colNama.HeaderText = "Nama Biji Kopi";
            colNama.Width = 180;
            data_kopi.Columns.Add(colNama);

            DataGridViewTextBoxColumn colStok = new DataGridViewTextBoxColumn();
            colStok.DataPropertyName = "stok_menu";
            colStok.HeaderText = "Stok (kg)";
            colStok.Width = 80;
            data_kopi.Columns.Add(colStok);

            DataGridViewTextBoxColumn colHarga = new DataGridViewTextBoxColumn();
            colHarga.DataPropertyName = "harga_menu";
            colHarga.HeaderText = "Harga (Rp)";
            colHarga.Width = 100;
            colHarga.DefaultCellStyle.Format = "N0";
            data_kopi.Columns.Add(colHarga);

            DataGridViewTextBoxColumn colJenis = new DataGridViewTextBoxColumn();
            colJenis.DataPropertyName = "jenis_menu";
            colJenis.HeaderText = "Jenis";
            colJenis.Width = 100;
            data_kopi.Columns.Add(colJenis);

            DataGridViewTextBoxColumn colDeskripsi = new DataGridViewTextBoxColumn();
            colDeskripsi.DataPropertyName = "deskripsi_menu";
            colDeskripsi.HeaderText = "Deskripsi";
            colDeskripsi.Width = 150;
            data_kopi.Columns.Add(colDeskripsi);

            // Tampilkan data
            data_kopi.DataSource = dt;

            // Atur properti readonly dan full row select
            data_kopi.ReadOnly = true;
            data_kopi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // Event handler tombol Daftar Pelanggan (sudah ada)
        private void Daftar_pelanggan_btn_Click(object sender, EventArgs e)
        {
            Daftar_Pelanggan daftar = new Daftar_Pelanggan(this.adminName, _induk);
            daftar.Show();
            this.Hide();
        }

        // Event lain jika diperlukan
        private void data_kopi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // bisa dikosongkan atau diisi sesuai kebutuhan
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Tambah_Kopi formTambah = new Tambah_Kopi();
            formTambah.Show();

            // refresh data setelah form ditutup
            LoadDataKopi();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (data_kopi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih data kopi terlebih dahulu!");
                return;
            }

            int id = Convert.ToInt32(
                data_kopi.SelectedRows[0].Cells[0].Value);

            string nama =
                data_kopi.SelectedRows[0].Cells[1].Value.ToString();

            decimal stok =
                Convert.ToDecimal(
                data_kopi.SelectedRows[0].Cells[2].Value);

            int harga =
                Convert.ToInt32(
                data_kopi.SelectedRows[0].Cells[3].Value);

            string kategori =
                data_kopi.SelectedRows[0].Cells[4].Value.ToString();

            Kelola_stok formEdit =
                new Kelola_stok(id, nama, stok, harga, kategori);

            formEdit.ShowDialog();

            LoadDataKopi();
        }

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            //Form3 mainDashboard = new Form3(this.adminName);
            //mainDashboard.Show();
            //this.Hide();
            _induk.BukaPanel(_induk.FormAdmin);
        }

        private void Daftar_pelanggan_btn_Click_1(object sender, EventArgs e)
        {
            _induk.BukaPanel(_induk.FormDaftarPelanggan);
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
