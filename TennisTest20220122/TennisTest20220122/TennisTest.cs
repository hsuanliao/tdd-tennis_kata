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
            _tennisGame.FirstPlayerScore();
            ScoreResultShouldBe("Fifteen Love");
        }

        [Test]
        public void A03_Thirty_Love()
        {
            _tennisGame.FirstPlayerScore();
            _tennisGame.FirstPlayerScore();
            ScoreResultShouldBe("Thirty Love");
        }

        private void ScoreResultShouldBe(string expected)
        {
            _tennisGame.ScoreResult().Should().Be(expected);
        }
    }
}