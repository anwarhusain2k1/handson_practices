using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using product;
namespace _26._08._2022
{
    class ps3
    {
        static void Main(string[] args)
        {
            
            
            List<Product> myproducts = new List<Product>();

            myproducts.Add(new Product { Name = "table", Price = 3000 });
            myproducts.Add(new Product { Name = "chair", Price = 2000 });
            Console.WriteLine("enter the total number of products");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Product p = new Product();
                Console.WriteLine("enter the product name");
                p.Name = Console.ReadLine();
                Console.WriteLine("enter the product price");
                p.Price =Convert.ToInt32( Console.ReadLine());
                myproducts.Add(p);
            }
            foreach (var item in myproducts)
            {
                Console.WriteLine("product name:"+item.Name);
                Console.WriteLine("product price:" + item.Price);
            }
            Console.WriteLine(myproducts.Count);
            Console.WriteLine("enter the name of the product you want to delete");
            Product p1 = new Product();
            p1.Name=Console.ReadLine();
            Console.WriteLine("enter the price of the product");
            p1.Price=Convert.ToInt32( Console.ReadLine());
            myproducts.Remove(p1);

            Console.WriteLine("product Removed");
            Console.Read();
        }
        
	
    }
}