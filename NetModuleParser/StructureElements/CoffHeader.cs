using NetModuleParser.Enums;

namespace NetModuleParser.StructureElements
{
    public class CoffHeader
    {
        public ImageFileIdMachine Machine; //2bytes, type of target machine 2bytes
        public ushort NumberOfSections; //Number of sections, that follows the header 2bytes
        public uint TimeDateStamp; //time and date file creation 4bytes

        public uint PointerToSymbolTable; //File Pointer of the COFF symbol table. Never used in PE files, should be 0 4bytes

        public uint NumberOfSymbols; //Number of entries in COFF sybmol table, Should be 0, 4bytes
        public ushort SizeOfOptionalHeader; // Size of PE header, Specific to PE files, set to 0 in COFF files.2bytes
        public ImageFileIdCharacteristics Characteristics; //Flags, indicating the attribtes of the file.2bytes
    }
}
