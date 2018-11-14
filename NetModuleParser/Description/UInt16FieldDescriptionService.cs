using System;
using System.IO;
using System.Reflection;

namespace NetModuleParser.Description
{
    public class UInt16FieldDescriptionService : FieldDescriptionService
    {
        public override string GetFieldValue(PropertyInfo property, object header) => ((ushort)property.GetValue(header)).ToString("x4");

        public override byte[] GetFieldBytes(PropertyInfo property, object header) => BitConverter.GetBytes((ushort) property.GetValue(header));
    }
}
