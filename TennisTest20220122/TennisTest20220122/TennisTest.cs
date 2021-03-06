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
            _tennisGame = new TennisGame("Jay", "Kevin");
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

        [Test]
        public void A05_Love_Fifteen()
        {
            GivenSecondPlayerScoreTimes(1);
            ScoreResultShouldBe("Love Fifteen");
        }

        [Test]
        public void A06_Love_Thirty()
        {
            GivenSecondPlayerScoreTimes(2);
            ScoreResultShouldBe("Love Thirty");
        }

        [Test]
        public void A07_Love_Forty()
        {
            GivenSecondPlayerScoreTimes(3);
            ScoreResultShouldBe("Love Forty");
        }

        [Test]
        public void A08_Fifteen_All()
        {
            GivenFirstPlayerScoreTimes(1);
            GivenSecondPlayerScoreTimes(1);
            ScoreResultShouldBe("Fifteen All");
        }

        [Test]
        public void A09_Thirty_All()
        {
            GivenFirstPlayerScoreTimes(2);
            GivenSecondPlayerScoreTimes(2);
            ScoreResultShouldBe("Thirty All");
        }

        [Test]
        public void A10_Deuce_3vs3()
        {
            GivenDeuce();
            ScoreResultShouldBe("Deuce");
        }

        [Test]
        public void A11_Deuce_4vs4()
        {
            GivenDeuce();
            GivenFirstPlayerScoreTimes(1);
            GivenSecondPlayerScoreTimes(1);
            ScoreResultShouldBe("Deuce");
        }

        [Test]
        public void A12_FirstPlayer_Adv()
        {
            GivenDeuce();
            GivenFirstPlayerScoreTimes(1);
            ScoreResultShouldBe("Jay Adv.");
        }

        [Test]
        public void A13_SecondPlayer_Adv()
        {
            GivenDeuce();
            GivenSecondPlayerScoreTimes(1);
            ScoreResultShouldBe("Kevin Adv.");
        }

        [Test]
        public void A14_FirstPlayer_Win()
        {
            GivenDeuce();
            GivenFirstPlayerScoreTimes(2);
            ScoreResultShouldBe("Jay Win.");
        }

        [Test]
        public void A15_SecondPlayer_Win()
        {
            GivenDeuce();
            GivenSecondPlayerScoreTimes(2);
            ScoreResultShouldBe("Kevin Win.");
        }

        [Test]
        [TestCase(0, 2, "Love Thirty")]
        [TestCase(3, 1, "Forty Fifteen")]
        [TestCase(4, 2, "Jay Win.")]
        [TestCase(1, 4, "Kevin Win.")]
        public void A99_Others(int firstPlayerScore, int secondPlayerScore, string expected)
        {
            GivenFirstPlayerScoreTimes(firstPlayerScore);
            GivenSecondPlayerScoreTimes(secondPlayerScore);
            ScoreResultShouldBe(expected);
        }

        private void GivenDeuce()
        {
            GivenFirstPlayerScoreTimes(3);
            GivenSecondPlayerScoreTimes(3);
        }

        private void GivenFirstPlayerScoreTimes(int times)
        {
            for (var i = 0; i < times; i++)
            {
                _tennisGame.FirstPlayerScore();
            }
        }

        private void GivenSecondPlayerScoreTimes(int times)
        {
            for (var i = 0; i < times; i++)
            {
                _tennisGame.SecondPlayerScore();
            }
        }

        private void ScoreResultShouldBe(string expected)
        {
            _tennisGame.ScoreResult().Should().Be(expected);
        }
    }
}