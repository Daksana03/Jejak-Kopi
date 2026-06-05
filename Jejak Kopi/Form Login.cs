using Jejak_Kopi.Database;
using Microsoft.VisualBasic.Logging;
using System.Drawing.Text;

namespace Jejak_Kopi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Login1_Click(object sender, EventArgs e)
        {
            string inusern = Username.Text;
            string inpass = Password.Text;
            DatabaseHelper dbHelper = new DatabaseHelper();
            List<User> users = dbHelper.GetAllUsers();
            bool status = false;
            bool is_admin = false;
            int id_current;

            foreach (User user in users)
            {
                if (inusern == user.username && inpass == user.password)
                {
                    MessageBox.Show("Berhasil");
                    status = true;
                    is_admin = user.is_admin;
                    id_current = user.id;
                }
            }

            if (status && is_admin)
            {
                Form3 mainDashboard = new Form3(inusern);
                mainDashboard.Show();
                this.Hide();
            }
            else if (status && is_admin == false)
            {
                //Dashboard_User userDBoard = new Dashboard_User(inusern);
                //userDBoard.Show();
                FormUtama FormUser = new FormUtama(inusern);
                FormUser.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Username atau Passwords Salah!!", "Login gagal");
            }
        }

        private void Register1_Click(object sender, EventArgs e)
        {
            using (Form2 regist = new Form2())
            {
                this.Hide();
                regist.ShowDialog();
            }
            this.Show();
        }

        //protected override void OnFormClosing(FormClosingEventArgs e)
        //{
        //    if (e.CloseReason == CloseReason.UserClosing)
        //    {
        //        Application.Exit();
        //    }
        //    base.OnFormClosing(e);
        //}
    }
}
