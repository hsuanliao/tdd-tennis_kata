namespace TennisTest20220122
{
    public class TennisGame
    {
        private int _firstPlayerScoreTimes;

        public void FirstPlayerScore()
        {
            _firstPlayerScoreTimes++;
        }

        public string ScoreResult()
        {
            if (_firstPlayerScoreTimes == 1)
            {
                return "Fifteen Love";
            }

            return "Love All";
        }
    }
}