using System;
using System.Collections.Generic;
using System.Text;

namespace name_sorter
{
    class InvalidFileException : Exception
    {
        public InvalidFileException(string filename): base(String.Format("{0} is invalid", filename))
        {

        }
    }
}
