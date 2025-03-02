namespace Belot
{
	public class Color
	{
		public string Name { get; private set; }
		public int Rank { get; private set; }

		private Color(string name, int rank)
		{
			Name = name;
			Rank = rank;
		}

		public static Color Clubs => new("Clubs", 1);
		public static Color Diamonds => new("Diamonds", 2);
		public static Color Hearts => new("Hearts", 3);
		public static Color Spades => new("Spades", 4);
		public static Color[] All => [Clubs, Diamonds, Hearts, Spades];

		public static bool operator ==(Color a, Color b) => a.Rank == b.Rank;
		public static bool operator !=(Color a, Color b) => a.Rank != b.Rank;
		public static bool operator >(Color a, Color b) => a.Rank > b.Rank;
		public static bool operator <(Color a, Color b) => a.Rank < b.Rank;
	}
}

