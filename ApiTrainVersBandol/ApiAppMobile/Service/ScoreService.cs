using MySql.Data.MySqlClient;
using System;

namespace ApiTrainVersBandol.Service
{
    public class ScoreService
    {
          
        public void AddScore(string name, int score)
        {
            MySqlConnection? connection = new SqlConnectionService().getConnection();
            if (connection != null )
            {
                connection.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("addScore", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@score", score);
                        command.Parameters.AddWithValue("@name", name);

                        command.ExecuteNonQuery();
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                connection.Close();
            }
            
        }
    }
}
