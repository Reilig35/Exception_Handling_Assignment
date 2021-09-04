using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Handling_Assignment
{
    class TooOldException : Exception
    {
        public TooOldException()
           : base() { }
        public TooOldException(string message)
            : base(message) { }
    }
}
