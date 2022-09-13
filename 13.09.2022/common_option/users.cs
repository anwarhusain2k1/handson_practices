using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using movie_rental;

namespace common_option
{
    public class users:Customer
    {
        public void resetpassword( Customer customer)
        {
            Console.WriteLine("enter your new password");
            customer.password = Console.ReadLine();
        }
        public void viewdetails( int phonenumber)
        {
            foreach (var item in list)
            {
                if (item.phone_no==phonenumber)
                {
                    Console.WriteLine("customer name :"+item.customername);
                    Console.WriteLine("customer subcription :"+item.subcription);
                }
            }
        }
        
    }
}
