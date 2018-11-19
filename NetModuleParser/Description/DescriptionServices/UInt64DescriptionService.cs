using System;
using System.Reflection;

namespace NetModuleParser.Description.DescriptionServices
{
    public class UInt64DescriptionService : HeaderMemberDescriptionService
    {
        public override string GetFieldValue(PropertyInfo property, object header) => ((ulong)property.GetValue(header)).ToString("x16");
        public override byte[] GetFieldBytes(PropertyInfo property, object header) => BitConverter.GetBytes((ulong) property.GetValue(header));
    }
}
