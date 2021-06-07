using System;
using System.Linq;
using Kioku.Accounts;

namespace Kioku
{
	public static class Menu
	{
		private static string userInput;
		public static void Display()
		{
			Console.Write("\n  -----きおく-----\n\n  Commands:\n\n" +
				"  [add deck]\n" +
				"  [add card]\n" +
				"  [edit]     (reworking)\n" +
				"  [del deck]     \n" +
				"  [del card]     \n" +
				"  [view decks]\n" +
				"  [view cards]\n" +
				"  [review]     (N/A)\n" +
				"  [upgrade]     go premium (笑)\n" +
				"  [stats]    (N/A)\n\n" +
				"  [exit]     close program\n" +
				"  [help]    view command list\n\n");
		}

		public static void Selection(User ninjaz, out bool runProgram)
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
				ninjaz.Edit();
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
				ninjaz.ShowAllCards();
			}
			else if (userInput == "upgrade")
			{
				ninjaz.GoPremium();
			}
			else if (userInput == "stats")
			{
				//ninjaz.ViewStats();
			}
			else if (userInput == "help")
			{
				Menu.Display();
			}
			else if (userInput == "exit")
			{
				runProgram = false;
			}
			else
			{
				Console.WriteLine($"{userInput} is an invalid command...\nType [help] for a list of all commands");
			}
		}
	}
}
