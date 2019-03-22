using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace PublicWitnessingApi.Repository
{
    public class DatabaseContext
    {
        public string connectionString { get; set; }
        public DatabaseContext()
        {

        }
        public async Task  Add(object user)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                var parameters = new List<SqlParameter>() {
                    new SqlParameter("@Email", "Jbryant@havenstudios.com"),
                    new SqlParameter("@FirstName", "Jason"),
                    new SqlParameter("@LastName","Bryant"),
                    new SqlParameter("@KingdomHall","Panorama"),
                    new SqlParameter("@Street","184 Paseo Bravo"),
                    new SqlParameter("@City","Palm Desert"),
                    new SqlParameter("@State","CA"),
                    new SqlParameter("@Zip","92211")
                }.ToArray();
                var sp = "add_new_users";
                var Command = new SqlCommand(sp, connection);
                Command.CommandType = System.Data.CommandType.StoredProcedure;
                Command.Parameters.AddRange(parameters);
                int Rows =Command.ExecuteNonQuery();
            }
        }
    }
}
