namespace NetModuleParser.HeaderResources
{
    public static class PeHeaderResources
    {
        public const string AddressOfEntryPoint = "RVA of the entry point function. For unmanaged DLLs, this can be 0. For managed PE files. this value always points to the common language runtime invokation stub.";
        public const string BaseOfCode = "RVA of the beginning og the file's code section(s).";
        public const string BaseOfData = "RVA of the beginning of the file's data section(s). This entry doesn't exist in the 64-bit optional header.";
        public const string Checksum = "Checksum of the disk image file";
        public const string DllCharacteristics = "In managed files of v1.0 always set to 0. In managed files of v1.1 and later, always set to 0x400: no unmanaged Windows structural exception handling";
        public const string FileAlignment = "Alignment of sections in the disk image file. The value should be a power of 2, from 0x200 to 0x10000. If the section Alignment is set less than the memory page size, FileAlignment must match SectionAlignment";
        public const string ImageBase = "Image's preferred starting virtual address; must be aligned on the 64KB boundary (0x10000).";
        public const string LoaderFlags = "Obsolete, set to 0";
        public const string MajorImageVersion = "Major version number of the application";
        public const string MajorLinkerVersion = "Linker major version number. The VC++ linker sets this field to 8; the pure IL file generator employed by other compilers does the same. In earlier versions, this field was set to 7 and 6, respectively";
        public const string MajorOperatingSystemVersion = "Major version number of the required operating system";
        public const string MajorSubsystemVersion = "Major version number of the subsystem";
        public const string MinorImageVersion = "Minor version number of the application";
        public const string MinorLinkerVersion = "Linker minor version number";
        public const string MinorOperatingSystemVersion = "Minor version number of the required operating system";
        public const string MinorSubsystemVersion = "Minor version number of the subsystem";
        public const string NumberOfRvaAndSizes = "";
        public const string SectionAlignment = "Alignment of sections when loaded in memory. This setting must be greater than or equal to the value of the FileAlignment field. The default is the memory page size.";
        public const string Signature = "Number, identifying the state of the image files. Acceptable values are 0x010b for 32-bit PE file, 0x020b for 64-bit PE file, and 0x107 for ROM image file. Managed PE files must have this field set to 0x010b or 0x020b";
        public const string SizeOfCode = "Size of code section (.text) or the sum of all code sections if multiple code sections exist. The IL assembler always emits a single code section";
        public const string SizeOfHeaders = "Sum of the sized of MsDos header and stub, the COFF header, the PE header, and the section headers, rounded up to a multiple of the FileAlignment value";
        public const string SizeOfHeapCommit = "";
        public const string SizeOfHeapReserve = "";
        public const string SizeOfImage = "Size of the image file (in bytes), including all headers. This field must be set to  a multiple of the SectionAlignment value";
        public const string SizeOfInitializedData = "Size of the initialized data section (held in the field SizeOfRawData of the respective section header) or the sum of all such sections. The initialized data is defined as specific values, stored in the disk image file";
        public const string SizeOfStackCommit = "";
        public const string SizeOfStackReserve = "Size of virtual memory to reserve for the initial thread's stack. Only the SizeOfStackCommit field is commited; the rest is available in one-page increments. The default is 1MB for 32-bit images and 4MB for 64-bit images";
        public const string SizeOfUninitializedData = "Size of the uninitialized data section (.bss) of the sum of all such sections. This data is not part of the disk file and does not have specific values, but the OS loader commits memory space for this data when the file is loaded";
        public const string Subsystem = "User interface subsystem required to run this image file.";
        public const string Win32VersionValue = "Reserved";
    }
}
