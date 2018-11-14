using System;
using System.Reflection;

namespace NetModuleParser.Description
{
    public interface IPropertyDescriptionService<out T>
    {
        T GetPropertyDescriptionInfo<THeader>(PropertyInfo property, Attribute attribute, THeader header);
    }
}
