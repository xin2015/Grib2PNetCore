using Grib2PNetCore.Core.Extensions;
using Grib2PNetCore.Core.Templates.GridDefinitionTemplates;
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
        public byte PointsNumbersOptionalListNumber { get; set; }
        public byte PointsNumbersListInterpetation { get; set; }
        public int GridDefinitionTemplateNumber { get; set; }
        public GridDefinitionTemplate GridDefinitionTemplate { get; set; }

        public GridDefinitionSection(BinaryReader reader) : base(reader)
        {
            GridDefinitionSource = reader.ReadByte();
            DataPointsNumber = reader.ReadGribInt32();
            PointsNumbersOptionalListNumber = reader.ReadByte();
            PointsNumbersListInterpetation = reader.ReadByte();
            GridDefinitionTemplateNumber = reader.ReadGribInt16();
            switch (GridDefinitionTemplateNumber)
            {
                case 0: { GridDefinitionTemplate = new LatitudeLongitudeGridDefinitionTemplate(reader); break; }
            }
        }
    }
}
