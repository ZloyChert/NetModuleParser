using System;

namespace NetModuleParser.Description
{
    [AttributeUsage(AttributeTargets.Property)]
    public class PropertyDescriptionAttribute : Attribute
    {
        public PropertyDescriptionAttribute(int fieldOffset, int fieldLength, string description, Type informationServiceType)
        {
            FieldOffset = fieldOffset;
            FieldLength = fieldLength;
            Description = description;
            InformationServiceType = informationServiceType;
        }

        public int FieldOffset { get; }
        public int FieldLength { get; }
        public string Description { get; }
        public Type InformationServiceType { get; }
    }
}
