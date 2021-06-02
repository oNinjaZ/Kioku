using System;
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
				Console.WriteLine(); //for space/program readability
				Menu.Selection(ref ninjaz, out runProgram);
			}
			Console.WriteLine("");
		}
	}

	public static class Menu
	{
		public static void Display()
		{
			Console.Write("  -----Menu-----\n  Commands:\n" +
				"  [/add]: Add Card\n" +
				"  [/edit]: Edit Card\n" +
				"  [/del]: Delete Card\n" +
				"  [/view]: View Deck\n" +
				"  [/upgrade]: Go Premium\n" +
				"  [/stats]: View Your Stats\n" +
				"  [/exit]: Exit Program\n");
		}

		public static void Selection(ref User ninjaz, out bool runProgram)
		{
			runProgram = true;
			string selection = "/" + Console.ReadLine().Substring(1).ToLower();
			if (selection == "/add")
			{
				ninjaz.AddCard();
			}
			else if (selection == "/edit")
			{
				ninjaz.EditCard();
			}
			else if (selection == "/del")
			{
				ninjaz.RemoveCard();
			}
			else if (selection == "/view")
			{
				ninjaz.ShowCards();
			}
			else if (selection == "/upgrade")
			{
				ninjaz.GoPremium();
			}
			else if (selection == "/stats")
			{
				ninjaz.ViewStats();
			}
			else if (selection == "/help") 
			{
				Menu.Display();
			}
			else if (selection == "/exit")
			{
				runProgram = false;
			}
			else
			{
				Console.WriteLine($"{selection} is an invalid command...\nType /help for a list of all commands");
			}
		}
	}
}
