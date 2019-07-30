using System;
using System.Collections.Generic;

namespace Lab11
{
    class Program
    {

        static void Main(string[] args)
        {
            Movie newMovie = new Movie("Title", "Genre");

            List<Movie> movies = new List<Movie>
        {
          new Movie("There Will Be Blood", "Drama"),
          new Movie("One Flew Over the Cuckoo's Nest", "Drama"),
          new Movie("Paris, Texas", "Drama"),
          new Movie("12 Angry Men", "Drama"),
          new Movie("The Godfather", "Drama"),

          new Movie("2001", "Sci-Fi"),
          new Movie("Alien", "Sci-Fi"),
          new Movie("The Thing", "Sci-Fi"),
          new Movie("Blade Runner", "Sci-Fi"),
          new Movie("Interstellar", "Sci-Fi"),

          new Movie("No Country For Old Men", "Thriller"),
          new Movie("Memento", "Thriller"),
          new Movie("Mulholland Drive", "Thriller"),
          new Movie("Reservoir Dogs", "Thriller"),
          new Movie("Chinatown", "Thriller"),

          new Movie("Eternal Sushine", "Romance"),
          new Movie("Casablanca", "Romance"),
          new Movie("The Apartment", "Romance"),
          new Movie("Annie Hall", "Romance"),
          new Movie("Before Sunset", "Romance"),


        };
            

            bool loop = true;
            Prompt.WelcomeUser();

                while (loop)
                {
                    newMovie.PrintMovies(movies);
                bool cont = Prompt.AskToContinue();
                if(cont == true)
                {
                    loop = true;
                }
                else
                {
                    System.Environment.Exit(1);
                }

            }


        } 
    }
}
