using System;
using System.Collections.Generic;

namespace Mockbuster_Midterm
{
    public class MoviesRepo
    {
        public static List<Movie> GetMovies()
        {
            List<Movie> movies = new List<Movie>()
             {
                 new Movie("National Treasure", "Nicolas Cage", "Action", "Jon Turteltaub"),
                 new Movie("The Sorcerer's Apprentice", "Nicolas Cage", "Fantasy", "Jon Turteltaub"),
                 new Movie("Transformers", "Shia LaBeouf", "Sci-Fi", "Michael Bay"),
                 new Movie("Dreams", "Martin Scorsese", "Drama", "Akira Kurosawa")

             };
         return movies;
        }
    }
    public class Movie
    {
        public string MovieName;
        public string MainActor;
        public string Genre;
        public string Director;
        
        public Movie(string moviename_, string mainactor_, string genre_, string director_)
        {
            MovieName = moviename_;
            MainActor = mainactor_;
            Genre = genre_;
            Director = director_;
        }
        public override string ToString()
        {
            return $"Movie Name: {MovieName}, Main Actor:{MainActor}, Genre:{Genre} Director: {Director}";
        }

    }
    public class User
    {

    }
    public class Admin : User
    {
        public static List<Movie> Addmovie()
        {
            Console.WriteLine("Enter Movie Name:");
            string movieName = Console.ReadLine();
            Console.WriteLine("Enter Main Actor:");
            string movieActor = Console.ReadLine();
            Console.WriteLine("Enter Genre of movie:");
            string movieGenre = Console.ReadLine();
            Console.WriteLine("Enter Director of movie:");
            string movieDirector = Console.ReadLine();
            Movie newmovie = new Movie($"{ movieName }", $"{movieActor}", $"{movieGenre}", $"{movieDirector}");

            return MoviesRepo.GetMovies().Add(newmovie);
            
            
        }
        public static void RemoveMovie()
        {
            Console.WriteLine("Enter the name of the movie you would like to remove:");
            string removname = Console.ReadLine();

            foreach (Movie movcheck in MoviesRepo.GetMovies())
            {
                if (removname == movcheck.MovieName)
                {
                    MoviesRepo.GetMovies().Remove(movcheck);
                }
                else
                {
                    Console.WriteLine("Apologies this movie does not exist");
                }
            }

        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Admin.Addmovie();
            foreach (Movie nextmov in MoviesRepo.GetMovies())
            {
                Console.WriteLine($"{nextmov.ToString()}");
            }
            
        }
    }
}
