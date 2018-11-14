namespace NetModuleParser.Description
{
    public class FieldDescriptionInfo
    {
        public int FieldOffset { get; set; }
        public int FieldLength { get; set; }
        public byte[] ValueBytes { get; set; }

        public string FieldName { get; set; }
        public string FieldValue { get; set; }
        public string Description { get; set; }
    }
}
