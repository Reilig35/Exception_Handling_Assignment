using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Handling_Assignment
{
    public class NotOldEnoughException : Exception
    {
        public NotOldEnoughException()
            : base() { }
        public NotOldEnoughException(string message)
            : base(message) { }
    }
}
