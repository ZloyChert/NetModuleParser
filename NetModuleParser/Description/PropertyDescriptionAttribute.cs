using System;

namespace NetModuleParser.Description
{
    [AttributeUsage(AttributeTargets.Property)]
    public class PropertyDescriptionAttribute : Attribute
    {
        public PropertyDescriptionAttribute(int fieldOffset, int fieldLength, string description, Type informationServiceType) : this(description, informationServiceType)
        {
            FieldOffset = fieldOffset;
            FieldLength = fieldLength;
        }

        public PropertyDescriptionAttribute(int orderNumber, string description, Type informationServiceType) : this(description, informationServiceType)
        {
            OrderNumber = orderNumber;
        }

        private PropertyDescriptionAttribute(string description, Type informationServiceType)
        {
            Description = description;
            InformationServiceType = informationServiceType;
        }

        public int? FieldOffset { get; }
        public int? FieldLength { get; }
        public int? OrderNumber { get; }
        public string Description { get; }
        public Type InformationServiceType { get; }
    }
}
