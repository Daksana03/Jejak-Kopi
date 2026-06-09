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
    public partial class Laporan : Form
    {
        private FormUtamaAdmin _induk;
        private readonly DatabaseHelper dbHelper;
        public string adminName;
        public Laporan(string adminName, FormUtamaAdmin induk)
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();

            label2.Text = adminName;
            label4.Text = adminName;

            dbHelper = new DatabaseHelper();
            TampilkanLaporan();
            this.adminName = adminName;
            _induk = induk;
        }

        public void TampilkanLaporan()
        {
            try
            {
                // 1. Ambil data dari fungsi helper yang membaca VIEW
                DataTable dt = dbHelper.GetLaporanPesananSelesai();

                // 2. Bersihkan datagridview sebelum diisi data baru
                data_kopi.DataSource = null;
                data_kopi.Columns.Clear();
                data_kopi.AutoGenerateColumns = false;

                // 3. Desain Kolom Grid secara manual agar rapi sesuai struktur VIEW
                DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
                colId.DataPropertyName = "id_pesanan";
                colId.HeaderText = "ID Pesanan";
                colId.Width = 90;
                data_kopi.Columns.Add(colId);

                DataGridViewTextBoxColumn colNama = new DataGridViewTextBoxColumn();
                colNama.DataPropertyName = "nama_pelanggan";
                colNama.HeaderText = "Nama Pelanggan";
                colNama.Width = 150;
                data_kopi.Columns.Add(colNama);

                DataGridViewTextBoxColumn colTanggal = new DataGridViewTextBoxColumn();
                colTanggal.DataPropertyName = "tanggal_pesanan";
                colTanggal.HeaderText = "Tanggal Transaksi";
                colTanggal.Width = 120;
                colTanggal.DefaultCellStyle.Format = "dd/MM/yyyy";
                data_kopi.Columns.Add(colTanggal);

                DataGridViewTextBoxColumn colStatus = new DataGridViewTextBoxColumn();
                colStatus.DataPropertyName = "status_pesanan";
                colStatus.HeaderText = "Status";
                colStatus.Width = 100;
                data_kopi.Columns.Add(colStatus);

                DataGridViewTextBoxColumn colTotal = new DataGridViewTextBoxColumn();
                colTotal.DataPropertyName = "total_bayar";
                colTotal.HeaderText = "Total Pembayaran";
                colTotal.Width = 130;
                colTotal.DefaultCellStyle.Format = "N0"; // Format ribuan tanpa desimal
                data_kopi.Columns.Add(colTotal);

                // 4. Ikat DataTable ke DataGridView
                data_kopi.DataSource = dt;

                // Buat agar data hanya bisa dibaca (Read Only)
                data_kopi.ReadOnly = true;
                data_kopi.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data ke grid: " + ex.Message, "Sistem Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void data_kopi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            _induk.BukaPanel(_induk.FormAdmin);
        }

        private void Data_btn_Click(object sender, EventArgs e)
        {
            _induk.BukaPanel(_induk.FormDataBiji);
        }

        private void Daftar_pelanggan_btn_Click(object sender, EventArgs e)
        {
            _induk.BukaPanel(_induk.FormDaftarPelanggan);
        }

        private void Pesanan_btn_Click(object sender, EventArgs e)
        {
            _induk.BukaPanel(_induk.FormPesanan);
        }
    }
}
