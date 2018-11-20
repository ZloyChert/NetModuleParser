using System.ComponentModel;

namespace NetModuleParser.Enums
{
    public enum WindowsSubsystem : ushort
    {
        [Description("lala")]
        Unknown = 0, //An unknown subsystem
        [Description("lala")]
        Native = 1, //Device drivers and native Windows processes
        [Description("lala")]
        WindowsGui = 2, //The Windows graphical user interface (GUI) subsystem
        [Description("lala")]
        WindowsCui = 3, //The Windows character subsystem
        [Description("lala")]
        Os2Cui = 5, //The OS/2 character subsystem
        [Description("lala")]
        PosixCui = 7, //The Posix character subsystem
        [Description("lala")]
        NativeWindows = 8, //Native Win9x driver
        [Description("lala")]
        WindowsCeGui = 9, //Windows CE
        [Description("lala")]
        EfiApplication = 10, //An Extensible Firmware Interface(EFI) application
        [Description("lala")]
        EfiBootServiceDriver = 11, //An EFI driver with boot services
        [Description("lala")]
        EfiRuntimeDriver = 12, //n EFI driver with run-time services
        [Description("lala")]
        EfiRom = 13, //        An EFI ROM image
        [Description("lala")]
        Xbox = 14, //XBOX
        [Description("lala")]
        WindowsBootApplication = 16, //Windows boot application.
    }
}
