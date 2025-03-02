namespace Belot
{
    public class Deck
    {
        public Stack<Card> Cards { get; private set; }

        public Deck()
        {
            var allCards = CreateCards();
			Cards = new Stack<Card>(Shuffle(allCards));
        }

        public IEnumerable<Card> Draw(int num)
        {
            for (int i = 0; i < num; i++)
            {
                yield return Cards.Pop();
			}
		}

        private IEnumerable<Card> Shuffle(IEnumerable<Card> cards)
        {
            return cards.OrderBy(_ => Guid.NewGuid());
        }

        private IEnumerable<Card> CreateCards()
        {
            foreach (var color in Color.All)
            {
                foreach (var num in Number.All)
                {
                    yield return new Card(num, color);
                }
            }
        }
    }
}
