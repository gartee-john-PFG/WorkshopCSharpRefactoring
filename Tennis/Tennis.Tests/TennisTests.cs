using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Xunit;

namespace Tennis.Tests
{

    public class TennisTests
    {
        [Theory]
        [InlineData(0, 0, "Love-All")]
        [InlineData(1, 1, "Fifteen-All")]
        [InlineData(2, 2, "Thirty-All")]
        [InlineData(3, 3, "Deuce")]
        [InlineData(4, 4, "Deuce")]
        [InlineData(1, 0, "Fifteen-Love")]
        [InlineData(0, 1, "Love-Fifteen")]
        [InlineData(2, 0, "Thirty-Love")]
        [InlineData(0, 2, "Love-Thirty")]
        [InlineData(3, 0, "Forty-Love")]
        [InlineData(0, 3, "Love-Forty")]
        [InlineData(4, 0, "Win for player1")]
        [InlineData(0, 4, "Win for player2")]
        [InlineData(2, 1, "Thirty-Fifteen")]
        [InlineData(1, 2, "Fifteen-Thirty")]
        [InlineData(3, 1, "Forty-Fifteen")]
        [InlineData(1, 3, "Fifteen-Forty")]
        [InlineData(4, 1, "Win for player1")]
        [InlineData(1, 4, "Win for player2")]
        [InlineData(3, 2, "Forty-Thirty")]
        [InlineData(2, 3, "Thirty-Forty")]
        [InlineData(4, 2, "Win for player1")]
        [InlineData(2, 4, "Win for player2")]
        [InlineData(4, 3, "Advantage player1")]
        [InlineData(3, 4, "Advantage player2")]
        [InlineData(5, 4, "Advantage player1")]
        [InlineData(4, 5, "Advantage player2")]
        [InlineData(15, 14, "Advantage player1")]
        [InlineData(14, 15, "Advantage player2")]
        [InlineData(6, 4, "Win for player1")]
        [InlineData(4, 6, "Win for player2")]
        [InlineData(16, 14, "Win for player1")]
        [InlineData(14, 16, "Win for player2")]
        public void CheckTennisGame1(int player1Score, int player2Score, string expectedScore)
        {
            var game = new TennisGame1("player1", "player2");
            CheckAllScores(game, player1Score, player2Score, expectedScore);
        }

        [Theory]
        [InlineData(0, 0, "Love-All")]
        [InlineData(1, 1, "Fifteen-All")]
        [InlineData(2, 2, "Thirty-All")]
        [InlineData(3, 3, "Deuce")]
        [InlineData(4, 4, "Deuce")]
        [InlineData(1, 0, "Fifteen-Love")]
        [InlineData(0, 1, "Love-Fifteen")]
        [InlineData(2, 0, "Thirty-Love")]
        [InlineData(0, 2, "Love-Thirty")]
        [InlineData(3, 0, "Forty-Love")]
        [InlineData(0, 3, "Love-Forty")]
        [InlineData(4, 0, "Win for player1")]
        [InlineData(0, 4, "Win for player2")]
        [InlineData(2, 1, "Thirty-Fifteen")]
        [InlineData(1, 2, "Fifteen-Thirty")]
        [InlineData(3, 1, "Forty-Fifteen")]
        [InlineData(1, 3, "Fifteen-Forty")]
        [InlineData(4, 1, "Win for player1")]
        [InlineData(1, 4, "Win for player2")]
        [InlineData(3, 2, "Forty-Thirty")]
        [InlineData(2, 3, "Thirty-Forty")]
        [InlineData(4, 2, "Win for player1")]
        [InlineData(2, 4, "Win for player2")]
        [InlineData(4, 3, "Advantage player1")]
        [InlineData(3, 4, "Advantage player2")]
        [InlineData(5, 4, "Advantage player1")]
        [InlineData(4, 5, "Advantage player2")]
        [InlineData(15, 14, "Advantage player1")]
        [InlineData(14, 15, "Advantage player2")]
        [InlineData(6, 4, "Win for player1")]
        [InlineData(4, 6, "Win for player2")]
        [InlineData(16, 14, "Win for player1")]
        [InlineData(14, 16, "Win for player2")]
        public void CheckTennisGame2(int player1Score, int player2Score, string expectedScore)
        {
            var game = new TennisGame2("player1", "player2");
            CheckAllScores(game, player1Score, player2Score, expectedScore);
        }

        [Theory]
        [InlineData(0, 0, "Love-All")]
        [InlineData(1, 1, "Fifteen-All")]
        [InlineData(2, 2, "Thirty-All")]
        [InlineData(3, 3, "Deuce")]
        [InlineData(4, 4, "Deuce")]
        [InlineData(1, 0, "Fifteen-Love")]
        [InlineData(0, 1, "Love-Fifteen")]
        [InlineData(2, 0, "Thirty-Love")]
        [InlineData(0, 2, "Love-Thirty")]
        [InlineData(3, 0, "Forty-Love")]
        [InlineData(0, 3, "Love-Forty")]
        [InlineData(4, 0, "Win for player1")]
        [InlineData(0, 4, "Win for player2")]
        [InlineData(2, 1, "Thirty-Fifteen")]
        [InlineData(1, 2, "Fifteen-Thirty")]
        [InlineData(3, 1, "Forty-Fifteen")]
        [InlineData(1, 3, "Fifteen-Forty")]
        [InlineData(4, 1, "Win for player1")]
        [InlineData(1, 4, "Win for player2")]
        [InlineData(3, 2, "Forty-Thirty")]
        [InlineData(2, 3, "Thirty-Forty")]
        [InlineData(4, 2, "Win for player1")]
        [InlineData(2, 4, "Win for player2")]
        [InlineData(4, 3, "Advantage player1")]
        [InlineData(3, 4, "Advantage player2")]
        [InlineData(5, 4, "Advantage player1")]
        [InlineData(4, 5, "Advantage player2")]
        [InlineData(15, 14, "Advantage player1")]
        [InlineData(14, 15, "Advantage player2")]
        [InlineData(6, 4, "Win for player1")]
        [InlineData(4, 6, "Win for player2")]
        [InlineData(16, 14, "Win for player1")]
        [InlineData(14, 16, "Win for player2")]
        public void CheckTennisGame3(int player1Score, int player2Score, string expectedScore)
        {
            var game = new TennisGame3("player1", "player2");
            CheckAllScores(game, player1Score, player2Score, expectedScore);
        }

        private void CheckAllScores(ITennisGame game, int player1Score, int player2Score, string expectedScore)
        {
            var highestScore = Math.Max(player1Score, player2Score);
            for (var i = 0; i < highestScore; i++)
            {
                if (i < player1Score)
                    game.WonPoint("player1");
                if (i < player2Score)
                    game.WonPoint("player2");
            }
            Assert.Equal(expectedScore, game.GetScore());
        }

    }

}

