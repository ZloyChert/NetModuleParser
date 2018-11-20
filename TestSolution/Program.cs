using System;
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
                var md = s.GetFieldDescription(module).ToList();

                foreach (var m in md.OrderBy(n => n.HeaderOrderNumber))
                {
                    Console.WriteLine($"HeaderOrderNumber {m.HeaderOrderNumber}");
                    Console.WriteLine($"Header description: {m.Description}");
                    foreach (var hm in m.HeaderMemberDescriptions.OrderBy(n => n.FieldOffset))
                    {
                        Console.WriteLine($"FieldName : {hm.FieldName}");
                        Console.WriteLine($"FieldOffset : {hm.FieldOffset}");
                        Console.WriteLine($"FieldLength : {hm.FieldLength}");
                        Console.WriteLine($"FieldValue : {hm.FieldValue}");
                        Console.Write("Bytes : ");
                        foreach (var b in hm.ValueBytes)
                        {
                            Console.Write($"{b};");
                        }
                        Console.WriteLine();
                        Console.WriteLine($"Description : {hm.Description}");
                        Console.WriteLine(hm.Description);
                    }

                    Console.WriteLine();
                }

                Console.Read();
            }
        }
    }
}
