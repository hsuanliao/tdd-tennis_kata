﻿using System.Collections.Generic;

namespace TennisTest20220122
{
    public class TennisGame
    {
        private readonly Dictionary<int, string> _scoreLookup = new Dictionary<int, string>
        {
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
            if (_secondPlayerScoreTimes > 0)
            {
                return $"Love {_scoreLookup[_secondPlayerScoreTimes]}";
            }
            if (_firstPlayerScoreTimes > 0)
            {
                return $"{_scoreLookup[_firstPlayerScoreTimes]} Love";
            }

            return "Love All";
        }

        public void SecondPlayerScore()
        {
            _secondPlayerScoreTimes++;
        }
    }
}