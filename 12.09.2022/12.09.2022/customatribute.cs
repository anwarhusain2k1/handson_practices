using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._09._2022
{
    [System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    class streodisc : Attribute
    {
        // See the attribute guidelines at 
        //  http://go.microsoft.com/fwlink/?LinkId=85236
        readonly string positionalString;

        // This is a positional argument
        public streodisc(string name, string language, string lyrics)
        {
            //this.positionalString = positionalString;

            // TODO: Implement code here
            this.songname = name;
            this.language = language;
            this.lyrics = lyrics;
        }
        public string songname { get; set; }
        public string language { get; set; }
        public string lyrics { get; set; }
       
        // This is a named argument
        
    }
    [streodisc("abc", "abc", "abc")]
    public class song
    {
        [streodisc("bbc", "bbc", "bbc")]
        public int Prodid { get; set; }
        public string Prodname { get; set; }
        public void products(int pid, string pname)
        {
            Prodid = pid;
            Prodname = pname;
        }
    }
    
}
