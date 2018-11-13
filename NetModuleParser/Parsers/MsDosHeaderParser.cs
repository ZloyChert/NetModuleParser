using System;
using System.IO;
using NetModuleParser.ParserInterfaces;
using NetModuleParser.StructureElements;

namespace NetModuleParser.Parsers
{
    public class MsDosHeaderParser : IByteParser<MsDosHeader>
    {
        public MsDosHeader Parse(BinaryReader reader)
        {
            if (reader == null)
            {
                throw new ArgumentNullException(nameof(reader));
            }

            return new MsDosHeader
            {
                FileIdTag = reader.ReadChars(2),
                LastSize = reader.ReadUInt16(),
                PagesCount = reader.ReadUInt16(),
                Relocations = reader.ReadUInt16(),
                HeaderSize = reader.ReadUInt16(),
                MinAlloc = reader.ReadUInt16(),
                MaxAlloc = reader.ReadUInt16(),
                Ss = reader.ReadUInt16(),
                Sp = reader.ReadUInt16(),
                Checksum = reader.ReadUInt16(),
                Ip = reader.ReadUInt16(),
                Cs = reader.ReadUInt16(),
                FileAddress = reader.ReadUInt16(),
                OverlayNumbers = reader.ReadUInt16(),
                ReversedFirst = reader.ReadUInt16Array(4),
                OemId = reader.ReadUInt16(),
                OemInformation = reader.ReadUInt16(),
                ReversedSecond = reader.ReadUInt16Array(10),
                PeOffset = reader.ReadUInt16()
            };
        }
    }
}
