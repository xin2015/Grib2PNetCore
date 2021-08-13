using Grib2PNetCore.Core.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grib2PNetCore.Core.Sections
{
    public class Section
    {
        public int Length { get; set; }
        public int Number { get; set; }

        public Section()
        {

        }

        public Section(BinaryReader reader)
        {
            Length = reader.ReadGribInt32();
            Number = reader.ReadByte();
        }
    }
}
