using System;
using System.Reflection;

namespace NetModuleParser.Description
{
    public interface IFieldDescriptionService<out TT>
    {
        TT GetFieldDescriptionInfo(PropertyInfo property, Attribute attribute, object header);
    }
}
