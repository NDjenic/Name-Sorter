using System;
using System.Collections.Generic;
using System.Text;

namespace name_sorter
{
    public class FileHandler //Both FileParser and FileWriter need a filename, thus why not make them subclasses to this?
    {
        //The filename that the system will read. MUST be .txt
        protected String fileName { get; set; }

        public FileHandler(String fileName)
        {
            this.fileName = fileName;
            if (!fileName.EndsWith("txt"))
            {
                throw new InvalidFileException(fileName);
            }
        }
    }
}
