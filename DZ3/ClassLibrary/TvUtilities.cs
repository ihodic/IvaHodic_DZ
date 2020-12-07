using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ClassLibrary
{
    public class TvUtilities
    {
        static public Episode[] LoadEpisodesFromFile(string fileName)
        {
            string[] episodesInput = File.ReadAllLines(fileName);
            Episode[] episodes = new Episode[episodesInput.Length];
            return episodes;
        }
        static public double GenerateRandomScore()
        {
            Random random = new Random();
            return random.NextDouble() * (10.0);
        }

        public static Episode Parse(string aEpisode)
        {
            string[] episode = aEpisode.Split(',');
            int viewers = int.Parse(aEpisode);
            double totalScore = double.Parse(aEpisode);
            double maxScore = double.Parse(aEpisode);
            int episodeNumber = int.Parse(aEpisode);
            TimeSpan episodeLength = TimeSpan.Parse(aEpisode);
            string episodeName = aEpisode;
            Description description = new Description(episodeNumber, episodeLength, episodeName);
            Episode episode1 = new Episode(viewers, totalScore, maxScore, description);
            return episode1;
        }
        public static void BubbleSort(Episode[] aEpisode)
        {
            Episode[] episode = aEpisode;
            Episode temp;
            int i, j;
            for (i = 0; i < episode.Length - 1; i++)
                for (j = 0; j < episode.Length - i - 1; j++)
                    if (episode[j] > episode[j + 1])
                    {
                        temp = episode[j];
                        episode[j] = episode[j + 1];
                        episode[j + 1] = temp;
                    }
        }
    }
}
