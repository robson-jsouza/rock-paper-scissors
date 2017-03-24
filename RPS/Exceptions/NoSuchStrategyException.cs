using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS.Exceptions
{
    public class NoSuchStrategyException : Exception
    {
        public NoSuchStrategyException(string message) : base(message)
        { }
    }
}
