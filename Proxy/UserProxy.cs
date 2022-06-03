using System.IO;
using B22_Ex03.Enums;
using B22_Ex03.Models;
using B22_Ex03.Services;
using FacebookWrapper.ObjectModel;

namespace B22_Ex03.Proxy
{
    public class UserProxy
    {
        private static readonly string sr_Path = Path.Combine(PathHelperService.sr_PathToFiles + @"Administrator.xml");
        private readonly User r_User;

        public UserProxy(User i_User)
        {
            r_User = i_User;
            UserType = setUserType();
        }

        public eUserType UserType { get; set; }

        private eUserType setUserType()
        {
            Administrator administratorUsers = XmlHelperService.LoadXmlData<Administrator>(sr_Path);
            
            return administratorUsers.Name.Contains(r_User.Name) ? eUserType.Administrator : eUserType.NotAdministrator;
        }
    }
}
