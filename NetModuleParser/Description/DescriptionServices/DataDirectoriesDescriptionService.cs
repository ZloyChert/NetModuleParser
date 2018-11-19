using System;
using System.Collections.Generic;
using System.Reflection;

namespace NetModuleParser.Description.DescriptionServices
{
    public class DataDirectoriesDescriptionService : PropertyDescriptionBaseService<HeaderMemberDescriptionInfo>
    {
        public override IEnumerable<HeaderMemberDescriptionInfo> GetPropertyDescriptionInfo<T>(PropertyInfo property, Attribute attribute, T header)
        {
            int dataDirectoriesOffset = GetOffset(attribute);
            var headerDescriptionService = new DescriptionService<HeaderMemberDescriptionInfo>();
            var propertyToGetDescription = property.GetValue(header);
            foreach (var headerDescription in headerDescriptionService.GetFieldDescription(propertyToGetDescription))
            {
                headerDescription.FieldOffset += dataDirectoriesOffset;
                yield return headerDescription;
            }
        }
    }
}

