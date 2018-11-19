using System;
using System.IO;
using NetModuleParser.Enums;
using NetModuleParser.StructureElements.PeHeader;

namespace NetModuleParser.Parsers
{
    public class PeHeaderParser : IByteParser<PeBaseHeader>
    {
        public PeBaseHeader Parse(BinaryReader reader)
        {
            if (reader == null)
            {
                throw new ArgumentNullException(nameof(reader));
            }

            var headerSignature = reader.ReadUInt16();
            bool isPe32 = headerSignature == 0x010b; //MAGIC NUMBERS AAAAAAAAAAAAAAAAAAAAAAAA


            if (isPe32)
            {
                return new Pe32Header
                {
                    Signature = headerSignature,
                    MajorLinkerVersion = reader.ReadByte(),
                    MinorLinkerVersion = reader.ReadByte(),
                    SizeOfCode = reader.ReadUInt32(),
                    SizeOfInitializedData = reader.ReadUInt32(),
                    SizeOfUninitializedData = reader.ReadUInt32(),
                    AddressOfEntryPoint = reader.ReadUInt32(),
                    BaseOfCode = reader.ReadUInt32(),
                    BaseOfData = reader.ReadUInt32(),
                    ImageBase = reader.ReadUInt32(),
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
                    SizeOfStackReserve = reader.ReadUInt32(),
                    SizeOfStackCommit = reader.ReadUInt32(),
                    SizeOfHeapReserve = reader.ReadUInt32(),
                    SizeOfHeapCommit = reader.ReadUInt32(),
                    LoaderFlags = reader.ReadUInt32(),
                    NumberOfRvaAndSizes = reader.ReadUInt32(),
                    DataDirectories = ReadDataDirectories(reader)
                };
            }

            return new Pe32PlusHeader
            {
                Signature = headerSignature,
                MajorLinkerVersion = reader.ReadByte(),
                MinorLinkerVersion = reader.ReadByte(),
                SizeOfCode = reader.ReadUInt32(),
                SizeOfInitializedData = reader.ReadUInt32(),
                SizeOfUninitializedData = reader.ReadUInt32(),
                AddressOfEntryPoint = reader.ReadUInt32(),
                BaseOfCode = reader.ReadUInt32(),
                ImageBase = reader.ReadUInt64(),
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
                Subsystem = (WindowsSubsystem)reader.ReadUInt16(),
                DllCharacteristics = (DllCharacteristics)reader.ReadUInt16(),
                SizeOfStackReserve = reader.ReadUInt64(),
                SizeOfStackCommit = reader.ReadUInt64(),
                SizeOfHeapReserve = reader.ReadUInt64(),
                SizeOfHeapCommit = reader.ReadUInt64(),
                LoaderFlags = reader.ReadUInt32(),
                NumberOfRvaAndSizes = reader.ReadUInt32(),
                DataDirectories = ReadDataDirectories(reader)
            };
        }

        private DataDirectories ReadDataDirectories(BinaryReader reader)
        {
            return new DataDirectories
            {
                ExportTable = ReadImageDataDirectory(reader),
                ImportTable = ReadImageDataDirectory(reader),
                ResourceTable = ReadImageDataDirectory(reader),
                ExceptionTable = ReadImageDataDirectory(reader),
                CertificateTable = ReadImageDataDirectory(reader),
                BaseRelocationTable = ReadImageDataDirectory(reader),
                Debug = ReadImageDataDirectory(reader),
                Architecture = ReadImageDataDirectory(reader),
                GlobalPtr = ReadImageDataDirectory(reader),
                TlsTable = ReadImageDataDirectory(reader),
                LoadConfigTable = ReadImageDataDirectory(reader),
                BoundImport = ReadImageDataDirectory(reader),
                ImportAddressTable = ReadImageDataDirectory(reader),
                DelayImportDescriptor = ReadImageDataDirectory(reader),
                ClrRuntimeHeader = ReadImageDataDirectory(reader),
                Reserved = ReadImageDataDirectory(reader)
            };
        }

        private ImageDataDirectory ReadImageDataDirectory(BinaryReader reader)
        {
            return new ImageDataDirectory
            {
                VirtualAddress = reader.ReadUInt32(),
                Size = reader.ReadUInt32(),
            };
        }
    }
}
