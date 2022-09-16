using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace movie_rental
{
    
    public class Customer
    {
        public string customername { get; set; }
        public int phone_no { get; set; }
        public enum sub
        {
            silver = 2,
            gold = 3,
            platinum = 5
        }
        public string subcription { get; set; }
        public string password { get; set; }
        
        public static List<Customer> list = new List<Customer>();


    }
    public class Admin:Movie
    {
        
        public void addcustomer(Customer customer)
        {
            list.Add(customer);
        }
        
    }
}
