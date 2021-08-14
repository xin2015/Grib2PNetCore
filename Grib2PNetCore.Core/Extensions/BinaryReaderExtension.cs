using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grib2PNetCore.Core.Extensions
{
    public static class BinaryReaderExtension
    {
        public static short ReadGribInt16(this BinaryReader reader)
        {
            byte[] bytes = reader.ReadBytes(2).Reverse().ToArray();
            short value = BitConverter.ToInt16(bytes);
            return (short)(bytes[0] < 128 ? value : (short.MinValue - value));
        }

        public static int ReadGribInt32(this BinaryReader reader)
        {
            byte[] bytes = reader.ReadBytes(4).Reverse().ToArray();
            int value = BitConverter.ToInt32(bytes);
            return bytes[0] < 128 ? value : (int.MinValue - value);
        }


        public static long ReadGribInt64(this BinaryReader reader)
        {
            byte[] bytes = reader.ReadBytes(8).Reverse().ToArray();
            long value = BitConverter.ToInt64(bytes);
            return bytes[0] < 128 ? value : (long.MinValue - value);
        }
    }
}
