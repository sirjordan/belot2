﻿namespace Belot.Tests
{
	[TestClass]
	public sealed class TableTests
	{
		[TestMethod]
		public void Correct_Count()
		{
			var p1 = new Player("John");
			var p2 = new Player("Beth");
			var p3 = new Player("Ann");
			var p4 = new Player("Roger");
			var teamA = new Team(p1, p2);
			var teamB = new Team(p3, p4);

			var deck = new Deck();
			var table = new Table(teamA, teamB, deck);

			table.DrawInit();
			table.DrawAfter();

			Assert.AreEqual(0, deck.Cards.Count);
			Assert.AreEqual(8, p1.Cards.Count);
			Assert.AreEqual(8, p1.Cards.Count);
			Assert.AreEqual(8, p1.Cards.Count);
			Assert.AreEqual(8, p1.Cards.Count);
		}

		[TestMethod]
		public void Voting()
		{
			var p1 = new Player("John");
			var p2 = new Player("Beth");
			var p3 = new Player("Ann");
			var p4 = new Player("Roger");
			var teamA = new Team(p1, p2);
			var teamB = new Team(p3, p4);

			var deck = new Deck();
			var table = new Table(teamA, teamB, deck);

			table.DrawInit();

			table.SetTrump(p1).AsColor(Color.Diamonds);
			// p2 passes
			table.SetTrump(p3).AsColor(Color.Hearts);
			table.SetTrump(p4).AsAll();

			table.DrawAfter();

			Assert.AreEqual(Trump.All, table.Mode.Trump);
			Assert.IsNotNull(table.Voter);
			Assert.AreEqual(p4.Name, table.Voter.Name);
		}

		[TestMethod]
		public void Next_Player()
		{
			/*             Beth (3dr)
			 * Ann (2nd)                 Roger(4th)  
			 *             John (1st)
			 */

			var p1 = new Player("John");
			var p2 = new Player("Beth");
			var p3 = new Player("Ann");
			var p4 = new Player("Roger");
			var teamA = new Team(p1, p2);
			var teamB = new Team(p3, p4);

			var deck = new Deck();
			var table = new Table(teamA, teamB, deck);

			Assert.IsNull(table.CurrentPlayer);

			table.NextPlayer();
			Assert.IsNotNull(table.CurrentPlayer);
			Assert.AreEqual(p1.Name, table.CurrentPlayer.Name);

			table.NextPlayer();
			Assert.AreEqual(p3.Name, table.CurrentPlayer.Name);

			table.NextPlayer();
			Assert.AreEqual(p2.Name, table.CurrentPlayer.Name);

			table.NextPlayer();
			Assert.AreEqual(p4.Name, table.CurrentPlayer.Name);

			table.NextPlayer();
			Assert.AreEqual(p1.Name, table.CurrentPlayer.Name);
		}
	}
}