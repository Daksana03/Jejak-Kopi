using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jejak_Kopi.Database
{
    public class DatabaseHelper
    {
        private string connString = "Host=localhost;Port=5432;Database=Jejak_Kopi;Username=postgres;Password=tidakdiketahui";

        public NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connString);
        }

        // READ - Get all users
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
                    reader.GetInt32(0),      // id
                    reader.GetBoolean(1),     // is_admin
                    reader.GetString(2),      // nama_lengkap -> maps to User.nama
                    reader.GetString(3),      // username
                    reader.GetString(4),      // password
                    reader.GetString(5),      // no_telepon
                    reader.GetString(6),      // email
                    reader.GetBoolean(7)      // is_delete
                ));
            }
            return list;
        }

        // CHECK if username already exists
        public bool IsUsernameExists(string username)
        {
            using var conn = GetConnection();
            conn.Open();
            string query = "SELECT COUNT(*) FROM pengguna WHERE username = @username";
            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);

            long count = (long)cmd.ExecuteScalar();
            return count > 0;
        }

        // CREATE - Register new user
        public bool RegisterUser(User user)
        {
            using var conn = GetConnection();
            conn.Open();

            string query = @"INSERT INTO pengguna (is_admin, nama_lengkap, username, passwords, no_telepon, email, is_delete) 
                     VALUES (@is_admin, @nama_lengkap, @username, @passwords, @no_telepon, @email, @is_delete)";

            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@is_admin", user.is_admin);
            cmd.Parameters.AddWithValue("@nama_lengkap", user.nama);
            cmd.Parameters.AddWithValue("@username", user.username);
            cmd.Parameters.AddWithValue("@passwords", user.password);
            cmd.Parameters.AddWithValue("@no_telpon", user.no_telepon);
            cmd.Parameters.AddWithValue("@email", user.email);
            cmd.Parameters.AddWithValue("@is_delete", user.is_delete);

            return cmd.ExecuteNonQuery() > 0;  // Returns bool
        }

        // READ - Get single user by username
        public User GetUserByUsername(string username)
        {
            using var conn = GetConnection();
            conn.Open();
            string query = "SELECT * FROM pengguna WHERE username = @username";
            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new User(
                    reader.GetInt32(0),      // id
                    reader.GetBoolean(1),     // is_admin
                    reader.GetString(2),      // nama_lengkap
                    reader.GetString(3),      // username
                    reader.GetString(4),      // password
                    reader.GetString(5),      // no_telepon
                    reader.GetString(6),      // email
                    reader.GetBoolean(7)      // is_delete
                );
            }
            return null;
        }

        // UPDATE - Update user data
        public bool UpdateUser(User user)
        {
            using var conn = GetConnection();
            conn.Open();

            string query = @"UPDATE pengguna 
                             SET nama_lengkap = @nama_lengkap, 
                                 password = @password, 
                                 no_telepon = @no_telepon, 
                                 email = @email 
                             WHERE id = @id";

            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nama_lengkap", user.nama);
            cmd.Parameters.AddWithValue("@password", user.password);
            cmd.Parameters.AddWithValue("@no_telepon", user.no_telepon);
            cmd.Parameters.AddWithValue("@email", user.email);
            cmd.Parameters.AddWithValue("@id", user.id);

            return cmd.ExecuteNonQuery() > 0;
        }

        // DELETE - Soft delete user (set is_delete = true)
        public bool DeleteUser(int userId)
        {
            using var conn = GetConnection();
            conn.Open();

            string query = "UPDATE pengguna SET is_delete = true WHERE id = @id";
            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", userId);

            return cmd.ExecuteNonQuery() > 0;
        }

        // GET all customers (non-admin users)
        public List<User> GetAllCustomers()
        {
            List<User> list = new List<User>();
            using var conn = GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand("SELECT * FROM pengguna WHERE is_admin = false AND is_delete = false", conn);
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

        // AUTHENTICATE user (returns user if credentials match)
        public User AuthenticateUser(string username, string password)
        {
            using var conn = GetConnection();
            conn.Open();
            string query = "SELECT * FROM pengguna WHERE username = @username AND password = @password AND is_delete = false";
            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new User(
                    reader.GetInt32(0),
                    reader.GetBoolean(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetString(5),
                    reader.GetString(6),
                    reader.GetBoolean(7)
                );
            }
            return null;
        }
    }
}