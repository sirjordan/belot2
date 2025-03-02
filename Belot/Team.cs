namespace Belot
{
	public class Team
	{
		public Tuple<Player, Player> Players { get; set; }

		public Team(Player p1, Player p2)
		{
			Players = new Tuple<Player, Player>(p1, p2);
		}
	}
}
