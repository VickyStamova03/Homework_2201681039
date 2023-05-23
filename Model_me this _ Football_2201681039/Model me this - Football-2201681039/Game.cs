using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_me_this___Football_2201681039
{
	public class Game
	{
		private const int RequiredPlayers = 11;
		public Team[] Team1
		{
			get { return Team1; }
			set
			{
				if (value.Length!=RequiredPlayers)
				{
					throw new Exception($"Броя на играчите трябва да е {RequiredPlayers}!");
				}
				Team1 = value;
			}
		}

		public Team[] Team2
		{
			get { return Team2; }
			set
			{
				if (value.Length != RequiredPlayers)
				{
					throw new ArgumentException($"Броя на играчите трябва да е {RequiredPlayers}!");
				}
				Team2 = value;
			}
		}

		public Referee Referee { get; set; }
		public Referee SecondReferee { get; set; }
		public Goal[] Goals { get; set; }
		public double GameResult { get; set; }
		public Team Winner { get; set; }
	}
}
