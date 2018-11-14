using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NetModuleParser.Description.DescriptionServices;

namespace NetModuleParser.Description
{
    public class DescriptionService<T>
    {
        public IEnumerable<T> GetFieldDescription<THeader>(THeader header)
        {
            var properties = header.GetType().GetProperties().Where(prop => prop.IsDefined(typeof(PropertyDescriptionAttribute), false));
            List<T> list = new List<T>(properties.Count());

            foreach (var property in properties)
            {
                PropertyDescriptionAttribute attribute = (PropertyDescriptionAttribute)property.GetCustomAttribute(typeof(PropertyDescriptionAttribute));
                IPropertyDescriptionService<T> srv = (IPropertyDescriptionService<T>) Activator.CreateInstance(attribute.InformationServiceType);
                list.Add(srv.GetPropertyDescriptionInfo(property, attribute, header));
            }

            return list;
        }
    }
}
