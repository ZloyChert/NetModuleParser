using System;
using System.ComponentModel;
using NetModuleParser.Resources.EnumDescriptions;

namespace NetModuleParser.Enums
{
    [Flags]
    public enum ImageFileIdCharacteristics : ushort
    {
        [Description(ImageFileIdCharacteristicsDescription.None)]
        None =0x0001,

        [Description(ImageFileIdCharacteristicsDescription.RelocationsStripped)]
        RelocationsStripped = 0x0001,

        [Description(ImageFileIdCharacteristicsDescription.ExecutableImage)]
        ExecutableImage = 0x0002,

        [Description(ImageFileIdCharacteristicsDescription.LineNumbersStripped)]
        LineNumbersStripped = 0x0004,

        [Description(ImageFileIdCharacteristicsDescription.LocalSymbolsStripped)]
        LocalSymbolsStripped = 0x0008,

        [Description(ImageFileIdCharacteristicsDescription.AggressiveWorkSetTrim)]
        AggressiveWorkSetTrim = 0x0010,

        [Description(ImageFileIdCharacteristicsDescription.LargeAdressAware)]
        LargeAdressAware = 0x0020,

        [Description(ImageFileIdCharacteristicsDescription.Reserved)]
        Reserved = 0x0040,

        [Description(ImageFileIdCharacteristicsDescription.BytesReversedLo)]
        BytesReversedLo = 0x0080,

        [Description(ImageFileIdCharacteristicsDescription.Machine32Bit)]
        Machine32Bit = 0x0100,

        [Description(ImageFileIdCharacteristicsDescription.DebugStripped)]
        DebugStripped = 0x0200,

        [Description(ImageFileIdCharacteristicsDescription.RemovableRunFromSwap)]
        RemovableRunFromSwap = 0x0400,

        [Description(ImageFileIdCharacteristicsDescription.NetRunFromSwap)]
        NetRunFromSwap = 0x0800,

        [Description(ImageFileIdCharacteristicsDescription.System)]
        System = 0x1000,

        [Description(ImageFileIdCharacteristicsDescription.Dll)]
        Dll = 0x2000,

        [Description(ImageFileIdCharacteristicsDescription.UniprocessorSystem)]
        UniprocessorSystem = 0x4000,

        [Description(ImageFileIdCharacteristicsDescription.BytesReversedHi)]
        BytesReversedHi = 0x8000,
    }
}
