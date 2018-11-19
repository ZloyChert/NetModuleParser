using NetModuleParser.Description;
using NetModuleParser.Description.DescriptionServices;
using NetModuleParser.Enums;
using NetModuleParser.HeaderResources;

namespace NetModuleParser.StructureElements
{
    public class CoffHeader
    {
        [PropertyDescription(0, 2, CoffHeaderResources.Machine, typeof(EnumUInt16DescriptionService<ImageFileIdMachine>))]
        public ImageFileIdMachine Machine{ get; set; } //2bytes, type of target machine 2bytes

        [PropertyDescription(2, 2, CoffHeaderResources.NumberOfSections, typeof(UInt16DescriptionService))]
        public ushort NumberOfSections{ get; set; } //Number of sections, that follows the header 2bytes

        [PropertyDescription(4, 4, CoffHeaderResources.TimeDateStamp, typeof(UInt32DescriptionService))]
        public uint TimeDateStamp{ get; set; } //time and date file creation 4bytes

        [PropertyDescription(8, 4, CoffHeaderResources.PointerToSymbolTable, typeof(UInt32DescriptionService))]
        public uint PointerToSymbolTable{ get; set; } //File Pointer of the COFF symbol table. Never used in PE files, should be 0 4bytes

        [PropertyDescription(12, 4, CoffHeaderResources.NumberOfSymbols, typeof(UInt32DescriptionService))]
        public uint NumberOfSymbols{ get; set; } //Number of entries in COFF sybmol table, Should be 0, 4bytes

        [PropertyDescription(16, 2, CoffHeaderResources.SizeOfOptionalHeader, typeof(UInt16DescriptionService))]
        public ushort SizeOfOptionalHeader{ get; set; } // Size of PE header, Specific to PE files, set to 0 in COFF files.2bytes

        //[PropertyDescription(18, 2, CoffHeaderResources.Characteristics, typeof(UInt16DescriptionService))]
        public ImageFileIdCharacteristics Characteristics{ get; set; } //Flags, indicating the attribtes of the file.2bytes
    }
}
