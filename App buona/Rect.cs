namespace ConsoleApplication1
{
	class Rect
	{
		protected float baseRettangolo;
		protected float altezzaRettangolo;

		public void SetSize(float b, float a)
		{
			this.baseRettangolo = b;
			this.altezzaRettangolo = a;
		}

		public float CalcoloArea()
		{
			return this.baseRettangolo * this.altezzaRettangolo;
		}

		public float CalcoloPerimetro()
		{
			return (this.baseRettangolo * 2) + (this.altezzaRettangolo * 2);
		}

		public string GetBaseAltezzaString()
		{
			return this.baseRettangolo + "x" + this.altezzaRettangolo;
		}
	}
}