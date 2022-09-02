using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using categorylibrary;

namespace _02._09._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number of categories");
            int n=Convert.ToInt32(Console.ReadLine());
            Category[] category = new Category[n];
            for (int i = 0; i < n; i++)
            {
                category[i] = new Category();
                category[i].addcategory();
                category[i].products = new List<Product>();
                Console.WriteLine("enter number of products in this category");
                int m = Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j < m; j++)
                {
                    Product product = new Product();
                    product.addproducts();
                    category[i].products.Add(product);
                    Category.productcount += 1;
                }
                Console.WriteLine("static counter:"+Category.productcount);
                
            }
            for (int i = 0; i < n; i++)
            {
                category[i].printdata();

            }
            Console.ReadLine();
        }
    }
}
