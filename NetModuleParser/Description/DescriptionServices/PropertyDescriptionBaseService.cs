﻿using System;
using System.Collections.Generic;
using System.Reflection;

namespace NetModuleParser.Description.DescriptionServices
{
    public abstract class PropertyDescriptionBaseService<T> : IPropertyDescriptionService<T>
    {
        public virtual int GetOffset(Attribute attribute) => PropertyDescriptionHelper.GetOffset(attribute);
        public virtual int GetLength(Attribute attribute) => PropertyDescriptionHelper.GetLength(attribute);
        public virtual int GetOrderNumber(Attribute attribute) => PropertyDescriptionHelper.GetOrderNumber(attribute);
        public virtual string GetDescription(Attribute attribute) => PropertyDescriptionHelper.GetDescription(attribute);
        public abstract IEnumerable<T> GetPropertyDescriptionInfo<THeader>(PropertyInfo property, Attribute attribute, THeader header);
    }
}
