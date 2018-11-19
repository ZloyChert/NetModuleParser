using System;
using System.Reflection;
using NetModuleParser.StructureElements.PeHeader;

namespace NetModuleParser.Description.DescriptionServices
{
    public class DataDirectoryDescriptionService : HeaderMemberDescriptionService
    {
        public override string GetFieldValue(PropertyInfo property, object header)
        {
            var dataDirectory = (ImageDataDirectory)property.GetValue(header);
            return $"VirtualAddress : {dataDirectory.VirtualAddress}; Size: {dataDirectory.Size}";
        }

        public override byte[] GetFieldBytes(PropertyInfo property, object header)
        {
            byte[] b = new byte[8];
            return b;
        }
    }
}

