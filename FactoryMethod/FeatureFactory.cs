using System;
using B22_Ex03.Enum;
using B22_Ex03.Forms;
using FacebookWrapper;

namespace B22_Ex03.FactoryMethod
{
    public class FeatureFactory
    {
        public IFeatures LoadFeature(eFeatureOption i_FeatureOption, LoginResult i_LoginResult)
        {
            IFeatures feature;

            switch(i_FeatureOption)
            {
                case eFeatureOption.SearchPostAndShowDetails:
                    feature = new FormSearchPostAndShowDetailsBasicExperience(i_LoginResult);
                    break;
                case eFeatureOption.WhoWatchMyProfile:
                    feature = new FormWhoWatchMyProfileFeature(i_LoginResult);
                    break;
                case eFeatureOption.ActivityFriendsProfile:
                    feature = new FormActivityFriendsProfileFeature(i_LoginResult);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(i_FeatureOption), i_FeatureOption, null);
            }

            return feature;
        }
    }
}
