using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterMovieLab
{
    class Blockbuster
    {

        List<string> scenes = new List<string>();
       


        List<Movie> movies = new List<Movie>();


        Movie movie1 = new Movie("The Little Rascals", "Comedy", 60 );
        Movie movie2 = new Movie("Inception", "Drama", 60 );
        Movie movie3 = new Movie("Charlie's Angle", "Action", 60 );
        Movie movie4 = new Movie("i Robot", "Action", 60 );
        Movie movie5 = new Movie("Guess Who", "Comedy", 60 );
        Movie movie6 = new Movie("Django", "Drama", 60 );
   
        public Blockbuster()
        {
       
        }

        public void Add(Movie movie1)
        {

        }

        public void PrintMovies()
        {
            for(int i = 0; i < movies.Count; i++)
            {
                Console.WriteLine(i);
            }
        }

        public string CheckOut()
        {
            PrintMovies();
            Console.Write("Which movie would you like to check out? ");
            int userAnswerIndex = int.Parse(Console.ReadLine());
            

            return "test";
        }



    }
}

   
