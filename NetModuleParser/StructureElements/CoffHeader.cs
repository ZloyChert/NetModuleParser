using NetModuleParser.Description;
using NetModuleParser.Description.DescriptionServices;
using NetModuleParser.Enums;
using NetModuleParser.Resources.HeaderDescriptions;

namespace NetModuleParser.StructureElements
{
    public class CoffHeader
    {
        [PropertyDescription(0, 2, CoffHeaderDescription.Machine, typeof(EnumUInt16DescriptionService<ImageFileIdMachine>))]
        public ImageFileIdMachine Machine{ get; set; } //2bytes, type of target machine 2bytes

        [PropertyDescription(2, 2, CoffHeaderDescription.NumberOfSections, typeof(UInt16DescriptionService))]
        public ushort NumberOfSections{ get; set; } //Number of sections, that follows the header 2bytes

        [PropertyDescription(4, 4, CoffHeaderDescription.TimeDateStamp, typeof(UInt32DescriptionService))]
        public uint TimeDateStamp{ get; set; } //time and date file creation 4bytes

        [PropertyDescription(8, 4, CoffHeaderDescription.PointerToSymbolTable, typeof(UInt32DescriptionService))]
        public uint PointerToSymbolTable{ get; set; } //File Pointer of the COFF symbol table. Never used in PE files, should be 0 4bytes

        [PropertyDescription(12, 4, CoffHeaderDescription.NumberOfSymbols, typeof(UInt32DescriptionService))]
        public uint NumberOfSymbols{ get; set; } //Number of entries in COFF sybmol table, Should be 0, 4bytes

        [PropertyDescription(16, 2, CoffHeaderDescription.SizeOfOptionalHeader, typeof(UInt16DescriptionService))]
        public ushort SizeOfOptionalHeader{ get; set; } // Size of PE header, Specific to PE files, set to 0 in COFF files.2bytes

        [PropertyDescription(18, 2, CoffHeaderDescription.Characteristics, typeof(EnumFlagsUInt16DescriptionService<ImageFileIdCharacteristics>))]
        public ImageFileIdCharacteristics Characteristics{ get; set; } //Flags, indicating the attribtes of the file.2bytes
    }
}
