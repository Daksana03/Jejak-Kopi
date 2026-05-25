using Jejak_Kopi.Database;
using System.Drawing.Text;

namespace Jejak_Kopi
{
    public partial class Form1 : Form
    {
        string testuser;
        string testpass;
        List<User> users;
        public Form1()
        {
            InitializeComponent();
            testuser = "rafif";
            testpass = "123";
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
            int id_current;

            foreach (User user in users)
            {
                if (inusern == user.username && inpass == user.password)
                {
                    MessageBox.Show("Berhasil");
                    status = true;
                    id_current = user.id;
                }
            }

            if (status)
            {
                //lanjut ke form selanjutnya
            }
            else
            {
                MessageBox.Show("Username atau Passwords Salah!!", "Login gagal");
            }
        }
    }
}
