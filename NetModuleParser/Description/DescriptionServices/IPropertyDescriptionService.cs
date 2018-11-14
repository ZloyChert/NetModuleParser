using System;
using System.Reflection;

namespace NetModuleParser.Description.DescriptionServices
{
    public interface IPropertyDescriptionService<out T>
    {
        T GetPropertyDescriptionInfo<THeader>(PropertyInfo property, Attribute attribute, THeader header);
    }
}
