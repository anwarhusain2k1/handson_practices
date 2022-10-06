using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _06._10._2022
{
    public class Product
    {
        [Required()]
        public int proid { get; set; }
        [MaxLength(20)]
        [MinLength(2)]
        public string product_name { get; set; }
        [DisplayFormat(DataFormatString ="{dd-mm-yyyy}",ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime mfg { get; set; }
    }
}