using NetModuleParser.Description;
using NetModuleParser.Description.DescriptionServices;
using NetModuleParser.Enums;
using NetModuleParser.HeaderResources;

namespace NetModuleParser.StructureElements.PeHeader
{
    public class PeBaseHeader
    {
        [PropertyDescription(0, 2, PeHeaderResources.Signature, typeof(UInt16DescriptionService))]
        public ushort Signature{ get; set; } //decimal number 267 for 32 bit (PE32 ), 523 for 64 bit(PE32+ ), and 263 for a ROM image. 2bytes

        [PropertyDescription(2, 1, PeHeaderResources.MajorLinkerVersion, typeof(ByteDescriptionService))]
        public byte MajorLinkerVersion{ get; set; } //The linker major version number. 

        [PropertyDescription(3, 1, PeHeaderResources.MinorLinkerVersion, typeof(ByteDescriptionService))]
        public byte MinorLinkerVersion{ get; set; } //The linker minor version number. 

        [PropertyDescription(4, 4, PeHeaderResources.SizeOfCode, typeof(UInt32DescriptionService))]
        public uint SizeOfCode{ get; set; } //The size of the code (text) section, or the sum of all code sections if there are multiple sections. 

        [PropertyDescription(8, 4, PeHeaderResources.SizeOfInitializedData, typeof(UInt32DescriptionService))]
        public uint SizeOfInitializedData{ get; set; } //The size of the initialized data section, or the sum of all such sections if there are multiple data sections. 

        [PropertyDescription(12, 4, PeHeaderResources.SizeOfUninitializedData, typeof(UInt32DescriptionService))]
        public uint SizeOfUninitializedData{ get; set; } //The size of the uninitialized data section (BSS), or the sum of all such sections if there are multiple BSS sections. 

        [PropertyDescription(16, 4, PeHeaderResources.AddressOfEntryPoint, typeof(UInt32DescriptionService))]
        public uint AddressOfEntryPoint{ get; set; } //The address of the entry point relative to the image base when the executable file is loaded into memory. For program images, this is the starting address. For device drivers, this is the address of the initialization function. An entry point is optional for DLLs. When no entry point is present, this field must be zero. 

        [PropertyDescription(20, 4, PeHeaderResources.BaseOfCode, typeof(UInt32DescriptionService))]
        public uint BaseOfCode { get; set; } //The address that is relative to the image base of the beginning-of-code section when it is loaded into memory. 

        [PropertyDescription(32, 4, PeHeaderResources.SectionAlignment, typeof(UInt32DescriptionService))]
        public uint SectionAlignment { get; set; } //The alignment (in bytes) of sections when they are loaded into memory. It must be greater than or equal to FileAlignment. The default is the page size for the architecture. 

        [PropertyDescription(36, 4, PeHeaderResources.FileAlignment, typeof(UInt32DescriptionService))]
        public uint FileAlignment { get; set; } //The alignment factor (in bytes) that is used to align the raw data of sections in the image file. The value should be a power of 2 between 512 and 64 K, inclusive. The default is 512. If the SectionAlignment is less than the architecture's page size, then FileAlignment must match SectionAlignment. 

        [PropertyDescription(40, 2, PeHeaderResources.MajorOperatingSystemVersion, typeof(UInt16DescriptionService))]
        public ushort MajorOperatingSystemVersion { get; set; } //The major version number of the required operating system. 

        [PropertyDescription(42, 2, PeHeaderResources.MinorOperatingSystemVersion, typeof(UInt16DescriptionService))]
        public ushort MinorOperatingSystemVersion { get; set; } // The minor version number of the required operating system. 

        [PropertyDescription(44, 2, PeHeaderResources.MajorImageVersion, typeof(UInt16DescriptionService))]
        public ushort MajorImageVersion { get; set; } // The major version number of the image. 

        [PropertyDescription(46, 2, PeHeaderResources.MinorImageVersion, typeof(UInt16DescriptionService))]
        public ushort MinorImageVersion { get; set; } // The minor version number of the image. 

        [PropertyDescription(48, 2, PeHeaderResources.MajorSubsystemVersion, typeof(UInt16DescriptionService))]
        public ushort MajorSubsystemVersion { get; set; } // The major version number of the subsystem. 

        [PropertyDescription(50, 2, PeHeaderResources.MinorSubsystemVersion, typeof(UInt16DescriptionService))]
        public ushort MinorSubsystemVersion { get; set; } // The minor version number of the subsystem. 

        [PropertyDescription(52, 4, PeHeaderResources.Win32VersionValue, typeof(UInt32DescriptionService))]
        public uint Win32VersionValue { get; set; } // Reserved, must be zero. 

        [PropertyDescription(56, 4, PeHeaderResources.SizeOfImage, typeof(UInt32DescriptionService))]
        public uint SizeOfImage { get; set; } // The size (in bytes) of the image, including all headers, as the image is loaded in memory. It must be a multiple of SectionAlignment. 

        [PropertyDescription(60, 4, PeHeaderResources.SizeOfHeaders, typeof(UInt32DescriptionService))]
        public uint SizeOfHeaders { get; set; } // The combined size of an MS-DOS stub, PE header, and section headers rounded up to a multiple of FileAlignment. 

        [PropertyDescription(64, 4, PeHeaderResources.Checksum, typeof(UInt32DescriptionService))]
        public uint Checksum { get; set; } // The image file checksum. The algorithm for computing the checksum is incorporated into IMAGHELP.DLL. The following are checked for validation at load time: all drivers, any DLL loaded at boot time, and any DLL that is loaded into a critical Windows process. 

        //[PropertyDescription(68, 2, PeHeaderResources.Subsystem, typeof(UInt16DescriptionService))]
        public WindowsSubsystem Subsystem { get; set; } // The subsystem that is required to run this image. For more information, see Windows Subsystem. 

        //[PropertyDescription(70, 2, PeHeaderResources.DllCharacteristics, typeof(UInt16DescriptionService))]
        public DllCharacteristics DllCharacteristics { get; set; } // For more information, see DLL Characteristics later in this specification. 
    }
}
