using System;

using System.IO;


namespace _25._08._2022
{
    internal class ps2
    {


        static void Main(string[] args)
        { 
            string path =@"C:\Users\hp\OneDrive\Desktop\demo\";
            Console.WriteLine("enter the filename");
            string name = Console.ReadLine();
            FileStream fs = File.Create(path+name+".txt");
            fs.Close();
            File.AppendAllLines(path + name, new string[] { "line1", "line2", "line3" });
            
            string copyname = name + "copy";
            //Console.WriteLine("created a copy in the same folder demo");

            //File.Copy(path, copyname);
            //Console.WriteLine("creating a copy in a differnt folder demo1");
            //copyname = copyname + "1";
            //File.Copy(path, @"C:\Users\hp\OneDrive\Desktop\demo\" + copyname);
            //File.Move(@"C:\Users\hp\OneDrive\Desktop\demo\" + copyname, @"C:\Users\hp\OneDrive\Desktop\demo");
            FileInfo fi = new FileInfo(name);
            Console.WriteLine("file info of "+name);
            Console.WriteLine("file extention of " +fi.Extension);
            Console.WriteLine("file created on"+fi.CreationTime);
            Console.WriteLine("filedirectory"+fi.DirectoryName);
            Console.Read();

        }
    }
}