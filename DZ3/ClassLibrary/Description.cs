using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Description
    {
        private int episodeNumber;
        private TimeSpan episodeLength;
        private string episodeName;


        public int EPISODENUMBER { get => episodeNumber; set => episodeNumber = value; }
        public TimeSpan EPISODELENGTH { get => episodeLength; set => episodeLength = value; }
        public string EPISODENAME { get => episodeName; set => episodeName = value; }

        public Description(int aEpisodeNumber, TimeSpan aEpisodeLength, string aEpisodeName)
        {
            episodeNumber = aEpisodeNumber;
            episodeLength = aEpisodeLength;
            episodeName = aEpisodeName;
        }



    }
}