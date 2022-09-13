
using System;

namespace _12._09._2022
{
    class program
    {
        static void WritedataForEachCode(Type t)
        {
            Console.WriteLine("Methods " + t.Name);

            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(t);  // Reflection.  

            // Displaying output.  
            foreach (System.Attribute attr in attrs)
            {
                if (attr is streodisc)
                {
                    streodisc a = (streodisc)attr;
                    Console.WriteLine("songname" + a.songname);
                    Console.WriteLine("language" + a.language);
                    Console.WriteLine("lyrics" + a.lyrics);
                }
            }
            
        }
        static void Main(string[] args)
        {
            program.WritedataForEachCode(typeof(song));
            Console.Read();
        }
    }
    
}