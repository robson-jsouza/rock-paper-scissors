using RPS.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    public class Tournament
    {
        public Group[] Groups { get; }

        public Tournament(params Group[] groups)
        {
            Groups = groups;
        }

        public PlayerMove Winner()
        {
            var winners = new List<PlayerMove>();
            Groups.ToList().ForEach(group => winners.Add(GetWinnerOfGroup(group.Games.ToList())));

            var gamesFactory = new GamesFactory();
            var gamesRemaining = gamesFactory.Build(winners);

            PlayerMove winner = GetWinnerOfGroup(gamesRemaining);
            return winner;
        }

        private PlayerMove GetWinnerOfGroup(List<Game> games)
        {
            var winners = new List<PlayerMove>();

            games.ForEach(game => winners.Add(game.Winner()));

            if (winners.Count > 1)
            {
                var gamesFactory = new GamesFactory();
                var gamesRemaining = gamesFactory.Build(winners);
                return GetWinnerOfGroup(gamesRemaining);
            }

            return winners.First();
        }
    }
}
