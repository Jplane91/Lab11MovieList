using System;
namespace Lab11
{
    public class Prompt
    {

        public static void WelcomeUser()
        {
            Console.WriteLine("Welcome to the Movie Database");
        }

        public static int ListGenres()
        {
            Console.WriteLine("\nWhich genre would you like?\n1.Drama\n2.Thriller" +
                "\n3.Sci-Fi\n4.Romance\n5.Quit"); //List, Add, Delete, Completed, Quit
            int userChoosesGenre = int.Parse(Console.ReadLine());
            if (userChoosesGenre > 0 && userChoosesGenre < 6)
            {
                return userChoosesGenre;
            }

            else
            {
                Console.WriteLine("Invalid option, please choose again");
                int loop = ListGenres();
                return ListGenres();
            }


        }

        public static bool AskToContinue()
        {
            Console.WriteLine("Which you like to continue? (yes or no)");
            string continueResponse = Console.ReadLine().ToLower();
            if(continueResponse == "yes")
            {
                return true;
            }

            else if(continueResponse == "no")
            {
                Console.WriteLine("Have a good day!");
                return false;
            }
            else
            {
                Console.WriteLine("Not a valid response");
                AskToContinue();   
            }

            return true;
        }

    }
}
