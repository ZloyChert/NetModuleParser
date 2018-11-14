using System;
using System.Reflection;

namespace NetModuleParser.Description
{
    public class ModuleHeaderDescriptionService : IFieldDescriptionService<HeaderDescriptionInfo>
    {
        public HeaderDescriptionInfo GetFieldDescriptionInfo(PropertyInfo property, Attribute attribute, object header)
        {
            return new HeaderDescriptionInfo
            {
                Description = (string)typeof(PropertyDescriptionAttribute).GetProperty("Description").GetValue(attribute),
                FieldDescriptions = new HeaderDescriptionService<FieldDescriptionInfo>().GetFieldDescription(property.GetValue(header)),
                HeaderOffset = (int)typeof(PropertyDescriptionAttribute).GetProperty("FieldOffset").GetValue(attribute),
                HeaderLength = (int)typeof(PropertyDescriptionAttribute).GetProperty("FieldLength").GetValue(attribute)
            };
        }
    }
}
