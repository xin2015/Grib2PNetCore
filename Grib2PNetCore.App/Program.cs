using Grib2PNetCore.Core;
using System;

namespace Grib2PNetCore.App
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\LiuHa\Downloads\fnl_20210808_00_00.grib2";
            GribFile gribFile = new GribFile(path);
        }
    }
}
