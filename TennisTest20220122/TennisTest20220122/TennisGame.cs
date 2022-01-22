using System.Collections.Generic;

namespace TennisTest20220122
{
    public class TennisGame
    {
        private readonly Dictionary<int, string> _scoreLookup = new Dictionary<int, string>
        {
            { 1, "Fifteen" },
            { 2, "Thirty" },
        };

        private int _firstPlayerScoreTimes;

        public void FirstPlayerScore()
        {
            _firstPlayerScoreTimes++;
        }

        public string ScoreResult()
        {
            if (_firstPlayerScoreTimes == 1 || _firstPlayerScoreTimes == 2)
            {
                return $"{_scoreLookup[_firstPlayerScoreTimes]} Love";
            }

            return "Love All";
        }
    }
}