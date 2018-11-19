using System.ComponentModel;

namespace NetModuleParser.Enums
{
    public enum ImageFileIdMachine
    {
        [Description("Unknown machine type")]
        UNKNOWN = 0,
        I386 = 0x014c, //Intel 386 or later processors and compatible processors 
        R3000 = 0x0162, //MIPS little endian, 
        R4000 = 0x0166, //MIPS little endian
        R10000 = 0x0168, //MIPS R10000
        WCEMIPSV2 = 0x0169, //MIPS little endian WCI v2
        ALPHA_OLD = 0x0183, //old Alpha AXP
        ALPHA = 0x0184, //Alpha AXP
        SH3 = 0x01a2, //Hitachi SH3
        SH3DSP = 0x01a3, //Hitachi SH3 DSP
        SH3E = 0x01a4,
        SH4 = 0x01a6, //Hitachi SH4
        SH5 = 0x01a8, //Hitachi SH5
        ARM = 0x01c0, //ARM little endian
        THUMB = 0x01c2, //Thumb
        ARM2 = 0x01c4, //ARM Thumb-2 little endian 
        AM33 = 0x01d3, //Matsushita AM33 
        POWERPC = 0x01F0, //PowerPC little endian
        POWERPCFP = 0x01f1, //PowerPC with floating point support
        IA64 = 0x0200, //Intel IA64
        MIPS16 = 0x0266, //MIPS16
        MOTOROLA = 0x0268, //Motorola 68000 series
        ALPHA64 = 0x0284, //Alpha AXP 64-bit
        MIPSFPU = 0x0366, //MIPS with FPU
        MIPSFPU16 = 0x0466, //MIPS16 with FPU
        TRICORE = 0x0520,
        CEF = 0x0CEF,
        EBC = 0x0EBC, //EFI Byte Code
        AMD64 = 0x8664, //AMD AMD64
        M32R = 0x9041, //Mitsubishi M32R little endian
        CEE = 0xC0EE, //clr pure MSIL
    }
}
