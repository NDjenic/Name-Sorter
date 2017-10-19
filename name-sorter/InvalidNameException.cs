using System;
using System.Collections.Generic;
using System.Text;

namespace name_sorter
{
    public class InvalidNameException : Exception //Custom exception for the handling of incorrect names. No surname or more than three given names.
    {
        public InvalidNameException(string message): base(message)
        {
        }
    }
}
