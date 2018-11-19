using NetModuleParser.Description;
using NetModuleParser.Description.DescriptionServices;
using NetModuleParser.StructureElements.PeHeader;

namespace NetModuleParser.StructureElements
{
    public class NetModule
    {
        public NetModule(MsDosHeader msDosHeader, MsDosStub msDosStub, PeSignature peSignature, CoffHeader coffHeader, PeBaseHeader peHeader)
        {
            MsDosHeader = msDosHeader;
            MsDosStub = msDosStub;
            PeSignature = peSignature;
            CoffHeader = coffHeader;
            PeHeader = peHeader;
        }

        [PropertyDescription(1, "MsDosHeader", typeof(HeaderDescriptionService))]
        public MsDosHeader MsDosHeader { get; }

        [PropertyDescription(2, "MsDosStub", typeof(HeaderDescriptionService))]
        public MsDosStub MsDosStub { get; }

        [PropertyDescription(3, "PeSignature", typeof(HeaderDescriptionService))]
        public PeSignature PeSignature { get; }

        [PropertyDescription(4, "CoffHeader", typeof(HeaderDescriptionService))]
        public CoffHeader CoffHeader { get; }

        [PropertyDescription(5, "PeHeader", typeof(HeaderDescriptionService))]
        public PeBaseHeader PeHeader { get; }


    }
}
