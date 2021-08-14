using System;
using System.IO;
using System.Text;

namespace Grib2PNetCore.Core
{
    public class GribFile
    {
        public GribFile(string path)
        {
            if (File.Exists(path))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
                {
                    GribMessage gribMessage = new GribMessage(reader);
                }
            }
        }
    }
}
