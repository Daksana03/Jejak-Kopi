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
        private readonly string inusern; // added to store the username passed in
        private FormUtama _induk;

        public Katalog_Kopi_User(FormUtama induk,string usern)
        {
            InitializeComponent();
            _induk = induk;
            inusern = usern;
            label2.Text = usern;
            label4.Text = usern;
            this.inusern = usern; 
            this.Load += this.Katalog_Kopi_User_Load;
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

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            //Dashboard_User userDBoard = new Dashboard_User(inusern);
            //userDBoard.Show();
            //this.Hide();
            if (_induk != null)
            {
                _induk.BukaPanel(new Dashboard_User(inusern, _induk));
                //_induk.BukaPanel(_induk.FormUser);
            }
        }
    }
}
