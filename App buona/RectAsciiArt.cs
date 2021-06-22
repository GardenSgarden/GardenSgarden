using System;

namespace ConsoleApplication1
{
	class RectAsciiArt : RectConsole
	{
		public override void DumpToConsole()
		{
			int baseIntera = (int)Math.Ceiling(this.baseRettangolo);
			int righeIntermedie = (int)Math.Ceiling(this.altezzaRettangolo) - 2;

			RectAsciiArt.DrawLine('+', '-', baseIntera);

			for (int i = 0; i < righeIntermedie; ++i)
			{
				RectAsciiArt.DrawLine('|', ' ', baseIntera);
			}

			RectAsciiArt.DrawLine('+', '-', baseIntera);
		}

		private static void DrawLine(char firstChar, char fillChar, int length)
		{
			Console.Write(firstChar);
			for (int i = 1; i < length - 1; ++i)
			{
				Console.Write(fillChar);
			}
			Console.WriteLine(firstChar);
		}
	}
}