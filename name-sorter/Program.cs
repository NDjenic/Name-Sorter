using System;
using System.Collections.Generic;

namespace name_sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            String fileName = args[0];
            SorterProgram SorterProgram = new SorterProgram(fileName);
            SorterProgram.DoSortingWork();
        }
    }
}
