using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace name_sorter
{
    //Originally named FileParser, then I figured, why not make it Parse and Write. Thus, FileHandler.
    class FileHandler
    {

        //The filename that the system will read. MUST be .txt
        private String fileName;

        public FileHandler(String fileName)
        {
            this.fileName = fileName;
        }

        //Fills a list of unsorted names.
        public List<Name> ParseFile()
        {
            List<Name> unsortedNames = new List<Name>();
            try
            {
                
                using (StreamReader reader = new StreamReader(this.fileName))
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

        public void WriteFile(List<Name> names)
        {
            String outputFileName = Path.GetDirectoryName(this.fileName) + "\\sorted-names-list.txt";

            using (StreamWriter writer = new StreamWriter(outputFileName, false))
            {
                foreach (Name name in names)
                {
                    Console.WriteLine(name.ToString());
                    writer.WriteLine(name.ToString());
                }
            }
        }
    }
}
