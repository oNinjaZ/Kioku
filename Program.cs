using System;
using System.Linq;
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
				Menu.Selection(ref ninjaz, out runProgram);
			}
			Console.WriteLine();
		}
	}

	public static class Menu
	{
		private static string userInput;
		public static void Display()
		{
			Console.Write("\n  -----Menu-----\n\n  Commands:\n\n" +
				"  [add deck]\n" +
				"  [add card]\n" +
				"  [edit]     (reworking)\n" +
				"  [del deck]     delete a deck\n" +
				"  [del card]     delete a card\n" +
				"  [view decks]\n" +
				"  [view cards]\n" +
				"  [review]     (N/A)\n" +
				"  [upgrade]     go premium (笑)\n" +
				"  [stats]\n" +
				"  [exit]\n");
		}

		public static void Selection(ref User ninjaz, out bool runProgram)
		{
			runProgram = true;
			userInput = Console.ReadLine();
			userInput = String.Concat(userInput.Where(c => !Char.IsWhiteSpace(c)));

			if (userInput == "adddeck")
			{
				ninjaz.AddDeck();
			}
			else if (userInput == "addcard")
			{
				ninjaz.AddCard();
			}
			else if (userInput == "edit")
			{
				//ninjaz.EditCard
			}
			else if (userInput == "deldeck")
			{
				ninjaz.DeleteADeck();
			}
			else if (userInput == "delcard")
			{
				ninjaz.RemoveCard();
			}
			else if (userInput == "viewdecks")
			{
				ninjaz.ViewDecks();
			}
			else if (userInput == "viewcards")
			{
				ninjaz.ShowCards();
			}
			else if (userInput == "upgrade")
			{
				ninjaz.GoPremium();
			}
			else if (userInput == "stats")
			{
				//ninjaz.ViewStats();
			}
			else if (userInput == "/help")
			{
				Menu.Display();
			}
			else if (userInput == "/exit")
			{
				runProgram = false;
			}
			else
			{
				Console.WriteLine($"{userInput} is an invalid command...\nType /help for a list of all commands");
			}
		}
	}
}
