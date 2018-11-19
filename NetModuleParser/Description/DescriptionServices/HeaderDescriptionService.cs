using System;
using System.Collections.Generic;
using System.Reflection;

namespace NetModuleParser.Description.DescriptionServices
{
    public class HeaderDescriptionService : PropertyDescriptionBaseService<HeaderDescriptionInfo>
    {
        public override IEnumerable<HeaderDescriptionInfo> GetPropertyDescriptionInfo<T>(PropertyInfo property, Attribute attribute, T header)
        {
            int headerOrderNumber = GetOrderNumber(attribute);
            string description = GetDescription(attribute);
            var headerDescriptionService = new DescriptionService<HeaderMemberDescriptionInfo>();
            var propertyToGetDescription = property.GetValue(header);
            IEnumerable<HeaderMemberDescriptionInfo> headerMemberDescriptions = headerDescriptionService.GetFieldDescription(propertyToGetDescription);

            yield return new HeaderDescriptionInfo
            {
                Description = description,
                HeaderMemberDescriptions = headerMemberDescriptions,
                HeaderOrderNumber = headerOrderNumber,
            };
        }
    }
}
