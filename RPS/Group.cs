using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    public class Group
    {
        public Game[] Games { get; }

        public Group(params Game[] games)
        {
            Games = games;
        }
    }
}
