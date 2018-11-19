using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace NetModuleParser.Description.DescriptionServices
{
    public class UInt16ArrayDescriptionService : HeaderMemberDescriptionService
    {
        public override string GetFieldValue(PropertyInfo property, object header)
        {
            ushort[] ushortArray = (ushort[])property.GetValue(header);
            IEnumerable<string> stringArray = ushortArray.Select(n => n.ToString("x4"));
            return string.Join(",", stringArray);
        }

        public override byte[] GetFieldBytes(PropertyInfo property, object header)
        {
            ushort[] ushortArray = (ushort[])property.GetValue(header);
            List<byte[]> bytes = new List<byte[]>(ushortArray.Length);

            foreach (var t in ushortArray)
            {
                bytes.Add(BitConverter.GetBytes(t));
            }

            return bytes.SelectMany(n => n).ToArray();
        }
    }
}
