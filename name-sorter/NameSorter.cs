using System;
using System.Collections.Generic;
using System.Text;

namespace name_sorter
{
    public class NameSorter
    {
        private List<Name> Names { get; set; }
        private FileHandler FileHandler { get; set; }

        public List<String> GetNames()
        {
            List<String> nameStrings = new List<string>();
            foreach(Name name in Names)
            {
                nameStrings.Add(name.ToString());
            }
            return nameStrings;
        }

        public NameSorter(String fileName)
        {
            FileHandler = new FileHandler(fileName);
            Names = FileHandler.ParseFile();
        }

        public void SortNames()
        {
            this.Names.Sort(new NameComparator());
        }

        public void GenerateNames()
        {
            FileHandler.WriteFile(this.Names);
        }
    }
}
