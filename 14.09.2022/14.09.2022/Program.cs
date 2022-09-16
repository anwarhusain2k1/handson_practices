using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLasses;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.SqlServer.Server;

namespace _14._09._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.Id = 123456789;
            c1.password = 123456789 + "password";
            c1.validateuser(c1);
            binaryserialization(c1);

        }
        private static  void binaryserialization(Customer c1)
        {
            
            c1.Id = 123456789;
            c1.password = 123456789 + "password";
            c1.validateuser(c1);
            FileStream fs = new FileStream(@"userfile.bin",FileMode.Create,FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, c1);
            fs.Flush();
            fs.Close();
            fs.Dispose();
        }
        
    }
}
