using Jejak_Kopi.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace Jejak_Kopi
{
    public partial class Keranjang : Form
    {
        public string usrn;
        private FormUtama _induk;
        private readonly DatabaseHelper dbHelper;

        public Keranjang(string usrn, FormUtama induk)
        {
            InitializeComponent();
            _induk = induk;
            this.usrn = usrn;
            label4.Text = usrn;
            dbHelper = new DatabaseHelper();
            LoadKeranjang();
        }
        public void LoadKeranjang()
        {
            try
            {
                DataTable dt = dbHelper.GetKeranjangByUsername(usrn);

                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();
                dataGridView1.AutoGenerateColumns = false;

                // 1. Kolom Pilihan Checkbox (User bisa memilih item)
                DataGridViewCheckBoxColumn colCheck = new DataGridViewCheckBoxColumn();
                colCheck.Name = "pilih_item";
                colCheck.HeaderText = "Pilih";
                colCheck.Width = 40;
                dataGridView1.Columns.Add(colCheck);

                // 2. Kolom ID Keranjang (Disembunyikan)
                DataGridViewTextBoxColumn colIdKrz = new DataGridViewTextBoxColumn();
                colIdKrz.DataPropertyName = "id_keranjang";
                colIdKrz.Name = "id_keranjang";
                colIdKrz.Visible = false;
                dataGridView1.Columns.Add(colIdKrz);

                // 3. Kolom Info Produk
                DataGridViewTextBoxColumn colNama = new DataGridViewTextBoxColumn();
                colNama.DataPropertyName = "nama_biji_kopi";
                colNama.HeaderText = "Biji Kopi";
                colNama.Width = 140;
                dataGridView1.Columns.Add(colNama);

                DataGridViewTextBoxColumn colJenis = new DataGridViewTextBoxColumn();
                colJenis.DataPropertyName = "tipe_biji";
                colJenis.HeaderText = "Jenis";
                colJenis.Width = 90;
                dataGridView1.Columns.Add(colJenis);

                DataGridViewTextBoxColumn colHarga = new DataGridViewTextBoxColumn();
                colHarga.DataPropertyName = "harga_satuan";
                colHarga.HeaderText = "Harga";
                colHarga.Width = 80;
                colHarga.DefaultCellStyle.Format = "N0";
                dataGridView1.Columns.Add(colHarga);

                DataGridViewTextBoxColumn colQty = new DataGridViewTextBoxColumn();
                colQty.DataPropertyName = "jumlah_beli";
                colQty.HeaderText = "Jumlah";
                colQty.Width = 60;
                dataGridView1.Columns.Add(colQty);

                DataGridViewTextBoxColumn colSubtotal = new DataGridViewTextBoxColumn();
                colSubtotal.DataPropertyName = "subtotal";
                colSubtotal.HeaderText = "Subtotal";
                colSubtotal.Width = 90;
                colSubtotal.DefaultCellStyle.Format = "N0";
                dataGridView1.Columns.Add(colSubtotal);

                dataGridView1.DataSource = dt;
                dataGridView1.ReadOnly = false;

                // Set agar hanya kolom Checkbox yang bisa diedit nilainya oleh user
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    if (col.Name != "pilih_item") col.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data keranjang: " + ex.Message, "Database Error");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            if (_induk != null)
            {
                //_induk.BukaPanel(new Dashboard_User(inusern, _induk));
                _induk.BukaPanel(_induk.FormUser);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit(); // Hentikan edit grid agar status check terbaru tersimpan

            List<int> itemTerpilih = new List<int>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["pilih_item"].Value != null && (bool)row.Cells["pilih_item"].Value == true)
                {
                    int idKrz = Convert.ToInt32(row.Cells["id_keranjang"].Value);
                    itemTerpilih.Add(idKrz);
                }
            }

            if (itemTerpilih.Count == 0)
            {
                MessageBox.Show("Silakan centang item di keranjang yang ingin Anda checkout terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Dapatkan info user id dari username session
            User userAktif = dbHelper.GetUserByUsername(usrn);
            if (userAktif == null) return;

            // Buka form checkout dengan melemparkan parameter list data pilihan
            Checkout checkoutForm = new Checkout(userAktif.id, itemTerpilih, this);
            checkoutForm.ShowDialog();
        }

        private void Katalog_btn_Click(object sender, EventArgs e)
        {
            _induk.BukaPanel(_induk.FormKatalogUser);
        }

        private void Riwayat_btn_Click(object sender, EventArgs e)
        {
            _induk.BukaPanel(_induk.FormRiwayat);
            //_induk.BukaPanel(_induk.Form)
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
