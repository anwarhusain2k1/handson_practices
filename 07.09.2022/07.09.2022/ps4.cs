using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._09._2022
{
    public delegate void print();
    public class product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void display()
        {
            Console.WriteLine("productid : " + Id);
            Console.WriteLine("productname : " + Name);
        }
        static void Main(string[] args)
        {
            product p = new product();
            Console.WriteLine("enter productid");
            p.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter productname");
            p.Name = Console.ReadLine();
            print d = new print(p.display);
            d();
            Console.Read();

        }
    }
}
