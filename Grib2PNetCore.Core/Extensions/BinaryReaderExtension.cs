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
            return BitConverter.ToInt16(bytes);
        }

        public static int ReadGribInt32(this BinaryReader reader)
        {
            byte[] bytes = reader.ReadBytes(4).Reverse().ToArray();
            return BitConverter.ToInt32(bytes);
        }

        public static long ReadGribInt64(this BinaryReader reader)
        {
            byte[] bytes = reader.ReadBytes(8).Reverse().ToArray();
            return BitConverter.ToInt64(bytes);
        }
    }
}
