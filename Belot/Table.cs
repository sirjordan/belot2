namespace Belot
{
	public class Table
	{
		private Deck _deck;
		private Team _leftRight;
		private Team _topBottom;

		public IReadOnlyCollection<Player> Players => [_leftRight.Players.Item1, _topBottom.Players.Item1, _leftRight.Players.Item2, _topBottom.Players.Item2];

		public Table(Team leftRight, Team topBottom, Deck deck)
		{
			_deck = deck;
			_leftRight = leftRight;
			_topBottom = topBottom;
		}

		public void DrawInit()
		{
			DrawCards(3);
			DrawCards(2);
		}

		public void DrawAfter()
		{
			DrawCards(3);
		}

		private void DrawCards(int num)
		{
			foreach (var p in Players)
			{
				p.Cards.AddRange(_deck.Draw(num));
			}
		}
	}
}
