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
    public partial class Katalog_Kopi_User : Form
    {
        private readonly string inusern; // added to store the username passed in
        private FormUtama _induk;
        private readonly DatabaseHelper dbHelper;

        public Katalog_Kopi_User(FormUtama induk, string usern)
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            Katalog_Kopi_User_Load();
            _induk = induk;
            inusern = usern;
            label2.Text = usern;
            label4.Text = usern;
            this.inusern = usern;
            //this.Load += this.Katalog_Kopi_User_Load;
        }

        private void Katalog_Kopi_User_Load()
        {
            try
            {
                DataTable dt = dbHelper.GetKopiUser(); // simplified 'new' expression

                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();
                dataGridView1.AutoGenerateColumns = false;

                DataGridViewTextBoxColumn IdKatalog = new DataGridViewTextBoxColumn();
                IdKatalog.DataPropertyName = "id_katalog";
                IdKatalog.Name = "id_katalog"; // Penting: Ini nama referensi untuk baris pemanggilan kode
                IdKatalog.Visible = false;
                dataGridView1.Columns.Add(IdKatalog);

                DataGridViewTextBoxColumn colId = new(); // simplified 'new' expressions
                colId.DataPropertyName = "nama_menu";
                colId.HeaderText = "Biji Kopi";
                colId.Width = 160;
                dataGridView1.Columns.Add(colId);

                DataGridViewTextBoxColumn colNama = new();
                colNama.DataPropertyName = "stok_menu";
                colNama.HeaderText = "Stok";
                colNama.Width = 40;
                dataGridView1.Columns.Add(colNama);

                DataGridViewTextBoxColumn colUsername = new();
                colUsername.DataPropertyName = "harga_menu";
                colUsername.HeaderText = "Harga";
                colUsername.Name = "harga_menu";
                colUsername.Width = 52;
                dataGridView1.Columns.Add(colUsername);

                DataGridViewTextBoxColumn colTelp = new();
                colTelp.DataPropertyName = "jenis_menu";
                colTelp.HeaderText = "Jenis";
                colTelp.Width = 130;
                dataGridView1.Columns.Add(colTelp);

                dataGridView1.DataSource = dt;
                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal terhubung ke database: " + ex.Message, "Database Error");
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            //Dashboard_User userDBoard = new Dashboard_User(inusern);
            //userDBoard.Show();
            //this.Hide();
            if (_induk != null)
            {
                //_induk.BukaPanel(new Dashboard_User(inusern, _induk));
                _induk.BukaPanel(_induk.FormUser);
            }
        }

        private void tambah_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silakan pilih biji kopi dari tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi apakah TextBox Kuantitas kosong atau bukan angka
            if (string.IsNullOrWhiteSpace(textBox1.Text) || !int.TryParse(textBox1.Text, out int kuantitasBeli))
            {
                MessageBox.Show("Silakan masukkan jumlah kuantitas yang valid (angka)!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi memastikan jumlah beli tidak boleh 0 atau minus
            if (kuantitasBeli <= 0)
            {
                MessageBox.Show("Jumlah kuantitas pembelian minimal 1!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idKatalog = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_katalog"].Value);
                int hargaMenu = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["harga_menu"].Value);

                User userAktif = dbHelper.GetUserByUsername(inusern);
                if (userAktif == null)
                {
                    MessageBox.Show("Sesi pengguna tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Mengirim nilai kuantitasBeli yang diambil dari textBox1 ke database
                bool berhasil = dbHelper.TambahItemKeKeranjang(userAktif.id, idKatalog, kuantitasBeli, hargaMenu);

                if (berhasil)
                {
                    MessageBox.Show("Biji kopi berhasil dimasukkan ke keranjang belanja!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _induk.FormKeranjang.LoadKeranjang();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memproses item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Katalog_btn_Click(object sender, EventArgs e)
        {

        }

        private void Riwayat_btn_Click(object sender, EventArgs e)
        {
            _induk.BukaPanel(_induk.FormRiwayat);
        }

        private void Keranjang_btn_Click(object sender, EventArgs e)
        {
            _induk.BukaPanel(_induk.FormKeranjang);
        }
    }
}
