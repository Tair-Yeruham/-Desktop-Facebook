using B22_Ex03.Enums;
using B22_Ex03.Proxy;

namespace B22_Ex03.Facade
{
    public class IsAdministratorSubSystem
    {
        public bool IsAdministratorUser(UserProxy i_User)
        {
            return i_User.UserType == eUserType.Administrator;
        }
    }
}
