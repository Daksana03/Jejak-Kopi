using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Jejak_Kopi.Database
{
    public class DatabaseHelper
    {
        private int cpuCount = Environment.ProcessorCount;
        private string connString ;

        public DatabaseHelper()
        {
            if (cpuCount == 8)
            {
                connString = "Host=localhost;Port=5432;Database=Jejak_Kopi;Username=postgres;Password=1234";
            }
            else if (cpuCount == 12)
            {
                connString = "Host=localhost;Port=5432;Database=Jejak_Kopi;Username=postgres;Password=tidakdiketahui";
            }
            else if (cpuCount == 16)
            {
                connString = "Host=localhost;Port=5432;Database=Projek_Final;Username=postgres;Password=123";
            }
        }
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
        public (bool success, string message) RegisterUser(User user)
        {
            using var conn = GetConnection();
            conn.Open();

            string query = "SELECT register_user(@is_admin, @nama_lengkap, @username, @passwords, @no_telepon, @email)";

            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@is_admin", user.is_admin);
            cmd.Parameters.AddWithValue("@nama_lengkap", user.nama);
            cmd.Parameters.AddWithValue("@username", user.username);
            cmd.Parameters.AddWithValue("@passwords", user.password);
            cmd.Parameters.AddWithValue("@no_telepon", user.no_telepon);
            cmd.Parameters.AddWithValue("@email", user.email);

            string jsonResult = (string)cmd.ExecuteScalar();

            // Parse JSON - you'll need Newtonsoft.Json or System.Text.Json
            using var doc = System.Text.Json.JsonDocument.Parse(jsonResult);
            bool success = doc.RootElement.GetProperty("success").GetBoolean();
            string message = doc.RootElement.GetProperty("message").GetString();

            return (success, message);
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

        public DataTable GetDataKopi()
        {
            DataTable dt = new DataTable();
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM katalog_tersedia";
                using (var da = new NpgsqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }
            }
            return dt;
 
        }

        public DataTable GetKopiUser()
        {
            DataTable dt = new DataTable();
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM kopi";
                using (var da = new NpgsqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }
            }
            return dt;

        }

        public DataTable GetStat()
        {
            DataTable dt = new DataTable();
            using (var conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM v_statistik_biji_kopi";
                using (var da = new NpgsqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }
            }
            return dt;

        }

        public bool TambahKopi(string nama, decimal stok, int harga, string kategori)
        {
            using var conn = GetConnection();
            conn.Open();

            string query =
                @"CALL tambah_kopi(
            @nama,
            @stok,
            @harga,
            @kategori)";

            using var cmd = new NpgsqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@stok", stok);
            cmd.Parameters.AddWithValue("@harga", harga);
            cmd.Parameters.AddWithValue("@kategori", kategori);

            cmd.ExecuteNonQuery();

            return true;
        }

        public bool EditKopi(int id, string nama, decimal stok, int harga, string kategori)
        {
            using var conn = GetConnection();
            conn.Open();

            string query =
            @"CALL edit_kopi(
            @id,
            @nama,
            @stok,
            @harga,
            @kategori)";

            using var cmd = new NpgsqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nama", nama);
            cmd.Parameters.AddWithValue("@stok", stok);
            cmd.Parameters.AddWithValue("@harga", harga);
            cmd.Parameters.AddWithValue("@kategori", kategori);

            cmd.ExecuteNonQuery();

            return true;
        }

        public bool HapusKopi(int id)
        {
            using var conn = GetConnection();
            conn.Open();

            string query = @"CALL hapus_kopi(@id)";

            using var cmd = new NpgsqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            return true;
        }

        public DataTable GetPesanan()
        {
            DataTable dt = new DataTable();

            using (var conn = GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM daftar_pesanan";

                using (var da = new NpgsqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }

        public bool UbahStatusPesanan(
            int idPesanan,
            string status)
        {
            using var conn = GetConnection();
            conn.Open();

            string query =
                @"CALL ubah_status_pesanan(
            @id,
            @status)";

            using var cmd =
                new NpgsqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@id", idPesanan);
            cmd.Parameters.AddWithValue("@status", status);

            cmd.ExecuteNonQuery();

            return true;
        }

    }
}