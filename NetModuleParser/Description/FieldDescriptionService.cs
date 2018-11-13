using System;
using System.Reflection;

namespace NetModuleParser.Description
{
    public abstract class FieldDescriptionService : IFieldDescriptionService
    {
        public virtual FieldDescriptionInfo GetFieldDescriptionInfo(PropertyInfo property, Attribute attribute, object header)
        {
            var orderNumber = GetOrderNumber(attribute);
            var description = GetDescription(attribute);
            
            return new FieldDescriptionInfo
            {
                OrderNumber = orderNumber,
                Description = description,
                FieldName = GetFieldName(property),
                FieldValue = GetFieldValue(property, header)
            };
        }

        public virtual int GetOrderNumber(Attribute attribute) => (int)typeof(FieldDescriptionAttribute).GetProperty("OrderNumber").GetValue(attribute);

        public virtual string GetDescription(Attribute attribute) => (string)typeof(FieldDescriptionAttribute).GetProperty("Description").GetValue(attribute);
        public virtual string GetFieldName(PropertyInfo property) => property.Name;

        public abstract string GetFieldValue(PropertyInfo property, object header);

    }
}
