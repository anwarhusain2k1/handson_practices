using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace _12._09._2022
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.LoadFile(@"D:\c#\12.09.2022\calculator\bin\Debug\calculator.dll");
            Type type = assembly.GetType("calculator.operation");
            object calcInstance = Activator.CreateInstance(type);
            PropertyInfo numberpropertinfo = type.GetProperty("number");
            numberpropertinfo.SetValue(calcInstance, 4.0 , null);
            MethodInfo myMethodInfo = type.GetMethod("cube");
            myMethodInfo.Invoke(calcInstance,new object[1] {4.0});

            MethodInfo myMethodInfo1 = type.GetMethod("squaroot");
            myMethodInfo1.Invoke(calcInstance, new object[1] { 4.0 });

            Console.ReadLine();
        }
    }
}
