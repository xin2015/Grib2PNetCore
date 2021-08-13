using Grib2PNetCore.Core.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grib2PNetCore.Core.Sections
{
    public class GridDefinitionSection : Section
    {
        public byte GridDefinitionSource { get; set; }
        public int DataPointsNumber { get; set; }

        public GridDefinitionSection(BinaryReader reader) : base(reader)
        {
            GridDefinitionSource = reader.ReadByte();
            DataPointsNumber = reader.ReadGribInt32();

        }
    }
}
