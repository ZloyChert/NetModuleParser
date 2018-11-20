namespace NetModuleParser.Resources.EnumDescriptions
{
    public static class DllCharacteristicsDescription
    {
        public const string None = "No dll characteristics flag";
        public const string Reserved1 = "Reserved, must be zero";
        public const string Reserved2 = "Reserved, must be zero.";
        public const string Reserved3 = "Reserved, must be zero.";
        public const string Reserved4 = "Reserved, must be zero. ";
        public const string HighEntropyVa = "Image can handle a high entropy 64-bit virtual address space";
        public const string DynamicBase = "DLL can be relocated at load time.";
        public const string ForceIntegrity = "Code Integrity checks are enforced.";
        public const string NxCompact = "Image is NX compatible.";
        public const string NoIsolation = "Isolation aware, but do not isolate the image.";
        public const string NoSeh = "Does not use structured exception (SE) handling. No SE handler may be called in this image";
        public const string NoBind = "Do not bind the image.";
        public const string Appcontainer = "Image must execute in an AppContainer.";
        public const string WdmDriver = "A WDM driver.";
        public const string GuardCf = "Image supports Control Flow Guard.";
        public const string TerminalServerAware = "Terminal Server aware.";
    }
}
