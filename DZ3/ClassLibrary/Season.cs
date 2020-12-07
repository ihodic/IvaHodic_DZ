using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ClassLibrary
{
    public class Season
    {
        public int index;
        public Episode[] episodes;

    public Season(int index, Episode[] episodes)
        {
            this.index = index;
            this.episodes = episodes;
        }

        public Episode this[int episodeIndex]
        {
            get { return episodes[episodeIndex]; }
            set { episodes[episodeIndex] = value; }
        }

        public void AllocateMemory()
        {
            Episode[] episode = new Episode[10];
            for(int i = 0; i < 10; i++)
            {
                episode[i] = new Episode();
            }
        }

        public override string ToString()
        {
            return $"Episode: {index}., {episodes}";
        }


    }
}
