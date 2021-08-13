using Grib2PNetCore.Core.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grib2PNetCore.Core.Sections
{
    public class IndicatorSection : Section
    {
        public byte Discipline { get; set; }
        public byte EditionNumber { get; set; }
        public int TotalLength { get; set; }

        public IndicatorSection(BinaryReader reader)
        {
            string start = new string(reader.ReadChars(4));
            if (start != "GRIB")
            {
                throw new Exception("Invalid file start.");
            }
            byte[] reserved = reader.ReadBytes(2);
            Discipline = reader.ReadByte();
            EditionNumber = reader.ReadByte();
            if (EditionNumber != 2)
            {
                throw new Exception("Invalid edition number.");
            }
            TotalLength = (int)reader.ReadGribInt64();
        }
    }
}
