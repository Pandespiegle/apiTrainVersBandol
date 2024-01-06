using ApiTrainVersBandol.Model;
using MySql.Data.MySqlClient;

namespace ApiTrainVersBandol.Service
{
    public class LeaderboardService
    {
        public Leaderboard getLeaderboard()
        {
            Leaderboard leaderboard = new Leaderboard();

            MySqlConnection? connection = new SqlConnectionService().getConnection();
            if (connection != null)
            {
                connection.Open();
                try
                {
                    using (MySqlCommand command = new MySqlCommand("getLeaderboard", connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine(reader);

                                Score score = new Score();

                                score.Name = reader.GetString("name");
                                score.Points = reader.GetInt32("score");


                                leaderboard.Scores.Add(score);
                            }
                        }

                    }
                    return leaderboard;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.ToString());
                    return leaderboard;
                }
            }
            return leaderboard;
        }
    }
}
