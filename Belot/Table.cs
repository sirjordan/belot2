using static Belot.Mode;

namespace Belot
{
	public class Table
	{
		private Deck _deck;
		private Team _leftRight;
		private Team _topBottom;
		private Queue<Player> _players;

		public Player? CurrentPlayer { get; private set; }
		public Mode Mode { get; private set; }
		public Player? Voter { get; private set; }
		public IReadOnlyCollection<Player> Players => _players;

		public Table(Team leftRight, Team topBottom, Deck deck)
		{
			_deck = deck;
			_leftRight = leftRight;
			_topBottom = topBottom;
			_players = new Queue<Player>([leftRight.Players.Item1, topBottom.Players.Item1, leftRight.Players.Item2, topBottom.Players.Item2]);
			CurrentPlayer = null;
			Mode = new Mode();
		}

		public void DrawInit()
		{
			// check if game is initial
			DrawCards(3);
			DrawCards(2);
		}

		public TrumpSetup SetTrump(Player p)
		{
			Voter = p;

			return Mode.SetTrump();
		}

		public void DrawAfter()
		{
			// check if there is trump 
			DrawCards(3);
		}

		public void GameStart()
		{
			// check if there is trump 
			// check if all cards are drawn
			// reset queue and current player
		}

		public Player NextPlayer()
		{
			var next = _players.Dequeue();
			CurrentPlayer = next;
			_players.Enqueue(next);

			return next;
		}

		public void Play(Player p, Card c)
		{
		}

		public void Announce(Player p, object announce)
		{
			// Belot, 4 of a kind, 50, 100 etc
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
