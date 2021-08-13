using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grib2PNetCore.Core.Sections
{
    public class LocalUseSection : Section
    {
        public byte[] Reserved { get; set; }

        public LocalUseSection(BinaryReader reader) : base(reader)
        {
            Reserved = reader.ReadBytes(Length - 5);
        }
    }
}
