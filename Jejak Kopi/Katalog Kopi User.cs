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
    public partial class Katalog_Kopi_User : Form
    {
        public Katalog_Kopi_User(string usern)
        {
            InitializeComponent();
            label2.Text = usern;
            label4.Text = usern;

            this.Load += new EventHandler(this.Katalog_Kopi_User_Load);
        }

        private void Katalog_Kopi_User_Load(object sender, EventArgs e)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();
                List<KatalogUser> list = dbHelper.GetKatalogs();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = list;
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
    }
}
