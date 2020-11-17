using System;
using ClassDescription;


namespace ClassEpisode
{
	public class Episode
	{
		public Description description;
		public int viewers;
		public double totalScore;
		public double maxScore;
		double max = 0;

		public Episode(int aViewers, double aTotalScore, double aMaxScore, Description aDescription)
		{
			viewers = aViewers;
			totalScore = aTotalScore;
			maxScore = aMaxScore;
			description = aDescription;
		}

		public Episode(int aViewers, double aTotalScore, double aMaxScore)
		{
			viewers = aViewers;
			totalScore = aTotalScore;
			maxScore = aMaxScore;
		}

		public Episode()
		{
			viewers = 0;
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
		public override string ToString()
		{
			return $"{viewers},{totalScore},{maxScore},{description};           

		}
	}
}

