using System;
using System.Collections.Generic;
using System.Text;

namespace name_sorter
{
    public class NameComparer : IComparer<Name>
    {
        public int Compare(Name a, Name b)
        {
            int surName = a.Surname.CompareTo(b.Surname); //We start with the surname
            if (surName == 0) //If nothing, move to the first name
            {
                int givenName;
                for (int i = 0; i < a.GivenNames.Count; i++)
                {
                    givenName = a.GivenNames[i].CompareTo(b.GivenNames[i]);
                }
            }
            return surName;
        }
    }
}
