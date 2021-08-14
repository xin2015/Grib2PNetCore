using Grib2PNetCore.Core.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grib2PNetCore.Core.Templates.GridDefinitionTemplates
{
    public class LatitudeLongitudeGridDefinitionTemplate : GridDefinitionTemplate
    {
        public byte EarthShape { get; set; }
        public int SphericalEarthRadiusScaleFactor { get; set; }
        public int SphericalEarthRadiusScaleValue { get; set; }
        public int OblateSpheroidEarthMajorAxisScaleFactor { get; set; }
        public int OblateSpheroidEarthMajorAxisScaleValue { get; set; }
        public int OblateSpheroidEarthMinorAxisScaleFactor { get; set; }
        public int OblateSpheroidEarthMinorAxisScaleValue { get; set; }
        public int Ni { get; set; }
        public int Nj { get; set; }
        public int InitialProductionDomainBasicAngle { get; set; }
        public int BasicAngleSubdivisions { get; set; }
        public int La1 { get; set; }
        public int Lo1 { get; set; }
        public byte ResolutionAndComponentFlags { get; set; }
        public int La2 { get; set; }
        public int Lo2 { get; set; }
        public int Di { get; set; }
        public int Dj { get; set; }
        public byte ScanningMode { get; set; }


        public LatitudeLongitudeGridDefinitionTemplate(BinaryReader reader)
        {
            EarthShape = reader.ReadByte();
            SphericalEarthRadiusScaleFactor = reader.ReadByte();
            SphericalEarthRadiusScaleValue = reader.ReadGribInt32();
            OblateSpheroidEarthMajorAxisScaleFactor = reader.ReadByte();
            OblateSpheroidEarthMajorAxisScaleValue = reader.ReadGribInt32();
            OblateSpheroidEarthMinorAxisScaleFactor = reader.ReadByte();
            OblateSpheroidEarthMinorAxisScaleValue = reader.ReadGribInt32();
            Ni = reader.ReadGribInt32();
            Nj = reader.ReadGribInt32();
            InitialProductionDomainBasicAngle = reader.ReadGribInt32();
            BasicAngleSubdivisions = reader.ReadGribInt32();
            La1 = reader.ReadGribInt32();
            Lo1 = reader.ReadGribInt32();
            ResolutionAndComponentFlags = reader.ReadByte();
            La2 = reader.ReadGribInt32();
            Lo2 = reader.ReadGribInt32();
            Di = reader.ReadGribInt32();
            Dj = reader.ReadGribInt32();
            ScanningMode = reader.ReadByte();
        }
    }
}
