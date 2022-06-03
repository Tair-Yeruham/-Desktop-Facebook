using B22_Ex03.Proxy;
using FacebookWrapper;
// ReSharper disable All

namespace B22_Ex03.Facade
{
    public class LoginFacade
    {
        private readonly LoginSubSystem r_LoginSubSystem;
        private readonly VerifyLoggedInSubSystem r_VerifyLoggedInSubSystem;
        private readonly IsAdministratorSubSystem r_IsAdministratorSubSystem;

        public LoginFacade()
        {
            r_LoginSubSystem = new LoginSubSystem();
            r_VerifyLoggedInSubSystem = new VerifyLoggedInSubSystem();
            r_IsAdministratorSubSystem = new IsAdministratorSubSystem();
        }

        public LoginResult Login()
        {
            LoginResult loginResult = r_LoginSubSystem.Login();
            loginResult = r_VerifyLoggedInSubSystem.VerifyLoggedIn(loginResult);
            
            if(loginResult != null)
            {
                bool isAdministrator = r_IsAdministratorSubSystem.IsAdministratorUser(new UserProxy(loginResult.LoggedInUser));

                loginResult = isAdministrator ? loginResult : null;
            }

            return loginResult;
        }
    }
}
