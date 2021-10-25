using System;
using System.Collections.Generic;

namespace BlockbusterMovieLab
{
    class Program
    {
        static void Main(string[] args)
        {
             
            List<string> Scenes = new List<string>();
           
            Blockbuster blockbuster = new Blockbuster();

            List<Movie> movies = new List<Movie>();


            Movie movie1 = new Movie("The Little Rascals", "Comedy", 60);
            Movie movie2 = new Movie("Inception", "Drama", 60);
            Movie movie3 = new Movie("Charlie's Angle", "Action", 60);
            Movie movie4 = new Movie("i Robot", "Action", 60);
            Movie movie5 = new Movie("Guess Who", "Comedy", 60);
            Movie movie6 = new Movie("Django", "Drama", 60);


            Console.WriteLine("Welcome to My Blockbuster!");
            Console.WriteLine();
            Console.Write("Please Select a Movie from the list: ");
            blockbuster.PrintMovies();
            Console.WriteLine();
            Console.Write("Please select a movie you want to watch: ");
            int userMovieChoice = int.Parse(Console.ReadLine());
            switch (userMovieChoice)
            {
                case 1:
                    Console.WriteLine(movie1.ToString());

                    break;
                case 2:
                    Console.WriteLine(movie2.ToString());
                    break;
                case 3:
                    Console.WriteLine(movie3.ToString());
                    break;
                case 4:
                    Console.WriteLine(movie4.ToString());
                    break;
                case 5:
                    Console.WriteLine(movie5.ToString());
                    break;
                case 6:
                    Console.WriteLine(movie6.ToString());
                    break;



                       
                   
            }
            blockbuster.CheckOut();
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
