using System;

namespace NetModuleParser.Description
{
    public class ParentOffsetAttribute : Attribute
    {
        public ParentOffsetAttribute(int parentOffset)
        {
            ParentOffset = parentOffset;
        }

        public int ParentOffset { get; }
    }
}
