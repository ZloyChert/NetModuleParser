using System.Collections.Generic;

namespace NetModuleParser.Description
{
    public class HeaderDescriptionInfo
    {
        public string Description { get; set; }
        public int HeaderOffset { get; set; }
        public int HeaderLength { get; set; }
        public IEnumerable<FieldDescriptionInfo> FieldDescriptions { get; set; }
    }
}
