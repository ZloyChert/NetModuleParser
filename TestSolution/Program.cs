using NetModuleParser;

namespace TestSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ModuleReader mr = new ModuleReader(@"Ne:\Her\SmOtReT\v\ChUzHiE\PuTi"))
            {
                var module = mr.ReadNetModule();
            }
        }
    }
}
