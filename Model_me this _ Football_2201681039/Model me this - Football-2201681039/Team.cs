using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_me_this___Football_2201681039
{
	public class Team
	{
		private const int Min = 11;
		private const int Max = 22;
		public Coach Coach { get; set; }
		public FootballPlayer[] FootballPlayers 
		{
			get { return FootballPlayers; }
			set
			{
				FootballPlayers = value;
				if (value.Length<Min||value.Length>Max)
				{
					throw new Exception($"Броя на играчите е невалиден! Трябва да бъде между {Min} и {Max}");
				}
				FootballPlayers = value;
			}
		}
		public double AverageAge
		{
			get
			{
				int totalAge = 0;
				foreach (FootballPlayer player in FootballPlayers)
				{
					totalAge += player.Age;
				}
				return totalAge / FootballPlayers.Length;
			}
		}
	}
	
}
