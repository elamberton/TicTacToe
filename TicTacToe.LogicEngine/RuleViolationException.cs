using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.LogicEngine
{
    public class RuleViolationException : Exception
    {
        public RuleViolationException(string message): base(message)
        {

        }

        public RuleViolationException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
