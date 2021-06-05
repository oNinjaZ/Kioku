﻿using System;
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

		public static void DisplayCardsShort(Deck deck)
		{
			deck.PrintCardInfoShort();
		}

		public static void DisplayEditedCard(Card card)
		{
			Console.WriteLine("Edit successful!\n" +
				$"   === Card Info ===");
			card.PrintCardInfo();
		}
		public static void DisplayCardsBeforeDelete(List<Deck> decks, string deckName, out int cardsToDelete)
		{
			cardsToDelete = FindDeck(decks, deckName).CardCount;
			FindDeck(decks, deckName).PrintCardInfoShort();
		}
		public static void DisplayCardsBeforeDelete(Deck deck)
		{
			deck.PrintCardInfoShort();
		}
		public static void ShowAllCards(List<Deck> deckList)
		{
			Console.WriteLine();
			foreach (var item in deckList)
			{
				Console.WriteLine($"=== Deck [{item.Name}] ===");
				item.PrintCardsHorizontal();
				Console.WriteLine();
			}
		}

		private static Deck FindDeck(List<Deck> decks, string name)
		{
			return decks.Find(deck => deck.Name == name);
		}

	}
}
