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
        public string subcription { get; set; }
        public string password { get; set; }
        public List<Customer> list = new List<Customer>();


    }
    public class Admin:Movie
    {
        
        public void addcustomer(Customer customer)
        {
            list.Add(customer);
        }
        
    }
}
