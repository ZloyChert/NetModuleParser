using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace NetModuleParser.Description.DescriptionServices
{
    public class ByteDescriptionService : HeaderMemberDescriptionService
    {
        public override string GetFieldValue(PropertyInfo property, object header) => ((byte)property.GetValue(header)).ToString("x2");

        public override byte[] GetFieldBytes(PropertyInfo property, object header) => BitConverter.GetBytes((byte)property.GetValue(header));
    }
}
