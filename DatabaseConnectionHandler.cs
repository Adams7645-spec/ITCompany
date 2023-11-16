using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ITCompany
{
    internal class DatabaseConnectionHandler
    {
        private static string connectionString = @"Data Source=(localdb)\LocalForLabs;Initial Catalog=ITCompany;Integrated Security=True";
        private static SqlConnection connection;

        public static SqlConnection GetConnection()
        {
            if (connection == null)
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            else if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

            return connection;
        }

        public static void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public static bool ValidateUser(string username, string password, char role)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                string query = "SELECT COUNT(*) FROM UserAuthentication WHERE UserLogin = @Username AND UserPassword = @Password AND UserRole = @Role";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Role", role);

                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
            else
                return false;
        }

        public static DataTable GetDataFromDB(string query)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }

            return dt;
        }

        public static void ExecuteCommand(string sqlQuery)
        {
            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            {
                // Выполняем запрос
                command.ExecuteNonQuery();
            }
        }
    }
}
