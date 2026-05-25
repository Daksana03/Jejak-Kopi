using Jejak_Kopi.Database;

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

            foreach (User user in users)
            {
            //MessageBox.Show(user.username);
                if (inusern == user.username && inpass == user.password)
                {
                    MessageBox.Show("Berhasil");
                }
                //else
                //{
                //    MessageBox.Show("Salah woyy");
                //}
            }
        }
    }
}
