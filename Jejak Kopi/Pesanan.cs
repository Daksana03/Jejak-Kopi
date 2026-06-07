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
    public partial class Pesanan : Form
    {
        private FormUtamaAdmin _induk;
        private DatabaseHelper db = new DatabaseHelper();
        public Pesanan(FormUtamaAdmin induk)
        {
            InitializeComponent();
            LoadPesanan();
            _induk = induk;
        }

        private void LoadPesanan()
        {
            dataGridView1.DataSource = db.GetPesanan();

            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Pilih pesanan terlebih dahulu!");
                return;
            }

            int idPesanan =
                Convert.ToInt32(
                dataGridView1.SelectedRows[0]
                .Cells["id_pesanan"].Value);

            Status_pesanan form =
                new Status_pesanan(idPesanan);

            form.ShowDialog();

            LoadPesanan();
        }

        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            _induk.BukaPanel(_induk.FormAdmin);
        }

        private void Data_btn_Click(object sender, EventArgs e)
        {
            _induk.BukaPanel(_induk.FormDataBiji);
        }

        private void Daftar_pelanggan_btn_Click(object sender, EventArgs e)
        {
            _induk.BukaPanel(_induk.FormDaftarPelanggan);
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}

