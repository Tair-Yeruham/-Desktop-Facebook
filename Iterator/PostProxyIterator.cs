using System.Collections.Generic;
using B22_Ex03.Proxy;
using FacebookWrapper.ObjectModel;

namespace B22_Ex03.Iterator
{
    public static class PostProxyIterator
    {
        public static IEnumerable<PostProxy> GetPostProxyIterator(IEnumerable<Post> i_Posts)
        {
            foreach(Post post in i_Posts)
            {
                PostProxy postProxy = new PostProxy(post);

                if(postProxy.CheckIfMessageIsNotNull())
                {
                    yield return postProxy;
                }
            }
        }
    }
}
