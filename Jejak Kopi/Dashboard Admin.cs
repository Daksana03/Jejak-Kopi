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
    public partial class Form3 : Form
    {
        
        private readonly DatabaseHelper dbHelper;
        public string adminName;
        public Form3(string adminName)
        {
            InitializeComponent();
            label2.Text = adminName;
            label4.Text = adminName;

            dbHelper = new DatabaseHelper();
            LoadStat();
            this.adminName = adminName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Daftar_Pelanggan daftar = new Daftar_Pelanggan(adminName);
            daftar.Show();
            this.Hide();
        }

        private void LoadStat()
        {
            try
            {

                DataTable dt = dbHelper.GetStat(); // simplified 'new' expression

                dataGridView1.DataSource = null;
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Columns.Clear();

                DataGridViewTextBoxColumn colId = new(); // simplified 'new' expressions
                colId.DataPropertyName = "nama_menu";
                colId.HeaderText = "Nama";
                colId.Width = 140;
                dataGridView1.Columns.Add(colId);

                DataGridViewTextBoxColumn colTerjual = new();
                colTerjual.DataPropertyName = "total_jual";
                colTerjual.HeaderText = "Terjual";
                colTerjual.Width = 60;
                dataGridView1.Columns.Add(colTerjual);

                DataGridViewTextBoxColumn colOmset = new();
                colOmset.DataPropertyName = "total_omset";
                colOmset.HeaderText = "Omset";
                colOmset.Width = 52;
                dataGridView1.Columns.Add(colOmset);

                DataGridViewTextBoxColumn colFrek = new();
                colFrek.DataPropertyName = "frekuensi";
                colFrek.HeaderText = "Frekuensi";
                colFrek.Width = 70;
                dataGridView1.Columns.Add(colFrek);

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

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void Logout_btn_Click1(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void Data_btn_Click(object sender, EventArgs e)
        {
            Data_Biji_Kopi kopi = new Data_Biji_Kopi(adminName);
            kopi.Show();
            this.Hide();
        }
    }
}
