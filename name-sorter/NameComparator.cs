using System;
using System.Collections.Generic;
using System.Text;

namespace name_sorter
{
    public class NameComparator : IComparer<Name>
    {
        public int Compare(Name a, Name b)
        {
            int surName = a.Surname.CompareTo(b.Surname); //We start with the surname
            if (surName == 0) //If nothing, move to the first name
            {
                int firstName = a.FirstName.CompareTo(b.FirstName);
                if(firstName == 0) //If nothing, move through the given names.
                {
                    int givenName;
                    for(int i=0; i<a.GivenNames.Count; i++)
                    {
                        try
                        {
                            givenName = a.GivenNames[i].CompareTo(b.GivenNames[i]);
                        }
                        catch(IndexOutOfRangeException) //Since we're dealing with different sizes, might be an idea to use this and avoid problems.
                        {

                        }
                    }
                }
                return firstName;
            }
            return surName;
        }
    }
}
