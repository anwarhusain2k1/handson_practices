using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using reusable_code;
using logic;

namespace myapp1
{
    internal class ps6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("press enter to create a file in \"C:\\Users\\hp\\OneDrive\\Desktop\\demo\"");
            differentmethod.makefile();
            Console.ReadLine();
        
            Console.WriteLine("file created");
            Console.ReadLine();
        }
    }
}