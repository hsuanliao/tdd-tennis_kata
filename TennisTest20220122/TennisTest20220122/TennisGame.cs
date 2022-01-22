using System;
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

        private readonly string _secondPlayerName;
        private int _firstPlayerScoreTimes;
        private int _secondPlayerScoreTimes;

        public TennisGame(string firstPlayerName, string secondPlayerName)
        {
            _firstPlayerName = firstPlayerName;
            _secondPlayerName = secondPlayerName;
        }

        public void FirstPlayerScore()
        {
            _firstPlayerScoreTimes++;
        }

        public string ScoreResult()
        {
            if (IsDifferentScore())
            {
                if (IsReadForGamePoint())
                {
                    return IsAdv() ? $"{AdvPlayer()} Adv." : $"{AdvPlayer()} Win.";
                }

                return LookupScore();
            }

            return IsDeuce() ? Deuce() : SameScore();
        }

        public void SecondPlayerScore()
        {
            _secondPlayerScoreTimes++;
        }

        private static string Deuce()
        {
            return "Deuce";
        }

        private string AdvPlayer()
        {
            var advPlayerName = _firstPlayerScoreTimes > _secondPlayerScoreTimes
                ? _firstPlayerName
                : _secondPlayerName;
            return advPlayerName;
        }

        private bool IsAdv()
        {
            return Math.Abs(_firstPlayerScoreTimes - _secondPlayerScoreTimes) == 1;
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

        private bool IsReadForGamePoint()
        {
            return _firstPlayerScoreTimes > 3 || _secondPlayerScoreTimes > 3;
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