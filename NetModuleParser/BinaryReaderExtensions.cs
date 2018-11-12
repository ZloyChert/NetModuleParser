using System;
using System.IO;

namespace NetModuleParser
{
    public static class BinaryReaderExtensions
    {
        public static ushort[] ReadUInt16Array(this BinaryReader reader, int count)
        {
            if (reader == null)
            {
                throw new ArgumentNullException(nameof(reader));
            }

            if (count < 0)
            {
                throw null; // vot tak
            }

            ushort[] result = new ushort[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = reader.ReadUInt16();
            }

            return result;
        }
    }
}
