using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using movie_rental;
using common_option;

namespace program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin();
            admin.customername = "adc";
            admin.phone_no = 9452;
            admin.addcustomer(admin); 
            Console.WriteLine();
            Movie movie = new Movie();
            movie.moviename="abc";
            movie.count = 2;
            movie.addmovie(movie);
            movie.display();
            Console.Read();
        }
    }
}
