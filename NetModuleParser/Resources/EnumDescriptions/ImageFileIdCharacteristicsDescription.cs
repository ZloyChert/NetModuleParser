namespace NetModuleParser.Resources.EnumDescriptions
{
    public class ImageFileIdCharacteristicsDescription
    {
        public const string None = "No image file id characteristics";
        public const string RelocationsStripped = "Image only, Windows CE, and Microsoft Windows NT and later. This indicates that the file does not contain base relocations and must therefore be loaded at its preferred base address. If the base address is not available, the loader reports an error. The default behavior of the linker is to strip base relocations from executable (EXE) files.";
        public const string ExecutableImage = "Image only. This indicates that the image file is valid and can be run. If this flag is not set, it indicates a linker error.";
        public const string LineNumbersStripped = "COFF line numbers have been removed. This flag is deprecated and should be zero."; 
        public const string LocalSymbolsStripped = "COFF symbol table entries for local symbols have been removed. This flag is deprecated and should be zero.";
        public const string AggressiveWorkSetTrim = "Obsolete. Aggressively trim working set. This flag is deprecated for Windows 2000 and later and must be zero."; 
        public const string LargeAdressAware = "Application can handle > 2-GB addresses.";
        public const string Reserved = "This flag is reserved for future use."; 
        public const string BytesReversedLo = "Little endian: the least significant bit (LSB) precedes the most significant bit (MSB) in memory. This flag is deprecated and should be zero.";
        public const string Machine32Bit = "Machine is based on a 32-bit-word architecture.";
        public const string DebugStripped = "Debugging information is removed from the image file."; 
        public const string RemovableRunFromSwap = "If the image is on removable media, fully load it and copy it to the swap file."; 
        public const string NetRunFromSwap = "If the image is on network media, fully load it and copy it to the swap file."; 
        public const string System = "The image file is a system file, not a user program.";
        public const string Dll = "The image file is a dynamic-link library (DLL). Such files are considered executable files for almost all purposes, although they cannot be directly run.";
        public const string UniprocessorSystem = "The file should be ru only on a uniprocessor machine.";
        public const string BytesReversedHi = "Big endian: the MSB precedes the LSB in memory. This flag is deprecated and should be zero."; 
    }
}
