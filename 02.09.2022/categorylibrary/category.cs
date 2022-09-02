using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace categorylibrary
{
    public class Category
    {
        private int catid { get; set; }
        private string catname { get; set; }
        private string description { get; set; }

        public static int productcount = 0;
        public List<Product> products { get; set; }
        public void addcategory()
        {
            Console.WriteLine("enter category id");
            catid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter category name");
            catname = Console.ReadLine();
            Console.WriteLine("enter description");
            description = Console.ReadLine();
        }

        public void printdata()
        {
            Console.WriteLine("category id:"+catid);
            Console.WriteLine("category name:" + catname);
            Console.WriteLine("description:" + description);
            Console.WriteLine("list of products in this category:");
            int i = 1;
            foreach (var item in products)
            {
                //productid,prodname,qtySold,unitprice,UnitOFMeasurement, QtyInHand, ReorderLevel.
                
                Console.WriteLine(i);
                Console.WriteLine("\tproductid:"+item.productid);
                Console.WriteLine("\tproductname:" + item.productname);
                Console.WriteLine("\tqtySold:" + item.qtysold);
                Console.WriteLine("\tunitprice:" + item.unitprice);
                Console.WriteLine("\tUnitOFMeasurement:" + item.unitofmeasurement);
                Console.WriteLine("\tQtyInHand:" + item.QtyInHand);
                Console.WriteLine("\tReorderLevel:" + item.ReorderLevel);
                i++;
            }

        }
        
    }
   
}
