using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace myapp1
{
    internal class ps7
    {
        static void Main(string[] args)
        { 
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("current year: "+dateTime.Year);
            Console.WriteLine("current month: " + dateTime.Month);
            Console.WriteLine("today: "+dateTime.Day);
            Console.WriteLine("hour: "+dateTime.Hour);
            Console.WriteLine("minute: " + dateTime.Minute);
            Console.WriteLine("second: " + dateTime.Second);
            Console.WriteLine("millisecond: " + dateTime.Millisecond);
            Console.Read();
        }
    }
}