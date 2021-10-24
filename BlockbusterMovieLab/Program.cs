using System;

namespace BlockbusterMovieLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to My Blockbuster!");
            Console.WriteLine();
            Console.Write("Please Select a Movie from the list: ");
            //print out movie list
            Console.WriteLine();
            Console.Write("Please select a movie you want to watch: ");
            int userMovieChoice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //if statment to print out movie selection

            Console.Write("Do you want to watch the movie? Enter [yes] or [no]: ");
            string answer = Console.ReadLine().ToLower();
            Console.WriteLine();
            while (answer != "yes")
            {
                Console.WriteLine("That response was invalid");
                Console.Write("Please enter \"yes\" or \"no\":" );
                answer = Console.ReadLine().ToLower();

            }
            //if statment to call PrintScenes(); method



        }
    }
}
