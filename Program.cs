using System;
using System.Threading.Tasks;

namespace n_1_21
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int y = 0;
			Est(y);
			do
			{
				char s;
				Console.SetCursorPosition(0, 10);
				Console.WriteLine("scrivi 'f' per finire e 'r' per ripetere");
				s = Console.ReadKey().KeyChar;
				Console.Write("\b ");
				if (s == 'f') break;
				else if (s == 'r') if (y != 9)
					{
						y++;
						Est(y);
					} else Console.WriteLine("\nspazio finito");
			} while (true);
		}
		static void Est(int y)
        {
			int x = 0; //y = 0;
			Random rnd = new Random();
			int lun = 21;
			int[] arr = new int[21];
			for (int i = 1; i <= lun; i++) arr[i - 1] = i;
			do
			{
				Console.SetCursorPosition(x, y);
				int ir = rnd.Next(0, lun); //indice del random
				int ne = arr[ir]; //numero estratto
				lun--;
				for (int i = 0; i < lun; i++) if (i >= ir) arr[i] = arr[i + 1];
				Console.Write(ne + " | ");
				x = Console.CursorLeft;

				Console.ReadKey();

				if (lun == 0) break;
			} while (true);
		}
	}
}