using NetModuleParser.Description;
using NetModuleParser.StructureElements;

namespace NetModuleParser
{
    public class NetModule
    {
        [PropertyDescription(0, 2, "1", typeof(HeaderDescriptionService))]
        public MsDosHeader MsDosHeader { get; }
        public MsDosStub MsDosStub { get; }
        public PeSignature PeSignature { get; }
        public CoffHeader CoffHeader { get; }
        public PeHeader PeHeader { get; }

        public NetModule(MsDosHeader msDosHeader, MsDosStub msDosStub, PeSignature peSignature, CoffHeader coffHeader, PeHeader peHeader)
        {
            MsDosHeader = msDosHeader;
            MsDosStub = msDosStub;
            PeSignature = peSignature;
            CoffHeader = coffHeader;
            PeHeader = peHeader;
        }
    }
}
