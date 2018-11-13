using System;
using System.Reflection;

namespace NetModuleParser.Description
{
    public interface IFieldDescriptionService
    {
        FieldDescriptionInfo GetFieldDescriptionInfo(PropertyInfo property, Attribute attribute, object header);
    }
}
