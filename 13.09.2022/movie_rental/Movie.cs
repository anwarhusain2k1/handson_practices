using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movie_rental
{
    public class Movie:Customer
    {
        public string moviename { get; set; }
        public string language { get; set; }
        public string genre { get; set; }
        public int count{ get; set; }
        public  int cost { get; set; }
        List<Movie> movies { get; set; }

        public void addmovie(Movie movie)
        {
            movies.Add(movie);
        }

        public void deletemovie(string name)
        {
            foreach (Movie movie in movies)
            {
                if(movie.moviename == name)
                    movies.Remove(movie);
            }
        }
        public void login(string unmae,string password)
        {
            if(password != null)
            {
                display();
            }

        }
        public void display()
        {
            foreach (var movie in movies)
            {
                if (movie.count > 0)
                {
                    Console.WriteLine("moviename : " + movie.moviename);
                    Console.WriteLine("language : " + movie.language);
                    Console.WriteLine("genre : " + movie.genre);
                }
            }
        }

        public void searchbylanguage(string l)
        {
            foreach (var item in movies)
            {
                if(item.language == l)
                {
                    if (item.count > 0)
                    {
                        Console.WriteLine("moviename : " + item.moviename);
                        Console.WriteLine("genre : " + item.genre);
                    }
                }
            }
        }

        public void searchbygenre(string l)
        {
            foreach (var item in movies)
            {
                if (item.genre == l)
                {
                    if (item.count > 0)
                    {
                        Console.WriteLine("moviename : " + item.moviename);
                        Console.WriteLine("language : " + item.language);
                    }
                }
            }
        }

        public string rent(string n,Customer customer)
        {
            int flag = 0;
            foreach (var item in movies)
            { 
                if (item.moviename == n)
                {
                    if (item.count > 0)
                    {
                        item.count--;
                        Console.WriteLine("movie rented");
                        flag = 1;
                    }
                    
                }
            }
            if (flag == 0)
            {
                return "not available";
            }
            else { return "rented"; }
        }

        public void returnmovie(DateTime days, string name)
        {
            foreach (var item in movies)
            {
                if (item.moviename == name)
                {
                    item.count++;
                    double bill = days.Day * (item.cost*0.10) + (0.18*item.cost);
                    Console.WriteLine("your bill for {0} days : {1}", days.Day, bill);
                }   
            }     
        }






    }
    
   

}
