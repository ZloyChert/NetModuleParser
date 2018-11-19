using System;
using System.Collections.Generic;
using System.Reflection;

namespace NetModuleParser.Description.DescriptionServices
{
    public interface IPropertyDescriptionService<out T>
    {
        IEnumerable<T> GetPropertyDescriptionInfo<THeader>(PropertyInfo property, Attribute attribute, THeader header);
    }
}
