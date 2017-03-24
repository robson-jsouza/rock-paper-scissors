using RPS;
using RPS.Exceptions;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RPS.Tests
{
    [TestClass]
    public class TournamentTests
    {
        [TestMethod]
        public void CheckWinner()
        {
            var player1 = new PlayerMove("Armando", "P");
            var player2 = new PlayerMove("Dave", "S");

            var game1Group1 = new Game(player1, player2);

            player1 = new PlayerMove("Richard", "R");
            player2 = new PlayerMove("Michael", "S");

            var game2Group1 = new Game(player1, player2);

            player1 = new PlayerMove("Allen", "S");
            player2 = new PlayerMove("Omer", "P");

            var game1Group2 = new Game(player1, player2);

            player1 = new PlayerMove("David E.", "R");
            player2 = new PlayerMove("Richard X.", "P");

            var game2Group2 = new Game(player1, player2);

            var group1 = new Group(game1Group1, game2Group1);
            var group2 = new Group(game1Group2, game2Group2);

            var tournament = new Tournament(group1, group2);
            PlayerMove winnerOfTournament = tournament.Winner();

            Assert.IsTrue(winnerOfTournament.Name == "Richard");
        }

        [TestMethod]
        public void CheckWinnerWithAGroupWithADifferentAmountOfGames()
        {
            var player1 = new PlayerMove("Armando", "P");
            var player2 = new PlayerMove("Dave", "S");

            var game1Group1 = new Game(player1, player2);

            player1 = new PlayerMove("Richard", "R");
            player2 = new PlayerMove("Michael", "S");

            var game2Group1 = new Game(player1, player2);

            player1 = new PlayerMove("Allen", "S");
            player2 = new PlayerMove("Omer", "P");

            var game1Group2 = new Game(player1, player2);

            var group1 = new Group(game1Group1, game2Group1);
            var group2 = new Group(game1Group2);

            var tournament = new Tournament(group1, group2);
            PlayerMove winnerOfTournament = tournament.Winner();

            Assert.IsTrue(winnerOfTournament.Name == "Richard");
        }
    }
}
