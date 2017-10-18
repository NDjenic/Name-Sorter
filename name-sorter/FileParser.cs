using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace name_sorter
{
    //Originally named FileParser, then I figured, why not make it Parse and Write. Thus, FileHandler.
    public class FileParser : FileHandler
    {
        public FileParser(String fileName) : base(fileName)
        {
        }

        //Fills a list of unsorted names.
        public List<Name> ParseFile()
        {
            List<Name> unsortedNames = new List<Name>();
            try
            {
                using (StreamReader reader = new StreamReader(base.fileName))
                {
                    String currentLine;
                    while ((currentLine = reader.ReadLine()) != null)
                    {
                        unsortedNames.Add(new Name(currentLine));
                    }
                }
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("File Not Found");
            }
            return unsortedNames;
        }
    }
}
