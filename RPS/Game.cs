using RPS.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    public class Game
    {
        private PlayerMove[] _playersMoves;

        public Game(params PlayerMove[] playersMoves)
        {
            _playersMoves = playersMoves;
        }

        public PlayerMove Winner()
        {
            if (_playersMoves.Length != Configurations.NumberOfPlayers)
                throw new WrongNumberOfPlayersException("Wrong number of players. There should be two players.");

            PlayerMove playerOne = _playersMoves[0];
            PlayerMove playerTwo = _playersMoves[1];

            PlayerMove winner = GetWinner(playerOne, playerTwo);
            
            return winner;
        }

        private PlayerMove GetWinner(PlayerMove playerOne, PlayerMove playerTwo)
        {
            ValidateMove(playerOne);
            ValidateMove(playerTwo);

            string playerOneMove = playerOne.Move.ToUpper();
            string playerTwoMove = playerTwo.Move.ToUpper();

            if (playerOneMove == "R" && playerTwoMove == "S")
                return playerOne;
            else if (playerOneMove == "S" && playerTwoMove == "P")
                return playerOne;
            else if (playerOneMove == "P" && playerTwoMove == "R")
                return playerOne;
            else if (playerOneMove == playerTwoMove)
                return playerOne;
            else
                return playerTwo;
        }

        private void ValidateMove(PlayerMove playerMove)
        {
            string[] validMoves = new string[] { "R", "P", "S" };

            if (!validMoves.Any(validMove => validMove == playerMove.Move.ToUpper()))
                throw new NoSuchStrategyException("Invalid move. It is not a valid strategy.");
        }
    }
}
