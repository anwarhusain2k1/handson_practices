using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public abstract void work();
    }
    public class Employee : Person
    {
        public override void work()
        {
            base.Description = "employee";
            Console.WriteLine("employee");
        }
    }
    public class Manager : Person
    {
        public override void work()
        {
            base.Description = "manager";
            Console.WriteLine("manager");
        }
    }

    public class Clerk : Person
    {
        public override void work()
        {
            base.Description = "clerk";
            Console.WriteLine("clerk");
        }
    }

}
