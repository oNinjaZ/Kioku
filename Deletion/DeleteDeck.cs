﻿using Kioku.Decks;
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
		public static void Delete(ref List<Deck> deckList)
		{
			Display.DisplayDecksShort(deckList);
			Console.WriteLine("Enter name of deck you would like to delete");
			string deckToDelete = Console.ReadLine();
			if (deckList.Any(deck => deck.Name == deckToDelete))
			{
				if (deckList.Find(deck => deck.Name == deckToDelete).CardCount > 0)
				{
					int numOfCardsToDelete = 0;
					Display.DisplayCardsBeforeDelete(deckList, deckToDelete, out numOfCardsToDelete);
					Console.WriteLine($"\nAbove are the cards you will lose by deleting [{deckToDelete}]... delete {numOfCardsToDelete} card(s)?\nType Yes (Y) or No (N)");
					string answer = Console.ReadLine().ToUpper();
					if (answer == "YES" || answer == "Y")
					{
						deckList.Remove(deckList.Find(deck => deck.Name == deckToDelete));
						Console.WriteLine($"deck [{deckToDelete}] deleted and {numOfCardsToDelete} card(s) removed");
					}
					else if (answer == "NO" || answer == "N")
					{
						Console.WriteLine("Cancelled...returning to menu");
					}
					else
					{
						Console.WriteLine("Invalid input...returning to menu");
					}
				}
				else
				{
					deckList.Remove(deckList.Find(deck => deck.Name == deckToDelete));
					Console.WriteLine($"deck{deckToDelete} deleted");
				}
			}
			else
			{
				Console.WriteLine($"Deck [{deckToDelete}] doesn't exist");
			}


		}
	}
}
