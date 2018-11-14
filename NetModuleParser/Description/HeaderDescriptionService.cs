using System;
using System.Collections.Generic;
using System.Reflection;

namespace NetModuleParser.Description
{
    public class HeaderDescriptionService : PropertyDescriptionBaseService<HeaderDescriptionInfo>
    {
        public override HeaderDescriptionInfo GetPropertyDescriptionInfo<T>(PropertyInfo property, Attribute attribute, T header)
        {
            int headerOffset = GetOffset(attribute);
            int headerLength = GetLength(attribute);
            string description = GetDescription(attribute);
            var headerDescriptionService = new HeaderDescriptionService<HeaderMemberDescriptionInfo>();
            var propertyToGetDescription = property.GetValue(header);
            IEnumerable<HeaderMemberDescriptionInfo> headerMemberDescriptions = headerDescriptionService.GetFieldDescription(propertyToGetDescription);

            return new HeaderDescriptionInfo
            {
                Description = description,
                HeaderMemberDescriptions = headerMemberDescriptions,
                HeaderOffset = headerOffset,
                HeaderLength = headerLength
            };
        }
    }
}
