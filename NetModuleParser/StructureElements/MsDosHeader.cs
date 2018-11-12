namespace NetModuleParser.StructureElements
{
    public class MsDosHeader
    {
        public char[] FileIdTag;         // MZ - Mark Zbikowski - 2bytes
        public ushort LastSize;          // Bytes on last page of file - 2bytes
        public ushort PagesCount;            // Pages in file - 2bytes
        public ushort Relocations;          // Relocations - 2bytes
        public ushort HeaderSize;       // Size of header in paragraphs - 2bytes
        public ushort MinAlloc;      // Minimum extra paragraphs needed - 2bytes
        public ushort MaxAlloc;      // Maximum extra paragraphs needed - 2bytes
        public ushort Ss;            // Initial (relative) SS value - 2bytes
        public ushort Sp;            // Initial SP value - 2bytes
        public ushort Checksum;          // Checksum - 2bytes
        public ushort Ip;            // Initial IP value - 2bytes
        public ushort Cs;            // Initial (relative) CS value - 2bytes
        public ushort FileAdress;        // File address of relocation table - 2bytes
        public ushort OverlayNumbers;          // Overlay number - 2bytes
        public ushort[] ReveresedFirst;        // Reserved words - 2bytes * 4
        public ushort OemId;         // OEM identifier (for e_oeminfo) - 2bytes
        public ushort OemInformation;       // OEM information; e_oemid specific - 2bytes
        public ushort[] ReveresedSecond;      // Reserved words - 2bytes * 10
        public uint PeOffset;        // File address of new exe header - 4bytes
    }
}
