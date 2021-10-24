using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterMovieLab
{
    class Blockbuster
    {
         List<Movie> movies = new List<Movie>()
         {
             "Save The Last Dance",
             "Honey",

         }
       
     
         public Blockbuster()
        {

        }

        public void PrintMovies()
        {

        }

        public string CheckOut()
        {
            PrintMovies();
            Console.Write("Which movie would you like to check out? ");

            
        }


      
    }
}

   
