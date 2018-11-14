using System;

namespace NetModuleParser.Description
{
    public static class PropertyDescriptionHelper
    {
        public static int GetOffset(Attribute attribute) => (int)typeof(PropertyDescriptionAttribute).GetProperty("FieldOffset").GetValue(attribute);
        public static int GetLength(Attribute attribute) => (int)typeof(PropertyDescriptionAttribute).GetProperty("FieldLength").GetValue(attribute);
        public static string GetDescription(Attribute attribute) => (string)typeof(PropertyDescriptionAttribute).GetProperty("Description").GetValue(attribute);
    }
}
