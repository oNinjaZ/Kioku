using Kioku.Decks;
using Kioku.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kioku.Deletion
{
	public static class DeleteDeck
	{
		public static void Delete(List<Deck> deckList, Deck deck)
		{
			Display.DisplayCardsBeforeDelete(deck);
			Console.WriteLine($"Above are the cards you will lose with the deletion of [{deck.Name}]... ({deck.CardCount} cards)\nAre you sure? Enter Yes (Y) or No (N)");
			string input = Console.ReadLine();
			switch (input.ToUpper())
			{
				case "YES":
				case "Y":
					deckList.Remove(deck);
					Console.WriteLine($"[{deck.Name}] ({deck.CardCount} cards) deleted");
					break;

				case "NO":
				case "N":
					Console.WriteLine("Deletion cancelled...");
					break;
				default: 
					Console.WriteLine("Deletion cancelled... invalid input");
					break;
			}
		}
	}
}
