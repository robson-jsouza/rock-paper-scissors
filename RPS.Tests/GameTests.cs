using RPS;
using RPS.Exceptions;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RPS.Tests
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void RockBeatsScissor()
        {
            var player1 = new PlayerMove("Armando", "R");
            var player2 = new PlayerMove("Dave", "S");
            var game = new Game(new PlayerMove[] { player1, player2 });
            PlayerMove winner = game.Winner();

            Assert.IsTrue(winner.Name.Equals(player1.Name));
        }

        [TestMethod]
        public void ScissorBeatsPaper()
        {
            var player1 = new PlayerMove("Armando", "S");
            var player2 = new PlayerMove("Dave", "P");
            var game = new Game(new PlayerMove[] { player1, player2 });
            PlayerMove winner = game.Winner();

            Assert.IsTrue(winner.Name.Equals(player1.Name));
        }

        [TestMethod]
        public void PaperBeatsScissor()
        {
            var player1 = new PlayerMove("Armando", "P");
            var player2 = new PlayerMove("Dave", "R");
            var game = new Game(new PlayerMove[] { player1, player2 });
            PlayerMove winner = game.Winner();

            Assert.IsTrue(winner.Name.Equals(player1.Name));
        }

        [TestMethod]
        public void DrawFirstPlayerWinner()
        {
            var player1 = new PlayerMove("Armando", "P");
            var player2 = new PlayerMove("Dave", "P");
            var game = new Game(new PlayerMove[] { player1, player2 });
            PlayerMove winner = game.Winner();

            Assert.IsTrue(winner.Name.Equals(player1.Name));
        }

        [TestMethod]
        public void RockBeatsScissorSecondPlayerWinner()
        {
            var player1 = new PlayerMove("Armando", "S");
            var player2 = new PlayerMove("Dave", "R");
            var game = new Game(new PlayerMove[] { player1, player2 });
            PlayerMove winner = game.Winner();

            Assert.IsTrue(winner.Name.Equals(player2.Name));
        }

        [TestMethod]
        public void ScissorBeatsPaperSecondPlayerWinner()
        {
            var player1 = new PlayerMove("Armando", "P");
            var player2 = new PlayerMove("Dave", "S");
            var game = new Game(new PlayerMove[] { player1, player2 });
            PlayerMove winner = game.Winner();

            Assert.IsTrue(winner.Name.Equals(player2.Name));
        }

        [TestMethod]
        public void PaperBeatsScissorSecondPlayerWinner()
        {
            var player1 = new PlayerMove("Armando", "R");
            var player2 = new PlayerMove("Dave", "P");
            var game = new Game(new PlayerMove[] { player1, player2 });
            PlayerMove winner = game.Winner();

            Assert.IsTrue(winner.Name.Equals(player2.Name));
        }

        [TestMethod]
        [ExpectedException(typeof(NoSuchStrategyException))]
        public void InvalidMove()
        {
            var player1 = new PlayerMove("Armando", "X");
            var player2 = new PlayerMove("Dave", "P");
            var game = new Game(new PlayerMove[] { player1, player2 });
            PlayerMove winner = game.Winner();
        }
    }
}
