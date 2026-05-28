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
    public partial class Form3 : Form
    {
        public string adminName;
        public Form3(string adminName)
        {
            InitializeComponent();
            label2.Text = adminName;
            label4.Text = adminName;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void Logout_btn_Click1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Data_btn_Click(object sender, EventArgs e)
        {
            Data_Biji_Kopi kopi = new Data_Biji_Kopi(adminName);
            kopi.Show();
            this.Hide();
        }
    }
}
