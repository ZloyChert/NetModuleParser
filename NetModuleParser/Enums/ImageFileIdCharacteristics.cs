using System;

namespace NetModuleParser.Enums
{
    [Flags]
    public enum ImageFileIdCharacteristics : ushort
    {
        RelocationsStripped =0x0001, //Image only, Windows CE, and Microsoft Windows NT and later. This indicates that the file does not contain base relocations and must therefore be loaded at its preferred base address. If the base address is not available, the loader reports an error. The default behavior of the linker is to strip base relocations from executable (EXE) files. 
        ExecutableImage = 0x0002,//Image only. This indicates that the image file is valid and can be run. If this flag is not set, it indicates a linker error. 
        LineNumbersStripped = 0x0004,//COFF line numbers have been removed. This flag is deprecated and should be zero. 
        LocalSymbolsStripped = 0x0008,//COFF symbol table entries for local symbols have been removed. This flag is deprecated and should be zero. 
        AggressiveWorkSetTrim = 0x0010,//Obsolete. Aggressively trim working set. This flag is deprecated for Windows 2000 and later and must be zero. 
        LargeAdressAware = 0x0020,//Application can handle > 2-GB addresses. 
        Reserved = 0x0040,//This flag is reserved for future use. 
        BytesReversedLo = 0x0080,//Little endian: the least significant bit (LSB) precedes the most significant bit (MSB) in memory. This flag is deprecated and should be zero. 
        Machine32Bit = 0x0100,//Machine is based on a 32-bit-word architecture. 
        DebugStripped = 0x0200,//Debugging information is removed from the image file. 
        RemovableRunFromSwap = 0x0400,//If the image is on removable media, fully load it and copy it to the swap file. 
        NetRunFromSwap= 0x0800,//If the image is on network media, fully load it and copy it to the swap file. 
        System = 0x1000,//The image file is a system file, not a user program. 
        Dll = 0x2000,//The image file is a dynamic-link library (DLL). Such files are considered executable files for almost all purposes, although they cannot be directly run. 
        UniprocessorSystem = 0x4000,//The file should be ru only on a uniprocessor machine. 
        BytesReversedHi = 0x8000,//Big endian: the MSB precedes the LSB in memory. This flag is deprecated and should be zero. 
    }
}
