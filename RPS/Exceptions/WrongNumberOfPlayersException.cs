using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS.Exceptions
{
    public class WrongNumberOfPlayersException : Exception
    {
        public WrongNumberOfPlayersException(string message) : base(message)
        { }
    }
}
