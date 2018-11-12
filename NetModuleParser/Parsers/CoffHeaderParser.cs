using System;
using System.IO;
using NetModuleParser.Enums;
using NetModuleParser.ParserInterfaces;
using NetModuleParser.StructureElements;

namespace NetModuleParser.Parsers
{
    public class CoffHeaderParser : IByteParser<CoffHeader>
    {
        public CoffHeader Parse(BinaryReader reader)
        {
            if (reader == null)
            {
                throw new ArgumentNullException(nameof(reader));
            }

            return new CoffHeader
            {
                Machine = (ImageFileIdMachine)reader.ReadUInt16(),
                NumberOfSections = reader.ReadUInt16(),
                TimeDateStamp = reader.ReadUInt32(),
                PointerToSymbolTable = reader.ReadUInt32(),
                NumberOfSymbols = reader.ReadUInt32(),
                SizeOfOptionalHeader = reader.ReadUInt16(),
                Characteristics = (ImageFileIdCharacteristics)reader.ReadUInt16(),
            };
        }
    }
}
