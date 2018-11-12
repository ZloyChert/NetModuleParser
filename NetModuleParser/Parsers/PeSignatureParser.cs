using System;
using System.IO;
using NetModuleParser.ParserInterfaces;
using NetModuleParser.StructureElements;

namespace NetModuleParser.Parsers
{
    public class PeSignatureParser : IByteParser<PeSignature>
    {
        public PeSignature Parse(BinaryReader reader)
        {
            if (reader == null)
            {
                throw new ArgumentNullException(nameof(reader));
            }

            return new PeSignature
            {
                FileIdSignature = reader.ReadChars(4)
            };
        }
    }
}
