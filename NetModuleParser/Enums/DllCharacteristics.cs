using System;

namespace NetModuleParser.Enums
{
    [Flags]
    public enum DllCharacteristics : ushort
    {
        Reserved1 = 0x0001, //Reserved, must be zero. 
        Reserved2 = 0x0002, //Reserved, must be zero. 
        Reserved3 = 0x0004, //Reserved, must be zero. 
        Reserved4 = 0x0008, //Reserved, must be zero. 
        HighEntropyVa = 0x0020, //Image can handle a high entropy 64-bit virtual address space. 
        DynamicBase = 0x0040, //DLL can be relocated at load time. 
        ForceIntegrity = 0x0080, //Code Integrity checks are enforced. 
        NxCompact = 0x0100, //Image is NX compatible. 
        NoIsolation = 0x0200, //Isolation aware, but do not isolate the image. 
        NoSeh = 0x0400, //Does not use structured exception (SE) handling. No SE handler may be called in this image. 
        NoBind = 0x0800, //Do not bind the image. 
        Appcontainer = 0x1000, //Image must execute in an AppContainer. 
        WdmDriver = 0x2000, //A WDM driver. 
        GuardCf = 0x4000, //Image supports Control Flow Guard. 
        TerminalServerAware = 0x8000, //Terminal Server aware. 
    }
}
