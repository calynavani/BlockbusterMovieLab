using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterMovieLab
{
   class Movie
    {
        public string Title { get; set; }

        public string Category { get; set; }
        public int RunTime { get; set; }

        public List<string> Scenes = new List<string>();

        public Movie(string title, string category, int runTime, List<string> scenes)
        {
            this.Title = title;
            this.Category = category;
            this.RunTime = runTime;
            this.Scenes = scenes;
            
        }


        string drama, comedy, horror, romance, action; 
        public override string ToString()
        {
            string output = $"Title: {Title}";

            return output;
        }

        public void PrintScenes(List<string> scenes)
        {
          foreach(string s in scenes)
            {
                Console.WriteLine(s);
            }
        }

        public virtual void Play()
        {

        }
    }
}
