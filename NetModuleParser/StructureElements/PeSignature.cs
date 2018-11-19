using NetModuleParser.Description;
using NetModuleParser.Description.DescriptionServices;
using NetModuleParser.HeaderResources;

namespace NetModuleParser.StructureElements
{
    public class PeSignature
    {
        [PropertyDescription(0, 4, PeSignatureResources.FileIdSignature, typeof(CharArrayDescriptionService))]
        public char[] FileIdSignature { get; set; } // 'PE/0/0', 4bytes 2000 for dll
    }
}
