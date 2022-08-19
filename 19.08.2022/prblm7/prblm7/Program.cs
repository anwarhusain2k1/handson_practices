using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace prblm7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input  the marks of Physics : ");
            int phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of  Chemistry : ");
            int che = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of Computer Application : ");
            int ca = Convert.ToInt32(Console.ReadLine());
            double total = phy + che + ca;
            double per = total / 3.0;
            string div;
            if (per >= 60)
                div = "First";
            else
                if (per < 60 && per >= 45)
                div = "Second";
            else
                    if (per < 45 && per >= 36)
                div = "third";
            else
                div = "Fail";
            Console.Write("your grade :"+div);
            Console.ReadLine();
        }
    }
}
