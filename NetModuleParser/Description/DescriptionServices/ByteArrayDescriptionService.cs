using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace NetModuleParser.Description.DescriptionServices
{
    public class ByteArrayDescriptionService : HeaderMemberDescriptionService
    {
        public override string GetFieldValue(PropertyInfo property, object header)
        {
            byte[] ushortArray = (byte[])property.GetValue(header);
            IEnumerable<string> stringArray = ushortArray.Select(n => n.ToString("x2"));
            return string.Join(",", stringArray);
        }

        public override byte[] GetFieldBytes(PropertyInfo property, object header) => (byte[])property.GetValue(header);
    }
}
