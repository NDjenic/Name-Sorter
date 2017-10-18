using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace name_sorter
{
    //Changed to adopt SOLID principles (to a degree)
    public class FileWriter : FileHandler
    {
        public FileWriter(String fileName) : base(fileName)
        {
            base.fileName = fileName;
        }

        public void WriteFile(List<Name> names)
        {
            String outputFileName = Path.GetDirectoryName(base.fileName) + "\\sorted-names-list.txt";

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
