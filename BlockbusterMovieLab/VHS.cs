using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterMovieLab
{
    class VHS : Movie
    {

        public int CurrentTime { get; set; }


        public VHS(int currenttime,string title, string category, int runTime, List<string> scenes): base(title, category, runTime)
        {

            this.CurrentTime = currenttime;
        }


            

        public override void Play()
        {
            CurrentTime++;
        }

        public void Rewind()
        {
            CurrentTime = 0;
        }
    }
}
