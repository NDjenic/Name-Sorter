using System;
using System.Collections.Generic;
using System.Text;

namespace name_sorter
{
    public class SorterProgram
    {
        private List<Name> Names { get; set; }
        private FileParser FileParser { get; set; }
        private FileWriter FileWriter { get; set; }
        private NameSorter NameSorter { get; set; }

        public SorterProgram(String fileName)
        {
            FileParser = new FileParser(fileName);
            FileWriter = new FileWriter(fileName);
            NameSorter = new NameSorter();
        }

        //Purely intended as a testing method, since CollectionAssert doesn't seem to like complex classes.
        public List<String> GetNames()
        {
            List<String> nameStrings = new List<string>();
            foreach (Name name in Names)
            {
                nameStrings.Add(name.ToString());
            }
            return nameStrings;
        }

        public void JustParseNames()
        {
            try
            {
                Names = FileParser.ParseFile();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("You have not designated a file to parse");
            }
            catch (InvalidFileException ife)
            {
                Console.WriteLine(ife.Message);
            }
            catch (InvalidNameException ine)
            {
                Console.WriteLine(ine.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void DoSortingWork()
        {
            try
            {
                Names = FileParser.ParseFile();
                NameSorter.SortNames(this.Names);
                FileWriter.WriteFile(this.Names);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("You have not designated a file to parse");
            }
            catch (InvalidFileException ife)
            {
                Console.WriteLine(ife.Message);
            }
            catch (InvalidNameException ine)
            {
                Console.WriteLine(ine.Message);
            }
        }
    }
}
