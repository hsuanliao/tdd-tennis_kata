using FluentAssertions;
using NUnit.Framework;

namespace TennisTest20220122
{
    [TestFixture]
    public class TennisTest
    {
        private TennisGame _tennisGame;

        [SetUp]
        public void _00_SetUp()
        {
            _tennisGame = new TennisGame();
        }

        [Test]
        public void A01_Love_All()
        {
            ScoreResultShouldBe("Love All");
        }

        [Test]
        public void A02_Fifteen_Love()
        {
            GivenFirstPlayerScoreTimes(1);
            ScoreResultShouldBe("Fifteen Love");
        }

        [Test]
        public void A03_Thirty_Love()
        {
            GivenFirstPlayerScoreTimes(2);
            ScoreResultShouldBe("Thirty Love");
        }

        [Test]
        public void A04_Forty_Love()
        {
            GivenFirstPlayerScoreTimes(3);
            ScoreResultShouldBe("Forty Love");
        }

        private void GivenFirstPlayerScoreTimes(int times)
        {
            for (var i = 0; i < times; i++)
            {
                _tennisGame.FirstPlayerScore();
            }
        }

        private void ScoreResultShouldBe(string expected)
        {
            _tennisGame.ScoreResult().Should().Be(expected);
        }
    }
}