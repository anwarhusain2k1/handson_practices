using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._08_prblm4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter firstnumber");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter third number");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter fourth number");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your age");
            int age  = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("you look younger than {0}",age);

            average(a, b, c, d);
            display2times(a);
            displayrectangle(b);
            
            isbothpositive();
            isonenegative();
            metertokilometer();
            celsiustofahrenheit();
            dollartorupee();
            checknull();
            Console.ReadLine();
        }
        static void average(int a, int b, int c, int d)
        {
            int result = (a + b + c + d) / 4;
            Console.WriteLine("the average of four number is " + result);
        }
        static void specified(int x,int y,int z)
        {
            //int a1 = (x + y).z;
            //int a2 = x.y + y.z;
            int a1 = 0, a2 = 0;
            Console.WriteLine("Result of specified numbers {0},{1} and {3}, (x + y).z is {4} and x.y + y.z is {5}",x,y,z,a1,a2); 
        }
        static void display2times(int a)
        {
            Console.WriteLine("the twotime display");
            for (int i = 0; i < 4; i++)
            {
                if ((i % 2) == 0)
                {
                    Console.WriteLine("{0}{0}{0}{0}",a);
            
                }
                else
                {
                
                        Console.WriteLine(a + " " + a+" " +a +" " +a +" " );
                    
                }
            }
        }
        static void displayrectangle(int b)
        {
            Console.WriteLine("displayrectangle with second number");
            for (int i = 1; i <= b; i++)
                if (i == 1 || i == b)
                    Console.WriteLine(b + "" + b + "" + b);
                else
                    Console.WriteLine(b + "  " + b);
        }
        static void isbothpositive()
        {
            Console.WriteLine("isbothpositive");
            Console.WriteLine("enter firstnumber");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > 0 && b > 0)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
        }
        static void isonenegative()
        {
            Console.WriteLine("isonenegative");
            Console.WriteLine("enter firstnumber");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            int b = Convert.ToInt32(Console.ReadLine());
            if ((a > 0 && b < 0) || (b>0 && a<0))
            {
                Console.WriteLine("true");
            }else
            {
                Console.WriteLine("false");
            }
        }
        static void metertokilometer()
        {
            Console.WriteLine("enter distance in meter");
            int meter=Convert.ToInt32(Console.ReadLine());
            int km = meter / 1000;
            Console.WriteLine( "the distance in kilometer is "+km );
        }
        static void celsiustofahrenheit()
        {
            Console.WriteLine("enter celsius");
            int celsius = Convert.ToInt32(Console.ReadLine());
            int fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("the fahrenheit of respective celsius is" + fahrenheit);
        }

        static void dollartorupee()
        {
            Console.WriteLine("enter the dollar value");
            double dollar = Convert.ToInt32(Console.ReadLine());
            double rupee = 79.61 * dollar;
            Console.WriteLine("the rupee value of {0}dollar is {1}",dollar,rupee);
        }

        static void checknull()
        {
            Console.WriteLine("enter the string value");
            string s = Console.ReadLine();
            bool a = string.IsNullOrEmpty(s);
            Console.WriteLine(a);

        }
    }
}
