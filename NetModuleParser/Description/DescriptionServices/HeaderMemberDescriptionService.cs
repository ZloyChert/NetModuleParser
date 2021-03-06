﻿using System;
using System.Collections.Generic;
using System.Reflection;

namespace NetModuleParser.Description.DescriptionServices
{
    public abstract class HeaderMemberDescriptionService : PropertyDescriptionBaseService<HeaderMemberDescriptionInfo>
    {
        public override IEnumerable<HeaderMemberDescriptionInfo> GetPropertyDescriptionInfo<THeader>(PropertyInfo property, Attribute attribute, THeader header)
        {
            yield return new HeaderMemberDescriptionInfo
            {
                FieldOffset = GetOffset(attribute),
                FieldLength = GetLength(attribute),
                Description = GetDescription(attribute),
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
