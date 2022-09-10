using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._09._2022
{
    public delegate void handler(Employee emp);
    public delegate void display();
    class employeeoperation :EventArgs
    {
        public static event handler add;
        public static event handler delete;
        public static event handler update;
        public static List<Employee> employees=new List<Employee>();
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.WriteLine("enter username");
            string uname = Console.ReadLine();
            Console.WriteLine("enter password");
            string password = Console.ReadLine();
            
            Action<string, string> checkcredentials = (u, p) =>
            {
                if (u != ""  && p != "" && p == "password")
                {
                    Console.WriteLine("U are logged in successfully");
                }
                else
                {
                    Console.WriteLine("Pls check userid/pwd");
                }
            }; checkcredentials(uname, password);
            add += new handler(insert);
            delete += new handler(remove);
            update += new handler(edit);
            
            while(true)
            {
                Console.WriteLine("select the operation:\n1.Add \n2.Update \n3.Delete \n0.exit");
                int a=Convert.ToInt32(Console.ReadLine());
                if(a==0)
                    break;
                else
                switch (a)
                {
                    case 1:add(emp);
                        break;
                    case 2:
                            Console.WriteLine("enter employee id you want to update");
                            Employee emp1 = new Employee();
                            emp1.employeeid = Convert.ToInt32(Console.ReadLine());
                        update(emp1);
                        break;
                    case 3:
                            Console.WriteLine("enter employee id you want to update");
                            Employee emp2 = new Employee();
                            emp2.employeeid = Convert.ToInt32(Console.ReadLine());
                            delete(emp2);
                        break;
                    default: Console.WriteLine("invslid option");
                        break;
                }
            }

            display del = new display(display);
            del();
            Console.ReadLine();
        }
        static void display()
        {
            foreach (var item in employees)
            {
                Console.WriteLine(item.employeename);
                Console.WriteLine(item.deptno);

            }

        }
        static void insert(Employee emp)
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
            Console.WriteLine("enter dept number");
            employee.deptno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter dept name");
            employee.dname = Console.ReadLine();
            Console.WriteLine("enter location");
            employee.location = Console.ReadLine();
            employees.Add(employee);
            Console.WriteLine("employee added_____________________");
        }
        static void remove(Employee emp)
        {
            Employee employee = employees.Find(y => y.employeeid == emp.employeeid);
            employees.Remove(employee);
            Console.WriteLine("employee romoved___________________"); 
        }
        static void edit(Employee emp)
        {
            Employee employee = employees.Find(y => y.employeeid == emp.employeeid);
            Console.WriteLine("enter new details of employee ");
            Console.WriteLine("enter employeeid");
            employee.employeeid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter employee name");
            employee.employeename = Console.ReadLine();
            Console.WriteLine("enter manager name");
            employee.manager = Console.ReadLine();
            Console.WriteLine("enter salary");
            employee.salary = Convert.ToInt32(Console.ReadLine());
            employees.Add(employee);
            Console.WriteLine("enter dept number");
            employee.deptno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter dept name");
            employee.dname = Console.ReadLine();
            Console.WriteLine("enter location");
            employee.location = Console.ReadLine();
            employees.Add(employee);
            Console.WriteLine("employee updated____________________");
        }
    }
}
