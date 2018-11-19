using NetModuleParser.Description;
using NetModuleParser.Description.DescriptionServices;
using NetModuleParser.HeaderResources;

namespace NetModuleParser.StructureElements.PeHeader
{
    public class Pe32PlusHeader : PeBaseHeader
    {
        [PropertyDescription(24, 8, PeHeaderResources.ImageBase, typeof(UInt64DescriptionService))]
        public ulong ImageBase { get; set; } //The preferred address of the first byte of image when loaded into memory; must be a multiple of 64 K. The default for DLLs is 0x10000000. The default for Windows CE EXEs is 0x00010000. The default for Windows NT, Windows 2000, Windows XP, Windows 95, Windows 98, and Windows Me is 0x00400000. 

        [PropertyDescription(72, 8, PeHeaderResources.SizeOfStackReserve, typeof(UInt64DescriptionService))]
        public ulong SizeOfStackReserve { get; set; } // The size of the stack to reserve. Only SizeOfStackCommit is committed; the rest is made available one page at a time until the reserve size is reached. 

        [PropertyDescription(80, 8, PeHeaderResources.SizeOfStackCommit, typeof(UInt64DescriptionService))]
        public ulong SizeOfStackCommit { get; set; } // The size of the stack to commit. 

        [PropertyDescription(88, 8, PeHeaderResources.SizeOfHeapReserve, typeof(UInt64DescriptionService))]
        public ulong SizeOfHeapReserve { get; set; } // The size of the local heap space to reserve. Only SizeOfHeapCommit is committed; the rest is made available one page at a time until the reserve size is reached. 

        [PropertyDescription(96, 8, PeHeaderResources.SizeOfHeapCommit, typeof(UInt64DescriptionService))]
        public ulong SizeOfHeapCommit { get; set; } // The size of the local heap space to commit. 

        [PropertyDescription(104, 4, PeHeaderResources.LoaderFlags, typeof(UInt32DescriptionService))]
        public uint LoaderFlags { get; set; } //Obsolete, set to 0

        [PropertyDescription(108, 4, PeHeaderResources.NumberOfRvaAndSizes, typeof(UInt32DescriptionService))]
        public uint NumberOfRvaAndSizes { get; set; } // The number of data-directory entries in the remainder of the optional header. Each describes a location and size. =16

        [PropertyDescription(112, 148, "", typeof(DataDirectoriesDescriptionService))]
        public DataDirectories DataDirectories { get; set; }
    }
}
