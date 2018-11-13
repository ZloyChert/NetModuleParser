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

            foreach (var prop in properties)
            {
                FieldDescriptionAttribute attr = (FieldDescriptionAttribute)prop.GetCustomAttribute(typeof(FieldDescriptionAttribute));

                var informationServiceType = attr.InformationServiceType;

                IFieldDescriptionService srv = (IFieldDescriptionService) Activator.CreateInstance(informationServiceType);

                FieldDescriptionInfo fdi = srv.GetFieldDescriptionInfo(prop, attr, header);

                list.Add(fdi);
            }

            return list;
        }
    }
}
