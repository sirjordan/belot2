namespace Belot
{
	public class Value
	{
		public int Default { get; private set; }
		public int Trump { get; private set; }

		public Value(int _default, int trump)
		{
			Default = _default;
			Trump = trump;
		}
	}
}
