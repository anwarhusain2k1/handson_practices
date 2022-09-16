using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLasses
{
    [Serializable()]
    public class Customer
    {
        public int Id { get; set; }
        public string password { get; set; }
        public bool loginstatus { get;private set; }
        public DateTime date = DateTime.Now;
        public void validateuser(Customer customer)
        {
            if (customer.password == customer.Id + "password")
            {
                loginstatus = true;
            }
            else
            {
                loginstatus = false;
            }
        }
    }
}
