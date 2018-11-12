using System;
using System.IO;
using NetModuleParser.Enums;
using NetModuleParser.ParserInterfaces;
using NetModuleParser.StructureElements;

namespace NetModuleParser.Parsers
{
    public class PeHeaderParser : IByteParser<PeHeader>
    {
        public PeHeader Parse(BinaryReader reader)
        {
            if (reader == null)
            {
                throw new ArgumentNullException(nameof(reader));
            }

            var headerSignature = reader.ReadUInt16();
            bool isPe32 = headerSignature == 0x010b; //MAGIC NUMBERS AAAAAAAAAAAAAAAAAAAAAAAA

            return new PeHeader
            {
                Signature = headerSignature,
                MajorLinkerVersion = reader.ReadByte(),
                MinorLinkerVersion = reader.ReadByte(),
                SizeOfCode = reader.ReadUInt32(),
                SizeOfInitializedData = reader.ReadUInt32(),
                SizeOfUninitializedData = reader.ReadUInt32(),
                AddressOfEntryPoint = reader.ReadUInt32(),
                BaseOfCode = reader.ReadUInt32(),
                BaseOfData = isPe32 ? reader.ReadUInt32() : (uint?) null,
                ImageBase = isPe32 ? reader.ReadUInt32() : reader.ReadUInt64(),
                SectionAlignment = reader.ReadUInt32(),
                FileAlignment = reader.ReadUInt32(),
                MajorOperatingSystemVersion = reader.ReadUInt16(),
                MinorOperatingSystemVersion = reader.ReadUInt16(),
                MajorImageVersion = reader.ReadUInt16(),
                MinorImageVersion = reader.ReadUInt16(),
                MajorSubsystemVersion = reader.ReadUInt16(),
                MinorSubsystemVersion = reader.ReadUInt16(),
                Win32VersionValue = reader.ReadUInt32(),
                SizeOfImage = reader.ReadUInt32(),
                SizeOfHeaders = reader.ReadUInt32(),
                Checksum = reader.ReadUInt32(),
                Subsystem = (WindowsSubsystem) reader.ReadUInt16(),
                DllCharacteristics = (DllCharacteristics) reader.ReadUInt16(),
                SizeOfStackReserve = isPe32 ? reader.ReadUInt32() : reader.ReadUInt64(),
                SizeOfStackCommit = isPe32 ? reader.ReadUInt32() : reader.ReadUInt64(),
                SizeOfHeapReserve = isPe32 ? reader.ReadUInt32() : reader.ReadUInt64(),
                SizeOfHeapCommit = isPe32 ? reader.ReadUInt32() : reader.ReadUInt64(),
                LoaderFlags = reader.ReadUInt32(),
                NumberOfRvaAndSizes = reader.ReadUInt32()
            };
        }
    }
}
