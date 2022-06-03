using System;
using FacebookWrapper.ObjectModel;

namespace B22_Ex03.Models
{
    public class Posts
    {
        public string Id { get; set; }

        public string Message { get; set; }

        public DateTime? CreatedTime { get; set; }

        public string Link { get; set; }

        public Post.eType? Type { get; set; }

        public int CommentsCount { get; set; }

        public int LikesCount { get; set; }

        public int HeartsCount { get; set; }
    }
}
