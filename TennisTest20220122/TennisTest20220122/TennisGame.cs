using System.Collections.Generic;

namespace TennisTest20220122
{
    public class TennisGame
    {
        private readonly string _firstPlayerName;

        private readonly Dictionary<int, string> _scoreLookup = new Dictionary<int, string>
        {
            { 0, "Love" },
            { 1, "Fifteen" },
            { 2, "Thirty" },
            { 3, "Forty" },
        };

        private int _firstPlayerScoreTimes;
        private int _secondPlayerScoreTimes;

        public TennisGame(string firstPlayerName)
        {
            _firstPlayerName = firstPlayerName;
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScoreTimes++;
        }

        public string ScoreResult()
        {
            if (IsDifferentScore())
            {
                if (_firstPlayerScoreTimes > 3)
                {
                    if (_firstPlayerScoreTimes - _secondPlayerScoreTimes == 1)
                    {
                        return $"{_firstPlayerName} Adv.";
                    }
                }

                return LookupScore();
            }

            if (IsDeuce())
            {
                return Deuce();
            }
            return SameScore();
        }

        public void SecondPlayerScore()
        {
            _secondPlayerScoreTimes++;
        }

        private static string Deuce()
        {
            return "Deuce";
        }

        private bool IsDeuce()
        {
            return _firstPlayerScoreTimes == _secondPlayerScoreTimes
                   && _firstPlayerScoreTimes >= 3;
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