using System;
using System.IO;
using NetModuleParser.StructureElements;

namespace NetModuleParser.Parsers
{
    public class MsDosStubParser : IByteParser<MsDosStub>
    {
        public MsDosStub Parse(BinaryReader reader)
        {
            if (reader == null)
            {
                throw new ArgumentNullException(nameof(reader));
            }

            return new MsDosStub
            {
                StubProgrammContent = reader.ReadBytes(NetModuleLengthConstants.MsDosStubLength)
            };
        }
    }
}
