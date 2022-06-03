using FacebookWrapper;

namespace B22_Ex03.Facade
{
    public class VerifyLoggedInSubSystem
    {
        public LoginResult VerifyLoggedIn(LoginResult i_LoginResult)
        {
            return i_LoginResult.AccessToken != null ? i_LoginResult : null;
        }
    }
}
