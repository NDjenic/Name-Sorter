using System;
using System.Collections.Generic;

namespace name_sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            String fileName = args[0];

            try
            {
                if (!fileName.EndsWith("txt"))
                {
                    Console.WriteLine("File is not a text file");
                }
                else
                {
                    NameSorter nameSorter = new NameSorter(fileName);
                    nameSorter.SortNames();
                    nameSorter.GenerateNames();
                }
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("You have not designated a file to parse");
            }
        }
    }
}
