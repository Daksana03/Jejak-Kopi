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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Register2_Click(object sender, EventArgs e)
        {
           
        }

        private void Kembali1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.ShowDialog();
            //this.Close();
        }

        private void Register2_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nama.Text))
            {
                MessageBox.Show("Nama lengkap harus diisi!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Nama.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(Username.Text))
            {
                MessageBox.Show("Username harus diisi!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Username.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(Password.Text))
            {
                MessageBox.Show("Password harus diisi!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Password.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(No_Telp.Text))
            {
                MessageBox.Show("Nomor telepon harus diisi!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                No_Telp.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(Email.Text))
            {
                MessageBox.Show("Email harus diisi!", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Email.Focus();
                return;
            }

            // Create new user
            User newUser = new User()
            {
                is_admin = false,
                nama = Nama.Text.Trim(),
                username = Username.Text.Trim(),
                password = Password.Text.Trim(),
                no_telepon = No_Telp.Text.Trim(),
                email = Email.Text.Trim(),
                is_delete = false
            };

            DatabaseHelper dbHelper = new DatabaseHelper();

            // Check if username already exists
            if (dbHelper.IsUsernameExists(newUser.username))
            {
                MessageBox.Show("Username sudah terdaftar! Silakan gunakan username lain.",
                    "Registrasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Username.Focus();
                Username.SelectAll();
                return;
            }

            // Attempt to register
            try
            {
                if (dbHelper.RegisterUser(newUser))
                {
                    MessageBox.Show("Registrasi berhasil! Silakan login.",
                        "Registrasi Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Return to login form
                    Form1 login = new Form1();
                    login.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Registrasi gagal! Silakan coba lagi.",
                        "Registrasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
