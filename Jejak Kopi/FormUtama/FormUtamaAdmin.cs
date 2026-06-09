using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Jejak_Kopi
{
    public partial class FormUtamaAdmin : Form
    {
        public string data; //Sementara jadi public. Harusnya ini jadi id dari usernya dan private(?)
        public Form3 FormAdmin;
        public Daftar_Pelanggan FormDaftarPelanggan;
        public Data_Biji_Kopi FormDataBiji;
        public Pesanan FormPesanan;
        public Laporan FormLaporan;

        public FormUtamaAdmin(string data)
        {
            InitializeComponent();
            panel1.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic)?.SetValue(panel1, true, null); // Double buffered biar transisi mulus
            this.DoubleBuffered = true; // mungkin redundan
            this.data = data;
            Preload();

            BukaPanel(FormAdmin);
            //BukaPanel(FormUser);
        }

        public void Preload()
        {
            //FormUser = new Dashboard_User(data, this) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill, Visible = false };
            //FormKatalogUser = new Katalog_Kopi_User(this, data) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill, Visible = false };
            //FormKeranjang = new Keranjang(data, this) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill, Visible = false };

            //panel1.Controls.Add(FormUser);
            //panel1.Controls.Add(FormKatalogUser);
            //panel1.Controls.Add(FormKeranjang);

            //FormUser.Show();
            //FormKatalogUser.Show();
            //FormKeranjang.Show();
            FormAdmin = new Form3(data, this) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill, Visible = false };
            FormDaftarPelanggan = new Daftar_Pelanggan(data, this) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill, Visible = false };
            FormDataBiji = new Data_Biji_Kopi(data, this) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill, Visible = false };
            FormPesanan = new Pesanan(data,this) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill, Visible = false };
            FormLaporan = new Laporan(data, this) { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill, Visible = false };

            panel1.Controls.Add(FormAdmin);
            panel1.Controls.Add(FormDaftarPelanggan);
            panel1.Controls.Add(FormDataBiji);
            panel1.Controls.Add(FormPesanan);
            panel1.Controls.Add(FormLaporan);
            
            FormAdmin.Show();
            FormDaftarPelanggan.Show();
            FormDataBiji.Show();
            FormPesanan.Show();
            FormLaporan.Show();
        }

        public void BukaPanel(Form formAnak)
        {
            //if (this.panel1.Controls.Count > 0)
            //{

            //    this.panel1.Controls[0].Dispose();
            //    this.panel1.Controls.Clear();
            //}

            //formAnak.TopLevel = false;
            //formAnak.FormBorderStyle = FormBorderStyle.None;
            //formAnak.Dock = DockStyle.Fill;

            //this.panel1.Controls.Add(formAnak);
            //this.panel1.Tag = formAnak;
            //formAnak.Show();
            panel1.SuspendLayout();
            foreach (Control control in panel1.Controls)
            {
                control.Visible = false;
            }
            formAnak.Visible = true;
            formAnak.BringToFront();
            panel1.ResumeLayout();


        }
    }
}
