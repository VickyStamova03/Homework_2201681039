using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_me_this___Football_2201681039
{
	public class Program
	{
		static void Main(string[] args)
		{
			FootballPlayer player1 = new FootballPlayer { Name = "Vasil", Age = 22, Height = 1.84, Number = 5 };
			FootballPlayer player2 = new FootballPlayer { Name = "Alex", Age = 25, Height = 1.90, Number = 10 };
			FootballPlayer player3 = new FootballPlayer { Name = "Boris", Age = 28, Height = 1.75, Number = 2 };
			FootballPlayer player4 = new FootballPlayer { Name = "Martin", Age = 19, Height = 1.89, Number = 6 };

			Coach coach1 = new Coach { Name = "Petar", Age = 50 };
			Coach coach2 = new Coach { Name = "Ivan", Age = 43 };

			Team team1 = new Team { Coach = coach1, FootballPlayers = new FootballPlayer[] { player1, player2 } };
			Team team2 = new Team { Coach = coach2, FootballPlayers = new FootballPlayer[] { player3, player4 } };


			Referee referee1 = new Referee { Name = "Referee1", Age = 30 };
			Referee referee2 = new Referee { Name = "Referee2", Age = 31 };

			Goal goal1 = new Goal { Minute = 20, Player = player1 };


			Game game = new Game(team1,team2,referee1,referee2)
			
		}
	}
}
