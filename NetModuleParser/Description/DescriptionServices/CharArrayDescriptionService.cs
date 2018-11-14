using System.Collections.Generic;
using System.Reflection;

namespace NetModuleParser.Description.DescriptionServices
{
    public class CharArrayDescriptionService : HeaderMemberDescriptionService
    {
        public override string GetFieldValue(PropertyInfo property, object header) => string.Join(", ", (char[])property.GetValue(header));
        public override byte[] GetFieldBytes(PropertyInfo property, object header)
        {
            List<byte> list = new List<byte>();
            foreach (var v in (char[])property.GetValue(header))
            {
                list.Add((byte)v);
            }

            return list.ToArray();
        }
    }
}
