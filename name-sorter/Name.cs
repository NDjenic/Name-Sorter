using System;
using System.Collections.Generic;
using System.Text;

namespace name_sorter
{
    public class Name
    {
        public String FirstName { get; set; }
        public List<String> GivenNames { get; set; }
        public String Surname { get; set; }

        public Name(String name)
        {
            String[] elements = name.TrimEnd(' ').Split(' ');

            this.FirstName = elements[0];
            this.Surname = elements[elements.Length - 1];
            this.GivenNames = new List<string>();
            if (elements.Length > 2)
            {
                for (int i = 1; i < elements.Length - 1; i++)
                {
                    //Instead of using a heavier List, why not simply just add it to the start of the array?
                    this.GivenNames.Add(elements[i]);
                }
            }
        }

        public override string ToString()
        {
            String fullname = String.Empty;

            fullname += this.FirstName + " ";

            foreach(String element in GivenNames)
            {
                fullname += element + " ";
            }

            fullname += this.Surname;
            return fullname;
        }
        
    }
}
