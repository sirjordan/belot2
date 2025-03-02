namespace Belot
{
	public class Player
	{
		public string Name { get; private set; }
		public List<Card> Cards { get; private set; }

		public Player(string name)
		{
			Name = name;
			Cards = new List<Card>();
		}
	}
}
