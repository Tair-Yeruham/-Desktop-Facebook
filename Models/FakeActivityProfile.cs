using System.Collections.Generic;
using B22_Ex03.Enums;

namespace B22_Ex03.Models
{
    public class FakeActivityProfile
    {
        public string NameFrom { get; set; }

        public List<string> NameTo { get; set; }

        public List<eActivityOption> ActivityOption { get; set; }

        public List<eActivityToData> ActivityToData { get; set; }

        public int CountActivity { get; set; }
    }
}
