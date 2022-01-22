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

        private void ScoreResultShouldBe(string expected)
        {
            _tennisGame.ScoreResult().Should().Be(expected);
        }
    }
}