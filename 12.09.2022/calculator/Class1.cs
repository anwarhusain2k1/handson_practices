using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class operation
    {
        public double number { get; set; }
        public void cube(double number)
        {
            Console.WriteLine(number*number*number);
        }
        public void squaroot(double number)
        {
            Console.WriteLine(Math.Sqrt(number) ); 
        }
    }
}
