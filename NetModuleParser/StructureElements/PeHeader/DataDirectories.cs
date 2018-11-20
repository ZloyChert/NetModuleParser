using NetModuleParser.Description;
using NetModuleParser.Description.DescriptionServices;
using NetModuleParser.Resources.HeaderDescriptions;

namespace NetModuleParser.StructureElements.PeHeader
{
    public class DataDirectories
    {
        [PropertyDescription(0, 8, PeHeaderDescription.BaseOfData, typeof(DataDirectoryDescriptionService))]
        public ImageDataDirectory ExportTable { get; set; }

        [PropertyDescription(8, 8, PeHeaderDescription.BaseOfData, typeof(DataDirectoryDescriptionService))]
        public ImageDataDirectory ImportTable { get; set; }

        [PropertyDescription(16, 8, PeHeaderDescription.BaseOfData, typeof(DataDirectoryDescriptionService))]
        public ImageDataDirectory ResourceTable { get; set; }

        [PropertyDescription(24, 8, PeHeaderDescription.BaseOfData, typeof(DataDirectoryDescriptionService))]
        public ImageDataDirectory ExceptionTable { get; set; }

        [PropertyDescription(32, 8, PeHeaderDescription.BaseOfData, typeof(DataDirectoryDescriptionService))]
        public ImageDataDirectory CertificateTable { get; set; }

        [PropertyDescription(40, 8, PeHeaderDescription.BaseOfData, typeof(DataDirectoryDescriptionService))]
        public ImageDataDirectory BaseRelocationTable { get; set; }

        [PropertyDescription(48, 8, PeHeaderDescription.BaseOfData, typeof(DataDirectoryDescriptionService))]
        public ImageDataDirectory Debug { get; set; }

        [PropertyDescription(56, 8, PeHeaderDescription.BaseOfData, typeof(DataDirectoryDescriptionService))]
        public ImageDataDirectory Architecture { get; set; }

        [PropertyDescription(64, 8, PeHeaderDescription.BaseOfData, typeof(DataDirectoryDescriptionService))]
        public ImageDataDirectory GlobalPtr { get; set; }

        [PropertyDescription(72, 8, PeHeaderDescription.BaseOfData, typeof(DataDirectoryDescriptionService))]
        public ImageDataDirectory TlsTable { get; set; }

        [PropertyDescription(80, 8, PeHeaderDescription.BaseOfData, typeof(DataDirectoryDescriptionService))]
        public ImageDataDirectory LoadConfigTable { get; set; }

        [PropertyDescription(88, 8, PeHeaderDescription.BaseOfData, typeof(DataDirectoryDescriptionService))]
        public ImageDataDirectory BoundImport { get; set; }

        [PropertyDescription(96, 8, PeHeaderDescription.BaseOfData, typeof(DataDirectoryDescriptionService))]
        public ImageDataDirectory ImportAddressTable { get; set; }

        [PropertyDescription(104, 8, PeHeaderDescription.BaseOfData, typeof(DataDirectoryDescriptionService))]
        public ImageDataDirectory DelayImportDescriptor { get; set; }

        [PropertyDescription(112, 8, PeHeaderDescription.BaseOfData, typeof(DataDirectoryDescriptionService))]
        public ImageDataDirectory ClrRuntimeHeader { get; set; }

        [PropertyDescription(120, 8, PeHeaderDescription.BaseOfData, typeof(DataDirectoryDescriptionService))]
        public ImageDataDirectory Reserved { get; set; }
    }
}
