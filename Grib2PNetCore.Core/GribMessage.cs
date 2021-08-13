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

        public LocalUseSection LocalUseSection { get; set; }

        public GribMessage(BinaryReader reader)
        {
            IndicatorSection = new IndicatorSection(reader);
            IdentificationSection = new IdentificationSection(reader);
            LocalUseSection = new LocalUseSection(reader);

        }
    }
}
