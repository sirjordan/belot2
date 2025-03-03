namespace Belot.Tests
{
	[TestClass]
	public class ModeTests
	{
		[TestMethod]
		public void Compare_Modes()
		{
			Assert.IsTrue(new Mode().SetTrump().AsColor(Color.Diamonds) > new Mode().SetTrump().AsColor(Color.Clubs));
			Assert.IsTrue(new Mode().SetTrump().AsColor(Color.Spades) > new Mode().SetTrump().AsColor(Color.Hearts));
			Assert.IsTrue(new Mode().SetTrump().AsColor(Color.Diamonds) < new Mode().SetTrump().AsColor(Color.Spades));
			Assert.IsTrue(new Mode().SetTrump().AsAll() > new Mode().SetTrump().AsColor(Color.Diamonds));
			Assert.IsTrue(new Mode().SetTrump().AsNo() > new Mode().SetTrump().AsColor(Color.Clubs));
			Assert.IsTrue(new Mode().SetTrump().AsNo() < new Mode().SetTrump().AsAll());
		}

		[TestMethod]
		public void Change_Modes_Up()
		{
			var mode = new Mode().SetTrump().AsColor(Color.Diamonds);
			Assert.IsTrue(mode.Trump == Trump.Color);
			Assert.IsTrue(mode.Color == Color.Diamonds);

			mode.SetTrump().AsColor(Color.Spades);
			Assert.IsTrue(mode.Trump == Trump.Color);
			Assert.IsTrue(mode.Color == Color.Spades);

			mode.SetTrump().AsNo();
			Assert.IsTrue(mode.Trump == Trump.No);
			Assert.IsNull(mode.Color);

			mode.SetTrump().AsAll();
			Assert.IsTrue(mode.Trump == Trump.All);
			Assert.IsNull(mode.Color);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidOperationException))]
		public void Change_Modes_Down_Should_Throw_No()
		{
			var mode = new Mode().SetTrump().AsNo();
			mode.SetTrump().AsColor(Color.Spades);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidOperationException))]
		public void Change_Modes_Down_Should_Throw_Color()
		{
			var mode = new Mode().SetTrump().AsColor(Color.Diamonds);
			mode.SetTrump().AsColor(Color.Clubs);
		}
	}
}
