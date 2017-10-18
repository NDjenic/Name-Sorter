using System;
using System.Collections.Generic;
using System.Text;

namespace name_sorter
{
    public class Name
    {
        public List<String> GivenNames { get; set; }
        public String Surname { get; set; }

        public Name(String name)
        {
            String[] elements = name.TrimEnd(' ').Split(' ');

            this.Surname = elements[elements.Length - 1];
            this.GivenNames = new List<string>();

            if(elements.Length>4)
            {
                throw new InvalidNameException("Name" + name + " has too many given name elements");
            }
            else if (elements.Length >= 2)
            {
                for (int i = 0; i < elements.Length - 1; i++)
                {
                   this.GivenNames.Add(elements[i]);
                }
            }
            else if(elements.Length<=1)
            {
                throw new InvalidNameException("Name" + name + " is too short");
            }
        }

        public override string ToString()
        {
            String fullname = String.Empty;

            foreach(String element in GivenNames)
            {
                fullname += element + " ";
            }

            fullname += this.Surname;
            return fullname;
        }
        
    }
}
