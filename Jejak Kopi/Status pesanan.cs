using Jejak_Kopi.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Jejak_Kopi
{
    public partial class Status_pesanan : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        private int idPesanan;
        public Status_pesanan(int id)
        {
            InitializeComponent();
            idPesanan = id;

            comboBox2.Items.Add("Diproses");
            comboBox2.Items.Add("Dikirim");
            comboBox2.Items.Add("Selesai");
            comboBox2.Items.Add("Dibatalkan");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Pilih status terlebih dahulu!");
                return;
            }

            bool result = db.UbahStatusPesanan(
                idPesanan,
                comboBox2.SelectedItem.ToString());

            if (result)
            {
                MessageBox.Show(
                    "Status berhasil diubah");

                this.Close();
            }
        }
    }
}
