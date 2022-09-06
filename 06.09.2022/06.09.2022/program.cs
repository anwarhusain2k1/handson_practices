using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using person;

namespace _06._09._2022
{
    internal class program
    {
        static void Main(string[] args)
        {
            Clerk clerk = new Clerk();
            clerk.work();
            Manager manager = new Manager();
            manager.work();
            Employee employee = new Employee();
            employee.work();
            Console.ReadLine();
        }
    }
}
