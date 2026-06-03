using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Jejak_Kopi
{
    public partial class Data_Biji_Kopi : Form
    {
        private readonly string adminName; // add this field

        public Data_Biji_Kopi(string adminName)
        {
            InitializeComponent();
            this.adminName = adminName;     // assign the field
            label2.Text = adminName;
            label4.Text = adminName;
        }

        private void Daftar_pelanggan_btn_Click(object sender, EventArgs e)
        {
            Daftar_Pelanggan daftar = new Daftar_Pelanggan(this.adminName);
            daftar.Show();
            this.Hide();
        }
    }
}
