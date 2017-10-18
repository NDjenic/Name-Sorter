using System;
using System.Collections.Generic;
using System.Text;

namespace name_sorter
{
    public class NameSorter
    {
        public void SortNames(List<Name> names)
        {
            names.Sort(new NameComparer());
        }
    }
}
