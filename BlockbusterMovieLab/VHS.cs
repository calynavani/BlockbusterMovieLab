using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterMovieLab
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }


        public VHS()
        {
        }
            

        public int Play()
        {

        }

        public void Rewind()
        {
            CurrentTime = 0;
        }
    }
}
