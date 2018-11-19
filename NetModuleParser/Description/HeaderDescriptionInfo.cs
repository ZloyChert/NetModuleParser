using System.Collections.Generic;

namespace NetModuleParser.Description
{
    public class HeaderDescriptionInfo
    {
        public string Description { get; set; }
        public int? HeaderOrderNumber { get; set; }
        public int? HeaderOffset { get; set; }
        public int? HeaderLength { get; set; }
        public IEnumerable<HeaderMemberDescriptionInfo> HeaderMemberDescriptions { get; set; }
    }
}
