using System;
using System.Collections.Generic;
using System.Reflection;

namespace NetModuleParser.Description.DescriptionServices
{
    public class EnumUInt16DescriptionService<T> : PropertyDescriptionBaseService<HeaderMemberDescriptionInfo>
    {
        public override IEnumerable<HeaderMemberDescriptionInfo> GetPropertyDescriptionInfo<THeader>(PropertyInfo property, Attribute attribute, THeader header)
        {
            string description = GetDescription(attribute);
            description += "lalala";

            yield return new HeaderMemberDescriptionInfo
            {
                FieldOffset = GetOffset(attribute),
                FieldLength = GetLength(attribute),
                Description = description,
                FieldName = GetFieldName(property),
                FieldValue = GetFieldValue(property, header),
                ValueBytes = GetFieldBytes(property, header)
            };
        }

        public virtual string GetFieldName(PropertyInfo property) => property.Name;
        public string GetFieldValue(PropertyInfo property, object header) => ((T)property.GetValue(header)).ToString();

        public byte[] GetFieldBytes(PropertyInfo property, object header) => new byte[2];
    }
}
