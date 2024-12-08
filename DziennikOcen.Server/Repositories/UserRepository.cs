using DziennikOcen.Server.Models;
using Microsoft.Data.SqlClient;

namespace DziennikOcen.Server.Repositories
{
    public class UserRepository
    {
        private string connectionString = "Server=DESKTOP-81BVVCK\\SQLEXPRESS;Database=DziennikOcen;Trusted_Connection=True;Encrypt=False;";

        public async Task<List<User>> GetAll()
        {
            List<User> users = new List<User>();

            string sql =
                """
                    SELECT * FROM USERS
                """;

            await using SqlConnection connection = new SqlConnection(connectionString);
            await using var command = new SqlCommand(sql, connection);
            connection.Open();

            await using SqlDataReader reader = await command.ExecuteReaderAsync();
            while (reader.Read())
            {
                User user = new User()
                {
                    UserID = Convert.ToInt32(reader["UserID"]),
                    Pin = Convert.ToInt32(reader["Pin"]),
                    Username = reader["Username"].ToString(),
                    Password = reader["Password"].ToString(),
                    RoleID = Convert.ToInt32(reader["RoleID"]),
                    Created_at = Convert.ToDateTime(reader["Created_at"]),
                    Updated_at = Convert.ToDateTime(reader["Updated_at"])
                };

                users.Add(user);
            }

            return users;
        }
    }
}
