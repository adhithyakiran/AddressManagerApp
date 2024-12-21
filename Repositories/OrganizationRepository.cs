using AddressManagerApp.Models;
using AddressManagerApp.Database;
using System.Collections.Generic;
using System.Data.SQLite;

namespace AddressManagerApp.Repositories
{
    public class OrganizationRepository
    {
        private DatabaseHelper _dbHelper;

        public OrganizationRepository()
        {
            _dbHelper = new DatabaseHelper();
        }

        public List<Organization> GetOrganizations()
        {
            var organizations = new List<Organization>();
            using (var connection = _dbHelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Organizations";
                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        organizations.Add(new Organization
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Street = reader.GetString(2),
                            Zip = reader.GetString(3),
                            City = reader.GetString(4),
                            Country = reader.GetString(5)
                        });
                    }
                }
            }
            return organizations;
        }
    }
}
