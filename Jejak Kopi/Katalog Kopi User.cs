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

        public Katalog_Kopi_User(FormUtama induk,string usern)
        {
            InitializeComponent();
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
                string query = "SELECT * FROM kopi";

                DataTable dt = new(); // simplified 'new' expression

                using var conn = new Jejak_Kopi.Database.DatabaseHelper().GetConnection(); // 'using var' is shorter
                conn.Open();
                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }

                dataGridView1.DataSource = null;
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Columns.Clear();

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

        protected override void Dispose(bool disposing) // Buat gantiin yang di designer
        {
            if (disposing)
            {
                // Unsubscribe from parent events
                if (this != null)
                {
                    this.Load -= this.Katalog_Kopi_User_Load;
                }
            }
            base.Dispose(disposing);
        }
    }
}
