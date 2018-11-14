using System;
using System.Reflection;

namespace NetModuleParser.Description.DescriptionServices
{
    public class UInt16DescriptionService : HeaderMemberDescriptionService
    {
        public override string GetFieldValue(PropertyInfo property, object header) => ((ushort)property.GetValue(header)).ToString("x4");

        public override byte[] GetFieldBytes(PropertyInfo property, object header) => BitConverter.GetBytes((ushort) property.GetValue(header));
    }
}
