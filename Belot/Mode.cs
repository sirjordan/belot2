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

		public static bool operator >(Mode a, Mode b)
		{
			if (a.Trump == b.Trump && a.Trump == Trump.Color)
			{
				ArgumentNullException.ThrowIfNull(a.Color);
				ArgumentNullException.ThrowIfNull(b.Color);

				return a.Color > b.Color;
			}
			else
			{
				return a.Trump > b.Trump;
			}
		}

		public static bool operator <(Mode a, Mode b)
		{
			return b > a;
		}

		public class TrumpSetup
		{
			private Mode _original;
			private Mode _changed;

			public TrumpSetup(Mode mode)
			{
				_original = mode;
				_changed = new Mode()
				{
					Color = mode.Color,
					Trump = mode.Trump
				};
			}

			public Mode AsColor(Color color)
			{
				_changed.Trump = Trump.Color;
				_changed.Color = color;

				return Verify(_changed);
			}

			public Mode AsNo()
			{
				_changed.Trump = Trump.No;
				_changed.Color = null;

				return Verify(_changed);
			}

			public Mode AsAll()
			{
				_changed.Trump = Trump.All;
				_changed.Color = null;

				return Verify(_changed);
			}

			public Mode Verify(Mode m)
			{
				if (_changed > _original)
				{
					_original.Color = _changed.Color;
					_original.Trump = _changed.Trump;

					return _original;
				}
				else
				{
					throw new InvalidOperationException();
				}
			}
		}
	}
}
