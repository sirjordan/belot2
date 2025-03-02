namespace Belot
{
    public class Deck
    {
        public Stack<Card> Cards { get; private set; }

        public Deck()
        {
            var allCards = GetAllCards();
            Cards = new(ShuffleCards(allCards));
        }

        private IEnumerable<Card> ShuffleCards(IEnumerable<Card> cards)
        {
            return cards.OrderBy(_ => Guid.NewGuid());
        }

        private IEnumerable<Card> GetAllCards()
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
