using Kioku.Decks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kioku.UI;

namespace Kioku.Deletion
{
	public static class DeleteCard
	{
		public static void SelectDeck(List<Deck> deckList)
		{
			Display.DisplayDecksShort(deckList);
			Console.WriteLine("Enter ID of the deck you wish to remove card from");
			string input = Console.ReadLine();
			if (deckList.Any(deck => deck.Id == input))
			{
				var deck = deckList.Find(deck => deck.Id == input);
				SelectCard(deck);
			}
			else
			{
				Console.WriteLine($"Deck ID {input} doesn't exist");
			}
		}

		public static void SelectCard(Deck deck)
		{
			Display.DisplayCardsShort(deck);
			Console.WriteLine("Enter Id of the card you wish to delete from list above...");
			string input = Console.ReadLine();
			if (deck.cardList.Any(card => card.Id == input))
			{
				var card = deck.cardList.Find(card => card.Id == input);
				Console.WriteLine($"Card [{card.Character}] deleted!");
				deck.cardList.Remove(card);
			}
			else
			{
				Console.WriteLine($"Card ID {input} doesn't exist");
			}
		}
	}
}
