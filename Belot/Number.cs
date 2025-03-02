namespace Belot
{
	public class Number
	{
		public const int MAX = 13;
		public const int MIN = 1;

		public int Order { get; private set; }
		public string Name { get; private set; }
		public Value Value { get; private set; }

		protected Number(int order, string name, Value value)
		{
			if (order < MIN || order > MAX) { throw new ArgumentOutOfRangeException($"Num must be between {MIN} and {MAX}"); }

			Order = order;
			Name = name;
			Value = value;
		}

		public static Number A => new(1, "A", new(11, 11));
		public static Number _7 => new(7, "7", new(0, 0));
		public static Number _8 => new(8, "8", new(0, 0));
		public static Number _9 => new(9, "9", new(0, 14));
		public static Number _10 => new(10, "10", new(10, 10));
		public static Number J => new(11, "J", new(2, 20));
		public static Number Q => new(12, "Q", new(3, 3));
		public static Number K => new(13, "K", new(4, 4));
		public static Number[] All => [A, _7, _8, _9, _10, J, Q, K];
	}
}
