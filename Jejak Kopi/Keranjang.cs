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
            dbHelper = new DatabaseHelper();
            LoadKeranjang();
        }
        private void LoadKeranjang()
        {
            try
            {
                // Contoh ID Pelanggan yang sedang aktif login (sesuaikan dengan sistem session Anda)
                string user = usrn;

                DataTable dt = dbHelper.GetKeranjang(user);

                dataGridView1.DataSource = null;
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Columns.Clear();

                DataGridViewTextBoxColumn colNama = new DataGridViewTextBoxColumn();
                colNama.DataPropertyName = "nama_biji_kopi";
                colNama.HeaderText = "Biji Kopi";
                colNama.Width = 160;
                dataGridView1.Columns.Add(colNama);

                DataGridViewTextBoxColumn colJenis = new DataGridViewTextBoxColumn();
                colJenis.DataPropertyName = "tipe_biji";
                colJenis.HeaderText = "Jenis";
                colJenis.Width = 100;
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
                colSubtotal.Width = 100;
                colSubtotal.DefaultCellStyle.Format = "N0";
                dataGridView1.Columns.Add(colSubtotal);

                dataGridView1.DataSource = dt;
                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
    }
}
