using System.IO;
using B22_Ex03.Models;
using B22_Ex03.Services;
using FacebookWrapper;

namespace B22_Ex03.Features
{
    public abstract class LoadDataToHelpFeatures
    {
        private static readonly string sr_Path = Path.Combine(PathHelperService.sr_PathToFiles + @"FakeDataProfile.xml");
        protected readonly FakeProfiles r_FakeProfiles;
        protected readonly LoginResult r_LoginResult;
        protected readonly GeneratorHelperService r_GeneratorHelperService;

        protected LoadDataToHelpFeatures(LoginResult i_LoginResult)
        {
            r_LoginResult = i_LoginResult;
            r_FakeProfiles = loadFakeProfileData();
            r_GeneratorHelperService = new GeneratorHelperService();
        }

        private FakeProfiles loadFakeProfileData()
        {
            return XmlHelperService.LoadXmlData<FakeProfiles>(sr_Path);
        }
    }
}
