using Grib2PNetCore.Core;
using System;
using System.Linq;
using System.Text;

namespace Grib2PNetCore.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Convert.ToString(5 << 24, 2));
            Console.WriteLine(Convert.ToString(5 << 25, 2));
            Console.WriteLine(Convert.ToString(133 << 24, 2));
            Console.WriteLine(Convert.ToString(133 << 25, 2));
            Console.WriteLine(((133 << 25) >> 1) + (93 << 16) + (74 << 8) + 128);
            //string path = @"C:\Users\LiuHa\Downloads\fnl_20210808_00_00.grib2";
            //string path = @"C:\Users\LiuHa\Downloads\gfs.t00z.pgrb2.0p25.anl";
            string path = @"C:\Users\LiuHa\Downloads\gfs.t00z.pgrb2.0p25.f012";
            GribFile gribFile = new GribFile(path);

        }
    }
}
