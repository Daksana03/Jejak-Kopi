using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Jejak_Kopi
{
    public partial class Dashboard_User : Form
    {
        public string usern;
        private FormUtama _induk;
        public Dashboard_User(string usern, FormUtama induk)
        {
            InitializeComponent();
            _induk = induk;
            label2.Text = usern;
            label4.Text = usern;

            this.usern = usern;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void Katalog_btn_Click(object sender, EventArgs e)
        {
            //Katalog_Kopi_User kopiUser = new Katalog_Kopi_User(usern);
            //kopiUser.Show();
            //this.Hide();

            if (_induk != null)
            {
                //_induk.BukaPanel(new Katalog_Kopi_User(_induk ,usern));
                _induk.BukaPanel(_induk.FormKatalogUser);
            }
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Katalog_Kopi_User kopiUser = new Katalog_Kopi_User(usern);
            //kopiUser.Show();
            //this.Hide();

        }
    }
}
