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
                Description = "stub",
                FieldDescriptions = new HeaderDescriptionService<FieldDescriptionInfo>().GetFieldDescription(property.GetValue(header)),
                HeaderOffset = 4,
                HeaderLength = 4
            };
        }
    }
}
