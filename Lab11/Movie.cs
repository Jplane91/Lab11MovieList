using System;
using System.Collections.Generic;

namespace Lab11
{
    public class Movie
    {
        private string title;
        private string genre;

        public string Title { get; set; }
        public string Genre { get; set; }

        public Movie (string title, string genre)
        {
            this.Title = title;
            this.Genre = genre;
        }


        public void PrintMovies(List<Movie> movie)
        {
            int genrePicked = Prompt.ListGenres();
            if (genrePicked == 1)
            {
                Console.WriteLine("\tDRAMA");
                PrintDramas(movie);
            }

            else if (genrePicked == 2)
            {
                Console.WriteLine("\tTHRILLER");
                PrintThriller(movie);
            }

            else if (genrePicked == 3)
            { 
                Console.WriteLine("\tSCI-FI");
                PrintSciFi(movie);
            }

            else if (genrePicked == 4)
            {
                Console.WriteLine("\tROMANCE");
                PrintRomance(movie);
            }
        }

        public static void PrintDramas(List<Movie> movies)
        {
            
            foreach(Movie item in movies)
            {
                if (item.Genre == "Drama")
                {
                    Console.WriteLine("\t" + item.Title);
                }
            }

        }

        public static void PrintThriller(List<Movie> movies)
        {

            foreach (Movie item in movies)
            {
                if (item.Genre == "Thriller")
                {
                    Console.WriteLine("\t" + item.Title);
                }
            }

        }

        public static void PrintSciFi(List<Movie> movies)
        {

            foreach (Movie item in movies)
            {
                if (item.Genre == "Sci-Fi")
                {
                    Console.WriteLine("\t" +item.Title);
                }
            }

        }

        public static void PrintRomance(List<Movie> movies)
        {

            foreach (Movie item in movies)
            {
                if (item.Genre == "Romance")
                {
                    Console.WriteLine("\t" + item.Title);
                }
            }

        }


    }
}
