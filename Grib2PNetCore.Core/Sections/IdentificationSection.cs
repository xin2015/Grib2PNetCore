using Grib2PNetCore.Core.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grib2PNetCore.Core.Sections
{
    public class IdentificationSection : Section
    {
        public int Center { get; set; }
        public int SubCenter { get; set; }
        public byte MasterTablesVersionNumber { get; set; }
        public byte LocalTablesVersionNumber { get; set; }
        public byte ReferenceTimeSignificance { get; set; }
        public DateTime ReferenceTime { get; set; }
        public byte ProductionStatus { get; set; }
        public byte Type { get; set; }
        public byte[] Reserved { get; set; }

        public IdentificationSection(BinaryReader reader) : base(reader)
        {
            Center = reader.ReadGribInt16();
            SubCenter = reader.ReadGribInt16();
            MasterTablesVersionNumber = reader.ReadByte();
            LocalTablesVersionNumber = reader.ReadByte();
            if (MasterTablesVersionNumber == 255 && (LocalTablesVersionNumber == 0 || LocalTablesVersionNumber == 255))
            {
                throw new Exception("Invalid tables version numbers.");
            }
            ReferenceTimeSignificance = reader.ReadByte();
            int year = reader.ReadGribInt16();
            int month = reader.ReadByte();
            int day = reader.ReadByte();
            int hour = reader.ReadByte();
            int minute = reader.ReadByte();
            int second = reader.ReadByte();
            ReferenceTime = new DateTime(year, month, day, hour, minute, second, DateTimeKind.Utc);
            ProductionStatus = reader.ReadByte();
            Type = reader.ReadByte();
            Reserved = reader.ReadBytes(Length - 21);
        }
    }
}
