using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS.Factories
{
    public class GamesFactory
    {
        public List<Game> Build(List<PlayerMove> players)
        {
            var games = new List<Game>();
            for(int index = 0; index < players.Count; index += 2)
            {
                var playersForGame = players.Skip(index).Take(2);
                var game = new Game(new PlayerMove[] { playersForGame.First(), playersForGame.Last() });
                games.Add(game);
            }

            return games;
        }
    }
}
