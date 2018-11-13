using System.Reflection;

namespace NetModuleParser.Description
{
    public class UInt16FieldDescriptionService : FieldDescriptionService
    {
        public override string GetFieldValue(PropertyInfo property, object header) => ((ushort) property.GetValue(header)).ToString("X");
    }
}
