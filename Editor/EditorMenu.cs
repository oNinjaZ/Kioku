using Kioku.Decks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kioku.Editor
{
	public static class EditorMenu
	{

		public static void Menu(List<Deck> decks)
		{
			EditorOptions();
			string userInput = Console.ReadLine();
			if (decks.Any())
			{
				switch (userInput)
				{
					case "1":
						DeckEditor.SelectDeck(decks);
						break;
					case "2":
						DeckEditor.SelectDeckToDelete(decks);
						break;
					default:
						Console.WriteLine("Invalid input...");
						break;
				}
			}
			else
			{
				Console.WriteLine("Nothing to edit, create a deck first using [deck add]");
			}
		}

		private static void EditorOptions()
		{

			Console.WriteLine("  === Editor ===\n" +
				"  (1) Edit a Deck\n" +
				"  (2) Delete a Deck\n");
		}

	}
}
