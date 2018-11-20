namespace NetModuleParser.Resources.HeaderDescriptions
{
    public static class MsDosHeaderDescription
    {

        public const string Checksum = "Checksum (or 0) of executable";
        public const string Cs = "Initial (relative) CS value relative to start of executable (entry point)";
        public const string FileAddress = "Offset of relocation table; 40h for new-(NE,LE,LX,W3,PE etc.) executable";
        public const string FileIdTag = "The first two chars. They are always the letters \"MZ\", the initials of Mark Zbikowski, who created the first linker for DOS";
        public const string HeaderSize = "Header size in paragraphs";
        public const string Ip = "Initial IP value relative to start of executable (entry point)";
        public const string LastSize = "Number of bytes in last 512-byte page of executable";
        public const string MaxAlloc = "Maximum number of paragraphs allocated in addition to the code size";
        public const string MinAlloc = "Minimum paragraphs of memory allocated in addition to the code size";
        public const string OemId = "OEM identifier (for e_oeminfo)";
        public const string OemInformation = "OEM information; e_oemid specific";
        public const string OverlayNumbers = "Overlay number (0h = main program)";
        public const string PagesCount = "Total number of 512-byte pages in executable(including the last page)";
        public const string PeOffset = "Offset to the 'PE\\0\\0' signature relative to the beginning of the file";
        public const string Relocations = "Number of relocation entries";
        public const string ReversedFirst = "Reserved words";
        public const string ReversedSecond = "Reserved words";
        public const string Sp = "Initial SP";
        public const string Ss = "Initial SS relative to start of executable";
    }
}
