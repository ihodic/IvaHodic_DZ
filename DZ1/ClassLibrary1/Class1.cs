using System;

namespace ClassLibrary1
{
	public class Episode
	{
			public int viewers;
			public double totalScore;
			public double maxScore;
			double max = 0;

			public Episode(int aViewers, double aTotalScore, double aMaxScore)
			{
				viewers = aViewers;
				totalScore = aTotalScore;
				maxScore = aMaxScore;
			}

			public Episode()
			{
			}


			public void AddView(double aScore)
			{
				double score = aScore;
				totalScore += score;
				if (score > max)
				{
					max = score;
				}
			}
			public double GetMaxScore()
			{
				return max;
			}

			public double GetAverageScore()
			{
				return totalScore / viewers;
			}


			public double GetViewerCount()
			{
				return 10;
			}
		}
}
