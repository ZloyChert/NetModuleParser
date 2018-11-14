using System;
using System.Reflection;

namespace NetModuleParser.Description
{
    public abstract class FieldDescriptionService : IFieldDescriptionService<FieldDescriptionInfo>
    {
        public virtual FieldDescriptionInfo GetFieldDescriptionInfo(PropertyInfo property, Attribute attribute, object header)
        {
            var fieldOffset = GetFieldOffset(attribute);
            var fieldLength = GetFieldLength(attribute);
            var description = GetDescription(attribute);
            
            return new FieldDescriptionInfo
            {
                FieldOffset = fieldOffset,
                FieldLength = fieldLength,
                Description = description,
                FieldName = GetFieldName(property),
                FieldValue = GetFieldValue(property, header),
                ValueBytes = GetFieldBytes(property, header)
            };
        }

        public virtual int GetFieldOffset(Attribute attribute) => (int)typeof(PropertyDescriptionAttribute).GetProperty("FieldOffset").GetValue(attribute);
        public virtual int GetFieldLength(Attribute attribute) => (int)typeof(PropertyDescriptionAttribute).GetProperty("FieldLength").GetValue(attribute);

        public virtual string GetDescription(Attribute attribute) => (string)typeof(PropertyDescriptionAttribute).GetProperty("Description").GetValue(attribute);
        public virtual string GetFieldName(PropertyInfo property) => property.Name;

        public abstract string GetFieldValue(PropertyInfo property, object header);
        public abstract byte[] GetFieldBytes(PropertyInfo property, object header);

    }
}
