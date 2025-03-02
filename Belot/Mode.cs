namespace Belot
{
	public class Mode
	{
		public Color? Color { get; private set; }
		public Trump Trump { get; private set; }

		public TrumpSetup SetTrump()
		{
			return new TrumpSetup(this);
		}

		public class TrumpSetup
		{
			private Mode _mode;

			public TrumpSetup(Mode mode)
			{
				_mode = mode;
			}

			public Mode AsColor(Color color)
			{
				_mode.Trump = Trump.Color;
				_mode.Color = color;

				return _mode;
			}

			public Mode AsNo()
			{
				_mode.Trump = Trump.No;

				return _mode;
			}

			public Mode AsAll()
			{
				_mode.Trump = Trump.All;

				return _mode;
			}
		}
	}
}
