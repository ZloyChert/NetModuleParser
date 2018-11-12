using System.IO;

namespace NetModuleParser.ParserInterfaces
{
    public interface IByteParser<out T>
    {
        T Parse(BinaryReader reader);
    }
}
