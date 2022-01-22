using System.Collections.Generic;

namespace TennisTest20220122
{
    public class TennisGame
    {
        private readonly Dictionary<int, string> _scoreLookup = new Dictionary<int, string>
        {
            { 0, "Love" },
            { 1, "Fifteen" },
            { 2, "Thirty" },
            { 3, "Forty" },
        };

        private int _firstPlayerScoreTimes;
        private int _secondPlayerScoreTimes;

        public void FirstPlayerScore()
        {
            _firstPlayerScoreTimes++;
        }

        public string ScoreResult()
        {
            if (IsDifferentScore())
            {
                return LookupScore();
            }

            if (_firstPlayerScoreTimes == 3)
            {
                return "Deuce";
            }
            return SameScore();
        }

        public void SecondPlayerScore()
        {
            _secondPlayerScoreTimes++;
        }

        private bool IsDifferentScore()
        {
            return _firstPlayerScoreTimes != _secondPlayerScoreTimes;
        }

        private string LookupScore()
        {
            return $"{_scoreLookup[_firstPlayerScoreTimes]} {_scoreLookup[_secondPlayerScoreTimes]}";
        }

        private string SameScore()
        {
            return $"{_scoreLookup[_firstPlayerScoreTimes]} All";
        }
    }
}