using System;
using System.Reflection;

namespace NetModuleParser.Description
{
    public class UInt32FieldDescriptionService : FieldDescriptionService
    {
        public override string GetFieldValue(PropertyInfo property, object header) => ((uint)property.GetValue(header)).ToString("x8");
        public override byte[] GetFieldBytes(PropertyInfo property, object header) => BitConverter.GetBytes((uint) property.GetValue(header));
    }
}
