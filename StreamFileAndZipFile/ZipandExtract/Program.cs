using System;
using System.IO;
using System.IO.Compression;

namespace Zip_and_Extract_Exc
{
    class Program
    {
        static void Main(string[] args)
        {

            var zipFile = @"..\..\..\myzip.zip";
            var file = "copyMe.png";

            using (var archive = ZipFile.Open(zipFile, ZipArchiveMode.Create))
            {
                archive.CreateEntryFromFile(file, Path.GetFileName(file));
            }
        }
    }
}
