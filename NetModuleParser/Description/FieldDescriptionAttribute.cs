using System;

namespace NetModuleParser.Description
{
    [AttributeUsage(AttributeTargets.Property)]
    public class FieldDescriptionAttribute : Attribute
    {
        public FieldDescriptionAttribute(int orderNumber, string description, Type informationServiceType)
        {
            OrderNumber = orderNumber;
            Description = description;
            InformationServiceType = informationServiceType;
        }

        public int OrderNumber { get; }
        public string Description { get; }
        public Type InformationServiceType { get; }
    }
}
