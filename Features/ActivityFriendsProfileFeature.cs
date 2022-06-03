using System.Collections.Generic;
using B22_Ex03.Enums;
using B22_Ex03.Models;
using FacebookWrapper;

namespace B22_Ex03.Features
{
    public class ActivityFriendsProfileFeature : LoadDataToHelpFeatures
    {
        public ActivityFriendsProfileFeature(LoginResult i_LoginResult)
            : base(i_LoginResult)
        {
        }

        public FakeActivityProfile GetFriendActivities(string i_FullName)
        {
            FakeActivityProfile fakeActivityProfile = new FakeActivityProfile() { NameFrom = i_FullName };
            List<string> friendList = GetFriends();
            List<string> nameToList = new List<string>();
            List<eActivityOption> activityOptions = new List<eActivityOption>();
            List<eActivityToData> activityToData = new List<eActivityToData>();
            int numberOfActivities = r_GeneratorHelperService.GetRandomNumber(1, r_FakeProfiles.FirstName.Count);

            fakeActivityProfile.CountActivity = numberOfActivities;
            friendList.Remove(i_FullName);
            for(int i = 0; i < numberOfActivities; i++)
            {
                int numberOfFriends = r_GeneratorHelperService.GetRandomNumber(1, friendList.Count);
                nameToList.Add(friendList[numberOfFriends]);

                int numberOfActivityOption = r_GeneratorHelperService.GetRandomNumber(1, System.Enum.GetNames(typeof(eActivityOption)).Length);
                activityOptions.Add((eActivityOption)numberOfActivityOption);

                int numberOfActivityToData = r_GeneratorHelperService.GetRandomNumber(1, System.Enum.GetNames(typeof(eActivityToData)).Length);
                activityToData.Add((eActivityToData)numberOfActivityToData);
            }

            fakeActivityProfile.NameTo = nameToList;
            fakeActivityProfile.ActivityOption = activityOptions;
            fakeActivityProfile.ActivityToData = activityToData;

            return fakeActivityProfile;
        }

        public List<string> GetFriends()
        {
            List<string> friendList = new List<string>();

            for(int i = 0; i < r_FakeProfiles.FirstName.Count; i++)
            {
                string firstName = r_FakeProfiles.FirstName[i];
                string lastName = r_FakeProfiles.LastName[i];
                string fullName = string.Join(" ", firstName, lastName);

                friendList.Add(fullName);
            }

            return friendList;
        }
    }
}
