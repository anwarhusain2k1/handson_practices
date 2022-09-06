using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person
{
    internal class bank
    {
    }
    interface IBank
    {
        
        void printbalance();
        void calculateinterest();
        
    }
    public class Saving : IBank
    {
        public double balance = 10000;
        public double deposit;
        public void printbalance()
        {
            Console.WriteLine("account balance:"+balance);
        }
        public void calculateinterest()
        {
            double i = balance + ((deposit * 0.4)/100);
            balance = i;
            Console.WriteLine("balance with interest:"+ balance);
        }
    }
    public class Current : IBank
    {
        public double balance = 10000;
        public double deposit ;
        public void printbalance()
        {
            Console.WriteLine("account balance:" + balance);
        }
        public void calculateinterest()
        {

            double i = balance + ((deposit * 0.2) / 100);
            balance = i;
            Console.WriteLine("balance with interest:" + balance);
        }
    }
}
