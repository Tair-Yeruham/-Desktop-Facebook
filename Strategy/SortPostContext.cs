using System;
using System.Collections.Generic;
using B22_Ex03.Enums;
using B22_Ex03.Models;

namespace B22_Ex03.Strategy
{
    public class SortPostContext
    {
        private readonly SortPostStrategy r_SortPostStrategy;
        private readonly bool r_Ascending;

        public SortPostContext(eSortTypes i_SortTypes, bool i_Ascending)
        {
            r_SortPostStrategy = setSortPostStrategy(i_SortTypes);
            r_Ascending = i_Ascending;
        }

        public List<Posts> Sort(List<Posts> i_Posts)
        {
            return r_Ascending ? r_SortPostStrategy.AscendingSort(i_Posts) : r_SortPostStrategy.DescendingSort(i_Posts);
        }

        private SortPostStrategy setSortPostStrategy(eSortTypes i_SortTypes)
        {
            SortPostStrategy strategy;

            switch(i_SortTypes)
            {
                case eSortTypes.CreatedTime:
                    strategy = new SortPostByCreatedTime();
                    break;
                case eSortTypes.LikesCount:
                    strategy = new SortPostByLikesCount();
                    break;
                case eSortTypes.CommentsCount:
                    strategy = new SortPostByCommentsCount();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(i_SortTypes), i_SortTypes, null);
            }

            return strategy;
        }
    }
}
