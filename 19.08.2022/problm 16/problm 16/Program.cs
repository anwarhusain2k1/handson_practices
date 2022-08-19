using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problm_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the action whether HIT or MISS");
            int score = 100;
            for (int i = 1; i < 5; i++)

            {
                Console.WriteLine("enter action{0}",i);
                string s = Console.ReadLine();
                if(s == "HIT")
                    score += 10;
                else if(s == "MISS")
                    score -= 20;
            }
            Console.WriteLine("the player score is"+score);
            Console.ReadLine();
        }
    }
}
