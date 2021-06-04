using System;
using System.Collections.Generic;
using System.Linq;
using Kioku.Decks;
using Kioku.UI;
using Kioku.Stats;
using Kioku.Deletion;

namespace Kioku.Accounts
{
	public class User
	{
		public string UserName { get; set; }
		public string Id { get; }
		public int Level { get; set; }
		private List<Deck> deckList = new();
		public bool IsPremium { get; set; }

		public User(string username)
		{
			UserName = username;
			IsPremium = false;
			Level = 0;
		}

		public void AddDeck()
		{
			Creator.AddDeck.Add(ref deckList);
		}

		public void AddCard()
		{
			if (deckList.Any())
			{
				Display.DisplayDecksShort(deckList);
				Console.WriteLine("Type name of deck you'd like to add card to...");
				string name = Console.ReadLine();
				if (deckList.Any(deck => deck.Name == name))
				{
					Creator.AddCard.ChooseType(ref deckList, name);
				}
				else
				{
					Console.WriteLine("Deck does not exist");
				}
			}
			else
			{
				Console.WriteLine("Create a deck first with [/add deck]");
			}
		}

		public void DeleteADeck()
		{
			if (deckList.Any())
			{
				DeleteDeck.Delete(ref deckList);
			}
			else
			{
				Console.WriteLine("No deck to delete...");
			}
		}


		public void RemoveCard()
		{
			if (OvrStats.TotalCards(deckList) > 0)
			{
				Display.DisplayDecksShort(deckList);
				DeleteCard.Delete(ref deckList);
			}
			else
			{
				Console.WriteLine("Deck Empty...(No Cards To Remove)");
			}
		}

		public void ViewDecks()
		{
			if (deckList.Any())
			{
				Display.DisplayDecksShort(deckList);
			}
			else
			{
				Console.WriteLine("You have 0 decks...create one first using [add deck]");
			}
		}

		public void ShowCards()
		{	
			if (OvrStats.TotalCards(deckList) != 0)
			{
				Display.ShowAllCards(deckList);
			}
			else
			{
				Console.WriteLine("You have 0 cards...");
			}
		}

		public void GoPremium()
		{
			IsPremium = true;
			Console.WriteLine($"Congradulations! {UserName} is a premium user as of {DateTime.Now}");
		}

		public void Edit()
		{
			if (deckList.Any())
			{
			}
			else
			{
				Console.WriteLine("Nothing to edit...create a card deck with [add deck]");
			}
		}

		//private void EditCard()
		//{
		//	if (cardList.Any())
		//	{
		//		CardPropertyShort();
		//		Console.WriteLine("Select Card ID from List Above:");
		//		int cardId = int.Parse(Console.ReadLine());
		//		if (FindCard(cardId).TypeOfCard == "Kanji")
		//		{
		//			Editor.KanjiEditor.FieldSelector(ref cardList, cardId);
		//		}
		//		if (FindCard(cardId).TypeOfCard == "Radical")
		//		{
		//			Editor.RadicalEditor.FieldSelector(ref cardList, cardId);
		//		}
		//		if (FindCard(cardId).TypeOfCard == "Vocab")
		//		{
		//			Editor.VocabEditor.FieldSelector(ref cardList, cardId);
		//		}
		//	}
		//	else
		//	{
		//		Console.WriteLine("List Empty...(No Cards To Edit)");
		//	}
		//}




		//public void ViewStats()
		//{
		//	Console.WriteLine($"\nTotal Cards in {UserName}'s Deck...\nRadicals: {RadicalCount}\nKanji: {KanjiCount}\nVocab: {VocabCount}");
		//}

	}
}
