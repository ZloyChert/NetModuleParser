namespace NetModuleParser.Enums
{
    public enum WindowsSubsystem
    {
        Unknown = 0, //An unknown subsystem
        Native = 1, //Device drivers and native Windows processes
        WindowsGui = 2, //The Windows graphical user interface (GUI) subsystem
        WindowsCui = 3, //The Windows character subsystem
        Os2Cui = 5, //The OS/2 character subsystem
        PosixCui = 7, //The Posix character subsystem
        NativeWindows = 8, //Native Win9x driver
        WindowsCeGui = 9, //Windows CE
        EfiApplication = 10, //An Extensible Firmware Interface(EFI) application
        EfiBootServiceDriver = 11, //An EFI driver with boot services
        EfiRuntimeDriver = 12, //n EFI driver with run-time services
        EfiRom = 13, //        An EFI ROM image
        Xbox = 14, //XBOX
        WindowsBootApplication = 16, //Windows boot application.
    }
}
