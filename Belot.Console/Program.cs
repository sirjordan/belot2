
using Belot;

var deck = new Deck();
var clubsMode = new Mode().SetTrump().AsColor(Color.Clubs);
var diamondsMode = new Mode().SetTrump().AsColor(Color.Diamonds);
var heartsMode = new Mode().SetTrump().AsColor(Color.Hearts);
var spadesMode = new Mode().SetTrump().AsColor(Color.Spades);
var noMode = new Mode().SetTrump().AsNo();
var allMode = new Mode().SetTrump().AsAll();

foreach (var card in deck.Cards)
{
	Console.WriteLine($"{card.Number.Name} {card.Color.Name} | {card.Score(noMode)}");
}