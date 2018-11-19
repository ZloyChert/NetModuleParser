using System.ComponentModel;

namespace NetModuleParser.Enums
{
    public enum ImageFileIdMachine : ushort
    {
        [Description("Unknown machine type")]
        UNKNOWN = 0,
        [Description("Intel 386 or later processors and compatible processors")]
        I386 = 0x014c, // Intel 386 or later processors and compatible processors
        [Description("MIPS little endian")]
        R3000 = 0x0162, //, 
        [Description("MIPS little endian")]
        R4000 = 0x0166, //MIPS little endian
        [Description("MIPS R10000")]
        R10000 = 0x0168, //MIPS R10000
        [Description("MIPS little endian WCI v2")]
        WCEMIPSV2 = 0x0169, //MIPS little endian WCI v2
        [Description("Old Alpha AXP")]
        ALPHA_OLD = 0x0183, //old Alpha AXP
        [Description("Alpha AXP")]
        ALPHA = 0x0184, //Alpha AXP
        [Description("Hitachi SH3")]
        SH3 = 0x01a2, //Hitachi SH3
        [Description("Hitachi SH3 DSP")]
        SH3DSP = 0x01a3, //Hitachi SH3 DSP
        [Description("SH3E")]
        SH3E = 0x01a4,
        [Description("Hitachi SH4")]
        SH4 = 0x01a6, //Hitachi SH4
        [Description("Hitachi SH5")]
        SH5 = 0x01a8, //Hitachi SH5
        [Description("ARM little endian")]
        ARM = 0x01c0, //ARM little endian
        [Description("Thumb")]
        THUMB = 0x01c2, //Thumb
        [Description("ARM Thumb-2 little endian ")]
        ARM2 = 0x01c4, //ARM Thumb-2 little endian 
        [Description("Matsushita AM33")]
        AM33 = 0x01d3, //Matsushita AM33 
        [Description("PowerPC little endian")]
        POWERPC = 0x01F0, //PowerPC little endian
        [Description("PowerPC with floating point support")]
        POWERPCFP = 0x01f1, //PowerPC with floating point support
        [Description("Intel IA64")]
        IA64 = 0x0200, //Intel IA64
        [Description("MIPS16")]
        MIPS16 = 0x0266, //MIPS16
        [Description("Motorola 68000 series")]
        MOTOROLA = 0x0268, //Motorola 68000 series
        [Description("Alpha AXP 64-bit")]
        ALPHA64 = 0x0284, //Alpha AXP 64-bit
        [Description("MIPS with FPU")]
        MIPSFPU = 0x0366, //MIPS with FPU
        [Description("MIPS16 with FPU")]
        MIPSFPU16 = 0x0466, //MIPS16 with FPU
        [Description("TRICORE")]
        TRICORE = 0x0520,
        [Description("CEF")]
        CEF = 0x0CEF,
        [Description("EFI Byte Code")]
        EBC = 0x0EBC, //EFI Byte Code
        [Description("AMD AMD64")]
        AMD64 = 0x8664, //AMD AMD64
        [Description("Mitsubishi M32R little endian")]
        M32R = 0x9041, //Mitsubishi M32R little endian
        [Description("Clr pure MSIL")]
        CEE = 0xC0EE, //clr pure MSIL
    }
}
