using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._08._2022
{
    internal class ps4
    {
        static void Main(string[] args)
        {
             
            Console.WriteLine("enter employee number");
            int empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter employee name");
            string name = Console.ReadLine();
            Console.WriteLine("enter salary");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter department number");
            int depno = Convert.ToInt32(Console.ReadLine());
            Employee emp = new Employee(empno, name, salary, depno);
            emp.display();
            


        }

        struct Employee
        {
            public int empno;
            public string name;
            public int salary;
            public int depno;

            public Employee(int empno, string name, int sal, int dno)
            {
                this.empno = empno;
                this.name = name;
                this.salary = sal;
                this.depno = dno;
            }

            public void display()
            {
                Console.WriteLine("employee.id:" + empno);
                Console.WriteLine("employee name :" + name);
                Console.WriteLine("employee salary :" + salary);
                Console.WriteLine("dept number:" + depno);
                Console.ReadLine();
            }
            
        }
        
    }
}