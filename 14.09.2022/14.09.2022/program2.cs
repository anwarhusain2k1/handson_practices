using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLasses;

namespace _14._09._2022
{
    internal class program2
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();
            Movie movie1 = new Movie();
            Movie movie2 = new Movie();
            movie1.moviename = "ads";
            movie1.language = "englsih";
            movie1.genre = "action";
            movie1.count = 2;
            movie1.cost = 12;
            movies.Add(movie1);
            //movie1.addmovie(movie1);
            movie1.moviename = "sdd";
            movie1.language = "englsih";
            movie1.genre = "action";
            movie2.count = 2;
            movie2.cost = 12;
            movies.Add(movie2);
            Movie movie = new Movie();
            Console.WriteLine("enter language filter");
            string l = Console.ReadLine();
            movie.searchbylanguage(l);
            Console.ReadLine();

        }
    }
}
