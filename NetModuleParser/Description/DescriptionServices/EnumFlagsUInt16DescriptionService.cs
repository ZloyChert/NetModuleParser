using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace NetModuleParser.Description.DescriptionServices
{
    public class EnumFlagsUInt16DescriptionService<T> : EnumUInt16DescriptionService<T>
    {
        public override string GetEnumDescription<THeader>(PropertyInfo property, Attribute attribute, THeader header)
        {
            var type = typeof(T);
            string enumDescription = string.Empty;
            Enum enumValue = (Enum)property.GetValue(header);
            foreach (var value in Enum.GetValues(type))
            {
                if (enumValue.HasFlag((Enum)value))
                {
                    var enumMember = type.GetMember(((T)value).ToString()).Single();
                    var descriptionAttribute = enumMember.GetCustomAttribute(typeof(DescriptionAttribute), false);
                    enumDescription += $"{((T)value).ToString()}: {((DescriptionAttribute)descriptionAttribute).Description}; ";
                }
            }

            return $"{GetDescription(attribute)}. Flag info: {enumDescription}";
        }
    }
}
