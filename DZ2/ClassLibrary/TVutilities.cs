using System;
using System.Collections.Generic;
using System.Text;
namespace ClassLibrary
{
    public class TvUtilities
    {
        double GenerateRandomScore()
        {
            Random random = new Random();
            return random.NextDouble() * (10.0);
        }
    }
    public Episode Parse(string[] aEpisode)
    {
        aEpisode = aEpisode.Split(',');
        int viewers = int.Parse(aEpisode[0]);
        double totalScore = double.Parse(aEpisode[1]);
        double maxScore = double.Parse(aEpisode[2]);
        int episodeNumber = int.Parse(aEpisode[3]);
        TimeSpan episodeLength = TimeSpan.Parse(aEpisode[4]);
        string episodeName = aEpisode[5];
        Description description = new Description(episodeNumber, episodeLength, episodeName);
        Episode episode1 = new Episode(viewers, totalScore, maxScore, description);
        return episode1;
    }
    public void BubbleSort(Episode[] aEpisode)
    {
        aEpisode episode = aEpisode;
        int i, j, temp;
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
