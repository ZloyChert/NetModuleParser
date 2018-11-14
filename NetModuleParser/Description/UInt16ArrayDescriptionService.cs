using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace NetModuleParser.Description
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
            List<byte[]> list = new List<byte[]>();
            ushort[] ushortArray = (ushort[])property.GetValue(header);
            foreach (var t in ushortArray)
            {
                list.Add(BitConverter.GetBytes(t));
            }

            return list.SelectMany(n => n).ToArray();
        }
    }
}
