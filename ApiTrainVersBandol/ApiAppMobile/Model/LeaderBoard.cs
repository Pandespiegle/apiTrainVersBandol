namespace ApiTrainVersBandol.Model
{
    public class Leaderboard
    {
        public List<Score> Scores { get; set; }

        public Leaderboard() { 
            Scores = new List<Score>();
        }
    }
}
