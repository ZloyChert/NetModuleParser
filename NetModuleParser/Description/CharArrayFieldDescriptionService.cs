using System;
using System.Reflection;

namespace NetModuleParser.Description
{
    public class CharArrayFieldDescriptionService : FieldDescriptionService
    {
        public override string GetFieldValue(PropertyInfo property, object header) => string.Join(',', (char[])property.GetValue(header));
    }
}
