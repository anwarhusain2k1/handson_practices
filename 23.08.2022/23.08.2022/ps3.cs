using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._08._2022
{
    internal class ps3
    {
        static void Main(string[] args)
        {
            Employee emp;
            Console.WriteLine("enter employee number");
            emp.empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter employee name");
            emp.name = Console.ReadLine();
            Console.WriteLine("enter salary");
            emp.salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter department number");
            emp.depno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("employee.id:"+emp.empno);
            Console.WriteLine("employee name :"+emp.name);
            Console.WriteLine("employee salary :"+emp.salary);
            Console.WriteLine("dept number:"+emp.depno);
            Console.Read();

        }

        struct Employee
        {
            public int empno;
            public string name;
            public int salary;
            public int depno;

            
        }
    }
}