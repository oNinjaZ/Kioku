using Kioku.Decks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kioku.Editor
{
	public static class DeckEditor
	{

		public static void SelectDeck(List<Deck> decks)
		{
			UI.Display.DisplayDecksShort(decks);
			Console.WriteLine("Type ID of the deck you'd like to edit");
			string input = Console.ReadLine();
			if (decks.Any(deck => deck.Id == input))
			{
				var deckToEdit = decks.Find(deck => deck.Id == input);
				Menu(deckToEdit, decks);
			}
			else
			{
				Console.WriteLine($"Deck with the ID of {input} doesn't exist...");
			}

		}

		public static void SelectDeckToDelete(List<Deck> decks)
		{
			UI.Display.DisplayDecksShort(decks);
			Console.WriteLine("Type ID of the deck you'd like to delete");
			string input = Console.ReadLine();
			if (decks.Any(deck => deck.Id == input))
			{
				var deckToDelete = decks.Find(deck => deck.Id == input);
				if (deckToDelete.CardCount == 0)
				{
					Console.WriteLine($"[{deckToDelete.Name}] deleted!");
					decks.Remove(deckToDelete);
				}
				else
				{
					Deletion.DeleteDeck.Delete(decks, deckToDelete);
				}
			}
			else
			{
				Console.WriteLine($"Deck with the ID of {input} doesn't exist...");
			}

		}

		private static void Menu(Deck deck, List<Deck> deckList)
		{
			DeckEditorOptions(deck.Name);
			string input = Console.ReadLine();
			switch (input)
			{
				case "1":
					Deletion.DeleteDeck.Delete(deckList, deck);
					break;
				case "2":
					EditName(deck);
					break;
				case "3":
					CardEditor.Selector.FindCard(deck);
					break;
				case "4":
					Deletion.DeleteCard.SelectCard(deck);
					break;
				case "5":
					break;
				default:
					Console.WriteLine("Error...valid input options are 1, 2, or 3");
					break;
			}
		}

		private static void EditName(Deck deck)
		{
			string oldName = deck.Name;

			Console.WriteLine("Enter new name...");
			string input = Console.ReadLine();

			deck.Name = input;
			Console.Write($"Deck [{oldName}] re-named to [{input}]!");
		}

		private static void DeckEditorOptions(string deckName)
		{

			Console.WriteLine($"  === Editing [{deckName}] ===\n" +
				$"  (1) Delete this deck [{deckName}]\n" +
				"  (2) Rename deck\n" +
				"  (3) Edit card\n" + //in progress
				"  (4) Delete card\n" +
				"  (5) Move card (to another deck)"); //todo
		}

	}
}
