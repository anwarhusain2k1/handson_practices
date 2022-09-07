using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._09._2022
{
    public delegate void experience(DateTime a);
    public class employee
    {
        public DateTime dateofjoining { get; set; }
        public string name { get; set; }
        public void experience(DateTime a)
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now;
            Console.WriteLine( dt.Year - a.Year);
        }

        static void Main(string[] args)
        {
            employee e1 = new employee();
            Console.WriteLine("enter employee name");
            e1.name= Console.ReadLine();
            Console.WriteLine("enter date of joining");
            e1.dateofjoining = Convert.ToDateTime(Console.ReadLine());
            experience d = new experience(e1.experience);
            d(e1.dateofjoining);
            Console.ReadLine();

        }
    }
    
}
