using System.Data.SQLite;

namespace AddressManagerApp.Database
{
    public class DatabaseHelper
    {
        private string connectionString = "Data Source=addressManager.db;Version=3;";

        public DatabaseHelper()
        {
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string sql = System.IO.File.ReadAllText("init.sql");
                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }
    }
}
