using System;
using System.Data;
using System.Data.SqlClient;

namespace Transactions
{
    public class Database
    {
        // Строка подключения к базе данных
        private string connectionString = @"Data Source=GUMKA\SQLEXPRESS;Initial Catalog=Finance;Integrated Security=True";

        // Метод для добавления транзакции
        public void AddTransaction(string type, double amount, string description, string date)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Transactions (Type, Amount, Description, Date) VALUES (@Type, @Amount, @Description, @Date)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Type", type);
                    command.Parameters.AddWithValue("@Amount", amount);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@Date", date);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Метод для получения транзакций
        public DataTable GetTransactions()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Transactions";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        // Метод для удаления транзакции по id
        public void DeleteTransaction(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Transactions WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
