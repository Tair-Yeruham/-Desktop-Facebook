using System;

namespace B22_Ex03.Models
{
    public class FakeProfile
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime WhenWatchMyProfile { get; set; }

        public bool IsAlreadyFriend { get; set; }

        public override string ToString()
        {
            return $"{FirstName}, {LastName}, {WhenWatchMyProfile}, {(IsAlreadyFriend ? "Friend" : "No Friend")}";
        }
    }
}
