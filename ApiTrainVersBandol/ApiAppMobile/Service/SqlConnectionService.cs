using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
namespace ApiTrainVersBandol.Service
{
    public class SqlConnectionService
    {

        public MySqlConnection? getConnection()
        {


            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

            builder.Server = "127.0.0.1";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "trainversbandol";

            using (MySqlConnection connection = new MySqlConnection(builder.ConnectionString))
            {
                try
                {
                    return connection;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return null;
                }
            }
        }
    }
}
