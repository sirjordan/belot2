namespace Belot
{
	public class Card
	{
		public Color Color { get; private set; }
		public Number Number { get; private set; }

		public Card(Number num, Color color)
		{
			Number = num;
			Color = color;
		}

		public int Score(Mode mode)
		{
			switch (mode.Trump)
			{
				case Trump.Color:
					{
						ArgumentNullException.ThrowIfNull(mode.Color);
						return mode.Color == Color ? Number.Value.Trump : Number.Value.Default;
					}
				case Trump.No:
					return Number.Value.Default;
				case Trump.All:
					return Number.Value.Trump;
				default:
					throw new NotSupportedException();
			}
		}
	}
}
