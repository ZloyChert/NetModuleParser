using System.Linq;
using NetModuleParser;
using NetModuleParser.Description;

namespace TestSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ModuleReader mr = new ModuleReader(@"opyat' popalsa"))
            {
                var module = mr.ReadNetModule();

                HeaderDescriptionService s = new HeaderDescriptionService();
                var a = s.GetFieldDescription(module.MsDosHeader).ToList();
            }
        }
    }
}
