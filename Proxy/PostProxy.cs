using FacebookWrapper.ObjectModel;

namespace B22_Ex03.Proxy
{
    public class PostProxy
    {
        public Post Post { get; set; }

        public PostProxy(Post i_Post)
        {
            Post = i_Post;
        }

        public bool CheckIfMessageIsNotNull()
        {
            return Post.Message != null;
        }

        public bool CheckIfPostMessageContainStringFromUser(string i_SearchPost)
        {
            return Post.Message.ToLower().Contains(i_SearchPost.ToLower());
        }
    }
}
