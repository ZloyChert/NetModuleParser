using System;
using System.ComponentModel;
using NetModuleParser.Resources.EnumDescriptions;

namespace NetModuleParser.Enums
{
    [Flags]
    public enum DllCharacteristics : ushort
    {
        [Description(DllCharacteristicsDescription.None)]
        None = 0x0000,

        [Description(DllCharacteristicsDescription.Reserved1)]
        Reserved1 = 0x0001,

        [Description(DllCharacteristicsDescription.Reserved2)]
        Reserved2 = 0x0002,

        [Description(DllCharacteristicsDescription.Reserved3)]
        Reserved3 = 0x0004,

        [Description(DllCharacteristicsDescription.Reserved4)]
        Reserved4 = 0x0008,

        [Description(DllCharacteristicsDescription.HighEntropyVa)]
        HighEntropyVa = 0x0020,

        [Description(DllCharacteristicsDescription.DynamicBase)]
        DynamicBase = 0x0040,

        [Description(DllCharacteristicsDescription.ForceIntegrity)]
        ForceIntegrity = 0x0080,

        [Description(DllCharacteristicsDescription.NxCompact)]
        NxCompact = 0x0100,

        [Description(DllCharacteristicsDescription.NoIsolation)]
        NoIsolation = 0x0200,

        [Description(DllCharacteristicsDescription.NoSeh)]
        NoSeh = 0x0400,

        [Description(DllCharacteristicsDescription.NoBind)]
        NoBind = 0x0800,

        [Description(DllCharacteristicsDescription.Appcontainer)]
        Appcontainer = 0x1000,

        [Description(DllCharacteristicsDescription.WdmDriver)]
        WdmDriver = 0x2000,

        [Description(DllCharacteristicsDescription.GuardCf)]
        GuardCf = 0x4000,

        [Description(DllCharacteristicsDescription.TerminalServerAware)]
        TerminalServerAware = 0x8000,
    }
}
