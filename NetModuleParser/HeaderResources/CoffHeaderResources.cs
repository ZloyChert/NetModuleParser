namespace NetModuleParser.HeaderResources
{
    public static class CoffHeaderResources
    {
        public const string Characteristics = "Flags indicating the attributes of the file";
        public const string Machine = "Number, identifying the type of target machine";
        public const string NumberOfSections = "Number of entries in the section table, which immediately follows the headers";
        public const string NumberOfSymbols = "Number of entries in the COFF symbol table. This field must be set to 0 in managed PE files.";
        public const string PointerToSymbolTable = "File pointer of the COFF symbol table. As this table is never managed PE files, this field must be set to 0";
        public const string SizeOfOptionalHeader = "Size of the PE header. This field is specidic to PE files; it is set to 0 in coff files";
        public const string TimeDateStamp = "Time and date of file creation";
    }
}
