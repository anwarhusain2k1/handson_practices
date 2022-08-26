using System;
using System.IO;
namespace _25._08._2022
{
    internal class ps4
    {
        public static void Main(string[] args)
        {
            var drive = DriveInfo.GetDrives();
            foreach (DriveInfo d in drive)
            {
                Console.WriteLine("drive name:"+d.Name);
                Console.WriteLine("  File type:"+ d.DriveType);
            }
            Console.ReadLine();
        }
    }
}