using System;
using System.Collections.Generic;
using System.Linq;
using B22_Ex03.Models;
using FacebookWrapper;

namespace B22_Ex03.Features
{
    public sealed class WhoWatchMyProfileFeature : LoadDataToHelpFeatures
    {
        public WhoWatchMyProfileFeature(LoginResult i_LoginResult) 
            : base(i_LoginResult)
        {
        }

        public List<FakeProfile> WhoWatchMeProfile()
        {
            List<FakeProfile> fakeProfiles = new List<FakeProfile>();
            int numberOfProfiles = r_GeneratorHelperService.GetRandomNumber(1, r_FakeProfiles.FirstName.Count);

            for (int i = 0; i < numberOfProfiles; i++)
            {
                int numberOfFirstName = r_GeneratorHelperService.GetRandomNumber(1, r_FakeProfiles.FirstName.Count);
                string firstName = r_FakeProfiles.FirstName[numberOfFirstName];
                int numberOfLastName = r_GeneratorHelperService.GetRandomNumber(1, r_FakeProfiles.LastName.Count);
                string lastName = r_FakeProfiles.LastName[numberOfLastName];
                int numberOfWhoWatchMyProfile = r_GeneratorHelperService.GetRandomNumber(1, r_FakeProfiles.WhenWatchMyProfile.Count);
                DateTime whenWatchMyProfile = r_FakeProfiles.WhenWatchMyProfile[numberOfWhoWatchMyProfile];
                bool isAlreadyFriend = r_GeneratorHelperService.GetRandomNumber(1, 3) == 2;

                fakeProfiles.Add(new FakeProfile()
                {
                  FirstName = firstName,
                  LastName = lastName,
                  WhenWatchMyProfile = whenWatchMyProfile,
                  IsAlreadyFriend = isAlreadyFriend
                });
            }

            return fakeProfiles.OrderByDescending(i_Date => i_Date.WhenWatchMyProfile).ToList();
        }
    }
}
