using System;
using System.Reflection;

namespace NetModuleParser.Description
{
    public class UInt32DescriptionService : HeaderMemberDescriptionService
    {
        public override string GetFieldValue(PropertyInfo property, object header) => ((uint)property.GetValue(header)).ToString("x8");
        public override byte[] GetFieldBytes(PropertyInfo property, object header) => BitConverter.GetBytes((uint) property.GetValue(header));
    }
}
