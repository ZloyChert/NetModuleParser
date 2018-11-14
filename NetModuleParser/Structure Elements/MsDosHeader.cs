﻿using NetModuleParser.Description;

namespace NetModuleParser.StructureElements
{
    public class MsDosHeader
    {
        [PropertyDescription(0, 2,"1", typeof(CharArrayFieldDescriptionService))]
        public char[] FileIdTag { get; set; } // MZ - Mark Zbikowski - 2bytes
        [PropertyDescription(2, 2, "1", typeof(UInt16FieldDescriptionService))]
        public ushort LastSize { get; set; }          // Bytes on last page of file - 2bytes
        [PropertyDescription(4, 2, "1", typeof(UInt16FieldDescriptionService))]
        public ushort PagesCount { get; set; }            // Pages in file - 2bytes
        [PropertyDescription(6, 2, "1", typeof(UInt16FieldDescriptionService))]
        public ushort Relocations { get; set; }          // Relocations - 2bytes
        [PropertyDescription(8, 2, "1", typeof(UInt16FieldDescriptionService))]
        public ushort HeaderSize { get; set; }       // Size of header in paragraphs - 2bytes
        [PropertyDescription(10, 2, "1", typeof(UInt16FieldDescriptionService))]
        public ushort MinAlloc { get; set; }      // Minimum extra paragraphs needed - 2bytes
        [PropertyDescription(12, 2, "1", typeof(UInt16FieldDescriptionService))]
        public ushort MaxAlloc { get; set; }      // Maximum extra paragraphs needed - 2bytes
        [PropertyDescription(14, 2, "1", typeof(UInt16FieldDescriptionService))]
        public ushort Ss { get; set; }            // Initial (relative) SS value - 2bytes
        [PropertyDescription(16, 2, "1", typeof(UInt16FieldDescriptionService))]
        public ushort Sp { get; set; }            // Initial SP value - 2bytes
        [PropertyDescription(18, 2, "1", typeof(UInt16FieldDescriptionService))]
        public ushort Checksum { get; set; }          // Checksum - 2bytes
        [PropertyDescription(20, 2, "1", typeof(UInt16FieldDescriptionService))]
        public ushort Ip { get; set; }            // Initial IP value - 2bytes
        [PropertyDescription(22, 2, "1", typeof(UInt16FieldDescriptionService))]
        public ushort Cs { get; set; }            // Initial (relative) CS value - 2bytes
        [PropertyDescription(24, 2, "1", typeof(UInt16FieldDescriptionService))]
        public ushort FileAddress { get; set; }        // File address of relocation table - 2bytes
        [PropertyDescription(26, 2, "1", typeof(UInt16FieldDescriptionService))]
        public ushort OverlayNumbers { get; set; }          // Overlay number - 2bytes
        [PropertyDescription(28, 2, "1", typeof(UInt16ArrayFieldDescriptionService))]
        public ushort[] ReversedFirst { get; set; }        // Reserved words - 2bytes * 4
        [PropertyDescription(36, 2, "1", typeof(UInt16FieldDescriptionService))]
        public ushort OemId { get; set; }         // OEM identifier (for e_oeminfo) - 2bytes
        [PropertyDescription(38, 2, "1", typeof(UInt16FieldDescriptionService))]
        public ushort OemInformation { get; set; }       // OEM information; e_oemid specific - 2bytes
        [PropertyDescription(40, 2, "1", typeof(UInt16ArrayFieldDescriptionService))]
        public ushort[] ReversedSecond { get; set; }      // Reserved words - 2bytes * 10
        [PropertyDescription(60, 4, "1", typeof(UInt32FieldDescriptionService))]
        public uint PeOffset { get; set; }        // File address of new exe header - 4bytes
    }
}