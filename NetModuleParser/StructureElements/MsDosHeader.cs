using NetModuleParser.Description;
using NetModuleParser.Description.DescriptionServices;
using NetModuleParser.HeaderResources;

namespace NetModuleParser.StructureElements
{
    public class MsDosHeader
    {
        [PropertyDescription(0, 2, MsDosHeaderResources.FileIdTag, typeof(CharArrayDescriptionService))]
        public char[] FileIdTag { get; set; } // MZ - Mark Zbikowski - 2bytes

        [PropertyDescription(2, 2, MsDosHeaderResources.LastSize, typeof(UInt16DescriptionService))]
        public ushort LastSize { get; set; }          // Bytes on last page of file - 2bytes

        [PropertyDescription(4, 2, MsDosHeaderResources.PagesCount, typeof(UInt16DescriptionService))]
        public ushort PagesCount { get; set; }            // Pages in file - 2bytes

        [PropertyDescription(6, 2, MsDosHeaderResources.Relocations, typeof(UInt16DescriptionService))]
        public ushort Relocations { get; set; }          // Relocations - 2bytes

        [PropertyDescription(8, 2, MsDosHeaderResources.HeaderSize, typeof(UInt16DescriptionService))]
        public ushort HeaderSize { get; set; }       // Size of header in paragraphs - 2bytes

        [PropertyDescription(10, 2, MsDosHeaderResources.MinAlloc, typeof(UInt16DescriptionService))]
        public ushort MinAlloc { get; set; }      // Minimum extra paragraphs needed - 2bytes

        [PropertyDescription(12, 2, MsDosHeaderResources.MaxAlloc, typeof(UInt16DescriptionService))]
        public ushort MaxAlloc { get; set; }      // Maximum extra paragraphs needed - 2bytes

        [PropertyDescription(14, 2, MsDosHeaderResources.Ss, typeof(UInt16DescriptionService))]
        public ushort Ss { get; set; }            // Initial (relative) SS value - 2bytes

        [PropertyDescription(16, 2, MsDosHeaderResources.Sp, typeof(UInt16DescriptionService))]
        public ushort Sp { get; set; }            // Initial SP value - 2bytes

        [PropertyDescription(18, 2, MsDosHeaderResources.Checksum, typeof(UInt16DescriptionService))]
        public ushort Checksum { get; set; }          // Checksum - 2bytes

        [PropertyDescription(20, 2, MsDosHeaderResources.Ip, typeof(UInt16DescriptionService))]
        public ushort Ip { get; set; }            // Initial IP value - 2bytes

        [PropertyDescription(22, 2, MsDosHeaderResources.Cs, typeof(UInt16DescriptionService))]
        public ushort Cs { get; set; }            // Initial (relative) CS value - 2bytes

        [PropertyDescription(24, 2, MsDosHeaderResources.FileAddress, typeof(UInt16DescriptionService))]
        public ushort FileAddress { get; set; }        // File address of relocation table - 2bytes

        [PropertyDescription(26, 2, MsDosHeaderResources.OverlayNumbers, typeof(UInt16DescriptionService))]
        public ushort OverlayNumbers { get; set; }          // Overlay number - 2bytes

        [PropertyDescription(28, 2, MsDosHeaderResources.ReversedFirst, typeof(UInt16ArrayDescriptionService))]
        public ushort[] ReversedFirst { get; set; }        // Reserved words - 2bytes * 4

        [PropertyDescription(36, 2, MsDosHeaderResources.OemId, typeof(UInt16DescriptionService))]
        public ushort OemId { get; set; }         // OEM identifier (for e_oeminfo) - 2bytes

        [PropertyDescription(38, 2, MsDosHeaderResources.OemInformation, typeof(UInt16DescriptionService))]
        public ushort OemInformation { get; set; }       // OEM information; e_oemid specific - 2bytes

        [PropertyDescription(40, 2, MsDosHeaderResources.ReversedSecond, typeof(UInt16ArrayDescriptionService))]
        public ushort[] ReversedSecond { get; set; }      // Reserved words - 2bytes * 10

        [PropertyDescription(60, 4, MsDosHeaderResources.PeOffset, typeof(UInt32DescriptionService))]
        public uint PeOffset { get; set; }        // File address of new exe header - 4bytes
    }
}
