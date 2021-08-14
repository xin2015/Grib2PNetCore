using Grib2PNetCore.Core.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grib2PNetCore.Core.Sections
{
    public class MDLLocalUseSection : Section
    {
        public byte TemplateNumber { get; set; }
        public int DataGroupsTotalNumber { get; set; }
        public int FirstGroupDataValuesNumber { get; set; }
        public float FirstGroupDataReferenceValue { get; set; }
        public int DecimalScaleFactor { get; set; }
        public int FirstGroupDataPackBitsNumber { get; set; }
        public byte FirstGroupDataType { get; set; }
        public byte[] FirstGroupData { get; set; }

        public MDLLocalUseSection(BinaryReader reader) : base(reader)
        {
            TemplateNumber = reader.ReadByte();
            DataGroupsTotalNumber = reader.ReadGribInt16();
            FirstGroupDataValuesNumber = reader.ReadGribInt32();
            FirstGroupDataReferenceValue = reader.ReadSingle();
            DecimalScaleFactor = reader.ReadGribInt16();
            FirstGroupDataPackBitsNumber = reader.ReadByte();
            FirstGroupDataType = reader.ReadByte();
            FirstGroupData = reader.ReadBytes(Length - 20);
        }
    }
}
