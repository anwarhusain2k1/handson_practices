using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Bookcategory
    {
        public int categoryid { get; set; }
        public string categoryname { get; set; }
        public string description { get; set; }

        Bookcategory()
        {

        }
        Bookcategory(int categoryid, string categoryname, string description)
        {
            this.categoryid = categoryid;
            this.categoryname = categoryname;
            this.description = description;
        }
    }
}
