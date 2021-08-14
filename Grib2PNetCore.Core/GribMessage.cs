using Grib2PNetCore.Core.Sections;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grib2PNetCore.Core
{
    public class GribMessage
    {
        public IndicatorSection IndicatorSection { get; set; }

        public IdentificationSection IdentificationSection { get; set; }

        public Section LocalUseSection { get; set; }

        public GridDefinitionSection GridDefinitionSection { get; set; }

        public GribMessage(BinaryReader reader)
        {
            IndicatorSection = new IndicatorSection(reader);
            IdentificationSection = new IdentificationSection(reader);
            if (IdentificationSection.Center == 7 && IdentificationSection.SubCenter == 14)
            {
                LocalUseSection = new MDLLocalUseSection(reader);
            }
            GridDefinitionSection = new GridDefinitionSection(reader);
        }
    }
}
