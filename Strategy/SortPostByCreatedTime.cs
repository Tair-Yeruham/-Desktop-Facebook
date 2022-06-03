using System.Collections.Generic;
using System.Linq;
using B22_Ex03.Models;

namespace B22_Ex03.Strategy
{
    public class SortPostByCreatedTime : SortPostStrategy
    {
        public override List<Posts> AscendingSort(List<Posts> i_ListTort)
        {
            return i_ListTort.OrderBy(i_Post => i_Post.CreatedTime).ToList();
        }

        public override List<Posts> DescendingSort(List<Posts> i_ListTort)
        {
            return i_ListTort.OrderByDescending(i_Post => i_Post.CreatedTime).ToList();
        }
    }
}
