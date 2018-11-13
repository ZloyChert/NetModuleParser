using NetModuleParser.Description;

namespace NetModuleParser.StructureElements
{
    public class MsDosHeader
    {
        [FieldDescription(1, "1", typeof(CharArrayFieldDescriptionService))]
        public char[] FileIdTag { get; set; } // MZ - Mark Zbikowski - 2bytes
        [FieldDescription(2, "1", typeof(UInt16FieldDescriptionService))]
        public ushort LastSize { get; set; }          // Bytes on last page of file - 2bytes
        [FieldDescription(3, "1", typeof(UInt16FieldDescriptionService))]
        public ushort PagesCount { get; set; }            // Pages in file - 2bytes
        [FieldDescription(4, "1", typeof(UInt16FieldDescriptionService))]
        public ushort Relocations { get; set; }          // Relocations - 2bytes
        [FieldDescription(5, "1", typeof(UInt16FieldDescriptionService))]
        public ushort HeaderSize { get; set; }       // Size of header in paragraphs - 2bytes
        [FieldDescription(6, "1", typeof(UInt16FieldDescriptionService))]
        public ushort MinAlloc { get; set; }      // Minimum extra paragraphs needed - 2bytes
        [FieldDescription(7, "1", typeof(UInt16FieldDescriptionService))]
        public ushort MaxAlloc { get; set; }      // Maximum extra paragraphs needed - 2bytes
        [FieldDescription(8, "1", typeof(UInt16FieldDescriptionService))]
        public ushort Ss { get; set; }            // Initial (relative) SS value - 2bytes
        [FieldDescription(9, "1", typeof(UInt16FieldDescriptionService))]
        public ushort Sp { get; set; }            // Initial SP value - 2bytes
        [FieldDescription(10, "1", typeof(UInt16FieldDescriptionService))]
        public ushort Checksum { get; set; }          // Checksum - 2bytes
        [FieldDescription(11, "1", typeof(UInt16FieldDescriptionService))]
        public ushort Ip { get; set; }            // Initial IP value - 2bytes
        [FieldDescription(12, "1", typeof(UInt16FieldDescriptionService))]
        public ushort Cs { get; set; }            // Initial (relative) CS value - 2bytes
        [FieldDescription(13, "1", typeof(UInt16FieldDescriptionService))]
        public ushort FileAddress { get; set; }        // File address of relocation table - 2bytes
        [FieldDescription(14, "1", typeof(UInt16FieldDescriptionService))]
        public ushort OverlayNumbers { get; set; }          // Overlay number - 2bytes
        [FieldDescription(15, "1", typeof(UInt16ArrayFieldDescriptionService))]
        public ushort[] ReversedFirst { get; set; }        // Reserved words - 2bytes * 4
        [FieldDescription(16, "1", typeof(UInt16FieldDescriptionService))]
        public ushort OemId { get; set; }         // OEM identifier (for e_oeminfo) - 2bytes
        [FieldDescription(17, "1", typeof(UInt16FieldDescriptionService))]
        public ushort OemInformation { get; set; }       // OEM information; e_oemid specific - 2bytes
        [FieldDescription(18, "1", typeof(UInt16ArrayFieldDescriptionService))]
        public ushort[] ReversedSecond { get; set; }      // Reserved words - 2bytes * 10
        [FieldDescription(19, "1", typeof(UInt32FieldDescriptionService))]
        public uint PeOffset { get; set; }        // File address of new exe header - 4bytes
    }
}
