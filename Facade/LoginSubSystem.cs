using FacebookWrapper;

namespace B22_Ex03.Facade
{
    public class LoginSubSystem
    {
        private const string k_AppId = "1876532692532213";
        private readonly string[] r_Permissions =
        {
            "email",
            "public_profile",
            "user_posts"
        };

        public LoginResult Login()
        {
            return FacebookService.Login(k_AppId, r_Permissions);
        }
    }
}
