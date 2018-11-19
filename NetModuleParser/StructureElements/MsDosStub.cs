using NetModuleParser.Description;
using NetModuleParser.Description.DescriptionServices;
using NetModuleParser.HeaderResources;

namespace NetModuleParser.StructureElements
{
    public class MsDosStub
    {
        [PropertyDescription(0, 64, MsDosStubResources.StubProgrammContent, typeof(ByteArrayDescriptionService))]
        public byte[] StubProgrammContent { get; set; } //Programm, that prints 'This program cannot be run in DOS mode.' 64bytes

    } 
}
