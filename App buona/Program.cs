using System;

namespace ConsoleApplication1
{
	
	class Program
	{
		static string separator = "=======================================";
		static string separator2 = "---------------------------------------";
	
		private static RectConsole rettangolo = new RectAsciiArt();

		static void Main(string[] args)
		{
			bool exitFlag = false;

			do
			{
				Console.WriteLine(separator);
				Console.WriteLine("Primo programma in C#!");
				Console.WriteLine(separator);

				Console.WriteLine("MENU PRINCIPALE:");
				Console.WriteLine(" 1. Non cliccare 1");
				Console.WriteLine(" 2. Somma di due numeri interi");
				Console.WriteLine(" 3. Somma di N numeri interi");
				Console.WriteLine(" 4. Definisci un rettangolo");
				Console.WriteLine(" 5. Calcola l'area del rettangolo");
				Console.WriteLine(" 6. Calcola il perimetro del rettangolo");
				Console.WriteLine(" 7. Dump del rettangolo");

				Console.WriteLine(" \n 0. Esci dal programma");

				ConsoleKeyInfo keyPressed = Console.ReadKey();

				Console.WriteLine("\n\n");

				if (keyPressed.Key == ConsoleKey.D1 || keyPressed.Key == ConsoleKey.NumPad1)
				{
					Program.Opzione1();
				}
				else if (keyPressed.Key == ConsoleKey.D2 || keyPressed.Key == ConsoleKey.NumPad2)
				{
					Program.SommaDiDueInteri();
				}
				else if (keyPressed.Key == ConsoleKey.D3 || keyPressed.Key == ConsoleKey.NumPad3)
				{
					Program.SommaDiInteri();
				}
				else if (keyPressed.Key == ConsoleKey.D4 || keyPressed.Key == ConsoleKey.NumPad4)
				{
					Program.DefinizioneRettangolo();
				}
				else if (keyPressed.Key == ConsoleKey.D5 || keyPressed.Key == ConsoleKey.NumPad5)
				{
					Program.CalcoloAreaRettangolo();
				}
				else if (keyPressed.Key == ConsoleKey.D6 || keyPressed.Key == ConsoleKey.NumPad6)
				{
					Program.CalcoloPerimetroRettangolo();
				}
				else if (keyPressed.Key == ConsoleKey.D6 || keyPressed.Key == ConsoleKey.NumPad6)
                {
					Program.rettangolo.DumpToConsole();
                }
				else if (keyPressed.Key == ConsoleKey.D7 || keyPressed.Key == ConsoleKey.NumPad7)
				{
					Program.rettangolo.DumpToConsole();
				}
				else if (keyPressed.Key == ConsoleKey.D0 || keyPressed.Key == ConsoleKey.NumPad0)
				{
					exitFlag = true;
				}
				else
				{
					Console.WriteLine(separator2);
					Console.WriteLine("La scelta effettuata non è valida!");
					Console.WriteLine(separator2);
				}

				if (exitFlag == false)
				{
					Console.WriteLine("\n\nPremere un \"tasto\" per continuare...");
					Console.ReadKey();
					Console.Clear();
				}
			}
			while (exitFlag == false);
		}

		private static void DefinizioneRettangolo()
		{
			Console.WriteLine(separator2);
			Console.WriteLine("Programma per la definizione di un rettangolo");
			Console.WriteLine(separator2);

			Console.Write("Inserisci la base: ");
			string temp = Console.ReadLine();
			float baseRettangolo = float.Parse(temp);

			Console.Write("Inserisci l'altezza: ");
			temp = Console.ReadLine();
			float altezzaRettangolo = float.Parse(temp);

			Program.rettangolo.SetSize(baseRettangolo, altezzaRettangolo);
		}

		private static void CalcoloAreaRettangolo()
		{
			Console.WriteLine(separator2);
			Console.WriteLine("Programma per il calcolo dell'area di un rettangolo");
			Console.WriteLine(separator2);

			float areaRettangolo = Program.rettangolo.CalcoloArea();
			Console.WriteLine("L'area del rettangolo specificato (" + Program.rettangolo.GetBaseAltezzaString() + ") è: " + areaRettangolo);
		}

		private static void CalcoloPerimetroRettangolo()
		{
			Console.WriteLine(separator2);
			Console.WriteLine("Programma per il calcolo del perimetro di un rettangolo");
			Console.WriteLine(separator2);

			float perimetroRettangolo = Program.rettangolo.CalcoloPerimetro();
			Console.WriteLine("Il perimetro del rettangolo specificato (" + Program.rettangolo.GetBaseAltezzaString() + ") è: " + perimetroRettangolo);
		}

		public static void Opzione1()
		{
			Console.WriteLine("Ma ti ho detto di non premere 1 perchè l'hai premuto?°_°");
		}

		public static void SommaDiDueInteri()
		{
			Console.WriteLine(separator2);
			Console.WriteLine("Programma per la somma di due numeri interi");
			Console.WriteLine(separator2);

			Console.Write("Inserisci il primo addendo: ");
			string temp = Console.ReadLine();

			int addendo1 = Int32.Parse(temp);

			Console.Write("Inserisci il secondo addendo: ");
			temp = Console.ReadLine();

			int addendo2 = Int32.Parse(temp);

			int somma = addendo1 + addendo2;

			Console.WriteLine("Il risultato della somma fra " + addendo1 + " e " + addendo2 + " è di " + somma);
		}

		public static void SommaDiInteri()
		{
			Console.WriteLine(separator2);
			Console.WriteLine("Programma per la somma di N numeri interi");
			Console.WriteLine(separator2);

			Console.Write("Inserisci il numero di interi da sommare: ");
			string temp = Console.ReadLine();
			int counter = Int32.Parse(temp);

			int somma = 0;

			// Allochiamo un array
			int[] inputNumbers = new int[counter];

			// 1: Condizioni di partenza
			// 2: Condizioni di uscita
			// 3: Incremento del contatore
			for (int i = 0; i < counter; i++)
			{
				Console.Write("Inserisci il numero #" + (i + 1) + ": ");
				temp = Console.ReadLine();
				//int currNumber = Int32.Parse (temp);
				inputNumbers[i] = Int32.Parse(temp);

				somma = somma + inputNumbers[i];
			}

			// L'operazione 1+2+8+5+9+4+2+5+8+7+6=???
			Console.Write("L'operazione ");
			for (int i = 0; i < counter; i++)
			{
				Console.Write(inputNumbers[i]);

				if (i < counter - 1)
				{
					Console.Write("+");
				}
			}
			Console.Write("=" + somma);

			//Console.Write ("La somma dei " + counter + " numeri inseriti è: " + somma);
		}
	}
}