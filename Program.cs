using System;
using System.Text.RegularExpressions;
using Kioku.Accounts;

namespace Kioku
{
	class Program
	{
		static void Main(string[] args)
		{
			var runProgram = true;
			User ninjaz = new User("ninjaz");
			Menu.Display();

			while (runProgram)
			{
				Console.WriteLine();
				Menu.Selection(ninjaz, out runProgram);
			}
			Console.WriteLine();
		}
	}
}
