namespace Belot.Tests
{
	[TestClass]
	public sealed class CardScoreTests
	{
		[TestMethod]
		public void Correct_Score_On_No_Trump()
		{
			var noMode = new Mode().SetTrump().AsNo();
			
			Assert.AreEqual(11, new Card(Number.A, Color.Clubs).Score(noMode));
			Assert.AreEqual(11, new Card(Number.A, Color.Spades).Score(noMode));
			Assert.AreEqual(2, new Card(Number.J, Color.Clubs).Score(noMode));
			Assert.AreEqual(0, new Card(Number._7, Color.Diamonds).Score(noMode));
			Assert.AreEqual(10, new Card(Number._10, Color.Hearts).Score(noMode));
			Assert.AreEqual(0, new Card(Number._9, Color.Clubs).Score(noMode));
		}

		[TestMethod]
		public void Correct_Score_On_All_Trump()
		{
			var allMode = new Mode().SetTrump().AsAll();

			Assert.AreEqual(11, new Card(Number.A, Color.Clubs).Score(allMode));
			Assert.AreEqual(11, new Card(Number.A, Color.Spades).Score(allMode));
			Assert.AreEqual(20, new Card(Number.J, Color.Clubs).Score(allMode));
			Assert.AreEqual(0, new Card(Number._7, Color.Diamonds).Score(allMode));
			Assert.AreEqual(10, new Card(Number._10, Color.Hearts).Score(allMode));
			Assert.AreEqual(14, new Card(Number._9, Color.Clubs).Score(allMode));
		}

		[TestMethod]
		public void Correct_Score_On_Color_Trump()
		{
			var mode = new Mode().SetTrump().AsColor(Color.Spades);

			Assert.AreEqual(11, new Card(Number.A, Color.Clubs).Score(mode));
			Assert.AreEqual(11, new Card(Number.A, Color.Spades).Score(mode));
			Assert.AreEqual(2, new Card(Number.J, Color.Clubs).Score(mode));
			Assert.AreEqual(0, new Card(Number._7, Color.Diamonds).Score(mode));
			Assert.AreEqual(10, new Card(Number._10, Color.Hearts).Score(mode));
			Assert.AreEqual(0, new Card(Number._9, Color.Clubs).Score(mode));
			Assert.AreEqual(14, new Card(Number._9, Color.Spades).Score(mode));
			Assert.AreEqual(20, new Card(Number.J, Color.Spades).Score(mode));
		}
	}
}
