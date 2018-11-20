using NetModuleParser.Description;
using NetModuleParser.Description.DescriptionServices;
using NetModuleParser.Resources.HeaderDescriptions;

namespace NetModuleParser.StructureElements
{
    public class MsDosStub
    {
        [PropertyDescription(0, 64, MsDosStubDescription.StubProgrammContent, typeof(ByteArrayDescriptionService))]
        public byte[] StubProgrammContent { get; set; } //Programm, that prints 'This program cannot be run in DOS mode.' 64bytes

    } 
}
