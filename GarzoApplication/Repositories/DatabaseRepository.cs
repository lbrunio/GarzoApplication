using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace GarzoApplication.Repositories
{
    public class Database
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        // Constructor
        public Database()
        {
            Initialize();
        }

        // Inicializa la conexión
        private void Initialize()
        {
            server = "192.168.1.130";
            database = "app_database";
            uid = "rooster";
            password = "rooster";
            string connectionString;
            connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            connection = new MySqlConnection(connectionString);
        }

        // Abre la conexión a la base de datos
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                // Manejar excepciones de conexión aquí
                return false;
            }
        }

        // Cierra la conexión a la base de datos
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                // Manejar excepciones de cierre aquí
                return false;
            }
        }

        public bool ValidateUser(string username, string password)
        {
            string query = $"SELECT COUNT(*) FROM users WHERE user = '{username}' AND password = '{password}'";
            int count = 0;

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                count = Convert.ToInt32(cmd.ExecuteScalar());
                this.CloseConnection();
            }

            return count > 0;
        }

        public bool ValidateUsername(string username)
        {
            string query = $"SELECT COUNT(*) FROM users WHERE user = '{username}'";
            int count = 0;

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                count = Convert.ToInt32(cmd.ExecuteScalar());
                this.CloseConnection();
            }

            return count > 0;
        }

        public bool ValidatePass(string password)
        {
            string query = $"SELECT COUNT(*) FROM users WHERE password = '{password}'";
            int count = 0;

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                count = Convert.ToInt32(cmd.ExecuteScalar());
                this.CloseConnection();
            }

            return count > 0;
        }

    }
}
