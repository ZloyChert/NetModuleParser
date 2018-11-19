﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace NetModuleParser.Description.DescriptionServices
{
    public class EnumUInt16DescriptionService<T> : PropertyDescriptionBaseService<HeaderMemberDescriptionInfo>
    {
        public override IEnumerable<HeaderMemberDescriptionInfo> GetPropertyDescriptionInfo<THeader>(PropertyInfo property, Attribute attribute, THeader header)
        {
            var type = typeof(T);
            var enumMember = type.GetMember(((T)property.GetValue(header)).ToString()).Single();
            var descriptionAttribute = enumMember.GetCustomAttribute(typeof(DescriptionAttribute), false);
            var enumDescription = ((DescriptionAttribute)descriptionAttribute).Description;

            yield return new HeaderMemberDescriptionInfo
            {
                FieldOffset = GetOffset(attribute),
                FieldLength = GetLength(attribute),
                Description = $"{GetDescription(attribute)}. Machine type: {enumDescription}",
                FieldName = GetFieldName(property),
                FieldValue = GetFieldValue(property, header),
                ValueBytes = GetFieldBytes(property, header)
            };
        }

        public virtual string GetFieldName(PropertyInfo property) => property.Name;
        public string GetFieldValue(PropertyInfo property, object header) => ((T)property.GetValue(header)).ToString();

        public byte[] GetFieldBytes(PropertyInfo property, object header) => BitConverter.GetBytes((ushort)property.GetValue(header));
    }
}
