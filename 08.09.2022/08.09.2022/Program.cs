using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._09._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number of departments");
            int a=Convert.ToInt32(Console.ReadLine());
            Department[] department = new Department[a];
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < a; i++)
            {
                department[i] = new Department();
                Console.WriteLine("enter dept number");
                department[i].deptno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter dept name");
                department[i].dname=Console.ReadLine();
                Console.WriteLine("ente location");
                department[i].location=Console.ReadLine();
                Console.WriteLine("enter number of employee in this department");
                int b = Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j < b; j++)
                {
                    
                    Employee employee = new Employee();
                    Console.WriteLine("enter employeeid");
                    employee.employeeid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter employee name");
                    employee.employeename = Console.ReadLine();
                    Console.WriteLine("enter manager name");
                    employee.manager = Console.ReadLine();
                    Console.WriteLine("enter salary");
                    employee.salary = Convert.ToInt32(Console.ReadLine());
                    employees.Add(employee);
                    employee.deptno = department[i].deptno;
                    employee.dname = department[i].dname;
                    employee.location = department[i].location;
                }
            }
            foreach (var item in employees)
            {
                Console.WriteLine(item.employeename);
                Console.WriteLine(item.deptno);

            }
            Console.ReadLine();
        }
    }
}
