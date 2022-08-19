using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prblm6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year : ");
            int Year = int.Parse(Console.ReadLine());
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0)) 
                Console.WriteLine("{0} is a Leap Year.", Year);
            else 
                Console.WriteLine("{0} is not a Leap Year.", Year);
            Console.ReadLine();
        }
    }
}
