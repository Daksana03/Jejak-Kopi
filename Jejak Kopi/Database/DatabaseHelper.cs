using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jejak_Kopi.Database
{
    public class DatabaseHelper
    {
        private string connString = "Host=localhost;Port=5432;Database=Jejak_Kopi;Username=postgres;Password=1234";

        // READ - ambil semua user
        public List<User> GetAllUsers()
        {
            List<User> list = new List<User>();
            using var conn = new NpgsqlConnection(connString);
            conn.Open();
            using var cmd = new NpgsqlCommand("SELECT * FROM pengguna", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new User(
                    reader.GetInt32(0),
                    reader.GetBoolean(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetString(5),
                    reader.GetString(6),
                    reader.GetBoolean(7)
                ));
            }
            return list;
        }

        

    }
}
