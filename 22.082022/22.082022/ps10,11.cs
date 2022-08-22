using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._082022
{
    internal class ps10
    {
        static void Main(string[] args)
        {
            IDictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "One");
            numberNames.Add(3, "Three");
            numberNames.Add(2, "Two");
            
            foreach (KeyValuePair<int, string> kvp in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            Console.WriteLine("sorted by key");
            var sorted = numberNames.OrderBy(x => x.Key);
            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}