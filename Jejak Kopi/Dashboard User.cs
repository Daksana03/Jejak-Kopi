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
        public Dashboard_User(string usern)
        {
            InitializeComponent();
            label2.Text = usern;
            label4.Text = usern;

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

        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
