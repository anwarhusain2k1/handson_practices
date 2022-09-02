using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace categorylibrary
{
    public class Product
    {
        public int productid { get; set; }
        public string productname { get; set; }
        public int qtysold { get; set; }
        public string unitofmeasurement { get; set; }
        public int unitprice { get; set; }
        public int QtyInHand { get; set; }
        public int ReorderLevel { get; set; }

        public void addproducts()
        {
            Console.WriteLine("enter product id");
            productid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter product name");
            productname = Console.ReadLine();
            Console.WriteLine("enter qtysold");
            qtysold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter unitofmeasurement");
            unitofmeasurement = Console.ReadLine();
            Console.WriteLine("enter unitprice");
            unitprice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter QtyInHand");
            QtyInHand = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter ReorderLevel");
            ReorderLevel = Convert.ToInt32(Console.ReadLine());
        }
    }
}
