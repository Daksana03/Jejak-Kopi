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
    public partial class Checkout : Form
    {
        private int _idPengguna;
        private List<int> _itemPilihan;
        private Keranjang _formKeranjang;
        private DatabaseHelper dbHelper;

        public Checkout(int idPengguna, List<int> itemPilihan, Keranjang formKeranjang)
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            _idPengguna = idPengguna;
            _itemPilihan = itemPilihan;
            _formKeranjang = formKeranjang;
            LoadMetodePembayaran();
        }

        private void LoadMetodePembayaran()
        {
            try
            {
                // Ambil data metode transaksi dari database
                DataTable dt = new DataTable();
                using (var conn = dbHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT id_metode_transaksi, nama_metode_transaksi FROM metode_transaksi";
                    using (var da = new Npgsql.NpgsqlDataAdapter(query, conn))
                    {
                        da.Fill(dt);
                    }
                }

                // Ikat data ke ComboBox
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "nama_metode_transaksi";       // Yang muncul di mata user (Cash, Saldo, dll)
                comboBox1.ValueMember = "id_metode_transaksi"; // ID asli yang akan dikirim ke database
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat metode pembayaran: " + ex.Message, "Error");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Register2_Click(object sender, EventArgs e)
        {
            string inputNoJalan = NoJalan.Text.Trim();
            string inputJalan = Jalan.Text.Trim();
            string inputKecamatan = Kecamatan.Text.Trim();
            string inputKabupaten = Kabupaten.Text.Trim();

            // 2. Validasi input alamat kosong
            if (string.IsNullOrEmpty(inputJalan) || string.IsNullOrEmpty(inputKecamatan) || string.IsNullOrEmpty(inputKabupaten))
            {
                MessageBox.Show("Semua kolom alamat (No, Jalan, Kecamatan, Kabupaten) wajib diisi untuk tujuan pengiriman!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Validasi pilihan ComboBox metode pembayaran
            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Silakan pilih metode pembayaran terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 4. Proses Insert/Update Alamat Pengiriman ke database terlebih dahulu
                bool alamatTersimpan = dbHelper.SimpanAlamat(_idPengguna, inputNoJalan, inputJalan, inputKecamatan, inputKabupaten);

                if (!alamatTersimpan) return; // Jika gagal menyimpan alamat, hentikan proses transaksi

                // 5. Jika sukses, ambil ID Metode Transaksi dari ComboBox lalu checkout item pilihan
                int idMetodePembayaran = Convert.ToInt32(comboBox1.SelectedValue);
                bool suksesCheckout = dbHelper.ProsesCheckoutPilihan(_idPengguna, idMetodePembayaran, _itemPilihan);

                if (suksesCheckout)
                {
                    MessageBox.Show("Checkout Berhasil! Alamat disimpan dan pesanan Anda sedang diproses.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh data tabel di form keranjang agar item yang dibeli terhapus dari visual grid
                    if (_formKeranjang != null)
                    {
                        _formKeranjang.LoadKeranjang();
                    }

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memproses transaksi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
