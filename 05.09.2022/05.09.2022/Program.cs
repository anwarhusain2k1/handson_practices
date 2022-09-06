using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace _05._09._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.insertbook(1, "C++", 150, "george");
            book.display();
            
            Console.WriteLine("enter number of books you want to add in cart");
            int n =Convert.ToInt32( Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter book id");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter book name");
                string name = Console.ReadLine();
                Console.WriteLine("enter author name");
                string author = Console.ReadLine();
                Console.WriteLine("enter book price");
                int price = Convert.ToInt32(Console.ReadLine());
                Cart cart = new Cart();
                cart.addtocart(id, name, author, price);
            }
            Cart cart1 = new Cart();
            cart1.displaycart();
            Console.ReadLine();
        }
    }
}
