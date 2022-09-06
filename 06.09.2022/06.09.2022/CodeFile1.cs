using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using person;

namespace _06._09._2022
{
    public static class xx
    {
        public static void withdraw(this Saving saving, int amount)
        {
            saving.balance = saving.balance - amount; Console.WriteLine("withrawn amount :"+amount);
            Console.WriteLine("account balance:"+saving.balance);
        }
        public static void withdraw(this Current current, int amount)
        {
            current.balance = current.balance - amount; Console.WriteLine("withrawn amount :" + amount);
            Console.WriteLine("account balance:" + current.balance);
        }

        public static void deposit(this Saving saving,int amount)
        {
            saving.deposit = amount;
        }
        public static void deposit(this Current current, int amount)
        {
            current.deposit = amount;

        }
    }
    internal class CodeFile1
    {
        
        static void Main(string[] args)
        {            
            Console.WriteLine("enter your account type \n 1.Saving \n2.current");
            int a = Convert.ToInt32(Console.ReadLine());
            int amount;
            if (a ==1)
            {
                Saving saving = new Saving();
                Console.WriteLine("\n 1.Withdraw \n 2.Deposit");
                int b = Convert.ToInt32(Console.ReadLine());
                
                switch(b)
                {
                    case 1:
                        Console.WriteLine("enter amount to withdraw");
                        amount = Convert.ToInt32(Console.ReadLine());
                        saving.withdraw(amount);
                        break;
                    case 2:
                        Console.WriteLine("enter the ammount to deposit");
                        amount = Convert.ToInt32(Console.ReadLine());
                        saving.deposit(amount);
                        break;
                }
          
            }else if(a==2)
            {
                Current current = new Current();
                Console.WriteLine("\n 1.Withdraw \n 2.Deposit");
                int b = Convert.ToInt32(Console.ReadLine());

                switch (b)
                {
                    case 1:
                        Console.WriteLine("enter amount to withdraw");
                        amount = Convert.ToInt32(Console.ReadLine());
                        current.withdraw(amount);
                        break;
                    case 2:
                        Console.WriteLine("enter the ammount to deposit");
                        amount = Convert.ToInt32(Console.ReadLine());
                        current.deposit(amount);
                        break;
                }
            }
            Console.ReadLine();
        
        }
    }
}