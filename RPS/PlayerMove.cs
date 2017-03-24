using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    public class PlayerMove
    {
        public string Name { get; }
        public string Move { get; }

        public PlayerMove(string name, string move)
        {
            Name = name;
            Move = move;
        }
    }
}
