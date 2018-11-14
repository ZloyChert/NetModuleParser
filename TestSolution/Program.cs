using System.Linq;
using NetModuleParser;
using NetModuleParser.Description;

namespace TestSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ModuleReader mr = new ModuleReader(@"D:\log4net.dll"))
            {
                var module = mr.ReadNetModule();

                DescriptionService<HeaderDescriptionInfo> s = new DescriptionService<HeaderDescriptionInfo>();
                var a = s.GetFieldDescription(module).ToList();
            }
        }
    }
}
