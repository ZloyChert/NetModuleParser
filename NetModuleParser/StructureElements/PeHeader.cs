using NetModuleParser.Enums;

namespace NetModuleParser.StructureElements
{
    public class PeHeader
    {
        public ushort Signature; //decimal number 267 for 32 bit (PE32 ), 523 for 64 bit(PE32+ ), and 263 for a ROM image. 2bytes
        public byte MajorLinkerVersion; //The linker major version number. 
        public byte MinorLinkerVersion; //The linker minor version number. 
        public uint SizeOfCode; //The size of the code (text) section, or the sum of all code sections if there are multiple sections. 
        public uint SizeOfInitializedData; //The size of the initialized data section, or the sum of all such sections if there are multiple data sections. 
        public uint SizeOfUninitializedData; //The size of the uninitialized data section (BSS), or the sum of all such sections if there are multiple BSS sections. 
        public uint AddressOfEntryPoint; //The address of the entry point relative to the image base when the executable file is loaded into memory. For program images, this is the starting address. For device drivers, this is the address of the initialization function. An entry point is optional for DLLs. When no entry point is present, this field must be zero. 
        public uint BaseOfCode; //The address that is relative to the image base of the beginning-of-code section when it is loaded into memory. 
        public uint? BaseOfData; // The address that is relative to the image base of the beginning-of-data section when it is loaded into memory. PE32 only (absent in PE32+)
        public ulong ImageBase; //The preferred address of the first byte of image when loaded into memory; must be a multiple of 64 K. The default for DLLs is 0x10000000. The default for Windows CE EXEs is 0x00010000. The default for Windows NT, Windows 2000, Windows XP, Windows 95, Windows 98, and Windows Me is 0x00400000. 
        public uint SectionAlignment; //The alignment (in bytes) of sections when they are loaded into memory. It must be greater than or equal to FileAlignment. The default is the page size for the architecture. 
        public uint FileAlignment; //The alignment factor (in bytes) that is used to align the raw data of sections in the image file. The value should be a power of 2 between 512 and 64 K, inclusive. The default is 512. If the SectionAlignment is less than the architecture's page size, then FileAlignment must match SectionAlignment. 
        public ushort MajorOperatingSystemVersion; //The major version number of the required operating system. 
        public ushort MinorOperatingSystemVersion; // The minor version number of the required operating system. 
        public ushort MajorImageVersion; // The major version number of the image. 
        public ushort MinorImageVersion; // The minor version number of the image. 
        public ushort MajorSubsystemVersion; // The major version number of the subsystem. 
        public ushort MinorSubsystemVersion; // The minor version number of the subsystem. 
        public uint Win32VersionValue; // Reserved, must be zero. 
        public uint SizeOfImage; // The size (in bytes) of the image, including all headers, as the image is loaded in memory. It must be a multiple of SectionAlignment. 
        public uint SizeOfHeaders; // The combined size of an MS-DOS stub, PE header, and section headers rounded up to a multiple of FileAlignment. 
        public uint Checksum; // The image file checksum. The algorithm for computing the checksum is incorporated into IMAGHELP.DLL. The following are checked for validation at load time: all drivers, any DLL loaded at boot time, and any DLL that is loaded into a critical Windows process. 
        public WindowsSubsystem Subsystem; // The subsystem that is required to run this image. For more information, see Windows Subsystem. 
        public DllCharacteristics DllCharacteristics; // For more information, see DLL Characteristics later in this specification. 
        public ulong SizeOfStackReserve; // The size of the stack to reserve. Only SizeOfStackCommit is committed; the rest is made available one page at a time until the reserve size is reached. 
        public ulong SizeOfStackCommit; // The size of the stack to commit. 
        public ulong SizeOfHeapReserve; // The size of the local heap space to reserve. Only SizeOfHeapCommit is committed; the rest is made available one page at a time until the reserve size is reached. 
        public ulong SizeOfHeapCommit; // The size of the local heap space to commit. 
        public uint LoaderFlags; // Reserved, must be zero. 
        public uint NumberOfRvaAndSizes; // The number of data-directory entries in the remainder of the optional header. Each describes a location and size. =16
    }
}
