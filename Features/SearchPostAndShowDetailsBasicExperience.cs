using System.Collections.Generic;
using System.Linq;
using B22_Ex03.Iterator;
using B22_Ex03.Models;
using B22_Ex03.Proxy;
using FacebookWrapper;

namespace B22_Ex03.Features
{
    public sealed class SearchPostAndShowDetailsBasicExperience : LoadDataToHelpFeatures
    {
        public SearchPostAndShowDetailsBasicExperience(LoginResult i_LoginResult)
            : base(i_LoginResult)
        {
        }

        public List<Posts> SearchPosts(string i_SearchPost)
        {
            IEnumerable<PostProxy> postProxies = PostProxyIterator.GetPostProxyIterator(r_LoginResult.LoggedInUser.Posts);

            return (from postProxy in postProxies
                    where postProxy.CheckIfPostMessageContainStringFromUser(i_SearchPost)
                    select new Posts()
                               {
                                   Id = postProxy.Post.Id,
                                   Message = postProxy.Post.Message,
                                   CreatedTime = postProxy.Post.CreatedTime,
                                   Link = postProxy.Post.Link,
                                   Type = postProxy.Post.Type,
                                   CommentsCount = r_GeneratorHelperService.GetRandomNumber(),
                                   LikesCount = r_GeneratorHelperService.GetRandomNumber(),
                                   HeartsCount = r_GeneratorHelperService.GetRandomNumber(),
                               }).ToList();
        }
    }
}
