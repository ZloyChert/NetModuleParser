using System;
using System.Reflection;

namespace NetModuleParser.Description
{
    public abstract class HeaderMemberDescriptionService : PropertyDescriptionBaseService<HeaderMemberDescriptionInfo>
    {
        public override HeaderMemberDescriptionInfo GetPropertyDescriptionInfo<THeader>(PropertyInfo property, Attribute attribute, THeader header)
        {
            int fieldOffset = GetOffset(attribute);
            int fieldLength = GetLength(attribute);
            string description = GetDescription(attribute);
            
            return new HeaderMemberDescriptionInfo
            {
                FieldOffset = fieldOffset,
                FieldLength = fieldLength,
                Description = description,
                FieldName = GetFieldName(property),
                FieldValue = GetFieldValue(property, header),
                ValueBytes = GetFieldBytes(property, header)
            };
        }

        public virtual string GetFieldName(PropertyInfo property) => property.Name;
        public abstract string GetFieldValue(PropertyInfo property, object header);
        public abstract byte[] GetFieldBytes(PropertyInfo property, object header);

    }
}
