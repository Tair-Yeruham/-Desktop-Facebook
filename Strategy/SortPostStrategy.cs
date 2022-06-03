using System.Collections.Generic;
using B22_Ex03.Models;

namespace B22_Ex03.Strategy
{
    public abstract class SortPostStrategy
    {
        public abstract List<Posts> AscendingSort(List<Posts> i_ListTort);
        public abstract List<Posts> DescendingSort(List<Posts> i_ListTort);
    }
}
