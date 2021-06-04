using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kioku.Decks;

namespace Kioku.UI
{
	public static class Display
	{
		public static void DisplayDecksShort(List<Deck> decks)
		{
			foreach (var deck in decks)
			{
				deck.PrintDeckInfoShort();
			}
		}

		public static void DisplayCardsShort(List<Deck> decks, string deckName)
		{
			FindDeck(decks, deckName).PrintCards(); //to fix, MAKE SHORT
		}
		public static void DisplayCardsBeforeDelete(List<Deck> decks, string deckName, out int cardsToDelete)
		{
			cardsToDelete = FindDeck(decks, deckName).CardCount;
			FindDeck(decks, deckName).PrintCardInfoShort(); //to fix, MAKE SHORT
		}
		public static void ShowAllCards(List<Deck> deckList)
		{
			foreach (var item in deckList)
			{
				item.PrintCards();
			}
		}

		private static Deck FindDeck(List<Deck> decks, string name)
		{
			return decks.Find(deck => deck.Name == name);
		}

	}
}
