using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel.Design;

namespace _25._08._2022
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("enter the filename");
            string name = Console.ReadLine ();
            Console.WriteLine ("Menu 1.create 2.add 3.truncate 4.edit");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    FileStream fs = new FileStream(name, FileMode.Create, FileAccess.Write);
                    break;
                case 2:
                    fs = new FileStream(name, FileMode.Append, FileAccess.Write);
                    break;
                case 3:
                    fs = new FileStream(name, FileMode.Truncate, FileAccess.Write);
                    break ;
                case 4:
                    fs = new FileStream(name, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine("edit text");
                    break;
                default:
                   
                    break;
            }
            

            
        }
    }
}
