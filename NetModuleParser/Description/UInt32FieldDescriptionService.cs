using System.Reflection;

namespace NetModuleParser.Description
{
    public class UInt32FieldDescriptionService : FieldDescriptionService
    {
        public override string GetFieldValue(PropertyInfo property, object header) => ((uint) property.GetValue(header)).ToString("X");
    }
}
