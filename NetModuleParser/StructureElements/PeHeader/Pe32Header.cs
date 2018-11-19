using NetModuleParser.Description;
using NetModuleParser.Description.DescriptionServices;
using NetModuleParser.HeaderResources;

namespace NetModuleParser.StructureElements.PeHeader
{
    public class Pe32Header : PeBaseHeader
    {
        [PropertyDescription(24, 4, PeHeaderResources.BaseOfData, typeof(UInt32DescriptionService))]
        public uint BaseOfData { get; set; } // The address that is relative to the image base of the beginning-of-data section when it is loaded into memory. PE32 only (absent in PE32+)

        [PropertyDescription(28, 4, PeHeaderResources.ImageBase, typeof(UInt32DescriptionService))]
        public uint ImageBase { get; set; } //The preferred address of the first byte of image when loaded into memory must be a multiple of 64 K. The default for DLLs is 0x10000000. The default for Windows CE EXEs is 0x00010000. The default for Windows NT, Windows 2000, Windows XP, Windows 95, Windows 98, and Windows Me is 0x00400000. 

        [PropertyDescription(72, 4, PeHeaderResources.SizeOfStackReserve, typeof(UInt32DescriptionService))]
        public uint SizeOfStackReserve { get; set; } // The size of the stack to reserve. Only SizeOfStackCommit is committed the rest is made available one page at a time until the reserve size is reached. 

        [PropertyDescription(76, 4, PeHeaderResources.SizeOfStackCommit, typeof(UInt32DescriptionService))]
        public uint SizeOfStackCommit { get; set; } // The size of the stack to commit. 

        [PropertyDescription(80, 4, PeHeaderResources.SizeOfHeapReserve, typeof(UInt32DescriptionService))]
        public uint SizeOfHeapReserve { get; set; } // The size of the local heap space to reserve. Only SizeOfHeapCommit is committed; the rest is made available one page at a time until the reserve size is reached. 

        [PropertyDescription(84, 4, PeHeaderResources.SizeOfHeapCommit, typeof(UInt32DescriptionService))]
        public uint SizeOfHeapCommit { get; set; } // The size of the local heap space to commit. 

        [PropertyDescription(88, 4, PeHeaderResources.LoaderFlags, typeof(UInt32DescriptionService))]
        public uint LoaderFlags { get; set; } //Obsolete, set to 0

        [PropertyDescription(92, 4, PeHeaderResources.NumberOfRvaAndSizes, typeof(UInt32DescriptionService))]
        public uint NumberOfRvaAndSizes { get; set; } // The number of data-directory entries in the remainder of the optional header. Each describes a location and size. =16

        [PropertyDescription(96, 148, "", typeof(DataDirectoriesDescriptionService))]
        public DataDirectories DataDirectories { get; set; }
    }
}
