
using Belot;

var p1 = new Player("John");
var p2 = new Player("Beth");
var p3 = new Player("Ann");
var p4 = new Player("Roger");
var teamA = new Team(p1, p2);
var teamB = new Team(p3, p4);

var deck = new Deck();
var table = new Table(teamA, teamB, deck);

table.DrawInit();

foreach (var p in table.Players)
{
	// Vote for trump :)
	// Take input from every p
}

table.SetTrump(p1).AsColor(Color.Diamonds);
// p2 passes
table.SetTrump(p3).AsColor(Color.Hearts);
table.SetTrump(p4).AsAll();

table.DrawAfter();

// Play


Console.WriteLine();

