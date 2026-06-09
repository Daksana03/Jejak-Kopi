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
    public partial class Dashboard_User : Form
    {
        public string usern;
        private FormUtama _induk;
        private DatabaseHelper dbHelper;
        public Dashboard_User(string usern, FormUtama induk)
        {
            InitializeComponent();
            _induk = induk;
            label2.Text = usern;
            label4.Text = usern;

            this.usern = usern;
            dbHelper = new DatabaseHelper();
            MuatRingkasanBelanja();
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
        public void MuatRingkasanBelanja()
        {
            DataRow rowBelanja = dbHelper.GetTotalBelanjaPengguna(this.usern);

            if (rowBelanja != null)
            {
                long totalPembelian = Convert.ToInt64(rowBelanja["total_pembelian"]);
                long totalKopiDibeli = Convert.ToInt64(rowBelanja["total_kopi_dibeli"]);

                // Set nilai ke label dengan format mata uang rupiah tanpa desimal
                label5.Text = "Rp " + totalPembelian.ToString("N0");
                label7.Text = totalKopiDibeli.ToString() + " Kg";
            }
            else
            {
                label5.Text = "Rp 0";
                label7.Text = "0 Pack/Pcs";
            }
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            //Form1 login = new Form1();
            //login.Show();
            //this.Close();
            //this.Dispose();
            Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {

        }

        private void Keranjang_btn_Click(object sender, EventArgs e)
        {
            if (_induk != null)
            {
                //_induk.BukaPanel(new Katalog_Kopi_User(_induk ,usern));
                _induk.BukaPanel(_induk.FormKeranjang);
            }
        }

        private void Riwayat_btn_Click(object sender, EventArgs e)
        {
            _induk.BukaPanel(_induk.FormRiwayat);
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }
    }
}
