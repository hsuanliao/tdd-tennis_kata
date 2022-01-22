using FluentAssertions;
using NUnit.Framework;

namespace TennisTest20220122
{
    [TestFixture]
    public class TennisTest
    {
        [Test]
        public void A01_Love_All()
        {
            var tennisGame = new TennisGame();
            var actual = tennisGame.ScoreResult();
            actual.Should().Be("Love All");
        }
    }
}