using System.Reflection;

namespace NetModuleParser.Description
{
    public class UInt16ArrayFieldDescriptionService : FieldDescriptionService
    {
        public override string GetFieldValue(PropertyInfo property, object header)
        {
            var fieldval = (ushort[]) property.GetValue(header);
            string toshow = "";
            foreach (var field in fieldval)
            {
                toshow += field;
                toshow += "(ochen krivo), ";
            }

            return toshow;
        }
    }
}
