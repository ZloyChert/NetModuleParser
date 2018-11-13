using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace NetModuleParser.Description
{
    public class HeaderDescriptionService
    {
        public IEnumerable<FieldDescriptionInfo> GetFieldDescription<T>(T header)
        {
            var properties = header.GetType().GetProperties().Where(prop => prop.IsDefined(typeof(FieldDescriptionAttribute), false));
            List<FieldDescriptionInfo> list = new List<FieldDescriptionInfo>(properties.Count());

            foreach (var property in properties)
            {
                FieldDescriptionAttribute attribute = (FieldDescriptionAttribute)property.GetCustomAttribute(typeof(FieldDescriptionAttribute));
                IFieldDescriptionService srv = (IFieldDescriptionService) Activator.CreateInstance(attribute.InformationServiceType);
                list.Add(srv.GetFieldDescriptionInfo(property, attribute, header));
            }

            return list;
        }
    }
}
