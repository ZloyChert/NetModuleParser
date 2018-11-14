using System.IO;

namespace NetModuleParser.Parsers
{
    public interface IByteParser<out T>
    {
        T Parse(BinaryReader reader);
    }
}
