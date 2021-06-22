using System;

namespace ConsoleApplication1
{
	class RectConsole : Rect
	{
		public  virtual void DumpToConsole()
		{
			Console.WriteLine("----------------------------------------");
			Console.WriteLine("Dati del rettangolo:");
			Console.WriteLine("----------------------------------------");
			Console.WriteLine("Base: " + this.baseRettangolo);
			Console.WriteLine("Altezza: " + this.altezzaRettangolo);
			Console.WriteLine("----------------------------------------");
		}
	}
}