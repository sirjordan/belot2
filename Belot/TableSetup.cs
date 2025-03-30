namespace Belot
{
	// TODO: Unit test this
	internal class TableSetup
	{
		public bool IsInit { get; private set; }
		public bool IsDrawnInit { get; private set; }
		public bool IsTrumpSet { get; private set; }
		public bool IsDrawnAfter { get; private set; }
		public bool IsGameStarted { get; private set; }

		public TableSetup()
		{
			IsInit = false;
			IsDrawnInit = false;
			IsTrumpSet = false;
			IsDrawnAfter = false;
			IsGameStarted = false;
		}

		public void Init()
		{
			IsInit = true;
		}

		public void DrawInit()
		{
			if (IsInit)
				IsDrawnInit = true;
			else
				throw new InvalidOperationException("Init must be called first");
		}

		public void SetTrump()
		{
			if (IsDrawnInit)
				IsTrumpSet = true;
			else
				throw new InvalidOperationException("DrawInit must be called first");
		}

		public void DrawAfter()
		{
			if (IsTrumpSet)
				IsDrawnAfter = true;
			else
				throw new InvalidOperationException("SetTrump must be called first");
		}

		public void GameStart()
		{
			if (IsDrawnAfter)
				IsGameStarted = true;
			else
				throw new InvalidOperationException("DrawAfter must be called first");
		}
	}
}
