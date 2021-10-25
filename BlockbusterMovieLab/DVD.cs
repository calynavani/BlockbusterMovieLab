using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterMovieLab
{
    class DVD: Movie
    {
        public DVD(string title, string category, int runTime, List<string> scenes): base(title, category,runTime)
        {

        }
        public override void Play()
        {
            Console.WriteLine($"What scene of would you like to watch? ");
            

            
        }
    }
}
