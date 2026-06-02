using System;
using System.Collections.Generic;
using System.Text;

namespace Jejak_Kopi
{
    public class User
    {
        public int id { get; set; }
        public bool is_admin { get; set; }
        public string nama { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string no_telepon { get; set; }
        public string email { get; set; }
        public bool is_delete { get; set; }

        public User(int id, bool admin, string nama, string user, string pass, string no, string email, bool delete)
        {
            this.id = id;
            this.is_admin = admin;
            this.nama = nama;
            this.username = user;
            this.password = pass;
            this.no_telepon = no;
            this.email = email;
            this.is_delete = delete;
        }

        public User() {}

    }
}
